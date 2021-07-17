using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Domain.CustomerPlugin;
using Nop.Data;
using Nop.Services.Stores;

namespace Nop.Services.CustomersTest
{
    
    public partial class CustomerTestService : ICustomerTestService
    {
        #region Fields

        private readonly IRepository<CustomerTest> _customerTestRepository;

        #endregion

        #region Ctor

        public CustomerTestService(IRepository<CustomerTest> customerTestRepository)
        {
            _customerTestRepository = customerTestRepository;
        }

        #endregion

        #region CustomTest

        public virtual async Task DeleteCustomerTestAsync(CustomerTest customerTest)
        {
            await _customerTestRepository.DeleteAsync(customerTest);
        }

        public virtual async Task<CustomerTest> GetCustomerTestByIdAsync(int customerID)
        {
            return await _customerTestRepository.GetByIdAsync(customerID, cache => default);
        }

        public virtual async Task InsertCustomerTestAsync(CustomerTest customerTest)
        {
            await _customerTestRepository.InsertAsync(customerTest);
        }

        public virtual async Task UpdateCustomerTestAsync(CustomerTest customerTest)
        {
            await _customerTestRepository.UpdateAsync(customerTest);
        }


        public virtual bool CustomerTestIsAvailable(CustomerTest customerTest)
        {
            if (customerTest == null)
                throw new ArgumentNullException(nameof(customerTest));

            return true;
        }

        #endregion

    }
}