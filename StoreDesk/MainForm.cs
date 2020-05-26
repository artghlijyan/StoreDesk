using Storedesk.Interfaces;
using Storedesk.Interfaces.Impl;
using Storedesk.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storedesk.Models;

namespace Storedesk
{
    public partial class MainForm : Form
    {
        IDbContext dbContext;
        public MainForm()
        {
            dbContext = new DbContext();
            InitializeComponent();
        }

        private void InitializeDataGrid()
        {
            custmoerGrid.DataSource = dbContext.GetCustomers();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeDataGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
            int customerId = deleteForm.CustomerId;
            dbContext.DeleteCustomerById(customerId);
            InitializeDataGrid();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            AddCustomerForm customerForm = new AddCustomerForm();
            customerForm.ShowDialog();

            if (customerForm.DialogResult == DialogResult.OK)
            {
                customer.FirstName = customerForm.FirstName;
                customer.LastName = customerForm.LastName;
                customer.PhoneNumber = customerForm.PhoneNumber;
                dbContext.AddCustomer(customer);
                InitializeDataGrid();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            EditCustomerForm customerForm = new EditCustomerForm();
            customerForm.ShowDialog();

            if (customerForm.DialogResult == DialogResult.OK)
            {
                customer.CustomerId = customerForm.Id;
                customer.FirstName = customerForm.FirstName;
                customer.LastName = customerForm.LastName;
                customer.PhoneNumber = customerForm.PhoneNumber;
            }

            dbContext.EditCustomer(customer);
            InitializeDataGrid();
        }

        private void tb_Main_Click(object sender, EventArgs e)
        {
            if (custmoerGrid.DataSource == null)
            {
                InitializeDataGrid();
            }
        }
    }
}
