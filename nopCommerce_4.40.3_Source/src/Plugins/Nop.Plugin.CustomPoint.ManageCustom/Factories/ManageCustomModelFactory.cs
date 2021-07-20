using System;
using System.Linq;
using System.Threading.Tasks;
using Nop.Plugin.CustomPoint.ManageCustom.Models;
using Nop.Plugin.CustomPoint.ManageCustom.Services;
using Nop.Services.Localization;
using Nop.Services.Stores;
using Nop.Web.Framework.Models.Extensions;

namespace Nop.Plugin.CustomPoint.ManageCustom.Factories
{
    public class ManageCustomModelFactory : IManageCustomModelFactory
    {
        #region Fields

        private readonly IManageCustomService _manageCustomService;
        private readonly ILocalizationService _localizationService;
        private readonly IStoreService _storeService;

        #endregion

        #region Ctor

        public ManageCustomModelFactory(IManageCustomService manageCustomService,
            ILocalizationService localizationService, IStoreService storeService)
        {
            _manageCustomService = manageCustomService;
            _localizationService = localizationService;
            _storeService = storeService;
        }

        #endregion

        #region Methods
        public async Task<ManageCustomListModel> PrepareManageCustomListModelAsync(ManageCustomSearchModel searchModel)
        {
            var custom = await _manageCustomService.GetAllCustomsAsync(pageIndex: searchModel.Page - 1,
                pageSize: searchModel.PageSize);
            var model = await new ManageCustomListModel().PrepareToGridAsync(searchModel, custom, () =>
            {
                return custom.SelectAwait(async point =>
                {
                    return new ManageCustomModel
                    {
                        Id = point.Id,
                        CustomerName = point.CustomerName,
                        Email = point.Email
                    };
                });
            });

            return model;
        }
        public Task<ManageCustomSearchModel> PrepareManageCustomSearchModelAsync(ManageCustomSearchModel searchModel)
        {
            if (searchModel == null)
                throw new ArgumentNullException(nameof(searchModel));

            //prepare page parameters
            searchModel.SetGridPageSize();

            return Task.FromResult(searchModel);
        }

        #endregion
    }
}
