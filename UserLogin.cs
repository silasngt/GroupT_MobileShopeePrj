using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupT_MobileShopeePrj
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminLogin adminForm = new frmAdminLogin();
            adminForm.Show();
            this.Hide();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword(); // tạo đối tượng form ForgotPassword
            forgotForm.Show(); 
            this.Hide(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            string query = "SELECT COUNT(*) FROM tbl_User WHERE UserName = @username AND PWD = @password";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    int userExists = (int)cmd.ExecuteScalar();

                    if (userExists > 0)
                    {
                        // Đăng nhập thành công
                        UserHomePage homeForm = new UserHomePage();
                        homeForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Sai thông tin
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Member memberForm = new Member(); // tạo đối tượng form ForgotPassword
            memberForm.Show();
            this.Hide();
        }
    }
}
