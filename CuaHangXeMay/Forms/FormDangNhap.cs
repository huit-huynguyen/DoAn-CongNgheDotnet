using System;
using System.Windows.Forms;

namespace CuaHangXeMay.Forms
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = true;

            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text) && string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                lblThongBaoLoi.Text = "Vui lòng nhập tài khoản và mật khẩu!";
                txtTaiKhoan.Focus();
                return;
            }

            if (txtTaiKhoan.Text != "admin" || txtMatKhau.Text != "password")
            {
                lblThongBaoLoi.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            lblThongBaoLoi.Text = string.Empty;
            lblThongBaoLoi.Visible = false;
        }
    }
}
