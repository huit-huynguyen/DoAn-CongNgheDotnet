namespace CuaHangXeMay.Forms
{
    partial class FormDangNhap
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
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThongBaoLoi = new System.Windows.Forms.Label();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDangNhap.BackColor = System.Drawing.Color.White;
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.lblTieuDe);
            this.pnlDangNhap.Controls.Add(this.lblThongBaoLoi);
            this.pnlDangNhap.Location = new System.Drawing.Point(200, 75);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Padding = new System.Windows.Forms.Padding(20);
            this.pnlDangNhap.Size = new System.Drawing.Size(400, 300);
            this.pnlDangNhap.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(40, 235);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(320, 35);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(40, 185);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(320, 25);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(40, 115);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(320, 25);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.Location = new System.Drawing.Point(39, 163);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 19);
            this.lblMatKhau.TabIndex = 3;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.Location = new System.Drawing.Point(39, 93);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(77, 19);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài khoản:";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(360, 43);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG NHẬP";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongBaoLoi
            // 
            this.lblThongBaoLoi.AutoSize = true;
            this.lblThongBaoLoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBaoLoi.ForeColor = System.Drawing.Color.Red;
            this.lblThongBaoLoi.Location = new System.Drawing.Point(40, 280);
            this.lblThongBaoLoi.Name = "lblThongBaoLoi";
            this.lblThongBaoLoi.Size = new System.Drawing.Size(0, 15);
            this.lblThongBaoLoi.TabIndex = 6;
            this.lblThongBaoLoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThongBaoLoi.Visible = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDangNhap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Cửa hàng xe máy";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblThongBaoLoi;

        #endregion
    }
}
