using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Blogs;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.CustomerPlugin;
using Nop.Core.Html;
using Nop.Services.CustomersTest;
using Nop.Services.Helpers;
using Nop.Services.Localization;
using Nop.Services.Seo;
using Nop.Services.Stores;
using Nop.Web.Framework.Extensions;
using Nop.Web.Framework.Factories;
using Nop.Web.Framework.Models.Extensions;
using Nop.Plugin.NewPlugin.PluginTest.Models;

namespace Nop.Plugin.NewPlugin.PluginTest.Factories
{
    public partial class CustomerTestFactory : ICustomerTestFactory
    {        
        #region Methods

        public virtual async Task<CustomSearchModel> PrepareCustomTestListModelAsync(CustomSearchModel searchModel)
        {
            return searchModel;
        }

        #endregion
    }
}