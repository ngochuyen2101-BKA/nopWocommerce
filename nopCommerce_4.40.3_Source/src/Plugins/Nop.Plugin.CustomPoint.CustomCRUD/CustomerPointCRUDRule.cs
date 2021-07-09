﻿using System;
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

namespace Nop.Plugin.CustomPoint.CustomerCRUD
{
    public partial class CustomerPointCRUDRule : BasePlugin, IDiscountRequirementRule
    {
        #region Fields

        private readonly IActionContextAccessor _actionContextAccessor;
        private readonly ICustomerService _customerService;
        private readonly IDiscountService _discountService;
        private readonly ILocalizationService _localizationService;
        private readonly ISettingService _settingService;
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly IWebHelper _webHelper;

        #endregion

        #region Ctor

        public CustomerPointCRUDRule(IActionContextAccessor actionContextAccessor,
            IDiscountService discountService,
            ICustomerService customerService,
            ILocalizationService localizationService,
            ISettingService settingService,
            IUrlHelperFactory urlHelperFactory,
            IWebHelper webHelper)
        {
            _actionContextAccessor = actionContextAccessor;
            _customerService = customerService;
            _discountService = discountService;
            _localizationService = localizationService;
            _settingService = settingService;
            _urlHelperFactory = urlHelperFactory;
            _webHelper = webHelper;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Check discount requirement
        /// </summary>
        /// <param name="request">Object that contains all information required to check the requirement (Current customer, discount, etc)</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the result
        /// </returns>
        public async Task<DiscountRequirementValidationResult> CheckRequirementAsync(DiscountRequirementValidationRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            //invalid by default
            var result = new DiscountRequirementValidationResult();

            if (request.Customer == null)
                return result;

            return result;
        }

        /// <summary>
        /// Get URL for rule configuration
        /// </summary>
        /// <param name="discountId">Discount identifier</param>
        /// <param name="discountRequirementId">Discount requirement identifier (if editing)</param>
        /// <returns>URL</returns>
        public string GetConfigurationUrl(int discountId, int? discountRequirementId)
        {
            var urlHelper = _urlHelperFactory.GetUrlHelper(_actionContextAccessor.ActionContext);

            return urlHelper.Action("Configure", "DiscountRulesCustomerRoles",
                new { discountId = discountId, discountRequirementId = discountRequirementId }, _webHelper.GetCurrentRequestProtocol());
        }

        /// <summary>
        /// Install the plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task InstallAsync()
        {
            //locales
            // await _localizationService.AddLocaleResourceAsync(new Dictionary<string, string>
            // {
            //     ["Plugins.DiscountRules.CustomerRoles.Fields.CustomerRole"] = "Required customer role",
            //     ["Plugins.DiscountRules.CustomerRoles.Fields.CustomerRole.Hint"] = "Discount will be applied if customer is in the selected customer role.",
            //     ["Plugins.DiscountRules.CustomerRoles.Fields.CustomerRole.Select"] = "Select customer role",
            //     ["Plugins.DiscountRules.CustomerRoles.Fields.CustomerRoleId.Required"] = "Customer role is required",
            //     ["Plugins.DiscountRules.CustomerRoles.Fields.DiscountId.Required"] = "Discount is required"
            // });

            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall the plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task UninstallAsync()
        {
            // //discount requirements
            // var discountRequirements = (await _discountService.GetAllDiscountRequirementsAsync());
            // foreach (var discountRequirement in discountRequirements)
            // {
            //     await _discountService.DeleteDiscountRequirementAsync(discountRequirement, false);
            // }

            // //locales
            // await _localizationService.DeleteLocaleResourcesAsync("Plugins.DiscountRules.CustomerRoles");

            await base.UninstallAsync();
        }

        #endregion
    }
}