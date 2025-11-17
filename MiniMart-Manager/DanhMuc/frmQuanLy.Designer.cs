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
            menuStrip1 = new MenuStrip();
            mnuGiaoDich = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuQLHoaDon = new ToolStripMenuItem();
            mnuQLNhapHang = new ToolStripMenuItem();
            giaoDịchToolStripMenuItem1 = new ToolStripMenuItem();
            mnuQLDanhMuc = new ToolStripMenuItem();
            mnuQLSanPham = new ToolStripMenuItem();
            mnuQLLoaiHang = new ToolStripMenuItem();
            mnuQLNhaCungCap = new ToolStripMenuItem();
            mnuQuanTri = new ToolStripMenuItem();
            mnuQLTaiKhoan = new ToolStripMenuItem();
            mnuQLNhanVien = new ToolStripMenuItem();
            mnuQLKhachHang = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMK = new ToolStripMenuItem();
            mnuCauHinh = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            label2 = new Label();
            lblTenTK = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            giaoDịchToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 0, 64);
            menuStrip1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGiaoDich, mnuQLDanhMuc, mnuQuanTri, mnuHeThong, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1430, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.DropDownItems.AddRange(new ToolStripItem[] { mnuBanHang, mnuQLHoaDon, mnuQLNhapHang, giaoDịchToolStripMenuItem1 });
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
            mnuBanHang.Size = new Size(298, 36);
            mnuBanHang.Text = "Bán Hàng";
            mnuBanHang.Click += mnuBanHang_Click;
            // 
            // mnuQLHoaDon
            // 
            mnuQLHoaDon.BackColor = Color.MintCream;
            mnuQLHoaDon.Name = "mnuQLHoaDon";
            mnuQLHoaDon.Size = new Size(298, 36);
            mnuQLHoaDon.Text = "Quản lý hóa đơn";
            mnuQLHoaDon.Click += mnuQLHoaDon_Click;
            // 
            // mnuQLNhapHang
            // 
            mnuQLNhapHang.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLNhapHang.ForeColor = SystemColors.ButtonHighlight;
            mnuQLNhapHang.Name = "mnuQLNhapHang";
            mnuQLNhapHang.Size = new Size(298, 36);
            mnuQLNhapHang.Text = "Quản lý nhập hàng";
            mnuQLNhapHang.Click += mnuQLNhapHang_Click;
            // 
            // giaoDịchToolStripMenuItem1
            // 
            giaoDịchToolStripMenuItem1.Name = "giaoDịchToolStripMenuItem1";
            giaoDịchToolStripMenuItem1.Size = new Size(298, 36);
            giaoDịchToolStripMenuItem1.Text = "Giao Dịch";
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
            mnuQLSanPham.Size = new Size(324, 36);
            mnuQLSanPham.Text = "Quản lý sản phẩm";
            mnuQLSanPham.Click += mnuQLSanPham_Click;
            // 
            // mnuQLLoaiHang
            // 
            mnuQLLoaiHang.BackColor = Color.MintCream;
            mnuQLLoaiHang.Name = "mnuQLLoaiHang";
            mnuQLLoaiHang.Size = new Size(324, 36);
            mnuQLLoaiHang.Text = "Quản lý loại hàng";
            mnuQLLoaiHang.Click += mnuQLLoaiHang_Click;
            // 
            // mnuQLNhaCungCap
            // 
            mnuQLNhaCungCap.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLNhaCungCap.ForeColor = SystemColors.ButtonHighlight;
            mnuQLNhaCungCap.Name = "mnuQLNhaCungCap";
            mnuQLNhaCungCap.Size = new Size(324, 36);
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
            mnuQLTaiKhoan.Size = new Size(305, 36);
            mnuQLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mnuQLNhanVien
            // 
            mnuQLNhanVien.BackColor = Color.MintCream;
            mnuQLNhanVien.Name = "mnuQLNhanVien";
            mnuQLNhanVien.Size = new Size(305, 36);
            mnuQLNhanVien.Text = "Quản lý nhân viên";
            // 
            // mnuQLKhachHang
            // 
            mnuQLKhachHang.BackColor = Color.FromArgb(0, 0, 64);
            mnuQLKhachHang.ForeColor = SystemColors.ButtonHighlight;
            mnuQLKhachHang.Name = "mnuQLKhachHang";
            mnuQLKhachHang.Size = new Size(305, 36);
            mnuQLKhachHang.Text = "Quản lý khách hàng";
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
            mnuDangXuat.Size = new Size(244, 36);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += đăngXuấtToolStripMenuItem1_Click;
            // 
            // mnuDoiMK
            // 
            mnuDoiMK.BackColor = Color.MintCream;
            mnuDoiMK.Name = "mnuDoiMK";
            mnuDoiMK.Size = new Size(244, 36);
            mnuDoiMK.Text = "Đổi mật khẩu";
            mnuDoiMK.Click += mnuDoiMK_Click;
            // 
            // mnuCauHinh
            // 
            mnuCauHinh.BackColor = Color.FromArgb(0, 0, 64);
            mnuCauHinh.ForeColor = SystemColors.ButtonHighlight;
            mnuCauHinh.Name = "mnuCauHinh";
            mnuCauHinh.Size = new Size(244, 36);
            mnuCauHinh.Text = "Cấu hình";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.ForeColor = SystemColors.GradientInactiveCaption;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(111, 31);
            mnuTroGiup.Text = "Trợ Giúp";
            mnuTroGiup.Click += mnuTroGiup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(82, 40);
            label2.Name = "label2";
            label2.Size = new Size(189, 64);
            label2.TabIndex = 2;
            label2.Text = "ADMIN";
            label2.Click += label2_Click;
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
            pictureBox1.Size = new Size(1064, 735);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 735);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(116, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 150);
            panel2.TabIndex = 4;
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
            ClientSize = new Size(1430, 770);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmQuanLy";
            Text = "Quản lý siêu thị";
            WindowState = FormWindowState.Maximized;
            Load += frmQuanLy_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuGiaoDich;
        private Label label2;
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
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private ToolStripMenuItem giaoDịchToolStripMenuItem;
        private ToolStripMenuItem giaoDịchToolStripMenuItem1;
    }
}