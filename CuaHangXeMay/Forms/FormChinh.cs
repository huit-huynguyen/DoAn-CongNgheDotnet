using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CuaHangXeMay.Controls;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Forms
{
    public partial class FormChinh : Form
    {
        private readonly CuaHangXeEntities _dbContext;

        private readonly BindingList<SanPhamGioHang> _gioHang = new BindingList<SanPhamGioHang>();

        public FormChinh()
        {
            InitializeComponent();
        }

        public FormChinh(CuaHangXeEntities dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = _gioHang;
            dgvGioHang.Columns["Xe"].HeaderText = "Tên xe";
            dgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";

            HienThiDsSanPham();
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

                var controlSanPham = new SanPham(xe);
                controlSanPham.ThemVaoGio += (btnSender, btnEvent) =>
                {
                    var sanPham = _gioHang.FirstOrDefault(sp => sp.Xe.Ma == controlSanPham.Xe.Ma);
                    if (sanPham != null)
                    {
                        sanPham.SoLuong += 1;
                    }
                    else
                    {
                        _gioHang.Add(new SanPhamGioHang
                        {
                            Xe = controlSanPham.Xe,
                            SoLuong = 1,
                        });
                    }
                };
                flpSanPham.Controls.Add(controlSanPham);
            }
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

            var tuKhoa = txtTimKiem.Text.Normalize().ToLowerInvariant();
            HienThiDsSanPham(xe => xe.Ten.Normalize().ToLowerInvariant().Contains(tuKhoa));
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
        }
    }
}
