namespace GroupT_MobileShopeePrj
{
    partial class UserHomePage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbIMEI = new System.Windows.Forms.ComboBox();
            this.lblIMEI = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tabPageViewStock = new System.Windows.Forms.TabPage();
            this.txtStockAvailable = new System.Windows.Forms.TextBox();
            this.lblStockAvailable = new System.Windows.Forms.Label();
            this.cmbViewStockModel = new System.Windows.Forms.ComboBox();
            this.lblSelectModel = new System.Windows.Forms.Label();
            this.cmbViewStockCompany = new System.Windows.Forms.ComboBox();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.lblViewStockTitle = new System.Windows.Forms.Label();
            this.tabPageSearchCustomer = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.tabPageViewStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSales);
            this.tabControl1.Controls.Add(this.tabPageViewStock);
            this.tabControl1.Controls.Add(this.tabPageSearchCustomer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1600, 865);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.btnSubmit);
            this.tabPageSales.Controls.Add(this.txtPrice);
            this.tabPageSales.Controls.Add(this.lblPrice);
            this.tabPageSales.Controls.Add(this.cmbIMEI);
            this.tabPageSales.Controls.Add(this.lblIMEI);
            this.tabPageSales.Controls.Add(this.cmbModel);
            this.tabPageSales.Controls.Add(this.lblModel);
            this.tabPageSales.Controls.Add(this.cmbCompany);
            this.tabPageSales.Controls.Add(this.lblCompany);
            this.tabPageSales.Controls.Add(this.txtEmail);
            this.tabPageSales.Controls.Add(this.lblEmail);
            this.tabPageSales.Controls.Add(this.txtAddress);
            this.tabPageSales.Controls.Add(this.lblAddress);
            this.tabPageSales.Controls.Add(this.txtMobile);
            this.tabPageSales.Controls.Add(this.lblMobile);
            this.tabPageSales.Controls.Add(this.txtCustomerName);
            this.tabPageSales.Controls.Add(this.lblCustomerName);
            this.tabPageSales.Location = new System.Drawing.Point(8, 45);
            this.tabPageSales.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageSales.Size = new System.Drawing.Size(1584, 812);
            this.tabPageSales.TabIndex = 0;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(700, 692);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 67);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(500, 615);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(396, 44);
            this.txtPrice.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.Location = new System.Drawing.Point(100, 621);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(176, 37);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price/Piece";
            // 
            // cmbIMEI
            // 
            this.cmbIMEI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIMEI.FormattingEnabled = true;
            this.cmbIMEI.Location = new System.Drawing.Point(500, 538);
            this.cmbIMEI.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIMEI.Name = "cmbIMEI";
            this.cmbIMEI.Size = new System.Drawing.Size(396, 45);
            this.cmbIMEI.TabIndex = 13;
            this.cmbIMEI.SelectedIndexChanged += new System.EventHandler(this.cmbIMEI_SelectedIndexChanged);
            // 
            // lblIMEI
            // 
            this.lblIMEI.AutoSize = true;
            this.lblIMEI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIMEI.Location = new System.Drawing.Point(100, 544);
            this.lblIMEI.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIMEI.Name = "lblIMEI";
            this.lblIMEI.Size = new System.Drawing.Size(204, 37);
            this.lblIMEI.TabIndex = 12;
            this.lblIMEI.Text = "IMEI Number";
            // 
            // cmbModel
            // 
            this.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(500, 462);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(6);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(396, 45);
            this.cmbModel.TabIndex = 11;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblModel.Location = new System.Drawing.Point(100, 467);
            this.lblModel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(227, 37);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model Number";
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(500, 385);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(396, 45);
            this.cmbCompany.TabIndex = 9;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCompany.Location = new System.Drawing.Point(100, 390);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(249, 37);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Company Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(500, 308);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(396, 44);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(100, 313);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(137, 37);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAddress.Location = new System.Drawing.Point(500, 192);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 92);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.Location = new System.Drawing.Point(100, 198);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(135, 37);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMobile.Location = new System.Drawing.Point(500, 115);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(6);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(396, 44);
            this.txtMobile.TabIndex = 3;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMobile.Location = new System.Drawing.Point(100, 121);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(234, 37);
            this.lblMobile.TabIndex = 2;
            this.lblMobile.Text = "Mobile Number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerName.Location = new System.Drawing.Point(500, 38);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(396, 44);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerName.Location = new System.Drawing.Point(100, 44);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(251, 37);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // tabPageViewStock
            // 
            this.tabPageViewStock.Controls.Add(this.txtStockAvailable);
            this.tabPageViewStock.Controls.Add(this.lblStockAvailable);
            this.tabPageViewStock.Controls.Add(this.cmbViewStockModel);
            this.tabPageViewStock.Controls.Add(this.lblSelectModel);
            this.tabPageViewStock.Controls.Add(this.cmbViewStockCompany);
            this.tabPageViewStock.Controls.Add(this.lblSelectCompany);
            this.tabPageViewStock.Controls.Add(this.lblViewStockTitle);
            this.tabPageViewStock.Location = new System.Drawing.Point(8, 45);
            this.tabPageViewStock.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageViewStock.Name = "tabPageViewStock";
            this.tabPageViewStock.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageViewStock.Size = new System.Drawing.Size(1584, 812);
            this.tabPageViewStock.TabIndex = 1;
            this.tabPageViewStock.Text = "viewstock";
            this.tabPageViewStock.UseVisualStyleBackColor = true;
            // 
            // txtStockAvailable
            // 
            this.txtStockAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStockAvailable.Location = new System.Drawing.Point(569, 287);
            this.txtStockAvailable.Name = "txtStockAvailable";
            this.txtStockAvailable.ReadOnly = true;
            this.txtStockAvailable.Size = new System.Drawing.Size(350, 44);
            this.txtStockAvailable.TabIndex = 6;
            // 
            // lblStockAvailable
            // 
            this.lblStockAvailable.AutoSize = true;
            this.lblStockAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStockAvailable.Location = new System.Drawing.Point(200, 290);
            this.lblStockAvailable.Name = "lblStockAvailable";
            this.lblStockAvailable.Size = new System.Drawing.Size(253, 37);
            this.lblStockAvailable.TabIndex = 5;
            this.lblStockAvailable.Text = "Stock Available :";
            // 
            // cmbViewStockModel
            // 
            this.cmbViewStockModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewStockModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbViewStockModel.FormattingEnabled = true;
            this.cmbViewStockModel.Location = new System.Drawing.Point(569, 212);
            this.cmbViewStockModel.Name = "cmbViewStockModel";
            this.cmbViewStockModel.Size = new System.Drawing.Size(350, 45);
            this.cmbViewStockModel.TabIndex = 4;
            this.cmbViewStockModel.SelectedIndexChanged += new System.EventHandler(this.cmbViewStockModel_SelectedIndexChanged);
            // 
            // lblSelectModel
            // 
            this.lblSelectModel.AutoSize = true;
            this.lblSelectModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectModel.Location = new System.Drawing.Point(200, 220);
            this.lblSelectModel.Name = "lblSelectModel";
            this.lblSelectModel.Size = new System.Drawing.Size(341, 37);
            this.lblSelectModel.TabIndex = 3;
            this.lblSelectModel.Text = "Select Model Number :";
            // 
            // cmbViewStockCompany
            // 
            this.cmbViewStockCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewStockCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbViewStockCompany.FormattingEnabled = true;
            this.cmbViewStockCompany.Location = new System.Drawing.Point(569, 142);
            this.cmbViewStockCompany.Name = "cmbViewStockCompany";
            this.cmbViewStockCompany.Size = new System.Drawing.Size(350, 45);
            this.cmbViewStockCompany.TabIndex = 2;
            this.cmbViewStockCompany.SelectedIndexChanged += new System.EventHandler(this.cmbViewStockCompany_SelectedIndexChanged);
            // 
            // lblSelectCompany
            // 
            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectCompany.Location = new System.Drawing.Point(200, 150);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(363, 37);
            this.lblSelectCompany.TabIndex = 1;
            this.lblSelectCompany.Text = "Select Company Name :";
            // 
            // lblViewStockTitle
            // 
            this.lblViewStockTitle.AutoSize = true;
            this.lblViewStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblViewStockTitle.Location = new System.Drawing.Point(650, 50);
            this.lblViewStockTitle.Name = "lblViewStockTitle";
            this.lblViewStockTitle.Size = new System.Drawing.Size(246, 51);
            this.lblViewStockTitle.TabIndex = 0;
            this.lblViewStockTitle.Text = "View Stock";
            // 
            // tabPageSearchCustomer
            // 
            this.tabPageSearchCustomer.Location = new System.Drawing.Point(8, 45);
            this.tabPageSearchCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageSearchCustomer.Name = "tabPageSearchCustomer";
            this.tabPageSearchCustomer.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageSearchCustomer.Size = new System.Drawing.Size(1584, 812);
            this.tabPageSearchCustomer.TabIndex = 2;
            this.tabPageSearchCustomer.Text = "searchCustomerbyIMEI";
            this.tabPageSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHomePage";
            this.Load += new System.EventHandler(this.UserHomePage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            this.tabPageSales.PerformLayout();
            this.tabPageViewStock.ResumeLayout(false);
            this.tabPageViewStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPageViewStock;
        private System.Windows.Forms.TabPage tabPageSearchCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label lblIMEI;
        private System.Windows.Forms.ComboBox cmbIMEI;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSubmit;

        // View Stock controls
        private System.Windows.Forms.Label lblViewStockTitle;
        private System.Windows.Forms.Label lblSelectCompany;
        private System.Windows.Forms.ComboBox cmbViewStockCompany;
        private System.Windows.Forms.Label lblSelectModel;
        private System.Windows.Forms.ComboBox cmbViewStockModel;
        private System.Windows.Forms.Label lblStockAvailable;
        private System.Windows.Forms.TextBox txtStockAvailable;
    }
}