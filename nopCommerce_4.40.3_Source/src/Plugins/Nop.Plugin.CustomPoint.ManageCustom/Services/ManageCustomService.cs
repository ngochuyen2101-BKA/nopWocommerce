using System.Linq;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Data;
using Nop.Plugin.CustomPoint.ManageCustom.Domain;

namespace Nop.Plugin.CustomPoint.ManageCustom.Services
{
    public partial class ManageCustomService : IManageCustomService
    {
        #region Constants

        #endregion

        #region Fields

        private readonly IRepository<ManagePointCustom> _manageCustomRepository;

        #endregion

        #region Ctor
        public ManageCustomService(IRepository<ManagePointCustom> manageCustomRepository)
        {
            _manageCustomRepository = manageCustomRepository;
        }

        #endregion

        #region Methods
        public virtual async Task<IPagedList<ManagePointCustom>> GetAllCustomsAsync(int storeId = 0, int pageIndex = 0, int pageSize = int.MaxValue)
        {
            var rez = await _manageCustomRepository.GetAllAsync(query =>
            {
                // if (storeId > 0)
                //     query = query.Where(point.StoreId == 0);
                // query = query.OrderBy(point => point.DisplayOrder).ThenBy(point => point.Name);

                return query;
            });

            return new PagedList<ManagePointCustom>(rez, pageIndex, pageSize);
        }
        public virtual async Task<ManagePointCustom> GetCustomByIdAsync(int CustomId)
        {
            return await _manageCustomRepository.GetByIdAsync(CustomId);
        }
        public virtual async Task InsertCustomAsync(ManagePointCustom manageCustom)
        {
            await _manageCustomRepository.InsertAsync(manageCustom, false);
        }
        public virtual async Task UpdateCustomAsync(ManagePointCustom manageCustom)
        {
            await _manageCustomRepository.UpdateAsync(manageCustom, false);
        }
        public virtual async Task DeleteCustomAsync(ManagePointCustom manageCustom)
        {
            await _manageCustomRepository.DeleteAsync(manageCustom, false);
        }

        #endregion
    }
}