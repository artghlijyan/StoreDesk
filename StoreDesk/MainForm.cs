using Storedesk.Forms;
using System;
using System.Windows.Forms;
using Storedesk.Controllers;

namespace Storedesk
{
    public partial class MainForm : Form
    {
        Controller controller;

        public MainForm()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void InitializeCustomersGrid()
        {
            grid_Customers.DataSource = controller.GetCustomers();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeCustomersGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();

            if (deleteForm.DialogResult == DialogResult.OK)
            {
                InitializeCustomersGrid();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCustomerForm customerForm = new AddCustomerForm();
            customerForm.ShowDialog();

            if (customerForm.DialogResult == DialogResult.OK)
            {
                InitializeCustomersGrid();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditCustomerForm customerForm = new EditCustomerForm();
            customerForm.ShowDialog();

            if (customerForm.DialogResult == DialogResult.OK)
            {
                InitializeCustomersGrid();
            }
        }

        private void tb_Main_Click(object sender, EventArgs e)
        {
            if (grid_Customers.DataSource == null)
            {
                InitializeCustomersGrid();
            }
        }
    }
}
