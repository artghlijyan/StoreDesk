using System.Windows.Forms;

namespace Storedesk.Forms
{
    public partial class DeleteForm : Form
    {
        public int CustomerId { get; private set; }
        public DeleteForm()
        {
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
                CustomerId = int.Parse(txtBox_CustomerId.Text);
                this.Close();
            }
        }
    }
}
