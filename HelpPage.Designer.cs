namespace GroupT_MobileShopeePrj
{
    partial class HelpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPage));
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.pbxPic1 = new System.Windows.Forms.PictureBox();
            this.pbxPic2 = new System.Windows.Forms.PictureBox();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblDirect1 = new System.Windows.Forms.Label();
            this.lblDirect2 = new System.Windows.Forms.Label();
            this.linkBackUser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpTitle.ForeColor = System.Drawing.Color.Red;
            this.lblHelpTitle.Location = new System.Drawing.Point(104, 36);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(451, 13);
            this.lblHelpTitle.TabIndex = 0;
            this.lblHelpTitle.Text = "NẾU NHƯ CÓI LỖI liên quan đến kết nối database hãy làm theo các bước sau";
            // 
            // pbxPic1
            // 
            this.pbxPic1.Image = ((System.Drawing.Image)(resources.GetObject("pbxPic1.Image")));
            this.pbxPic1.Location = new System.Drawing.Point(45, 96);
            this.pbxPic1.Name = "pbxPic1";
            this.pbxPic1.Size = new System.Drawing.Size(251, 159);
            this.pbxPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPic1.TabIndex = 1;
            this.pbxPic1.TabStop = false;
            // 
            // pbxPic2
            // 
            this.pbxPic2.Image = ((System.Drawing.Image)(resources.GetObject("pbxPic2.Image")));
            this.pbxPic2.Location = new System.Drawing.Point(360, 96);
            this.pbxPic2.Name = "pbxPic2";
            this.pbxPic2.Size = new System.Drawing.Size(256, 159);
            this.pbxPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPic2.TabIndex = 2;
            this.pbxPic2.TabStop = false;
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep1.ForeColor = System.Drawing.Color.Teal;
            this.lblStep1.Location = new System.Drawing.Point(142, 69);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(52, 13);
            this.lblStep1.TabIndex = 3;
            this.lblStep1.Text = "BƯỚC 1\r\n";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStep2.ForeColor = System.Drawing.Color.Teal;
            this.lblStep2.Location = new System.Drawing.Point(471, 69);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(52, 13);
            this.lblStep2.TabIndex = 4;
            this.lblStep2.Text = "BƯỚC 2";
            // 
            // lblDirect1
            // 
            this.lblDirect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirect1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDirect1.Location = new System.Drawing.Point(52, 269);
            this.lblDirect1.Name = "lblDirect1";
            this.lblDirect1.Size = new System.Drawing.Size(220, 39);
            this.lblDirect1.TabIndex = 5;
            this.lblDirect1.Text = "Trong thư mục source code click vào file App.Config";
            // 
            // lblDirect2
            // 
            this.lblDirect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirect2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDirect2.Location = new System.Drawing.Point(380, 269);
            this.lblDirect2.Name = "lblDirect2";
            this.lblDirect2.Size = new System.Drawing.Size(218, 54);
            this.lblDirect2.TabIndex = 6;
            this.lblDirect2.Text = "Sau đó thay phần Datasource phù hợp với SSMS (Windows Server) trên máy, và phần I" +
    "nitial Catalog thay đúng tên của db\r\n";
            // 
            // linkBackUser
            // 
            this.linkBackUser.AutoSize = true;
            this.linkBackUser.Location = new System.Drawing.Point(22, 18);
            this.linkBackUser.Name = "linkBackUser";
            this.linkBackUser.Size = new System.Drawing.Size(32, 13);
            this.linkBackUser.TabIndex = 7;
            this.linkBackUser.TabStop = true;
            this.linkBackUser.Text = "Back";
            this.linkBackUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackUser_LinkClicked);
            // 
            // HelpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 379);
            this.Controls.Add(this.linkBackUser);
            this.Controls.Add(this.lblDirect2);
            this.Controls.Add(this.lblDirect1);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.pbxPic2);
            this.Controls.Add(this.pbxPic1);
            this.Controls.Add(this.lblHelpTitle);
            this.Name = "HelpPage";
            this.Text = "HelpPage";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.PictureBox pbxPic1;
        private System.Windows.Forms.PictureBox pbxPic2;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblDirect1;
        private System.Windows.Forms.Label lblDirect2;
        private System.Windows.Forms.LinkLabel linkBackUser;
    }
}