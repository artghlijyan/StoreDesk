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

        public void DeleteCustomerById(int customerId)
        {
            dbContext.DeleteCustomerById(customerId);
        }

        public void AddCustomer(Customer customer)
        {
            dbContext.AddCustomer(customer);
        }

        public void EditCustomer(Customer customer)
        {
            dbContext.EditCustomer(customer);
        }
    }
}
