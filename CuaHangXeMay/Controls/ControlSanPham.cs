using System;
using System.ComponentModel;
using System.Windows.Forms;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Controls
{
    public partial class ControlSanPham : UserControl
    {
        public Xe Xe { get; set; }

        public ControlSanPham()
        {
            InitializeComponent();
        }

        public ControlSanPham(Xe xe)
        {
            InitializeComponent();
            Xe = xe;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            TenSanPham.Text = Xe.Ten;
            HinhAnh.ImageLocation = string.Format(@".\Contents\Images\{0}",
                Xe.FileHinhAnh != null ? Xe.FileHinhAnh : "default.png");
        }

        [Browsable(true)]
        [Description("Khi người dùng nhấn vào button 'Thêm vào giỏ'")]
        public event EventHandler ThemVaoGio;

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (ThemVaoGio != null)
            {
                ThemVaoGio(this, e);
            }
        }
    }
}
