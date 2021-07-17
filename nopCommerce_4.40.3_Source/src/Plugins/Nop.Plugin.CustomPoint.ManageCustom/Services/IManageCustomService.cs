using System.Threading.Tasks;
using Nop.Core;
using Nop.Plugin.CustomPoint.ManageCustom.Domain;

namespace Nop.Plugin.CustomPoint.ManageCustom.Services
{
    public partial interface IManageCustomService
    {
        Task<IPagedList<ManagePointCustom>> GetAllCustomsAsync(int storeId = 0, int pageIndex = 0, int pageSize = int.MaxValue);

        Task<ManagePointCustom> GetCustomByIdAsync(int CustomId);

        Task InsertCustomAsync(ManagePointCustom manageCustom);

        Task UpdateCustomAsync(ManagePointCustom manageCustom);

        Task DeleteCustomAsync(ManagePointCustom manageCustom);
    }
}