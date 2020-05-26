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
    public partial class EditCustomerForm : Form
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

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
                Id = int.Parse(txtBox_ID.Text);
                FirstName = txtBox_Name.Text;
                LastName = txtBox_Surname.Text;
                PhoneNumber = txtBox_Phonenumber.Text;
                this.Close();
            }
        }
    }
}
