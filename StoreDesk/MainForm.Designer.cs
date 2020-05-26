namespace Storedesk
{
    partial class MainForm
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
            this.grid_Customers = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_Main = new System.Windows.Forms.TabControl();
            this.tb_Products = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_Products = new System.Windows.Forms.DataGridView();
            this.tb_Customers = new System.Windows.Forms.TabPage();
            this.tb_Sales = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).BeginInit();
            this.tb_Main.SuspendLayout();
            this.tb_Products.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).BeginInit();
            this.tb_Customers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Customers
            // 
            this.grid_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_Customers.Location = new System.Drawing.Point(3, 3);
            this.grid_Customers.Name = "grid_Customers";
            this.grid_Customers.Size = new System.Drawing.Size(786, 362);
            this.grid_Customers.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.Location = new System.Drawing.Point(549, 395);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.Location = new System.Drawing.Point(630, 395);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.Location = new System.Drawing.Point(711, 395);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tb_Main
            // 
            this.tb_Main.Controls.Add(this.tb_Products);
            this.tb_Main.Controls.Add(this.tb_Customers);
            this.tb_Main.Controls.Add(this.tb_Sales);
            this.tb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Main.Location = new System.Drawing.Point(0, 0);
            this.tb_Main.Name = "tb_Main";
            this.tb_Main.SelectedIndex = 0;
            this.tb_Main.Size = new System.Drawing.Size(800, 450);
            this.tb_Main.TabIndex = 5;
            this.tb_Main.Click += new System.EventHandler(this.tb_Main_Click);
            // 
            // tb_Products
            // 
            this.tb_Products.Controls.Add(this.panel2);
            this.tb_Products.Controls.Add(this.panel1);
            this.tb_Products.Location = new System.Drawing.Point(4, 22);
            this.tb_Products.Name = "tb_Products";
            this.tb_Products.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Products.Size = new System.Drawing.Size(792, 424);
            this.tb_Products.TabIndex = 0;
            this.tb_Products.Text = "Products";
            this.tb_Products.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 45);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dg_Products);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 367);
            this.panel1.TabIndex = 0;
            // 
            // dg_Products
            // 
            this.dg_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Products.Location = new System.Drawing.Point(0, 0);
            this.dg_Products.Name = "dg_Products";
            this.dg_Products.Size = new System.Drawing.Size(778, 367);
            this.dg_Products.TabIndex = 0;
            // 
            // tb_Customers
            // 
            this.tb_Customers.Controls.Add(this.btn_Delete);
            this.tb_Customers.Controls.Add(this.btn_Edit);
            this.tb_Customers.Controls.Add(this.btn_Add);
            this.tb_Customers.Controls.Add(this.grid_Customers);
            this.tb_Customers.Location = new System.Drawing.Point(4, 22);
            this.tb_Customers.Name = "tb_Customers";
            this.tb_Customers.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Customers.Size = new System.Drawing.Size(792, 424);
            this.tb_Customers.TabIndex = 1;
            this.tb_Customers.Text = "Customers";
            this.tb_Customers.UseVisualStyleBackColor = true;
            // 
            // tb_Sales
            // 
            this.tb_Sales.Location = new System.Drawing.Point(4, 22);
            this.tb_Sales.Name = "tb_Sales";
            this.tb_Sales.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Sales.Size = new System.Drawing.Size(792, 424);
            this.tb_Sales.TabIndex = 2;
            this.tb_Sales.Text = "Sales";
            this.tb_Sales.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Main);
            this.Name = "MainForm";
            this.Text = "StoreDesk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).EndInit();
            this.tb_Main.ResumeLayout(false);
            this.tb_Products.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Products)).EndInit();
            this.tb_Customers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_Customers;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TabControl tb_Main;
        private System.Windows.Forms.TabPage tb_Products;
        private System.Windows.Forms.TabPage tb_Customers;
        private System.Windows.Forms.TabPage tb_Sales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_Products;
    }
}

