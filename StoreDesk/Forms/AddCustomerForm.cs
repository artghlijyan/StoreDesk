using Storedesk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storedesk.Forms
{
    public partial class AddCustomerForm : Form
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        public int MyProperty { get; set; }
        public AddCustomerForm()
        {
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
                FirstName = txtBox_Name.Text;
                LastName = txtBox_Surname.Text;
                PhoneNumber = txtBox_Phonenumber.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
