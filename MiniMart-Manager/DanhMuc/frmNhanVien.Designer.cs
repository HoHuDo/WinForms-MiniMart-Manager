namespace MiniMart_Manager.DanhMuc
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            pnlQuyen = new Panel();
            lblQuyen = new Label();
            pnlLeft = new Panel();
            lblTen = new Label();
            lblTenTK = new Label();
            mnuTroGiup = new ToolStripMenuItem();
            mnuDoiMK = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuQLSanPham = new ToolStripMenuItem();
            mnuQLDanhMuc = new ToolStripMenuItem();
            mnuQLLoaiHang = new ToolStripMenuItem();
            mnuQLNhaCungCap = new ToolStripMenuItem();
            mnuQLHoaDon = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuGiaoDich = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnuBaoCao = new ToolStripMenuItem();
            mnuGiaoDien = new ToolStripMenuItem();
            mnuGDTim = new ToolStripMenuItem();
            mnuGDXanh = new ToolStripMenuItem();
            mnuGDDo = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pnlQuyen.SuspendLayout();
            pnlLeft.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlQuyen
            // 
            pnlQuyen.BackColor = Color.SeaGreen;
            pnlQuyen.Controls.Add(lblQuyen);
            pnlQuyen.Location = new Point(0, 137);
            pnlQuyen.Name = "pnlQuyen";
            pnlQuyen.Size = new Size(366, 150);
            pnlQuyen.TabIndex = 4;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.BackColor = Color.SeaGreen;
            lblQuyen.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuyen.ForeColor = Color.Cornsilk;
            lblQuyen.Location = new Point(36, 43);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(289, 64);
            lblQuyen.TabIndex = 2;
            lblQuyen.Text = "NHÂN VIÊN";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.Cornsilk;
            pnlLeft.Controls.Add(lblTen);
            pnlLeft.Controls.Add(lblTenTK);
            pnlLeft.Controls.Add(pnlQuyen);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 35);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(366, 715);
            pnlLeft.TabIndex = 6;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTen.ForeColor = Color.SeaGreen;
            lblTen.Location = new Point(92, 333);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(141, 32);
            lblTen.TabIndex = 5;
            lblTen.Text = "User Name";
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenTK.ForeColor = SystemColors.MenuHighlight;
            lblTenTK.Location = new Point(72, 333);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(0, 32);
            lblTenTK.TabIndex = 3;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.ForeColor = Color.Cornsilk;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(111, 31);
            mnuTroGiup.Text = "Trợ Giúp";
            mnuTroGiup.Click += mnuTroGiup_Click;
            // 
            // mnuDoiMK
            // 
            mnuDoiMK.BackColor = Color.SeaGreen;
            mnuDoiMK.ForeColor = Color.Cornsilk;
            mnuDoiMK.Name = "mnuDoiMK";
            mnuDoiMK.Size = new Size(244, 36);
            mnuDoiMK.Text = "Đổi mật khẩu";
            mnuDoiMK.Click += mnuDoiMK_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = Color.Cornsilk;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(244, 36);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuDoiMK });
            mnuHeThong.ForeColor = Color.Cornsilk;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(121, 31);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuQLSanPham
            // 
            mnuQLSanPham.BackColor = Color.Cornsilk;
            mnuQLSanPham.Name = "mnuQLSanPham";
            mnuQLSanPham.Size = new Size(324, 36);
            mnuQLSanPham.Text = "Quản lý sản phẩm";
            mnuQLSanPham.Click += mnuQLSanPham_Click;
            // 
            // mnuQLDanhMuc
            // 
            mnuQLDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuQLSanPham, mnuQLLoaiHang, mnuQLNhaCungCap });
            mnuQLDanhMuc.ForeColor = Color.Cornsilk;
            mnuQLDanhMuc.Name = "mnuQLDanhMuc";
            mnuQLDanhMuc.Size = new Size(210, 31);
            mnuQLDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // mnuQLLoaiHang
            // 
            mnuQLLoaiHang.BackColor = Color.SeaGreen;
            mnuQLLoaiHang.ForeColor = Color.Cornsilk;
            mnuQLLoaiHang.Name = "mnuQLLoaiHang";
            mnuQLLoaiHang.Size = new Size(324, 36);
            mnuQLLoaiHang.Text = "Quản lý loại hàng";
            mnuQLLoaiHang.Click += mnuQLLoaiHang_Click;
            // 
            // mnuQLNhaCungCap
            // 
            mnuQLNhaCungCap.BackColor = Color.Cornsilk;
            mnuQLNhaCungCap.Name = "mnuQLNhaCungCap";
            mnuQLNhaCungCap.Size = new Size(324, 36);
            mnuQLNhaCungCap.Text = "Quản lý nhà cung cấp";
            mnuQLNhaCungCap.Click += mnuQLNhaCungCap_Click;
            // 
            // mnuQLHoaDon
            // 
            mnuQLHoaDon.BackColor = Color.SeaGreen;
            mnuQLHoaDon.ForeColor = Color.Cornsilk;
            mnuQLHoaDon.Name = "mnuQLHoaDon";
            mnuQLHoaDon.Size = new Size(273, 36);
            mnuQLHoaDon.Text = "Quản lý hóa đơn";
            mnuQLHoaDon.Click += mnuQLHoaDon_Click;
            // 
            // mnuBanHang
            // 
            mnuBanHang.BackColor = Color.Cornsilk;
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.Size = new Size(273, 36);
            mnuBanHang.Text = "Bán Hàng";
            mnuBanHang.Click += mnuBanHang_Click;
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.DropDownItems.AddRange(new ToolStripItem[] { mnuBanHang, mnuQLHoaDon });
            mnuGiaoDich.ForeColor = Color.Cornsilk;
            mnuGiaoDich.Name = "mnuGiaoDich";
            mnuGiaoDich.Size = new Size(121, 31);
            mnuGiaoDich.Text = "Giao Dịch";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SeaGreen;
            menuStrip1.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGiaoDich, mnuQLDanhMuc, mnuBaoCao, mnuHeThong, mnuGiaoDien, mnuTroGiup, thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1617, 35);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.ForeColor = Color.Cornsilk;
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(107, 31);
            mnuBaoCao.Text = "Báo Cáo";
            mnuBaoCao.Click += mnuBaoCao_Click;
            // 
            // mnuGiaoDien
            // 
            mnuGiaoDien.DropDownItems.AddRange(new ToolStripItem[] { mnuGDTim, mnuGDXanh, mnuGDDo });
            mnuGiaoDien.ForeColor = Color.Cornsilk;
            mnuGiaoDien.Name = "mnuGiaoDien";
            mnuGiaoDien.Size = new Size(124, 31);
            mnuGiaoDien.Text = "Giao Diện";
            mnuGiaoDien.Click += mnuGiaoDien_Click;
            // 
            // mnuGDTim
            // 
            mnuGDTim.BackColor = Color.FromArgb(0, 0, 64);
            mnuGDTim.ForeColor = Color.MintCream;
            mnuGDTim.Name = "mnuGDTim";
            mnuGDTim.Size = new Size(270, 36);
            mnuGDTim.Text = "Tím";
            mnuGDTim.Click += tímToolStripMenuItem_Click;
            // 
            // mnuGDXanh
            // 
            mnuGDXanh.BackColor = Color.SeaGreen;
            mnuGDXanh.ForeColor = Color.Cornsilk;
            mnuGDXanh.Name = "mnuGDXanh";
            mnuGDXanh.Size = new Size(270, 36);
            mnuGDXanh.Text = "Xanh";
            mnuGDXanh.Click += mnuGDXanh_Click;
            // 
            // mnuGDDo
            // 
            mnuGDDo.BackColor = Color.DarkRed;
            mnuGDDo.ForeColor = Color.Snow;
            mnuGDDo.Name = "mnuGDDo";
            mnuGDDo.Size = new Size(270, 36);
            mnuGDDo.Text = "Đỏ";
            mnuGDDo.Click += mnuGDDo_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.ForeColor = Color.Cornsilk;
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(83, 31);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Main;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1617, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 750);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            WindowState = FormWindowState.Maximized;
            Load += frmNhanVien_Load;
            pnlQuyen.ResumeLayout(false);
            pnlQuyen.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlQuyen;
        private Label lblQuyen;
        private Panel pnlLeft;
        private Label lblTen;
        private Label lblTenTK;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuDoiMK;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQLSanPham;
        private ToolStripMenuItem mnuQLDanhMuc;
        private ToolStripMenuItem mnuQLHoaDon;
        private ToolStripMenuItem mnuBanHang;
        private ToolStripMenuItem mnuGiaoDich;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mnuGiaoDien;
        private ToolStripMenuItem mnuGDTim;
        private ToolStripMenuItem mnuGDXanh;
        private ToolStripMenuItem mnuGDDo;
        private ToolStripMenuItem mnuQLLoaiHang;
        private ToolStripMenuItem mnuQLNhaCungCap;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem mnuBaoCao;
    }
}