namespace CuaHangXeMay.Controls
{
    partial class ControlSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HinhAnh = new System.Windows.Forms.PictureBox();
            this.TenSanPham = new System.Windows.Forms.Label();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // HinhAnh
            // 
            this.HinhAnh.ImageLocation = ".\\Contents\\Images\\default.png";
            this.HinhAnh.Location = new System.Drawing.Point(10, 13);
            this.HinhAnh.Margin = new System.Windows.Forms.Padding(10, 13, 10, 13);
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Size = new System.Drawing.Size(133, 149);
            this.HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HinhAnh.TabIndex = 0;
            this.HinhAnh.TabStop = false;
            // 
            // TenSanPham
            // 
            this.TenSanPham.AutoEllipsis = true;
            this.TenSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TenSanPham.Location = new System.Drawing.Point(10, 175);
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.Size = new System.Drawing.Size(133, 36);
            this.TenSanPham.TabIndex = 1;
            this.TenSanPham.Text = "** Tên xe **";
            this.TenSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVaoGio.Location = new System.Drawing.Point(10, 214);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(133, 37);
            this.btnThemVaoGio.TabIndex = 2;
            this.btnThemVaoGio.Text = "Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.TenSanPham);
            this.Controls.Add(this.HinhAnh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(154, 260);
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HinhAnh;
        private System.Windows.Forms.Label TenSanPham;
        private System.Windows.Forms.Button btnThemVaoGio;
    }
}
