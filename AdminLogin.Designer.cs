namespace GroupT_MobileShopeePrj
{
    partial class frmAdminLogin
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
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lnkAdminForgot = new System.Windows.Forms.LinkLabel();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAdminUser
            // 
            this.lblAdminUser.AutoSize = true;
            this.lblAdminUser.Location = new System.Drawing.Point(78, 104);
            this.lblAdminUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdminUser.Name = "lblAdminUser";
            this.lblAdminUser.Size = new System.Drawing.Size(113, 25);
            this.lblAdminUser.TabIndex = 0;
            this.lblAdminUser.Text = "UserName";
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Location = new System.Drawing.Point(204, 98);
            this.txtAdminUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(340, 31);
            this.txtAdminUser.TabIndex = 1;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(204, 165);
            this.txtAdminPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(340, 31);
            this.txtAdminPass.TabIndex = 3;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(78, 171);
            this.lblAdminPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(106, 25);
            this.lblAdminPass.TabIndex = 2;
            this.lblAdminPass.Text = "Password";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(398, 246);
            this.btnAdminLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(150, 44);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lnkAdminForgot
            // 
            this.lnkAdminForgot.AutoSize = true;
            this.lnkAdminForgot.Location = new System.Drawing.Point(466, 315);
            this.lnkAdminForgot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkAdminForgot.Name = "lnkAdminForgot";
            this.lnkAdminForgot.Size = new System.Drawing.Size(186, 25);
            this.lnkAdminForgot.TabIndex = 5;
            this.lnkAdminForgot.TabStop = true;
            this.lnkAdminForgot.Text = "Forgot Password?";
            this.lnkAdminForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdminForgot_LinkClicked);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(24, 42);
            this.lnkBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(60, 25);
            this.lnkBack.TabIndex = 6;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 388);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.lnkAdminForgot);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.lblAdminPass);
            this.Controls.Add(this.txtAdminUser);
            this.Controls.Add(this.lblAdminUser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAdminLogin";
            this.Text = "Admin Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminUser;
        private System.Windows.Forms.TextBox txtAdminUser;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.LinkLabel lnkAdminForgot;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}