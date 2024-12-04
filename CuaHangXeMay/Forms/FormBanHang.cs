using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CuaHangXeMay.Controls;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Forms
{
    public partial class FormBanHang : Form
    {
        private readonly CuaHangXeEntities _dbContext;
        private readonly NhanVien _nhanVien;

        private readonly BindingList<SanPhamGioHang> _gioHang = new BindingList<SanPhamGioHang>();

        public FormBanHang()
        {
            InitializeComponent();
        }

        public FormBanHang(CuaHangXeEntities dbContext, NhanVien nhanVien) : this()
        {
            _dbContext = dbContext;
            _nhanVien = nhanVien;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = _gioHang;
            dgvGioHang.Columns["Xe"].HeaderText = "Tên xe";
            dgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";

            // Tính toán tổng tiền mỗi khi có thay đổi trong giỏ hàng
            _gioHang.ListChanged += (object listSender, ListChangedEventArgs listEvent) =>
            {
                txtTongTien.Text = string.Format("{0:n0} ₫", _gioHang.TongTien());
            };

            HienThiDsSanPham();
        }

        private void dgvGioHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvGioHang.Columns[e.ColumnIndex].Name == "Xe")
            {
                if (e.Value != null)
                {
                    var xe = (Xe)e.Value;
                    e.Value = xe.Ten;
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                HienThiDsSanPham();
                return;
            }

            var tuKhoa = txtTimKiem.Text.Normalize().ToLower();
            HienThiDsSanPham(xe => xe.Ten.Normalize().ToLower().Contains(tuKhoa));
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvGioHang.SelectedRows)
            {
                var sanPham = (SanPhamGioHang)selectedRow.DataBoundItem;
                _gioHang.Remove(sanPham);
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            _gioHang.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var frmThanhToan = new FormThanhToan(_dbContext, _gioHang, _nhanVien);
            frmThanhToan.Show();
            frmThanhToan.FormClosed += (formSender, fromEvent) =>
            {
                _gioHang.Clear();
            };
        }

        private void HienThiDsSanPham(Predicate<Xe> predicate = null)
        {
            flpSanPham.Controls.Clear();
            foreach (var xe in _dbContext.DsXe)
            {
                if (predicate != null && !predicate(xe))
                {
                    continue;
                }

                var ctlSanPham = new ControlSanPham(xe);
                ctlSanPham.ThemVaoGio += (btnSender, btnEvent) =>
                {
                    var sanPham = _gioHang.FirstOrDefault(sp => sp.Xe == ctlSanPham.Xe);
                    if (sanPham != null)
                    {
                        sanPham.SoLuong += 1;
                    }
                    else
                    {
                        _gioHang.Add(new SanPhamGioHang()
                        {
                            Xe = ctlSanPham.Xe,
                            SoLuong = 1,
                        });
                    }
                };
                flpSanPham.Controls.Add(ctlSanPham);
            }
        }
    }
}
