using Storedesk.Controllers;
using Storedesk.Models;
using System;
using System.Windows.Forms;

namespace Storedesk.Forms
{
    public partial class AddCustomerForm : Form
    {
        Controller controller;

        public AddCustomerForm()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Name.Text) ||
                string.IsNullOrEmpty(txtBox_Surname.Text) ||
                string.IsNullOrEmpty(txtBox_Phonenumber.Text))
            {
                MessageBox.Show("All Fileds Must Be Filled");
            }
            else
            {
                Customer customer = new Customer()
                {
                    FirstName = txtBox_Name.Text,
                    LastName = txtBox_Surname.Text,
                    PhoneNumber = txtBox_Phonenumber.Text
                };

                DialogResult = DialogResult.OK;
                controller.AddCustomer(customer);
                this.Close();
            }
        }
    }
}
