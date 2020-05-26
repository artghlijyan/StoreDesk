using Storedesk.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Storedesk.Interfaces.Impl
{
    class DbContext : IDbContext
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Customer customer = new Customer();
                            customer.CustomerId = (int)reader["CustomerId"];
                            customer.FirstName = (string)reader["FirstName"];
                            customer.LastName = (string)reader["LastName"];
                            customer.PhoneNumber = (string)reader["PhoneNumber"];
                            customers.Add(customer);
                        }
                    }
                }
            }

            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            string insertQuery = "INSERT INTO Customers (FirstName, LastName, PhoneNumber)" +
                " VALUES (@FirstName, @LastName, @PhoneNumber)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditCustomer(Customer customer)
        {
            string insertQuery = "UPDATE Customers SET " +
                "FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "PhoneNumber = @PhoneNumber " +
                "WHERE CustomerId = @CustomerId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCustomerById(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMERS WHERE CustomerId = @customerId", connection))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
