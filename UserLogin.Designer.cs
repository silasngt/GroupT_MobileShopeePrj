namespace GroupT_MobileShopeePrj
{
    partial class frmUserLogin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lnkAdmin = new System.Windows.Forms.LinkLabel();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(134, 119);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "UserName";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(260, 113);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(260, 190);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(278, 31);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(134, 196);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lnkAdmin
            // 
            this.lnkAdmin.AutoSize = true;
            this.lnkAdmin.Location = new System.Drawing.Point(548, 42);
            this.lnkAdmin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkAdmin.Name = "lnkAdmin";
            this.lnkAdmin.Size = new System.Drawing.Size(72, 25);
            this.lnkAdmin.TabIndex = 4;
            this.lnkAdmin.TabStop = true;
            this.lnkAdmin.Text = "Admin";
            this.lnkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdmin_LinkClicked);
            // 
            // lnkForgot
            // 
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Location = new System.Drawing.Point(356, 321);
            this.lnkForgot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.Size = new System.Drawing.Size(186, 25);
            this.lnkForgot.TabIndex = 5;
            this.lnkForgot.TabStop = true;
            this.lnkForgot.Text = "Forgot Password?";
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(392, 240);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 44);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(12, 27);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(172, 54);
            this.btnMember.TabIndex = 7;
            this.btnMember.Text = "Member ";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // frmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 381);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkForgot);
            this.Controls.Add(this.lnkAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserLogin";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lnkAdmin;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnMember;
    }
}

