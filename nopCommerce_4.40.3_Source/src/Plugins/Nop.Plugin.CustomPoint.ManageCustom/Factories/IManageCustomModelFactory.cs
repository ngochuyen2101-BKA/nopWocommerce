using System.Threading.Tasks;
using Nop.Plugin.CustomPoint.ManageCustom.Models;

namespace Nop.Plugin.CustomPoint.ManageCustom.Factories
{
    public interface IManageCustomModelFactory
    {
        Task<ManageCustomListModel> PrepareManageCustomListModelAsync(ManageCustomSearchModel searchModel);

        Task<ManageCustomSearchModel> PrepareManageCustomSearchModelAsync(ManageCustomSearchModel searchModel);
    }
}