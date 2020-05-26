namespace Storedesk.Forms
{
    partial class DeleteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_CustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CustomerIdOk = new System.Windows.Forms.Button();
            this.btn_CustomerIdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_CustomerId
            // 
            this.txtBox_CustomerId.Location = new System.Drawing.Point(154, 28);
            this.txtBox_CustomerId.Name = "txtBox_CustomerId";
            this.txtBox_CustomerId.Size = new System.Drawing.Size(32, 20);
            this.txtBox_CustomerId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter customer ID to delete";
            // 
            // btn_CustomerIdOk
            // 
            this.btn_CustomerIdOk.Location = new System.Drawing.Point(15, 116);
            this.btn_CustomerIdOk.Name = "btn_CustomerIdOk";
            this.btn_CustomerIdOk.Size = new System.Drawing.Size(75, 23);
            this.btn_CustomerIdOk.TabIndex = 2;
            this.btn_CustomerIdOk.Text = "Ok";
            this.btn_CustomerIdOk.UseVisualStyleBackColor = true;
            this.btn_CustomerIdOk.Click += new System.EventHandler(this.btn_CustomerIdOk_Click);
            // 
            // btn_CustomerIdCancel
            // 
            this.btn_CustomerIdCancel.Location = new System.Drawing.Point(108, 116);
            this.btn_CustomerIdCancel.Name = "btn_CustomerIdCancel";
            this.btn_CustomerIdCancel.Size = new System.Drawing.Size(78, 23);
            this.btn_CustomerIdCancel.TabIndex = 3;
            this.btn_CustomerIdCancel.Text = "Cancel";
            this.btn_CustomerIdCancel.UseVisualStyleBackColor = true;
            this.btn_CustomerIdCancel.Click += new System.EventHandler(this.btn_CustomerIdCancel_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 151);
            this.Controls.Add(this.btn_CustomerIdCancel);
            this.Controls.Add(this.btn_CustomerIdOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_CustomerId);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_CustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CustomerIdOk;
        private System.Windows.Forms.Button btn_CustomerIdCancel;
    }
}