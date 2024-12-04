using System;
using System.Linq;
using System.Windows.Forms;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Forms
{
    public partial class FormDangNhap : Form
    {
        private readonly CuaHangXeEntities _dbContext;

        public FormDangNhap()
        {
            InitializeComponent();
        }

        public FormDangNhap(CuaHangXeEntities dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblThongBaoLoi.Visible = true;

            var taiKhoan = txtTaiKhoan.Text.Trim();
            var matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(taiKhoan) && string.IsNullOrWhiteSpace(matKhau))
            {
                lblThongBaoLoi.Text = "Vui lòng nhập tài khoản và mật khẩu!";
                txtTaiKhoan.Focus();
                return;
            }

            var nhanVien = _dbContext.DsNhanVien
                .FirstOrDefault(nv => nv.Ma == taiKhoan && nv.MatKhau == matKhau);
            if (nhanVien == null)
            {
                lblThongBaoLoi.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            lblThongBaoLoi.Text = string.Empty;
            lblThongBaoLoi.Visible = false;

            var frmChinh = new FormChinh(_dbContext);
            frmChinh.Show();
            frmChinh.FormClosed += (formSender, formEvent) =>
            {
                this.Show();
            };
        }
    }
}
