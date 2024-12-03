using System;
using System.Linq;
using System.Windows.Forms;
using CuaHangXeMay.Controls;
using CuaHangXeMay.Models;

namespace CuaHangXeMay.Forms
{
    public partial class FormChinh : Form
    {
        private readonly CuaHangXeEntities _dbContext;

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
            flpSanPham.Controls.AddRange(
                _dbContext.DsXe
                    .ToList()
                    .Select(xe => new SanPham(xe))
                    .ToArray()
            );
        }
    }
}
