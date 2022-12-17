namespace QLKhachSan
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnHeThong = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnstripHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThongTinKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstringThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDanhSachKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitemDanhSachHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnHeThong
            // 
            this.mnHeThong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnstripHeThong,
            this.mnstripQLKhachHang,
            this.mnstripQLPhong,
            this.mnstringThongKe,
            this.mnstripTroGiup});
            this.mnHeThong.Location = new System.Drawing.Point(0, 0);
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(995, 24);
            this.mnHeThong.TabIndex = 0;
            this.mnHeThong.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLKhachSan.Properties.Resources.bgHotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1066);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mnstripHeThong
            // 
            this.mnstripHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDoiMK,
            this.mnitemDangXuat,
            this.mnitemThoat});
            this.mnstripHeThong.Image = global::QLKhachSan.Properties.Resources.System_settings_icon;
            this.mnstripHeThong.Name = "mnstripHeThong";
            this.mnstripHeThong.Size = new System.Drawing.Size(87, 20);
            this.mnstripHeThong.Text = "Hệ Thống";
            this.mnstripHeThong.Click += new System.EventHandler(this.mnstripHeThong_Click);
            // 
            // mnitemDoiMK
            // 
            this.mnitemDoiMK.Name = "mnitemDoiMK";
            this.mnitemDoiMK.Size = new System.Drawing.Size(180, 22);
            this.mnitemDoiMK.Text = "Đổi Mật Khẩu";
            this.mnitemDoiMK.Click += new System.EventHandler(this.mnitemDoiMK_Click);
            // 
            // mnitemDangXuat
            // 
            this.mnitemDangXuat.Name = "mnitemDangXuat";
            this.mnitemDangXuat.Size = new System.Drawing.Size(180, 22);
            this.mnitemDangXuat.Text = "Đăng Xuất";
            this.mnitemDangXuat.Click += new System.EventHandler(this.mnitemDangXuat_Click);
            // 
            // mnitemThoat
            // 
            this.mnitemThoat.Name = "mnitemThoat";
            this.mnitemThoat.Size = new System.Drawing.Size(180, 22);
            this.mnitemThoat.Text = "Thoát";
            this.mnitemThoat.Click += new System.EventHandler(this.mnitemThoat_Click);
            // 
            // mnstripQLKhachHang
            // 
            this.mnstripQLKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemThongTinKH,
            this.mnitemThanhToan});
            this.mnstripQLKhachHang.Image = global::QLKhachSan.Properties.Resources.User_Clients_icon;
            this.mnstripQLKhachHang.Name = "mnstripQLKhachHang";
            this.mnstripQLKhachHang.Size = new System.Drawing.Size(146, 20);
            this.mnstripQLKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // mnitemThongTinKH
            // 
            this.mnitemThongTinKH.Name = "mnitemThongTinKH";
            this.mnitemThongTinKH.Size = new System.Drawing.Size(195, 22);
            this.mnitemThongTinKH.Text = "Thông Tin Khách Hàng";
            this.mnitemThongTinKH.Click += new System.EventHandler(this.mnitemThongTinKH_Click);
            // 
            // mnitemThanhToan
            // 
            this.mnitemThanhToan.Name = "mnitemThanhToan";
            this.mnitemThanhToan.Size = new System.Drawing.Size(195, 22);
            this.mnitemThanhToan.Text = "Thanh Toán";
            this.mnitemThanhToan.Click += new System.EventHandler(this.mnitemThanhToan_Click);
            // 
            // mnstripQLPhong
            // 
            this.mnstripQLPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDatPhong,
            this.mnitemThuePhong,
            this.mnitemPhong,
            this.mnitemHoaDon,
            this.mnitemVatTu});
            this.mnstripQLPhong.Image = global::QLKhachSan.Properties.Resources.House_icon;
            this.mnstripQLPhong.Name = "mnstripQLPhong";
            this.mnstripQLPhong.Size = new System.Drawing.Size(116, 20);
            this.mnstripQLPhong.Text = "Quản Lý Phòng";
            // 
            // mnitemDatPhong
            // 
            this.mnitemDatPhong.Name = "mnitemDatPhong";
            this.mnitemDatPhong.Size = new System.Drawing.Size(138, 22);
            this.mnitemDatPhong.Text = "Đặt Phòng";
            this.mnitemDatPhong.Click += new System.EventHandler(this.mnitemDatPhong_Click);
            // 
            // mnitemThuePhong
            // 
            this.mnitemThuePhong.Name = "mnitemThuePhong";
            this.mnitemThuePhong.Size = new System.Drawing.Size(138, 22);
            this.mnitemThuePhong.Text = "Thuê Phòng";
            this.mnitemThuePhong.Click += new System.EventHandler(this.mnitemThuePhong_Click);
            // 
            // mnitemPhong
            // 
            this.mnitemPhong.Name = "mnitemPhong";
            this.mnitemPhong.Size = new System.Drawing.Size(138, 22);
            this.mnitemPhong.Text = "Phòng";
            this.mnitemPhong.Click += new System.EventHandler(this.mnitemPhong_Click);
            // 
            // mnitemHoaDon
            // 
            this.mnitemHoaDon.Name = "mnitemHoaDon";
            this.mnitemHoaDon.Size = new System.Drawing.Size(138, 22);
            this.mnitemHoaDon.Text = "Hóa Đơn";
            this.mnitemHoaDon.Click += new System.EventHandler(this.mnitemHoaDon_Click);
            // 
            // mnitemVatTu
            // 
            this.mnitemVatTu.Name = "mnitemVatTu";
            this.mnitemVatTu.Size = new System.Drawing.Size(138, 22);
            this.mnitemVatTu.Text = "Vật Tư";
            this.mnitemVatTu.Click += new System.EventHandler(this.mnitemVatTu_Click);
            // 
            // mnstringThongKe
            // 
            this.mnstringThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitemDanhSachKH,
            this.mnitemDanhSachHD});
            this.mnstringThongKe.Image = global::QLKhachSan.Properties.Resources.thongke;
            this.mnstringThongKe.Name = "mnstringThongKe";
            this.mnstringThongKe.Size = new System.Drawing.Size(85, 20);
            this.mnstringThongKe.Text = "Thống Kê";
            // 
            // mnitemDanhSachKH
            // 
            this.mnitemDanhSachKH.Name = "mnitemDanhSachKH";
            this.mnitemDanhSachKH.Size = new System.Drawing.Size(198, 22);
            this.mnitemDanhSachKH.Text = "Danh Sách Khách Hàng";
            this.mnitemDanhSachKH.Click += new System.EventHandler(this.mnitemDanhSachKH_Click);
            // 
            // mnitemDanhSachHD
            // 
            this.mnitemDanhSachHD.Name = "mnitemDanhSachHD";
            this.mnitemDanhSachHD.Size = new System.Drawing.Size(198, 22);
            this.mnitemDanhSachHD.Text = "Danh Sách Hóa Đơn";
            this.mnitemDanhSachHD.Click += new System.EventHandler(this.mnitemDanhSachHD_Click);
            // 
            // mnstripTroGiup
            // 
            this.mnstripTroGiup.Image = global::QLKhachSan.Properties.Resources.help;
            this.mnstripTroGiup.Name = "mnstripTroGiup";
            this.mnstripTroGiup.Size = new System.Drawing.Size(79, 20);
            this.mnstripTroGiup.Text = "Trợ Giúp";
            this.mnstripTroGiup.Click += new System.EventHandler(this.mnstripTroGiup_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnHeThong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnHeThong;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khách Sạn";
            this.mnHeThong.ResumeLayout(false);
            this.mnHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnstripHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnstripQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnstripQLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnstringThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnstripTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnitemDoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnitemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnitemThoat;
        private System.Windows.Forms.ToolStripMenuItem mnitemThongTinKH;
        private System.Windows.Forms.ToolStripMenuItem mnitemThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnitemDatPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemPhong;
        private System.Windows.Forms.ToolStripMenuItem mnitemHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnitemVatTu;
        private System.Windows.Forms.ToolStripMenuItem mnitemDanhSachKH;
        private System.Windows.Forms.ToolStripMenuItem mnitemDanhSachHD;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}