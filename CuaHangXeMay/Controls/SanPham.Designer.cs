namespace CuaHangXeMay.Controls
{
    partial class SanPham
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.TenSanPham.Size = new System.Drawing.Size(133, 48);
            this.TenSanPham.TabIndex = 1;
            this.TenSanPham.Text = "** Tên xe **";
            this.TenSanPham.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đặt vào giỏ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TenSanPham);
            this.Controls.Add(this.HinhAnh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(154, 266);
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HinhAnh;
        private System.Windows.Forms.Label TenSanPham;
        private System.Windows.Forms.Button button1;
    }
}
