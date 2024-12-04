namespace CuaHangXeMay.Forms
{
    partial class FormBanHang
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
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoaSanPham = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSanPham
            // 
            this.flpSanPham.AutoScroll = true;
            this.flpSanPham.Location = new System.Drawing.Point(264, 48);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(656, 493);
            this.flpSanPham.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(344, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(576, 25);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimKiem.Location = new System.Drawing.Point(263, 14);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(75, 19);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Tìm kiếm:";
            this.lblTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.Location = new System.Drawing.Point(12, 502);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(84, 39);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoaSanPham
            // 
            this.btnXoaSanPham.BackColor = System.Drawing.Color.Bisque;
            this.btnXoaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaSanPham.Location = new System.Drawing.Point(102, 502);
            this.btnXoaSanPham.Name = "btnXoaSanPham";
            this.btnXoaSanPham.Size = new System.Drawing.Size(75, 39);
            this.btnXoaSanPham.TabIndex = 7;
            this.btnXoaSanPham.Text = "Xóa SP";
            this.btnXoaSanPham.UseVisualStyleBackColor = false;
            this.btnXoaSanPham.Click += new System.EventHandler(this.btnXoaSanPham_Click);
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaGioHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaGioHang.Location = new System.Drawing.Point(183, 502);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(75, 39);
            this.btnXoaGioHang.TabIndex = 8;
            this.btnXoaGioHang.Text = "Xóa GH";
            this.btnXoaGioHang.UseVisualStyleBackColor = false;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(12, 14);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(245, 441);
            this.dgvGioHang.TabIndex = 3;
            this.dgvGioHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGioHang_CellFormatting);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(12, 464);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(76, 19);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.Location = new System.Drawing.Point(94, 461);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTongTien.Size = new System.Drawing.Size(163, 25);
            this.txtTongTien.TabIndex = 5;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.btnXoaGioHang);
            this.Controls.Add(this.btnXoaSanPham);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.flpSanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormChinh";
            this.Text = "Cửa hàng xe máy";
            this.Load += new System.EventHandler(this.FormChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoaSanPham;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}
