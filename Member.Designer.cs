﻿namespace GroupT_MobileShopeePrj
{
    partial class Member
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member of group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2251120049-Nguyễn Giang Thành Tài";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "2251120182-Nguyễn Ngọc Quận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "2251120165-Nguyễn Khao";
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Location = new System.Drawing.Point(15, 9);
            this.lnkBack.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(60, 25);
            this.lnkBack.TabIndex = 7;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "Back";
            this.lnkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBack_LinkClicked);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 264);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Member";
            this.Text = "Member of Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}