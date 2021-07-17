using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Core;
using Nop.Core.Domain.CustomerPlugin;

namespace Nop.Services.CustomersTest
{
    public partial interface ICustomerTestService
    {
        #region CustomerTest

        Task DeleteCustomerTestAsync(CustomerTest customerTest);

        Task<CustomerTest> GetCustomerTestByIdAsync(int customerID);

        Task InsertCustomerTestAsync(CustomerTest customerTest);

        Task UpdateCustomerTestAsync(CustomerTest customerTest);

        bool CustomerTestIsAvailable(CustomerTest customerTest);

        #endregion

    }
}
