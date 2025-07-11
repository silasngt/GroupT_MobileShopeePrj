using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroupT_MobileShopeePrj
{
    public partial class AdminHomePage : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        SqlCommand cmd;

        public AdminHomePage()
        {
            InitializeComponent();
            //Part of Company
            AutoGenCompanyId();
            LoadCompanyList();

            //Part of Model
            AutoGenerateModelId();
            LoadCompanyNames(cmbCName);
            LoadModelList();

            //Part of Transaction
            AutoGenTransId();
            LoadCompanyNames(cmbUpdateCName);
            LoadStockList();

            //Part of Mobile
            LoadCompanyNames(cmbMobileCName);
            LoadWarrantyOptions();
            LoadMobileList();

            //Part Of User
            LoadUserList();

            //Part of Report
            SetupListView(lvwSingleDateReport);
            SetupListView(lvwDateRangeReport);
        }

        // --- Company ---
        void AutoGenCompanyId()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(CompId, 3, LEN(CompId)-2) AS int)), 0) FROM tbl_Company", conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                id++;
                txtCompId.Text = "CP" + id.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo Company ID: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên công ty!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM tbl_Company WHERE CName = @CompName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@CompName", txtCompName.Text.Trim());
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Tên công ty đã tồn tại!");
                    return;
                }

                cmd = new SqlCommand("INSERT INTO tbl_Company (CompId, CName) VALUES (@CompId, @CompName)", conn);
                cmd.Parameters.AddWithValue("@CompId", txtCompId.Text);
                cmd.Parameters.AddWithValue("@CompName", txtCompName.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm Công ty thành công!");

                AutoGenCompanyId();
                txtCompName.Clear();
                LoadCompanyNames(cmbCName);
                LoadCompanyNames(cmbUpdateCName);
                LoadCompanyNames(cmbMobileCName);
                LoadCompanyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //---Function ListView For Company---
        void LoadCompanyList()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("SELECT CompId, CName FROM tbl_Company", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                lvwListOfCompany.Items.Clear(); // Dọn trước

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["CompId"].ToString());
                    item.SubItems.Add(dr["CName"].ToString());
                    lvwListOfCompany.Items.Add(item);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Company: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        // --- Model ---
        void AutoGenerateModelId()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Lấy số lớn nhất trong ModelId (cắt bỏ 2 ký tự "MD")
                cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(ModelId, 3, LEN(ModelId)-2) AS int)), 0) FROM tbl_Model", conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                id++;

                // Tạo ModelId mới với tiền tố "MD" + số (ví dụ: MD01, MD02,...)
                txtModelId.Text = "MD" + id.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo Model ID: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        


        void LoadCompanyNames(ComboBox comboBox)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("SELECT CompId, CName FROM tbl_Company", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                comboBox.DataSource = dt;
                comboBox.DisplayMember = "CName";
                comboBox.ValueMember = "CompId";

                if (dt.Rows.Count > 0)
                    comboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải Company: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnAddModel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelNum.Text))
            {
                MessageBox.Show("Vui lòng nhập tên model!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string compId = cmbCName.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(compId))
            {
                MessageBox.Show("Vui lòng chọn công ty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modelId = txtModelId.Text.Trim();
            string modelName = txtModelNum.Text.Trim();
            string modelNum = txtModelNum.Text.Trim();

            if (string.IsNullOrWhiteSpace(modelNum))
            {
                MessageBox.Show("Vui lòng nhập ModelNum!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO tbl_Model (ModelId, CompId, ModelNum, AvailableQty) VALUES (@ModelId, @CompId, @ModelNum, @AvailableQty)", conn);
                cmd.Parameters.AddWithValue("@ModelId", modelId);
                cmd.Parameters.AddWithValue("@CompId", compId);
                cmd.Parameters.AddWithValue("@ModelNum", modelNum);
                cmd.Parameters.AddWithValue("@AvailableQty", 0);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm Model thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AutoGenerateModelId();   // Sinh ID mới
                txtModelNum.Clear();
                LoadModelList();         // Tải lại danh sách Model
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //--- Function ListView For Model ---
        void LoadModelList()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"
            SELECT m.ModelId, c.CName, m.ModelNum, m.AvailableQty
            FROM tbl_Model m
            JOIN tbl_Company c ON m.CompId = c.CompId";

                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                lvwListOfModel.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ModelId"].ToString());
                    item.SubItems.Add(dr["CName"].ToString());
                    item.SubItems.Add(dr["ModelNum"].ToString());
                    item.SubItems.Add(dr["AvailableQty"].ToString());

                    lvwListOfModel.Items.Add(item);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Model: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        // --- Transaction ---
        void AutoGenTransId()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd = new SqlCommand("SELECT ISNULL(MAX(CAST(SUBSTRING(TransId, 3, LEN(TransId)-2) AS int)), 0) FROM tbl_Transaction", conn);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                id++;
                txtTransId.Text = "TS" + id.ToString("D2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo TransId: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

       
        void LoadModelNumbers(string compId, ComboBox targetComboBox)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                targetComboBox.DataSource = null;
                targetComboBox.Items.Clear();
                targetComboBox.Text = "";

                SqlCommand cmd = new SqlCommand("SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId = @CompId", conn);
                cmd.Parameters.AddWithValue("@CompId", compId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                targetComboBox.DataSource = dt;
                targetComboBox.DisplayMember = "ModelNum";
                targetComboBox.ValueMember = "ModelId";

                if (dt.Rows.Count > 0)
                    targetComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        // --- Update Stock ---
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbUpdateCName.SelectedValue == null || cmbModelNumber.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Company và Model!");
                return;
            }

            if (!int.TryParse(txtUpdateQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity phải là số nguyên!");
                return;
            }

            if (!decimal.TryParse(txtUpdateAmount.Text, out decimal amount))
            {
                MessageBox.Show("Amount phải là số!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand("INSERT INTO tbl_Transaction (TransId, ModelId, Quantity, Date, Amount) VALUES (@TransId, @ModelId, @Quantity, @Date, @Amount)", conn);
                cmd.Parameters.AddWithValue("@TransId", txtTransId.Text);
                cmd.Parameters.AddWithValue("@ModelId", cmbModelNumber.SelectedValue);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Amount", amount);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("UPDATE tbl_Model SET AvailableQty = AvailableQty + @Quantity WHERE ModelId = @ModelId", conn);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ModelId", cmbModelNumber.SelectedValue);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!");
                LoadStockList();

                AutoGenTransId();
                txtUpdateQuantity.Clear();
                txtUpdateAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void cmbUpdateCName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateCName.SelectedValue != null)
            {
                string compId = cmbUpdateCName.SelectedValue.ToString();
                LoadModelNumbers(compId, cmbModelNumber);
            }
        }

        //--- Function ListView For Transaction ---
        void LoadStockList()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"
            SELECT t.TransId, c.CName, m.ModelNum, t.Quantity, t.Amount, t.Date
            FROM tbl_Transaction t
            JOIN tbl_Model m ON t.ModelId = m.ModelId
            JOIN tbl_Company c ON m.CompId = c.CompId
            ORDER BY t.TransId DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                lvwListStockOfProduct.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["TransId"].ToString());
                    item.SubItems.Add(reader["CName"].ToString());
                    item.SubItems.Add(reader["ModelNum"].ToString());
                    item.SubItems.Add(reader["Quantity"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(reader["Amount"]).ToString("N0"));
                    item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("dd/MM/yyyy"));

                    lvwListStockOfProduct.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách stock: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        //--- Mobile ---
        private void cmbMobileCName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMobileCName.SelectedValue != null)
            {
                string compId = cmbMobileCName.SelectedValue.ToString();
                LoadModelNumbers(compId, cmbMobileModelNumber);
            }
        }


        void LoadWarrantyOptions()
        {
            cmbMobileWarranty.Items.Clear();
            cmbMobileWarranty.Items.Add("6 Tháng");
            cmbMobileWarranty.Items.Add("1 Năm");
            cmbMobileWarranty.Items.Add("2 Năm");
            cmbMobileWarranty.Items.Add("3 Năm");
            cmbMobileWarranty.SelectedIndex = 0;
        }


        void InsertMobileData()
        {
            if (cmbMobileCName.SelectedValue == null || cmbMobileModelNumber.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Company và Model!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImeiNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập IMEI Number!");
                return;
            }

            if (!decimal.TryParse(txtMobilePrice.Text, out decimal price))
            {
                MessageBox.Show("Giá không hợp lệ!");
                return;
            }

            // Tính ngày hết hạn bảo hành
            DateTime warrantyDate = DateTime.Now;
            switch (cmbMobileWarranty.Text)
            {
                case "6 Tháng":
                    warrantyDate = warrantyDate.AddMonths(6);
                    break;
                case "1 Năm":
                    warrantyDate = warrantyDate.AddYears(1);
                    break;
                case "2 Năm":
                    warrantyDate = warrantyDate.AddYears(2);
                    break;
                case "3 Năm":
                    warrantyDate = warrantyDate.AddYears(3);
                    break;
                default:
                    warrantyDate = warrantyDate.AddYears(1);
                    break;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Check duplicate IMEI
                string checkQuery = "SELECT COUNT(*) FROM tbl_Mobile WHERE IMEINO = @IMEI";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@IMEI", txtImeiNumber.Text.Trim());
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("IMEI đã tồn tại!");
                    return;
                }

                string query = "INSERT INTO tbl_Mobile (IMEINO, ModelId, Status, Warranty, Price) VALUES (@IMEI, @ModelId, @Status, @Warranty, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IMEI", txtImeiNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@ModelId", cmbMobileModelNumber.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Status", "Not sold");
                cmd.Parameters.AddWithValue("@Warranty", warrantyDate);
                cmd.Parameters.AddWithValue("@Price", price);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm Mobile thành công!");
                LoadMobileList();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        void ClearFields()
        {
            txtImeiNumber.Clear();
            txtMobilePrice.Clear();
            if (cmbMobileWarranty.Items.Count > 0)
                cmbMobileWarranty.SelectedIndex = 0;
        }

        private void btnMobileInsert_Click(object sender, EventArgs e)
        {
            InsertMobileData();
        }

        //--- Fuction ListView For Mobile ---
        void LoadMobileList()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"
            SELECT mo.IMEINO, c.CName, m.ModelNum, mo.Status, mo.Warranty, mo.Price
            FROM tbl_Mobile mo
            JOIN tbl_Model m ON mo.ModelId = m.ModelId
            JOIN tbl_Company c ON m.CompId = c.CompId";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                lvwListOfMobile.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["IMEINO"].ToString());
                    item.SubItems.Add(dr["CName"].ToString());
                    item.SubItems.Add(dr["ModelNum"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(dr["Price"]).ToString("N0"));
                    item.SubItems.Add(Convert.ToDateTime(dr["Warranty"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(dr["Status"].ToString());

                    lvwListOfMobile.Items.Add(item);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load Mobile: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        // --- Report ---
        void SetupListView(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.Columns.Clear();
            lv.Columns.Add("SaleID", 80);
            lv.Columns.Add("Company", 120);
            lv.Columns.Add("ModelNum", 100);
            lv.Columns.Add("IMEI", 120);
            lv.Columns.Add("Price", 80, HorizontalAlignment.Right);
        }


        private void btnSearchSingleDate_Click(object sender, EventArgs e)
        {
            DateTime estDate = new DateTime(2025, 7, 1);
            if (dtpSingleDate.Value.Date < estDate)
            {
                MessageBox.Show("Không được chọn trước ngày thành lập (01/07/2025)!");
                return;
            }
            if (dtpSingleDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Không được chọn ngày trong tương lai!");
                return;
            }
            if (dtpSingleDate.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Chủ nhật là ngày nghỉ!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                SELECT s.SaleId, s.IMEINo, c.CName, m.ModelNum, s.Price
                FROM tbl_Sales s
                JOIN tbl_Mobile mo ON s.IMEINo = mo.IMEINo
                JOIN tbl_Model m ON mo.ModelId = m.ModelId
                JOIN tbl_Company c ON m.CompId = c.CompId
                WHERE CONVERT(DATE, s.PurchageDate) = @Date", conn);


                cmd.Parameters.AddWithValue("@Date", dtpSingleDate.Value.Date);

                SqlDataReader reader = cmd.ExecuteReader();
                lvwSingleDateReport.Items.Clear();
                decimal total = 0;

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["SaleId"].ToString());
                    item.SubItems.Add(reader["CName"].ToString());
                    item.SubItems.Add(reader["ModelNum"].ToString());
                    item.SubItems.Add(reader["IMEINo"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(reader["Price"]).ToString("N0"));

                    lvwSingleDateReport.Items.Add(item);
                    total += Convert.ToDecimal(reader["Price"]);
                }


                lblTotalSingleDateAmount.Text = $"Tổng doanh thu {dtpSingleDate.Value:dd/MM/yyyy}: {total:N0} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSearchDateRange_Click(object sender, EventArgs e)
        {
            DateTime estDate = new DateTime(2025, 7, 1);
            if (dtpStartDate.Value.Date < estDate)
            {
                MessageBox.Show("Ngày bắt đầu không được trước ngày thành lập!");
                return;
            }
            if (dtpEndDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày kết thúc không được lớn hơn hôm nay!");
                return;
            }
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                SELECT s.SaleId, c.CName, m.ModelNum, s.IMEINo, s.Price
                FROM tbl_Sales s
                JOIN tbl_Mobile mo ON s.IMEINo = mo.IMEINo
                JOIN tbl_Model m ON mo.ModelId = m.ModelId
                JOIN tbl_Company c ON m.CompId = c.CompId
                WHERE CONVERT(DATE, s.PurchageDate) BETWEEN @Start AND @End", conn);

                cmd.Parameters.AddWithValue("@Start", dtpStartDate.Value.Date);
                cmd.Parameters.AddWithValue("@End", dtpEndDate.Value.Date);
                SqlDataReader reader = cmd.ExecuteReader();
                lvwDateRangeReport.Items.Clear();
                decimal total = 0;

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["SaleId"].ToString());
                    item.SubItems.Add(reader["CName"].ToString());
                    item.SubItems.Add(reader["ModelNum"].ToString());
                    item.SubItems.Add(reader["IMEINo"].ToString());
                    item.SubItems.Add(Convert.ToDecimal(reader["Price"]).ToString("N0"));

                    lvwDateRangeReport.Items.Add(item);
                    total += Convert.ToDecimal(reader["Price"]);
                }


                lblTotalRangeAmount.Text = $"Tổng doanh thu từ {dtpStartDate.Value:dd/MM/yyyy} đến {dtpEndDate.Value:dd/MM/yyyy}: {total:N0} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //--- User ---
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string empName = txtEmployeeName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string hint = txtHint.Text.Trim();

            if (string.IsNullOrWhiteSpace(empName) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(retypePassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!");
                return;
            }

            if (!Regex.IsMatch(mobile, @"^\d{10,12}$"))
            {
                MessageBox.Show("Số điện thoại phải từ 10–12 chữ số!");
                return;
            }

            if (username.Length < 6 || !Regex.IsMatch(username, @"^(?=.*[A-Za-z])(?=.*\d).+$"))
            {
                MessageBox.Show("Username ít nhất 6 ký tự, có ít nhất 1 chữ và 1 số!");
                return;
            }

            if (password.Length < 8 || !Regex.IsMatch(password, @"^[A-Z].*") || !Regex.IsMatch(password, @".*\d.*") || !Regex.IsMatch(password, @".*[\W_].*"))
            {
                MessageBox.Show("Password phải bắt đầu chữ in hoa, có ít nhất 1 số và 1 ký tự đặc biệt, >= 8 ký tự!");
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            if (hint.Length < 5)
            {
                MessageBox.Show("Hint ít nhất 5 ký tự!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM tbl_User WHERE UserName = @UserName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@UserName", username);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Username đã tồn tại!");
                    return;
                }

                string insertQuery = "INSERT INTO tbl_User (UserName, PWD, EmployeeName, Address, MobileNumber, Hint) VALUES (@UserName, @PWD, @EmpName, @Address, @Mobile, @Hint)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@PWD", password);
                cmd.Parameters.AddWithValue("@EmpName", empName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Mobile", mobile);
                cmd.Parameters.AddWithValue("@Hint", hint);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm User thành công!");
                LoadUserList();

                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void ClearUserFields()
        {
            txtEmployeeName.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtRetypePassword.Clear();
            txtHint.Clear();
        }

        //--- Function ListView For User ---
        void LoadUserList()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT EmployeeName, Address, MobileNumber, UserName, Hint FROM tbl_User";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                lvwListOfUser.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["EmployeeName"].ToString());
                    item.SubItems.Add(reader["Address"].ToString());
                    item.SubItems.Add(reader["MobileNumber"].ToString());
                    item.SubItems.Add(reader["UserName"].ToString());
                    item.SubItems.Add(reader["Hint"].ToString());

                    lvwListOfUser.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load user: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminLogin loginForm = new frmAdminLogin();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
