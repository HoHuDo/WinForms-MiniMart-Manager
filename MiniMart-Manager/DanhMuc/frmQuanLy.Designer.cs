namespace MiniMart_Manager.DanhMuc
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            menuStrip1 = new MenuStrip();
            mnuGiaoDich = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuQLHoaDon = new ToolStripMenuItem();
            mnuQLNhapHang = new ToolStripMenuItem();
            mnuQLDanhMuc = new ToolStripMenuItem();
            mnuQLSanPham = new ToolStripMenuItem();
            mnuQLLoaiHang = new ToolStripMenuItem();
            mnuQLNhaCungCap = new ToolStripMenuItem();
            mnuQuanTri = new ToolStripMenuItem();
            mnuQLTaiKhoan = new ToolStripMenuItem();
            mnuQLNhanVien = new ToolStripMenuItem();
            mnuQLKhachHang = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMK = new ToolStripMenuItem();
            mnuCauHinh = new ToolStripMenuItem();
            mnuGiaoDien = new ToolStripMenuItem();
            tímToolStripMenuItem = new ToolStripMenuItem();
            xanhToolStripMenuItem = new ToolStripMenuItem();
            đỏToolStripMenuItem = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            lblQuyen = new Label();
            lblTenTK = new Label();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            pnlQuyen = new Panel();
            giaoDịchToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            pnlQuyen.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 64);
            menuStrip1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGiaoDich, mnuQLDanhMuc, mnuQuanTri, mnuBaoCao, mnuHeThong, mnuGiaoDien, mnuTroGiup, mnuThoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1571, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.DropDownItems.AddRange(new ToolStripItem[] { mnuBanHang, mnuQLHoaDon, mnuQLNhapHang });
            mnuGiaoDich.ForeColor = SystemColors.GradientInactiveCaption;
            mnuGiaoDich.Name = "mnuGiaoDich";
            mnuGiaoDich.Size = new Size(121, 31);
            mnuGiaoDich.Text = "Giao Dịch";
            mnuGiaoDich.Click += mnuGiaoDich_Click;
            // 
            // mnuBanHang
            // 
            mnuBanHang.BackColor = Color.FromArgb(0, 0, 64);
            mnuBanHang.ForeColor = SystemColors.ButtonHighlight;
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.ShortcutKeys = Keys.Control | Keys.F1;
            mnuBanHang.Size = new Size(383, 36);
            mnuBanHang.Text = "Bán Hàng";
            mnuBanHang.Click += mnuBanHang_Click;
            // 
            // mnuQLHoaDon
            // 
            mnuQLHoaDon.BackColor = Color.MintCream;
            mnuQLHoaDon.Name = "mnuQLHoaDon";
            mnuQLHoaDon.ShortcutKeys = Keys.Control | Keys.F2;
            mnuQLHoaDon.Size = new Size(383, 36);
            mnuQLHoaDon.Text = "Quản lý hóa đơn";
            mnuQLHoaDon.Click += mnuQLHoaDon_Click;
            // 
            // mnuQLNhapHang
            // 
            mnuQLNhapHang.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLNhapHang.ForeColor = SystemColors.ButtonHighlight;
            mnuQLNhapHang.Name = "mnuQLNhapHang";
            mnuQLNhapHang.ShortcutKeys = Keys.Control | Keys.F3;
            mnuQLNhapHang.Size = new Size(383, 36);
            mnuQLNhapHang.Text = "Quản lý nhập hàng";
            mnuQLNhapHang.Click += mnuQLNhapHang_Click;
            // 
            // mnuQLDanhMuc
            // 
            mnuQLDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuQLSanPham, mnuQLLoaiHang, mnuQLNhaCungCap });
            mnuQLDanhMuc.ForeColor = SystemColors.GradientInactiveCaption;
            mnuQLDanhMuc.Name = "mnuQLDanhMuc";
            mnuQLDanhMuc.Size = new Size(210, 31);
            mnuQLDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // mnuQLSanPham
            // 
            mnuQLSanPham.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLSanPham.ForeColor = SystemColors.ButtonHighlight;
            mnuQLSanPham.Name = "mnuQLSanPham";
            mnuQLSanPham.ShortcutKeys = Keys.Control | Keys.D1;
            mnuQLSanPham.Size = new Size(398, 36);
            mnuQLSanPham.Text = "Quản lý sản phẩm";
            mnuQLSanPham.Click += mnuQLSanPham_Click;
            // 
            // mnuQLLoaiHang
            // 
            mnuQLLoaiHang.BackColor = Color.MintCream;
            mnuQLLoaiHang.Name = "mnuQLLoaiHang";
            mnuQLLoaiHang.ShortcutKeys = Keys.Control | Keys.D2;
            mnuQLLoaiHang.Size = new Size(398, 36);
            mnuQLLoaiHang.Text = "Quản lý loại hàng";
            mnuQLLoaiHang.Click += mnuQLLoaiHang_Click;
            // 
            // mnuQLNhaCungCap
            // 
            mnuQLNhaCungCap.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLNhaCungCap.ForeColor = SystemColors.ButtonHighlight;
            mnuQLNhaCungCap.Name = "mnuQLNhaCungCap";
            mnuQLNhaCungCap.ShortcutKeys = Keys.Control | Keys.D3;
            mnuQLNhaCungCap.Size = new Size(398, 36);
            mnuQLNhaCungCap.Text = "Quản lý nhà cung cấp";
            mnuQLNhaCungCap.Click += mnuQLNhaCungCap_Click;
            // 
            // mnuQuanTri
            // 
            mnuQuanTri.DropDownItems.AddRange(new ToolStripItem[] { mnuQLTaiKhoan, mnuQLNhanVien, mnuQLKhachHang });
            mnuQuanTri.ForeColor = SystemColors.GradientInactiveCaption;
            mnuQuanTri.Name = "mnuQuanTri";
            mnuQuanTri.Size = new Size(110, 31);
            mnuQuanTri.Text = "Quản Trị";
            // 
            // mnuQLTaiKhoan
            // 
            mnuQLTaiKhoan.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLTaiKhoan.ForeColor = SystemColors.ButtonHighlight;
            mnuQLTaiKhoan.Name = "mnuQLTaiKhoan";
            mnuQLTaiKhoan.ShortcutKeys = Keys.Control | Keys.T;
            mnuQLTaiKhoan.Size = new Size(426, 36);
            mnuQLTaiKhoan.Text = "Quản lý tài khoản";
            mnuQLTaiKhoan.Click += mnuQLTaiKhoan_Click;
            // 
            // mnuQLNhanVien
            // 
            mnuQLNhanVien.BackColor = Color.MintCream;
            mnuQLNhanVien.Name = "mnuQLNhanVien";
            mnuQLNhanVien.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            mnuQLNhanVien.Size = new Size(426, 36);
            mnuQLNhanVien.Text = "Quản lý nhân viên";
            mnuQLNhanVien.Click += mnuQLNhanVien_Click;
            // 
            // mnuQLKhachHang
            // 
            mnuQLKhachHang.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLKhachHang.ForeColor = SystemColors.ButtonHighlight;
            mnuQLKhachHang.Name = "mnuQLKhachHang";
            mnuQLKhachHang.ShortcutKeys = Keys.Control | Keys.K;
            mnuQLKhachHang.Size = new Size(426, 36);
            mnuQLKhachHang.Text = "Quản lý khách hàng";
            mnuQLKhachHang.Click += mnuQLKhachHang_Click;
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.ForeColor = SystemColors.GradientInactiveCaption;
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.ShortcutKeys = Keys.Control | Keys.R;
            mnuBaoCao.Size = new Size(107, 31);
            mnuBaoCao.Text = "Báo Cáo";
            mnuBaoCao.Click += mnuBaoCao_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuDoiMK, mnuCauHinh });
            mnuHeThong.ForeColor = SystemColors.GradientInactiveCaption;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(121, 31);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = Color.FromArgb(0, 0, 64);
            mnuDangXuat.ForeColor = SystemColors.ButtonHighlight;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D;
            mnuDangXuat.Size = new Size(385, 36);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += đăngXuấtToolStripMenuItem1_Click;
            // 
            // mnuDoiMK
            // 
            mnuDoiMK.BackColor = Color.MintCream;
            mnuDoiMK.Name = "mnuDoiMK";
            mnuDoiMK.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
            mnuDoiMK.Size = new Size(385, 36);
            mnuDoiMK.Text = "Đổi mật khẩu";
            mnuDoiMK.Click += mnuDoiMK_Click;
            // 
            // mnuCauHinh
            // 
            mnuCauHinh.BackColor = Color.FromArgb(0, 0, 64);
            mnuCauHinh.ForeColor = SystemColors.ButtonHighlight;
            mnuCauHinh.Name = "mnuCauHinh";
            mnuCauHinh.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            mnuCauHinh.Size = new Size(385, 36);
            mnuCauHinh.Text = "Cấu hình";
            mnuCauHinh.Click += mnuCauHinh_Click;
            // 
            // mnuGiaoDien
            // 
            mnuGiaoDien.DropDownItems.AddRange(new ToolStripItem[] { tímToolStripMenuItem, xanhToolStripMenuItem, đỏToolStripMenuItem });
            mnuGiaoDien.ForeColor = SystemColors.GradientInactiveCaption;
            mnuGiaoDien.Name = "mnuGiaoDien";
            mnuGiaoDien.Size = new Size(124, 31);
            mnuGiaoDien.Text = "Giao Diện";
            mnuGiaoDien.Click += mnuGiaoDien_Click;
            // 
            // tímToolStripMenuItem
            // 
            tímToolStripMenuItem.BackColor = Color.FromArgb(0, 0, 64);
            tímToolStripMenuItem.ForeColor = Color.MintCream;
            tímToolStripMenuItem.Name = "tímToolStripMenuItem";
            tímToolStripMenuItem.Size = new Size(162, 36);
            tímToolStripMenuItem.Text = "Tím";
            tímToolStripMenuItem.Click += tímToolStripMenuItem_Click;
            // 
            // xanhToolStripMenuItem
            // 
            xanhToolStripMenuItem.BackColor = Color.SeaGreen;
            xanhToolStripMenuItem.ForeColor = Color.Cornsilk;
            xanhToolStripMenuItem.Name = "xanhToolStripMenuItem";
            xanhToolStripMenuItem.Size = new Size(162, 36);
            xanhToolStripMenuItem.Text = "Xanh";
            xanhToolStripMenuItem.Click += xanhToolStripMenuItem_Click;
            // 
            // đỏToolStripMenuItem
            // 
            đỏToolStripMenuItem.BackColor = Color.DarkRed;
            đỏToolStripMenuItem.ForeColor = Color.Snow;
            đỏToolStripMenuItem.Name = "đỏToolStripMenuItem";
            đỏToolStripMenuItem.Size = new Size(162, 36);
            đỏToolStripMenuItem.Text = "Đỏ";
            đỏToolStripMenuItem.Click += đỏToolStripMenuItem_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.ForeColor = SystemColors.GradientInactiveCaption;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.ShortcutKeys = Keys.Control | Keys.H;
            mnuTroGiup.Size = new Size(111, 31);
            mnuTroGiup.Text = "Trợ Giúp";
            mnuTroGiup.Click += mnuTroGiup_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.ForeColor = SystemColors.GradientInactiveCaption;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(83, 31);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.BackColor = Color.FromArgb(0, 0, 64);
            lblQuyen.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuyen.ForeColor = Color.MintCream;
            lblQuyen.Location = new Point(82, 40);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(189, 64);
            lblQuyen.TabIndex = 2;
            lblQuyen.Text = "ADMIN";
            lblQuyen.Click += label2_Click;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenTK.ForeColor = Color.MidnightBlue;
            lblTenTK.Location = new Point(72, 324);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(141, 32);
            lblTenTK.TabIndex = 3;
            lblTenTK.Text = "User Name";
            lblTenTK.Click += lblTenTK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Main;
            pictureBox1.Location = new Point(366, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1205, 735);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.Cornsilk;
            pnlLeft.Controls.Add(lblTenTK);
            pnlLeft.Controls.Add(pnlQuyen);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 35);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(366, 735);
            pnlLeft.TabIndex = 3;
            pnlLeft.Paint += panel1_Paint;
            // 
            // pnlQuyen
            // 
            pnlQuyen.BackColor = Color.FromArgb(0, 0, 64);
            pnlQuyen.Controls.Add(lblQuyen);
            pnlQuyen.Location = new Point(0, 137);
            pnlQuyen.Name = "pnlQuyen";
            pnlQuyen.Size = new Size(366, 150);
            pnlQuyen.TabIndex = 4;
            // 
            // giaoDịchToolStripMenuItem
            // 
            giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            giaoDịchToolStripMenuItem.Size = new Size(32, 19);
            giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            // 
            // frmQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1571, 770);
            Controls.Add(pictureBox1);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLy";
            Text = "Quản lý siêu thị";
            WindowState = FormWindowState.Maximized;
            Load += frmQuanLy_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlQuyen.ResumeLayout(false);
            pnlQuyen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuGiaoDich;
        private Label lblQuyen;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuBanHang;
        private ToolStripMenuItem mnuQLHoaDon;
        private ToolStripMenuItem mnuQLNhapHang;
        private ToolStripMenuItem mnuQLDanhMuc;
        private ToolStripMenuItem mnuQuanTri;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMK;
        private ToolStripMenuItem mnuCauHinh;
        private ToolStripMenuItem mnuQLSanPham;
        private ToolStripMenuItem mnuQLLoaiHang;
        private ToolStripMenuItem mnuQLNhaCungCap;
        private ToolStripMenuItem mnuQLNhanVien;
        private ToolStripMenuItem mnuQLTaiKhoan;
        private ToolStripMenuItem mnuQLKhachHang;
        private PictureBox pictureBox1;
        private Label lblTenTK;
        private Panel pnlLeft;
        private Panel pnlQuyen;
        private ToolStripMenuItem giaoDịchToolStripMenuItem;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuGiaoDien;
        private ToolStripMenuItem tímToolStripMenuItem;
        private ToolStripMenuItem xanhToolStripMenuItem;
        private ToolStripMenuItem đỏToolStripMenuItem;
        private ToolStripMenuItem mnuBaoCao;
    }
}