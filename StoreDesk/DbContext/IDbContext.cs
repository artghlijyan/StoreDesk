using Storedesk.Models;
using System.Collections.Generic;

namespace Storedesk.DbContext
{
    interface IDbContext
    { 
        List<Customer> GetCustomers();

        void EditCustomer(Customer customer);

        void AddCustomer(Customer customer);

        void DeleteCustomerById(int customerId);
    }
}
