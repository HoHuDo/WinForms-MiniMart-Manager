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
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            lblTen = new Label();
            lblTenTK = new Label();
            mnuTroGiup = new ToolStripMenuItem();
            mnuDoiMK = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuQLNhaCungCap = new ToolStripMenuItem();
            mnuQLLoaiHang = new ToolStripMenuItem();
            mnuQLSanPham = new ToolStripMenuItem();
            mnuQLDanhMuc = new ToolStripMenuItem();
            mnuQLNhapHang = new ToolStripMenuItem();
            mnuQLHoaDon = new ToolStripMenuItem();
            mnuBanHang = new ToolStripMenuItem();
            mnuGiaoDich = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 150);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(36, 43);
            label2.Name = "label2";
            label2.Size = new Size(289, 64);
            label2.TabIndex = 2;
            label2.Text = "NHÂN VIÊN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(lblTen);
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 715);
            panel1.TabIndex = 6;
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
            // 
            // mnuDoiMK
            // 
            mnuDoiMK.BackColor = Color.SeaGreen;
            mnuDoiMK.ForeColor = Color.Cornsilk;
            mnuDoiMK.Name = "mnuDoiMK";
            mnuDoiMK.Size = new Size(244, 36);
            mnuDoiMK.Text = "Đổi mật khẩu";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.BackColor = Color.Cornsilk;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(244, 36);
            mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat, mnuDoiMK });
            mnuHeThong.ForeColor = Color.Cornsilk;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(121, 31);
            mnuHeThong.Text = "Hệ Thống";
            // 
            // mnuQLNhaCungCap
            // 
            mnuQLNhaCungCap.BackColor = Color.Cornsilk;
            mnuQLNhaCungCap.Name = "mnuQLNhaCungCap";
            mnuQLNhaCungCap.Size = new Size(324, 36);
            mnuQLNhaCungCap.Text = "Quản lý nhà cung cấp";
            // 
            // mnuQLLoaiHang
            // 
            mnuQLLoaiHang.BackColor = Color.SeaGreen;
            mnuQLLoaiHang.ForeColor = Color.Cornsilk;
            mnuQLLoaiHang.Name = "mnuQLLoaiHang";
            mnuQLLoaiHang.Size = new Size(324, 36);
            mnuQLLoaiHang.Text = "Quản lý loại hàng";
            // 
            // mnuQLSanPham
            // 
            mnuQLSanPham.BackColor = Color.Cornsilk;
            mnuQLSanPham.Name = "mnuQLSanPham";
            mnuQLSanPham.Size = new Size(324, 36);
            mnuQLSanPham.Text = "Quản lý sản phẩm";
            // 
            // mnuQLDanhMuc
            // 
            mnuQLDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuQLSanPham, mnuQLLoaiHang, mnuQLNhaCungCap });
            mnuQLDanhMuc.ForeColor = Color.Cornsilk;
            mnuQLDanhMuc.Name = "mnuQLDanhMuc";
            mnuQLDanhMuc.Size = new Size(210, 31);
            mnuQLDanhMuc.Text = "Quản Lý Danh Mục";
            // 
            // mnuQLNhapHang
            // 
            mnuQLNhapHang.BackColor = Color.Cornsilk;
            mnuQLNhapHang.Name = "mnuQLNhapHang";
            mnuQLNhapHang.Size = new Size(298, 36);
            mnuQLNhapHang.Text = "Quản lý nhập hàng";
            // 
            // mnuQLHoaDon
            // 
            mnuQLHoaDon.BackColor = Color.SeaGreen;
            mnuQLHoaDon.ForeColor = Color.Cornsilk;
            mnuQLHoaDon.Name = "mnuQLHoaDon";
            mnuQLHoaDon.Size = new Size(298, 36);
            mnuQLHoaDon.Text = "Quản lý hóa đơn";
            // 
            // mnuBanHang
            // 
            mnuBanHang.BackColor = Color.Cornsilk;
            mnuBanHang.Name = "mnuBanHang";
            mnuBanHang.Size = new Size(298, 36);
            mnuBanHang.Text = "Bán Hàng";
            // 
            // mnuGiaoDich
            // 
            mnuGiaoDich.DropDownItems.AddRange(new ToolStripItem[] { mnuBanHang, mnuQLHoaDon, mnuQLNhapHang });
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuGiaoDich, mnuQLDanhMuc, mnuHeThong, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1617, 35);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
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
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Name = "frmNhanVien";
            WindowState = FormWindowState.Maximized;
            Load += frmNhanVien_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label lblTen;
        private Label lblTenTK;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuDoiMK;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQLNhaCungCap;
        private ToolStripMenuItem mnuQLLoaiHang;
        private ToolStripMenuItem mnuQLSanPham;
        private ToolStripMenuItem mnuQLDanhMuc;
        private ToolStripMenuItem mnuQLNhapHang;
        private ToolStripMenuItem mnuQLHoaDon;
        private ToolStripMenuItem mnuBanHang;
        private ToolStripMenuItem mnuGiaoDich;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
    }
}