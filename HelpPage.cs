﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupT_MobileShopeePrj
{
    public partial class HelpPage : Form
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        private void linkBackUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmUserLogin loginForm = new frmUserLogin();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
