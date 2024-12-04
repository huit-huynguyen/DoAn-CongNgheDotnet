namespace CuaHangXeMay.Forms
{
    partial class FormThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDanhSachKh = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lstDsKhachHang = new System.Windows.Forms.ListBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSinhNhat = new System.Windows.Forms.Label();
            this.dtpSinhNhat = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rdoGtNam = new System.Windows.Forms.RadioButton();
            this.rdoGtNu = new System.Windows.Forms.RadioButton();
            this.rdoGtKhac = new System.Windows.Forms.RadioButton();
            this.grpThongTinKh = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.grpDanhSachKh.SuspendLayout();
            this.grpThongTinKh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDanhSachKh
            // 
            this.grpDanhSachKh.Controls.Add(this.lblTimKiem);
            this.grpDanhSachKh.Controls.Add(this.lstDsKhachHang);
            this.grpDanhSachKh.Controls.Add(this.txtTimKiem);
            this.grpDanhSachKh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhSachKh.Location = new System.Drawing.Point(12, 12);
            this.grpDanhSachKh.Name = "grpDanhSachKh";
            this.grpDanhSachKh.Size = new System.Drawing.Size(200, 407);
            this.grpDanhSachKh.TabIndex = 0;
            this.grpDanhSachKh.TabStop = false;
            this.grpDanhSachKh.Text = "Danh sách khách hàng";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.Location = new System.Drawing.Point(6, 19);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(75, 19);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // lstDsKhachHang
            // 
            this.lstDsKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDsKhachHang.FormattingEnabled = true;
            this.lstDsKhachHang.ItemHeight = 15;
            this.lstDsKhachHang.Location = new System.Drawing.Point(6, 72);
            this.lstDsKhachHang.Name = "lstDsKhachHang";
            this.lstDsKhachHang.Size = new System.Drawing.Size(188, 319);
            this.lstDsKhachHang.TabIndex = 0;
            this.lstDsKhachHang.SelectedIndexChanged += new System.EventHandler(this.lstDsKhachHang_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(6, 41);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(188, 25);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(6, 19);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(58, 19);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã KH:";
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(70, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(99, 25);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(6, 50);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 19);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(70, 47);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(227, 25);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtThongTinKh_TextChanged);
            // 
            // lblSinhNhat
            // 
            this.lblSinhNhat.AutoSize = true;
            this.lblSinhNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhNhat.Location = new System.Drawing.Point(303, 50);
            this.lblSinhNhat.Name = "lblSinhNhat";
            this.lblSinhNhat.Size = new System.Drawing.Size(74, 19);
            this.lblSinhNhat.TabIndex = 8;
            this.lblSinhNhat.Text = "Sinh nhật:";
            // 
            // dtpSinhNhat
            // 
            this.dtpSinhNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSinhNhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSinhNhat.Location = new System.Drawing.Point(390, 44);
            this.dtpSinhNhat.Name = "dtpSinhNhat";
            this.dtpSinhNhat.Size = new System.Drawing.Size(169, 25);
            this.dtpSinhNhat.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(303, 19);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(69, 19);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // rdoGtNam
            // 
            this.rdoGtNam.AutoSize = true;
            this.rdoGtNam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGtNam.Location = new System.Drawing.Point(390, 16);
            this.rdoGtNam.Name = "rdoGtNam";
            this.rdoGtNam.Size = new System.Drawing.Size(56, 23);
            this.rdoGtNam.TabIndex = 3;
            this.rdoGtNam.TabStop = true;
            this.rdoGtNam.Text = "Nam";
            this.rdoGtNam.UseVisualStyleBackColor = true;
            this.rdoGtNam.CheckedChanged += new System.EventHandler(this.rdoThongTinKh_CheckedChanged);
            // 
            // rdoGtNu
            // 
            this.rdoGtNu.AutoSize = true;
            this.rdoGtNu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGtNu.Location = new System.Drawing.Point(452, 16);
            this.rdoGtNu.Name = "rdoGtNu";
            this.rdoGtNu.Size = new System.Drawing.Size(45, 23);
            this.rdoGtNu.TabIndex = 4;
            this.rdoGtNu.TabStop = true;
            this.rdoGtNu.Text = "Nữ";
            this.rdoGtNu.UseVisualStyleBackColor = true;
            this.rdoGtNu.CheckedChanged += new System.EventHandler(this.rdoThongTinKh_CheckedChanged);
            // 
            // rdoGtKhac
            // 
            this.rdoGtKhac.AutoSize = true;
            this.rdoGtKhac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGtKhac.Location = new System.Drawing.Point(503, 16);
            this.rdoGtKhac.Name = "rdoGtKhac";
            this.rdoGtKhac.Size = new System.Drawing.Size(56, 23);
            this.rdoGtKhac.TabIndex = 5;
            this.rdoGtKhac.TabStop = true;
            this.rdoGtKhac.Text = "Khác";
            this.rdoGtKhac.UseVisualStyleBackColor = true;
            this.rdoGtKhac.CheckedChanged += new System.EventHandler(this.rdoThongTinKh_CheckedChanged);
            // 
            // grpThongTinKh
            // 
            this.grpThongTinKh.Controls.Add(this.btnTaoMoi);
            this.grpThongTinKh.Controls.Add(this.txtDienThoai);
            this.grpThongTinKh.Controls.Add(this.lblEmail);
            this.grpThongTinKh.Controls.Add(this.txtEmail);
            this.grpThongTinKh.Controls.Add(this.txtDiaChi);
            this.grpThongTinKh.Controls.Add(this.lblDienThoai);
            this.grpThongTinKh.Controls.Add(this.lblDiaChi);
            this.grpThongTinKh.Controls.Add(this.rdoGtKhac);
            this.grpThongTinKh.Controls.Add(this.lblMa);
            this.grpThongTinKh.Controls.Add(this.rdoGtNu);
            this.grpThongTinKh.Controls.Add(this.txtMa);
            this.grpThongTinKh.Controls.Add(this.rdoGtNam);
            this.grpThongTinKh.Controls.Add(this.txtHoTen);
            this.grpThongTinKh.Controls.Add(this.lblGioiTinh);
            this.grpThongTinKh.Controls.Add(this.lblHoTen);
            this.grpThongTinKh.Controls.Add(this.dtpSinhNhat);
            this.grpThongTinKh.Controls.Add(this.lblSinhNhat);
            this.grpThongTinKh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinKh.Location = new System.Drawing.Point(218, 12);
            this.grpThongTinKh.Name = "grpThongTinKh";
            this.grpThongTinKh.Size = new System.Drawing.Size(565, 188);
            this.grpThongTinKh.TabIndex = 1;
            this.grpThongTinKh.TabStop = false;
            this.grpThongTinKh.Text = "Thông tin khách hàng";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.Violet;
            this.btnTaoMoi.Location = new System.Drawing.Point(10, 153);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(88, 29);
            this.btnTaoMoi.TabIndex = 16;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai.Location = new System.Drawing.Point(390, 109);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(169, 25);
            this.txtDienThoai.TabIndex = 15;
            this.txtDienThoai.TextChanged += new System.EventHandler(this.txtThongTinKh_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 19);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(70, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 25);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtThongTinKh_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(70, 78);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(489, 25);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtThongTinKh_TextChanged);
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(303, 112);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(81, 19);
            this.lblDienThoai.TabIndex = 14;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(6, 81);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(58, 19);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(218, 206);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.Size = new System.Drawing.Size(565, 151);
            this.dgvGioHang.TabIndex = 2;
            this.dgvGioHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGioHang_CellFormatting);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(679, 363);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(104, 40);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(214, 375);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(76, 19);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.Location = new System.Drawing.Point(296, 372);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTongTien.Size = new System.Drawing.Size(163, 25);
            this.txtTongTien.TabIndex = 4;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 431);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.grpThongTinKh);
            this.Controls.Add(this.grpDanhSachKh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormThanhToan";
            this.Text = "Thanh toán - Cửa hàng xe máy";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.grpDanhSachKh.ResumeLayout(false);
            this.grpDanhSachKh.PerformLayout();
            this.grpThongTinKh.ResumeLayout(false);
            this.grpThongTinKh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDanhSachKh;
        private System.Windows.Forms.ListBox lstDsKhachHang;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSinhNhat;
        private System.Windows.Forms.DateTimePicker dtpSinhNhat;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton rdoGtNam;
        private System.Windows.Forms.RadioButton rdoGtNu;
        private System.Windows.Forms.RadioButton rdoGtKhac;
        private System.Windows.Forms.GroupBox grpThongTinKh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}
