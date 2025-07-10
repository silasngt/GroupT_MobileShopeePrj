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
    public partial class ConfirmDetail : Form
    {
        // Properties để nhận dữ liệu từ UserHomePage
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string CompanyName { get; set; }
        public string ModelNumber { get; set; }
        public string IMEINumber { get; set; }
        public string Price { get; set; }
        public string Warranty { get; set; }
        public ConfirmDetail()
        {
            InitializeComponent();
        }

        private void ConfirmDetail_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu lên các Label
            lblCustomerNameValue.Text = CustomerName ?? "";
            lblMobileValue.Text = MobileNumber ?? "";
            lblAddressValue.Text = Address ?? "";
            lblEmailValue.Text = EmailId ?? "";
            lblCompanyValue.Text = CompanyName ?? "";
            lblModelValue.Text = ModelNumber ?? "";
            lblIMEIValue.Text = IMEINumber ?? "";
            lblPriceValue.Text = Price ?? "";
            lblWarrantyValue.Text = Warranty ?? "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Xử lý khi user nhấn OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xử lý khi user nhấn Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}