using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Http.Extensions;
using Nop.Services.Localization;
using Nop.Services.Messages;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;
using Nop.Plugin.CustomPoint.ManageCustom.Domain;
using Nop.Plugin.CustomPoint.ManageCustom.Factories;
using Nop.Plugin.CustomPoint.ManageCustom.Models;
using Nop.Plugin.CustomPoint.ManageCustom.Services;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.CustomPoint.ManageCustom.Controllers
{
    [Area(AreaNames.Admin)]
    public class ManageCustomController : BasePluginController
    {
        private readonly ILocalizationService _localizationService;
        private readonly IManageCustomModelFactory _manageCustomModelFactory;
        private readonly IManageCustomService _manageCustomService;
        private readonly IStoreService _storeService;
        public ManageCustomController(ILocalizationService localizationService,
            IManageCustomModelFactory manageCustomModelFactory,
            IManageCustomService manageCustomService,
            IStoreService storeService) {
                _localizationService = localizationService;
                _manageCustomModelFactory = manageCustomModelFactory;
                _manageCustomService = manageCustomService;
                _storeService = storeService;
        }

        public async Task<IActionResult> List() {
            var model = await _manageCustomModelFactory.PrepareManageCustomSearchModelAsync(new ManageCustomSearchModel());

            return View("~/Plugins/CustomPoint.ManageCustom/Views/List.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> List(ManageCustomSearchModel searchModel)
        {
            var model = await _manageCustomModelFactory.PrepareManageCustomListModelAsync(searchModel);

            return Json(model);
        }

        public async Task<IActionResult> Create()
        {
            return View("~/Plugins/CustomPoint.ManageCustom/Views/Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create(ManageCustomModel model)
        {
            var custom = new ManagePointCustom
            {
                // CustomerId = model.Id,
                CustomerName = model.CustomerName,
                Email = model.Email
            };
            await _manageCustomService.InsertCustomAsync(custom);

            ViewBag.RefreshPage = true;

            return View("~/Plugins/CustomPoint.ManageCustom/Views/Create.cshtml", model);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            var customer = await _manageCustomService.GetCustomByIdAsync(id);
            if (customer == null)
                return RedirectToAction("List");

            var model = new ManagePointCustom
            {
                Id = customer.Id,
                CustomerName = customer.CustomerName,
                Email = customer.Email,
            };

            return View("~/Plugins/Pickup.PickupInStore/Views/Edit.cshtml", model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var custom = await _manageCustomService.GetCustomByIdAsync(id);
            if (custom == null)
                return RedirectToAction("List");

            await _manageCustomService.DeleteCustomAsync(custom);

            return new NullJsonResult();
        }

    }
}