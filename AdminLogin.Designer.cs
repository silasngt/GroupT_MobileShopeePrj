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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.txtAdminUser = new System.Windows.Forms.TextBox();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.lnkAdminForgot = new System.Windows.Forms.LinkLabel();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.pbxAdminLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnAdminHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminUser
            // 
            this.lblAdminUser.AutoSize = true;
            this.lblAdminUser.Location = new System.Drawing.Point(163, 138);
            this.lblAdminUser.Name = "lblAdminUser";
            this.lblAdminUser.Size = new System.Drawing.Size(57, 13);
            this.lblAdminUser.TabIndex = 0;
            this.lblAdminUser.Text = "UserName";
            // 
            // txtAdminUser
            // 
            this.txtAdminUser.Location = new System.Drawing.Point(226, 135);
            this.txtAdminUser.Name = "txtAdminUser";
            this.txtAdminUser.Size = new System.Drawing.Size(172, 20);
            this.txtAdminUser.TabIndex = 1;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(226, 170);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(172, 20);
            this.txtAdminPass.TabIndex = 3;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.Location = new System.Drawing.Point(163, 173);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(53, 13);
            this.lblAdminPass.TabIndex = 2;
            this.lblAdminPass.Text = "Password";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(323, 212);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // lnkAdminForgot
            // 
            this.lnkAdminForgot.AutoSize = true;
            this.lnkAdminForgot.Location = new System.Drawing.Point(357, 248);
            this.lnkAdminForgot.Name = "lnkAdminForgot";
            this.lnkAdminForgot.Size = new System.Drawing.Size(92, 13);
            this.lnkAdminForgot.TabIndex = 5;
            this.lnkAdminForgot.TabStop = true;
            this.lnkAdminForgot.Text = "Forgot Password?";
            this.lnkAdminForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdminForgot_LinkClicked);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(12, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(32, 13);
            this.lnkBack.TabIndex = 6;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // pbxAdminLogo
            // 
            this.pbxAdminLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdminLogo.Image")));
            this.pbxAdminLogo.Location = new System.Drawing.Point(204, 21);
            this.pbxAdminLogo.Name = "pbxAdminLogo";
            this.pbxAdminLogo.Size = new System.Drawing.Size(78, 76);
            this.pbxAdminLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdminLogo.TabIndex = 7;
            this.pbxAdminLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.Location = new System.Drawing.Point(270, 109);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(47, 13);
            this.lblAdminTitle.TabIndex = 9;
            this.lblAdminTitle.Text = "ADMIN";
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(503, 21);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(81, 28);
            this.btnMember.TabIndex = 10;
            this.btnMember.Text = "Thành viên";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnAdminHelp
            // 
            this.btnAdminHelp.Location = new System.Drawing.Point(503, 55);
            this.btnAdminHelp.Name = "btnAdminHelp";
            this.btnAdminHelp.Size = new System.Drawing.Size(81, 28);
            this.btnAdminHelp.TabIndex = 11;
            this.btnAdminHelp.Text = "Trợ giúp";
            this.btnAdminHelp.UseVisualStyleBackColor = true;
            this.btnAdminHelp.Click += new System.EventHandler(this.btnAdminHelp_Click);
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 291);
            this.Controls.Add(this.btnAdminHelp);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.lblAdminTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxAdminLogo);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.lnkAdminForgot);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.lblAdminPass);
            this.Controls.Add(this.txtAdminUser);
            this.Controls.Add(this.lblAdminUser);
            this.Name = "frmAdminLogin";
            this.Text = "Admin Login ";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdminLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pbxAdminLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnAdminHelp;
    }
}