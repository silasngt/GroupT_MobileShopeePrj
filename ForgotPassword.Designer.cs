namespace GroupT_MobileShopeePrj
{
    partial class ForgotPassword
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbHint = new System.Windows.Forms.Label();
            this.lbPWD = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lnkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(294, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 31);
            this.txtName.TabIndex = 0;
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(294, 130);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(221, 31);
            this.txtHint.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(92, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(113, 25);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "UserName";
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.Location = new System.Drawing.Point(92, 136);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(50, 25);
            this.lbHint.TabIndex = 3;
            this.lbHint.Text = "Hint";
            // 
            // lbPWD
            // 
            this.lbPWD.AutoSize = true;
            this.lbPWD.Location = new System.Drawing.Point(92, 280);
            this.lbPWD.Name = "lbPWD";
            this.lbPWD.Size = new System.Drawing.Size(186, 25);
            this.lbPWD.TabIndex = 4;
            this.lbPWD.Text = "Your Password is:";
            this.lbPWD.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(294, 211);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 46);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lnkLogin
            // 
            this.lnkLogin.AutoSize = true;
            this.lnkLogin.Location = new System.Drawing.Point(536, 338);
            this.lnkLogin.Name = "lnkLogin";
            this.lnkLogin.Size = new System.Drawing.Size(114, 25);
            this.lnkLogin.TabIndex = 6;
            this.lnkLogin.TabStop = true;
            this.lnkLogin.Text = "login Page";
            this.lnkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogin_LinkClicked);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 382);
            this.Controls.Add(this.lnkLogin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbPWD);
            this.Controls.Add(this.lbHint);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.txtName);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.Label lbPWD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.LinkLabel lnkLogin;
    }
}