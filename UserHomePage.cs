using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupT_MobileShopeePrj
{
    public partial class UserHomePage : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        SqlCommand cmd;
        public UserHomePage()
        {
            InitializeComponent();
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            LoadViewStockCompanies();
        }

        // Tạo Customer ID tuần tự theo cách Admin
        private string AutoGenCustomerId(SqlConnection connection, SqlTransaction transaction)
        {
            try
            {

                // Lấy số lớn nhất trong CustId (bỏ ký tự "C" đầu tiên)
                cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(CustId, 2, LEN(CustId)-1) AS int)), 0) FROM tbl_Customer", connection, transaction);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                id++;

                // Trả về ID dạng C01, C02, C03...
                return "C" + id.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo Customer ID: " + ex.Message);
                // Fallback về cách cũ nếu có lỗi
                return "C" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        // Tạo Sale ID tuần tự theo cách Admin
        private string AutoGenSaleId(SqlConnection connection, SqlTransaction transaction)
        {
            try
            {

                // Lấy số lớn nhất trong SaleId (bỏ ký tự "S" đầu tiên)
                cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(SaleId, 2, LEN(SaleId)-1) AS int)), 0) FROM tbl_Sales", connection, transaction);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                id++;

                // Trả về ID dạng S01, S02, S03...
                return "S" + id.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo Sale ID: " + ex.Message);
                // Fallback về cách cũ nếu có lỗi
                return "S" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void LoadCompanies()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT CompId, CName FROM tbl_Company", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbCompany.DataSource = dt;
                cmbCompany.DisplayMember = "CName";
                cmbCompany.ValueMember = "CompId";
                cmbCompany.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu công ty: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate tất cả các trường
            if (!ValidateInput())
                return;
            // Tạo và hiển thị form ConfirmDetail
            ConfirmDetail confirmForm = new ConfirmDetail();

            // Truyền dữ liệu sang form ConfirmDetail
            confirmForm.CustomerName = txtCustomerName.Text;
            confirmForm.MobileNumber = txtMobile.Text;
            confirmForm.Address = txtAddress.Text;
            confirmForm.EmailId = txtEmail.Text;
            confirmForm.CompanyName = cmbCompany.Text;
            confirmForm.ModelNumber = cmbModel.Text;
            confirmForm.IMEINumber = cmbIMEI.Text;
            confirmForm.Price = txtPrice.Text;

            // Lấy thông tin warranty
            DataTable dt = (DataTable)cmbIMEI.DataSource;
            if (dt != null && cmbIMEI.SelectedIndex >= 0)
            {
                DataRow row = dt.Rows[cmbIMEI.SelectedIndex];
                confirmForm.Warranty = Convert.ToDateTime(row["Warranty"]).ToString("dd/MM/yyyy");
            }

            // Hiển thị form dạng modal
            DialogResult result = confirmForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Lưu đơn hàng vào database
                if (SaveSale())
                {
                    MessageBox.Show("Đơn hàng đã được lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadCompanies(); // Refresh dữ liệu
                }
            }
        }

        private bool ValidateInput()
        {
            // Validate Customer Name - phải là string
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtCustomerName.Text, @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ\s]+$"))
            {
                MessageBox.Show("Tên khách hàng chỉ được chứa chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return false;
            }

            // Validate Mobile Number - phải là 12 chữ số
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobile.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtMobile.Text, @"^\d{12}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 12 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobile.Focus();
                return false;
            }

            // Validate Address - phải là string
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return false;
            }

            // Validate Email - phải đúng format
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate combo boxes
            if (cmbCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hãng điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCompany.Focus();
                return false;
            }

            if (cmbModel.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn model!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbModel.Focus();
                return false;
            }

            if (cmbIMEI.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn IMEI!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbIMEI.Focus();
                return false;
            }

            return true;
        }

        private bool SaveSale()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string custId = AutoGenCustomerId(conn, transaction);
                    string saleId = AutoGenSaleId(conn, transaction);

                    // Insert customer
                    cmd = new SqlCommand("INSERT INTO tbl_Customer (CustId, Cust_Name, MobileNumber, EmailId, Address) VALUES (@CustId, @CustName, @Mobile, @Email, @Address)", conn, transaction);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@CustId", custId);
                    cmd.Parameters.AddWithValue("@CustName", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.ExecuteNonQuery();

                    // Insert sale
                    decimal price = Convert.ToDecimal(txtPrice.Text.Replace(",", ""));
                    cmd = new SqlCommand("INSERT INTO tbl_Sales (SaleId, IMEINO, PurchageDate, Price, CustId) VALUES (@SaleId, @IMEI, @Date, @Price, @CustId)", conn, transaction);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@SaleId", saleId);
                    cmd.Parameters.AddWithValue("@IMEI", cmbIMEI.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@CustId", custId);
                    cmd.ExecuteNonQuery();

                    // Update mobile status
                    cmd = new SqlCommand("UPDATE tbl_Mobile SET Status = 'Sold' WHERE IMEINO = @IMEI", conn, transaction);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@IMEI", cmbIMEI.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();

                    // 4. Update Available Quantity trong tbl_Model (giảm 1) dựa trên ModelId
                    string selectedModelId = cmbModel.SelectedValue.ToString();
                    cmd = new SqlCommand("UPDATE tbl_Model SET AvailableQty = AvailableQty - 1 WHERE ModelId = @ModelId", conn, transaction);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ModelId", selectedModelId);
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtMobile.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            cmbCompany.SelectedIndex = -1;
            cmbModel.DataSource = null;
            cmbModel.Items.Clear();
            cmbIMEI.DataSource = null;
            cmbIMEI.Items.Clear();
            txtPrice.Clear();
        }

        private void cmbIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIMEI.SelectedValue != null && cmbIMEI.SelectedIndex != -1)
            {
                // Lấy giá từ DataTable
                DataTable dt = (DataTable)cmbIMEI.DataSource;
                if (dt != null && cmbIMEI.SelectedIndex >= 0)
                {
                    DataRow row = dt.Rows[cmbIMEI.SelectedIndex];
                    decimal price = Convert.ToDecimal(row["Price"]);
                    txtPrice.Text = price.ToString("N0");
                }
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear IMEI combo box
            cmbIMEI.DataSource = null;
            cmbIMEI.Items.Clear();
            txtPrice.Clear();

            if (cmbModel.SelectedValue != null && cmbModel.SelectedIndex != -1)
            {
                string modelId = cmbModel.SelectedValue.ToString();
                LoadIMEIByModel(modelId);
            }
        }

        private void LoadIMEIByModel(string modelId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT IMEINO, Price, Warranty FROM tbl_Mobile WHERE ModelId = @ModelId AND Status = 'Not sold'", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ModelId", modelId);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbIMEI.DataSource = dt;
                cmbIMEI.DisplayMember = "IMEINO";
                cmbIMEI.ValueMember = "IMEINO";
                cmbIMEI.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu IMEI: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear các combo box phụ thuộc
            cmbModel.DataSource = null;
            cmbModel.Items.Clear();
            cmbIMEI.DataSource = null;
            cmbIMEI.Items.Clear();
            txtPrice.Clear();

            if (cmbCompany.SelectedValue != null && cmbCompany.SelectedIndex != -1)
            {
                string companyId = cmbCompany.SelectedValue.ToString();
                LoadModelsByCompany(companyId);
            }
        }

        private void LoadModelsByCompany(string companyId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId = @CompId", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompId", companyId);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbModel.DataSource = dt;
                cmbModel.DisplayMember = "ModelNum";
                cmbModel.ValueMember = "ModelId";
                cmbModel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu model: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        private void cmbViewStockCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear model combo box và stock text
            cmbViewStockModel.DataSource = null;
            cmbViewStockModel.Items.Clear();
            txtStockAvailable.Clear();

            if (cmbViewStockCompany.SelectedValue != null && cmbViewStockCompany.SelectedIndex != -1)
            {
                string companyId = cmbViewStockCompany.SelectedValue.ToString();
                LoadViewStockModelsByCompany(companyId);
            }
        }
        private void LoadViewStockModelsByCompany(string companyId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId = @CompId", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CompId", companyId);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbViewStockModel.DataSource = dt;
                cmbViewStockModel.DisplayMember = "ModelNum";
                cmbViewStockModel.ValueMember = "ModelId";
                cmbViewStockModel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu model: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void cmbViewStockModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStockAvailable.Clear();

            if (cmbViewStockModel.SelectedValue != null && cmbViewStockModel.SelectedIndex != -1)
            {
                string modelId = cmbViewStockModel.SelectedValue.ToString();
                LoadStockAvailable(modelId);
            }
        }
        private void LoadStockAvailable(string modelId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Lấy số lượng available từ tbl_Model
                cmd = new SqlCommand("SELECT AvailableQty FROM tbl_Model WHERE ModelId = @ModelId", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ModelId", modelId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    txtStockAvailable.Text = result.ToString();
                }
                else
                {
                    txtStockAvailable.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu stock: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void LoadViewStockCompanies()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT CompId, CName FROM tbl_Company", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbViewStockCompany.DataSource = dt;
                cmbViewStockCompany.DisplayMember = "CName";
                cmbViewStockCompany.ValueMember = "CompId";
                cmbViewStockCompany.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu công ty cho View Stock: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 1. Validate IMEI input
            string imeiNumber = txtSearchIMEI.Text.Trim();

            // Kiểm tra IMEI không được để trống
            if (string.IsNullOrWhiteSpace(imeiNumber))
            {
                MessageBox.Show("Vui lòng nhập số IMEI!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchIMEI.Focus();
                return;
            }

            // Kiểm tra IMEI phải có đúng 16 chữ số
            if (!Regex.IsMatch(imeiNumber, @"^\d{16}$"))
            {
                MessageBox.Show("Số IMEI phải có đúng 16 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchIMEI.Focus();
                return;
            }

            // 2. Truy vấn dữ liệu
            SearchCustomerByIMEI(imeiNumber);
        }

        private void SearchCustomerByIMEI(string imeiNumber)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Query để lấy thông tin từ tbl_Sales và tbl_Customer dựa trên IMEI
                string query = @"
            SELECT c.Cust_Name AS CustomerName, 
                   c.MobileNumber, 
                   c.EmailId, 
                   c.Address, 
                   s.PurchageDate, 
                   s.Price
            FROM tbl_Sales s 
            INNER JOIN tbl_Customer c ON s.CustId = c.CustId
            WHERE s.IMEINO = @IMEI";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IMEI", imeiNumber);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị kết quả
                if (dt.Rows.Count > 0)
                {
                    // Nếu tìm thấy dữ liệu, hiển thị trên DataGridView
                    dgvSearchResults.DataSource = dt;

                    // Format lại các cột (nếu cần)
                    if (dgvSearchResults.Columns.Contains("PurchageDate"))
                    {
                        dgvSearchResults.Columns["PurchageDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        dgvSearchResults.Columns["PurchageDate"].HeaderText = "Purchase Date";
                    }

                    if (dgvSearchResults.Columns.Contains("Price"))
                    {
                        dgvSearchResults.Columns["Price"].DefaultCellStyle.Format = "N0";
                    }

                    if (dgvSearchResults.Columns.Contains("CustomerName"))
                    {
                        dgvSearchResults.Columns["CustomerName"].HeaderText = "Customer Name";
                    }

                    if (dgvSearchResults.Columns.Contains("MobileNumber"))
                    {
                        dgvSearchResults.Columns["MobileNumber"].HeaderText = "Mobile Number";
                    }

                    if (dgvSearchResults.Columns.Contains("EmailId"))
                    {
                        dgvSearchResults.Columns["EmailId"].HeaderText = "Email ID";
                    }
                }
                else
                {
                    // Nếu không tìm thấy dữ liệu
                    MessageBox.Show("Không tìm thấy thông tin cho số IMEI này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSearchResults.DataSource = null; // Xóa dữ liệu cũ nếu có
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();
            frmUserLogin loginForm = new frmUserLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}