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
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserLogin objLogin = new frmUserLogin();
            objLogin.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if(txtAdminUser.Text == "admin" && txtAdminPass.Text == "admin")
            {
                AdminHomePage objAdminHome = new AdminHomePage();
                objAdminHome.Show();
                this.Hide();
                this.Close(); // Close the login form after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkAdminForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword(); // tạo đối tượng form ForgotPassword
            forgotForm.Show(); // hiển thị form
            this.Hide(); // ẩn form hiện tại nếu muốn (tùy)
        }
    }
}
