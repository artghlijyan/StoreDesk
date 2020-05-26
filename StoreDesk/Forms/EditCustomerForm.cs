using Storedesk.Controllers;
using Storedesk.Models;
using System;
using System.Windows.Forms;

namespace Storedesk.Forms
{
    public partial class EditCustomerForm : Form
    {
        Controller controllers = new Controller();

        public EditCustomerForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_ID.Text) ||
                string.IsNullOrEmpty(txtBox_Name.Text) ||
                string.IsNullOrEmpty(txtBox_Surname.Text) ||
                string.IsNullOrEmpty(txtBox_Phonenumber.Text))
            {
                MessageBox.Show("All Fileds Must Be Filled");
            }
            else
            {
                Customer customer = new Customer
                {
                    CustomerId = int.Parse(txtBox_ID.Text),
                    FirstName = txtBox_Name.Text,
                    LastName = txtBox_Surname.Text,
                    PhoneNumber = txtBox_Phonenumber.Text
                };

                controllers.EditCustomer(customer);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
