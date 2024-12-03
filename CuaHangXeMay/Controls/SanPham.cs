using System.Windows.Forms;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Controls
{
    public partial class SanPham : UserControl
    {
        public Xe Xe { get; set; }

        public SanPham()
        {
            InitializeComponent();
        }

        public SanPham(Xe xe)
        {
            InitializeComponent();
            Xe = xe;
        }

        private void SanPham_Load(object sender, System.EventArgs e)
        {
            TenSanPham.Text = Xe.Ten;
            HinhAnh.ImageLocation = string.Format(@".\Contents\Images\{0}",
                Xe.FileHinhAnh != null ? Xe.FileHinhAnh : "default.png");
        }
    }
}
