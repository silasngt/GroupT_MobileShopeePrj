using System;
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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserLogin objLogin = new frmUserLogin();
            objLogin.Show();
            this.Hide();
        }
    }
}
