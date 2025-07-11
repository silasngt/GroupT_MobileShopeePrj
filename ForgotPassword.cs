using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;


namespace GroupT_MobileShopeePrj
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string hint = txtHint.Text.Trim();

            if (username == "" || hint == "")
            {
                lbPWD.Visible = true;

                lbPWD.Text = "Please enter both Username and Hint.";
                lbPWD.ForeColor = Color.Red;
                return;
            }

            // Lấy connection string từ App.config
            string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
            string query = "SELECT PWD FROM tbl_User WHERE UserName = @username AND Hint = @hint";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@hint", hint);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lbPWD.Visible = true;
                        lbPWD.ForeColor = Color.Green;
                        lbPWD.Text = "Your password is: " + result.ToString();
                    }
                    else
                    {
                        lbPWD.Visible = true;
                        lbPWD.ForeColor = Color.Red;
                        lbPWD.Text = "Invalid username or hint.";
                    }
                }
                catch (Exception ex)
                {
                    lbPWD.Visible = true;
                    lbPWD.ForeColor = Color.Red;
                    lbPWD.Text = "Database error: " + ex.Message;
                }
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserLogin objLogin = new frmUserLogin();
            objLogin.Show();
            this.Hide();
        }
    }
}
