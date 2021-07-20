using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Customers;
using Nop.Core.Http.Extensions;
using Nop.Services.Customers;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Web.Framework.Controllers;
using Nop.Services.CustomersTest;
using Nop.Plugin.NewPlugin.PluginTest.Factories;
using Nop.Plugin.NewPlugin.PluginTest.Models;

namespace Nop.Plugin.NewPlugin.PluginTest.Controllers
{
    public class CustomerAdminController : BasePluginController
    {
        private readonly ICustomerTestService _customerTestService;
        private readonly ICustomerTestFactory _customerTestFactory;

        public CustomerAdminController(ICustomerTestService customerService, ICustomerTestFactory customerTestFactory ) {
            _customerTestService = customerService;
            _customerTestFactory = customerTestFactory;
        }

        public IActionResult List() {
            // var model = _customerTestFactory.PrepareCustomTestListModelAsync(new CustomSearchModel());

            return View("~/Plugins/NewPlugin.PluginTest/Views/List.cshtml");
        }

        [HttpPost]
        public virtual async Task<IActionResult> List(CustomSearchModel searchModel)
        {
            var model = await _customerTestFactory.PrepareCustomTestListModelAsync(searchModel);

            return Json(model);
        }

        // public virtual async Task<IActionResult> CustomTestCreate()
        // {
        //     var model = await _customerModelFactory.PrepareCustomTestModelAsync(new CustomTestModel(), null);

        //     return View(model);
        // }
    }
}