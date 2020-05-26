using Storedesk.Controllers;
using System.Windows.Forms;

namespace Storedesk.Forms
{
    public partial class DeleteForm : Form
    {
        Controller controller;

        public DeleteForm()
        {
            controller = new Controller();
            InitializeComponent();
        }

        private void btn_CustomerIdCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_CustomerIdOk_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_CustomerId.Text))
            {
                MessageBox.Show("All Fileds Must Be Filled");
            }
            else
            {
                DialogResult = DialogResult.OK;
                int customerId = int.Parse(txtBox_CustomerId.Text);
                controller.DeleteCustomerById(customerId);
                this.Close();
            }
        }
    }
}
