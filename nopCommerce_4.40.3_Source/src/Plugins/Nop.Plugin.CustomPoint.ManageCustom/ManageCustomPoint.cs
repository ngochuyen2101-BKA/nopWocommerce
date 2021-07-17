using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Nop.Core;
using Nop.Services.Configuration;
using Nop.Services.Customers;
using Nop.Services.Discounts;
using Nop.Services.Localization;
using Nop.Services.Plugins;
using Nop.Web.Framework.Menu;

namespace Nop.Plugin.CustomPoint.ManageCustom
{
    public partial class ManageCustomPointNewRule : BasePlugin, IAdminMenuPlugin
    {
        private readonly IWebHelper _webHelper;

        public ManageCustomPointNewRule(IWebHelper webHelper) {
            _webHelper = webHelper;
        }

        #region Fields

        #endregion

        #region Ctor

        #endregion

        #region Methods

        /// <summary>
        /// Install the plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall the plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }

        public Task ManageSiteMapAsync(SiteMapNode rootNode) {
            string pluginName = "Customer Manage";
            // const string adminUrlPart = "Admin/";
            var pluginMainMenu = new SiteMapNode
            {
                Title = pluginName,
                Url = _webHelper.GetStoreLocation() + "Admin/ManageCustom/List",
                Visible = true,
                SystemName = "Customer-Main-Menu",
                IconClass = "fa-cogs"
            };
            rootNode.ChildNodes.Add(pluginMainMenu);
            return Task.CompletedTask;
        }

        #endregion
    }
}