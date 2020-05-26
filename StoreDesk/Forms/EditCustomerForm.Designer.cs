namespace Storedesk.Forms
{
    partial class EditCustomerForm
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
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_Surname = new System.Windows.Forms.TextBox();
            this.txtBox_Phonenumber = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(12, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(68, 13);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Customer ID:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 33);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(63, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "New Name:";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(12, 57);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(77, 13);
            this.lbl_Surname.TabIndex = 2;
            this.lbl_Surname.Text = "New Surname:";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(12, 81);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(101, 13);
            this.lbl_PhoneNumber.TabIndex = 3;
            this.lbl_PhoneNumber.Text = "New Phonenumber:";
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Location = new System.Drawing.Point(119, 6);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(100, 20);
            this.txtBox_ID.TabIndex = 4;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(119, 30);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Name.TabIndex = 5;
            // 
            // txtBox_Surname
            // 
            this.txtBox_Surname.Location = new System.Drawing.Point(119, 54);
            this.txtBox_Surname.Name = "txtBox_Surname";
            this.txtBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Surname.TabIndex = 6;
            // 
            // txtBox_Phonenumber
            // 
            this.txtBox_Phonenumber.Location = new System.Drawing.Point(119, 78);
            this.txtBox_Phonenumber.Name = "txtBox_Phonenumber";
            this.txtBox_Phonenumber.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Phonenumber.TabIndex = 7;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(40, 117);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 8;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(121, 117);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // EditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 149);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txtBox_Phonenumber);
            this.Controls.Add(this.txtBox_Surname);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Id);
            this.MaximizeBox = false;
            this.Name = "EditCustomerForm";
            this.Text = "EditCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_Surname;
        private System.Windows.Forms.TextBox txtBox_Phonenumber;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}