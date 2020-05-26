using Storedesk.DbContext;
using Storedesk.DbContext.Impl;
using Storedesk.Models;
using System;
using System.Collections.Generic;

namespace Storedesk.Controllers
{
    public class Controller
    {
        private IDbContext dbContext;

        public Controller()
        {
            dbContext = new SqlDbContext();
        }

        public List<Customer> GetCustomers()
        {
            return dbContext.GetCustomers();
        }

        internal void DeleteCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Customer customer)
        {
            dbContext.AddCustomer(customer);
        }

        internal void EditCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
