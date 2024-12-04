using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Forms
{
    public partial class FormThanhToan : Form
    {
        private readonly CuaHangXeEntities _dbContext;
        private readonly NhanVien _nhanVien;
        private readonly List<SanPhamGioHang> _gioHang;

        private readonly BindingList<KhachHang> _dsKhachHang = new BindingList<KhachHang>();
        private object kh;

        public FormThanhToan()
        {
            InitializeComponent();
        }

        public FormThanhToan(
            CuaHangXeEntities dbContext,
            IEnumerable<SanPhamGioHang> gioHang,
            NhanVien nhanVien) : this()
        {
            _dbContext = dbContext;
            _gioHang = gioHang.ToList();
            _nhanVien = nhanVien;
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            lstDsKhachHang.DataSource = _dsKhachHang;
            lstDsKhachHang.DisplayMember = "HoTen";

            HienThiDsKhachHang();

            dgvGioHang.DataSource = _gioHang;
            dgvGioHang.Columns["Xe"].HeaderText = "Tên xe";
            dgvGioHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvGioHang.Columns["ThanhTien"].HeaderText = "Thành tiền";

            txtTongTien.Text = string.Format("{0:n0} ₫", _gioHang.TongTien());
        }

        private void lstDsKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDsKhachHang.SelectedIndex >= 0)
            {
                var khachHang = (KhachHang)lstDsKhachHang.SelectedItem;
                HienThiKhachHang(khachHang);
            }
            else
            {
                ThietLapLaiThongTinKhach();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                HienThiDsKhachHang();
                return;
            }

            var tuKhoa = txtTimKiem.Text.Normalize().ToLower();
            HienThiDsKhachHang(kh => kh.HoTen.Normalize().ToLower().Contains(tuKhoa));
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

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            lstDsKhachHang.SelectedIndex = -1;

            ThietLapLaiThongTinKhach();
            txtMa.Text = TaoMaKhachHang();
        }

        private void txtThongTinKh_TextChanged(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = KtKhachHangThanhToan();
        }

        private void rdoThongTinKh_CheckedChanged(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = KtKhachHangThanhToan();
        }

        private void HienThiDsKhachHang(Predicate<KhachHang> predicate = null)
        {
            _dsKhachHang.Clear();
            foreach (var khachHang in _dbContext.DsKhachHang)
            {
                if (predicate != null && !predicate(khachHang))
                {
                    continue;
                }
                _dsKhachHang.Add(khachHang);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var khachHang = _dbContext.DsKhachHang
                .FirstOrDefault(kh => kh.Ma == txtMa.Text);
            if (khachHang == null)
            {
                khachHang = _dbContext.DsKhachHang.Create();

                khachHang.Ma = txtMa.Text;
                khachHang.HoTen = txtHoTen.Text;
                khachHang.DiaChi = txtDiaChi.Text;
                khachHang.DiaChiEmail = txtEmail.Text;
                khachHang.SoDienThoai = txtDienThoai.Text;
                khachHang.NgaySinh = dtpSinhNhat.Value;

                if (rdoGtNam.Checked)
                {
                    khachHang.GioiTinh = "Nam";
                }
                else if (rdoGtNu.Checked)
                {
                    khachHang.GioiTinh = "Nữ";
                }
                else
                {
                    khachHang.GioiTinh = "Khác";
                }

                _dbContext.DsKhachHang.Add(khachHang);
            }

            var donHang = _dbContext.DsDonHang.Create();
            donHang.Ma = TaoMaDonHang();
            donHang.NhanVien = _nhanVien;
            donHang.KhachHang = khachHang;
            donHang.TinhTrang = "Chờ xử lý";

            _dbContext.DsDonHang.Add(donHang);

            for (int i = 0; i < _gioHang.Count; i++)
            {
                var chiTiet = _dbContext.DsChiTietDonHang.Create();
                chiTiet.Ma = string.Format("CTDH{0:000}", TaoSoMaChiTiet() + i);
                chiTiet.DonHang = donHang;
                chiTiet.Xe = _gioHang[i].Xe;
                chiTiet.GiaBan = _gioHang[i].Xe.DonGia;
                chiTiet.SoLuong = _gioHang[i].SoLuong;

                _dbContext.DsChiTietDonHang.Add(chiTiet);
            }

            var soDongCapNhat = _dbContext.SaveChanges();
            MessageBox.Show(string.Format("Đã cập nhật {0} dòng", soDongCapNhat));

            Close();
        }

        private void ThietLapLaiThongTinKhach()
        {
            txtMa.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();

            dtpSinhNhat.Value = DateTime.Today;

            foreach (RadioButton rdoGioiTinh in grpThongTinKh.Controls.OfType<RadioButton>())
            {
                rdoGioiTinh.Checked = false;
            }
        }

        private void HienThiKhachHang(KhachHang khachHang)
        {
            if (khachHang != null)
            {
                txtMa.Text = khachHang.Ma;
                txtHoTen.Text = khachHang.HoTen;
                txtDiaChi.Text = khachHang.DiaChi;
                txtEmail.Text = khachHang.DiaChiEmail;
                txtDienThoai.Text = khachHang.SoDienThoai;

                dtpSinhNhat.Value = khachHang.NgaySinh;

                switch (khachHang.GioiTinh)
                {
                    case "Nam":
                        rdoGtNam.Checked = true;
                        break;
                    case "Nữ":
                        rdoGtNu.Checked = true;
                        break;
                    case "Khác":
                        rdoGtKhac.Checked = true;
                        break;
                }
            }
        }

        private string TaoMaKhachHang()
        {
            int maMoiNhat = _dbContext.DsKhachHang
                // Xóa prefix 'KH' khỏi mã khách hàng
                .Select(kh => kh.Ma.Substring(2))
                // Chuyển từ SQL LINQ thành C# LINQ,
                // vì sử dụng hàm C# `int.Parse`
                .ToList()
                // Chuyển từ chuỗi (số) thành số
                .Select(ma => int.Parse(ma))
                // Tìm mã có số lớn nhất
                .Max();
            return string.Format("KH{0:000}", maMoiNhat + 1);
        }

        private string TaoMaDonHang()
        {
            int maMoiNhat = _dbContext.DsDonHang
                .Select(dh => dh.Ma.Substring(2))
                .ToList()
                .Select(ma => int.Parse(ma))
                .Max();
            return string.Format("DH{0:000}", maMoiNhat + 1);
        }

        private int TaoSoMaChiTiet()
        {
            int maMoiNhat = _dbContext.DsChiTietDonHang
                .Select(ct => ct.Ma.Substring(4))
                .ToList()
                .Select(ma => int.Parse(ma))
                .Max();
            return maMoiNhat + 1;
        }

        private bool KtKhachHangThanhToan()
        {
            return !string.IsNullOrWhiteSpace(txtMa.Text)
                && !string.IsNullOrWhiteSpace(txtHoTen.Text)
                && (rdoGtNam.Checked || rdoGtNu.Checked || rdoGtKhac.Checked)
                && !string.IsNullOrWhiteSpace(txtDiaChi.Text)
                && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtDienThoai.Text);
        }
    }
}
