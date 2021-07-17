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

namespace Nop.Plugin.PluginTest.NewPlugin
{
    public partial class PluginTestNewRule : BasePlugin, IAdminMenuPlugin
    {
        private readonly IWebHelper _webHelper;

        public PluginTestNewRule(IWebHelper webHelper) {
            _webHelper = webHelper;
        }

        #region Fields

        #endregion

        #region Ctor

        public PluginTestNewRule()
        {
            
        }

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
            string pluginName = "Customer List";
            // const string adminUrlPart = "Admin/";
            var pluginMainMenu = new SiteMapNode
            {
                Title = pluginName,
                Url = _webHelper.GetStoreLocation() + "CustomerAdmin/List",
                Visible = true,
                SystemName = "Customer-Main-Menu",
                IconClass = "fa-genderless"
            };
            rootNode.ChildNodes.Add(pluginMainMenu);
            return Task.CompletedTask;
        }

        #endregion
    }
}