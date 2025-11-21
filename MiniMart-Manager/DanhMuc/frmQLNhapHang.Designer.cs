namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhapHang));
            panel1 = new Panel();
            lblTenTk = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvPhieuNhap = new DataGridView();
            dgvChiTietPN = new DataGridView();
            grbThongTin = new GroupBox();
            btnReset = new Button();
            chkTimTheoNgay = new CheckBox();
            btnNhanVien = new Button();
            btnSanPham = new Button();
            btnNCC = new Button();
            cbxMaNV = new ComboBox();
            cbxMaNCC = new ComboBox();
            cbxMaSP = new ComboBox();
            dtpNgayNhap = new DateTimePicker();
            txtTongTien = new TextBox();
            txtThanhTien = new TextBox();
            txtDonGia = new TextBox();
            txtSL = new TextBox();
            txtMaPN = new TextBox();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            button1 = new Button();
            btnXoaPN = new Button();
            Tìm = new Button();
            btnSua = new Button();
            btnThemCTPN = new Button();
            btnThemPN = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPN).BeginInit();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTk);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1577, 110);
            panel1.TabIndex = 0;
            // 
            // lblTenTk
            // 
            lblTenTk.AutoSize = true;
            lblTenTk.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTk.Location = new Point(674, 46);
            lblTenTk.Margin = new Padding(2, 0, 2, 0);
            lblTenTk.Name = "lblTenTk";
            lblTenTk.Size = new Size(96, 22);
            lblTenTk.TabIndex = 0;
            lblTenTk.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(10, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(338, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhập Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 0;
            label2.Text = "Phiếu Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label3.Location = new Point(0, 487);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(161, 22);
            label3.TabIndex = 0;
            label3.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.BackgroundColor = Color.WhiteSmoke;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(0, 132);
            dgvPhieuNhap.Margin = new Padding(2);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(660, 355);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // dgvChiTietPN
            // 
            dgvChiTietPN.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPN.Dock = DockStyle.Bottom;
            dgvChiTietPN.Location = new Point(0, 509);
            dgvChiTietPN.Margin = new Padding(2);
            dgvChiTietPN.Name = "dgvChiTietPN";
            dgvChiTietPN.RowHeadersWidth = 62;
            dgvChiTietPN.Size = new Size(660, 286);
            dgvChiTietPN.TabIndex = 2;
            dgvChiTietPN.CellClick += dgvChiTietPN_CellClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(btnReset);
            grbThongTin.Controls.Add(chkTimTheoNgay);
            grbThongTin.Controls.Add(btnNhanVien);
            grbThongTin.Controls.Add(btnSanPham);
            grbThongTin.Controls.Add(btnNCC);
            grbThongTin.Controls.Add(cbxMaNV);
            grbThongTin.Controls.Add(cbxMaNCC);
            grbThongTin.Controls.Add(cbxMaSP);
            grbThongTin.Controls.Add(dtpNgayNhap);
            grbThongTin.Controls.Add(txtTongTien);
            grbThongTin.Controls.Add(txtThanhTien);
            grbThongTin.Controls.Add(txtDonGia);
            grbThongTin.Controls.Add(txtSL);
            grbThongTin.Controls.Add(txtMaPN);
            grbThongTin.Controls.Add(label15);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(label11);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label14);
            grbThongTin.Controls.Add(label12);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(grbChucNang);
            grbThongTin.Dock = DockStyle.Right;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(660, 110);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(917, 685);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(693, 397);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 47);
            btnReset.TabIndex = 8;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // chkTimTheoNgay
            // 
            chkTimTheoNgay.AutoSize = true;
            chkTimTheoNgay.Location = new Point(390, 360);
            chkTimTheoNgay.Margin = new Padding(2);
            chkTimTheoNgay.Name = "chkTimTheoNgay";
            chkTimTheoNgay.Size = new Size(60, 26);
            chkTimTheoNgay.TabIndex = 7;
            chkTimTheoNgay.Text = "Tìm";
            chkTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Snow;
            btnNhanVien.Location = new Point(181, 294);
            btnNhanVien.Margin = new Padding(2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(131, 29);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNV_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.Location = new Point(663, 196);
            btnSanPham.Margin = new Padding(2);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(129, 29);
            btnSanPham.TabIndex = 6;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSP_Click;
            // 
            // btnNCC
            // 
            btnNCC.BackColor = Color.Snow;
            btnNCC.Location = new Point(181, 196);
            btnNCC.Margin = new Padding(2);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(131, 29);
            btnNCC.TabIndex = 6;
            btnNCC.Text = "Nhà Cung Cấp";
            btnNCC.UseVisualStyleBackColor = false;
            btnNCC.Click += btnNCC_Click;
            // 
            // cbxMaNV
            // 
            cbxMaNV.Enabled = false;
            cbxMaNV.FormattingEnabled = true;
            cbxMaNV.Location = new Point(181, 261);
            cbxMaNV.Margin = new Padding(2);
            cbxMaNV.Name = "cbxMaNV";
            cbxMaNV.Size = new Size(252, 30);
            cbxMaNV.TabIndex = 5;
            // 
            // cbxMaNCC
            // 
            cbxMaNCC.FormattingEnabled = true;
            cbxMaNCC.Location = new Point(181, 163);
            cbxMaNCC.Margin = new Padding(2);
            cbxMaNCC.Name = "cbxMaNCC";
            cbxMaNCC.Size = new Size(322, 30);
            cbxMaNCC.TabIndex = 5;
            // 
            // cbxMaSP
            // 
            cbxMaSP.FormattingEnabled = true;
            cbxMaSP.Location = new Point(663, 163);
            cbxMaSP.Margin = new Padding(2);
            cbxMaSP.Name = "cbxMaSP";
            cbxMaSP.Size = new Size(214, 30);
            cbxMaSP.TabIndex = 5;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = " dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(181, 360);
            dtpNgayNhap.Margin = new Padding(2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(205, 30);
            dtpNgayNhap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(181, 406);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(205, 30);
            txtTongTien.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(661, 353);
            txtThanhTien.Margin = new Padding(2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(172, 30);
            txtThanhTien.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(661, 307);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(139, 30);
            txtDonGia.TabIndex = 1;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtSL_KeyPress;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(661, 256);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(86, 30);
            txtSL.TabIndex = 1;
            txtSL.TextChanged += txtSL_TextChanged;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(181, 64);
            txtMaPN.Margin = new Padding(2);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(160, 30);
            txtMaPN.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(543, 362);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(94, 22);
            label15.TabIndex = 0;
            label15.Text = "Thành Tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(543, 310);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(117, 22);
            label13.TabIndex = 0;
            label13.Text = "Đơn Giá Nhập";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(543, 262);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 0;
            label11.Text = "Số Lượng";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(543, 166);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(116, 22);
            label9.TabIndex = 0;
            label9.Text = "Mã Sản Phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 412);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(85, 22);
            label14.TabIndex = 0;
            label14.Text = "Tổng Tiền";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 361);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(97, 22);
            label12.TabIndex = 0;
            label12.Text = "Ngày Nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 266);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(119, 22);
            label10.TabIndex = 0;
            label10.Text = "Mã Nhân Viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 166);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(152, 22);
            label8.TabIndex = 0;
            label8.Text = "Mã Nhà Cung Cấp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(543, 115);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(161, 22);
            label7.TabIndex = 0;
            label7.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(14, 115);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 22);
            label6.TabIndex = 0;
            label6.Text = "Phiếu Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 64);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 0;
            label5.Text = "Mã Phiếu Nhập";
            label5.Click += label5_Click;
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(button1);
            grbChucNang.Controls.Add(btnXoaPN);
            grbChucNang.Controls.Add(Tìm);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThemCTPN);
            grbChucNang.Controls.Add(btnThemPN);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(2, 494);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(913, 189);
            grbChucNang.TabIndex = 4;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(691, 106);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(152, 55);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(485, 106);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(152, 55);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "      Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Image = Properties.Resources.delete;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(279, 106);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(152, 55);
            button1.TabIndex = 0;
            button1.Text = "     Xóa CTPN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnXoaCTPN_Click;
            // 
            // btnXoaPN
            // 
            btnXoaPN.BackColor = Color.FromArgb(255, 192, 192);
            btnXoaPN.Image = Properties.Resources.delete;
            btnXoaPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaPN.Location = new Point(74, 106);
            btnXoaPN.Margin = new Padding(2);
            btnXoaPN.Name = "btnXoaPN";
            btnXoaPN.Size = new Size(152, 55);
            btnXoaPN.TabIndex = 0;
            btnXoaPN.Text = "Xóa PN";
            btnXoaPN.UseVisualStyleBackColor = false;
            btnXoaPN.Click += btnXoaPN_Click;
            // 
            // Tìm
            // 
            Tìm.Image = Properties.Resources.loupe;
            Tìm.ImageAlign = ContentAlignment.MiddleLeft;
            Tìm.Location = new Point(691, 26);
            Tìm.Margin = new Padding(2);
            Tìm.Name = "Tìm";
            Tìm.Size = new Size(152, 55);
            Tìm.TabIndex = 0;
            Tìm.Text = "Tìm";
            Tìm.UseVisualStyleBackColor = true;
            Tìm.Click += Tìm_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(485, 26);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(152, 55);
            btnSua.TabIndex = 0;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThemCTPN
            // 
            btnThemCTPN.BackColor = Color.FromArgb(255, 224, 192);
            btnThemCTPN.Image = Properties.Resources.more;
            btnThemCTPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemCTPN.Location = new Point(279, 26);
            btnThemCTPN.Margin = new Padding(2);
            btnThemCTPN.Name = "btnThemCTPN";
            btnThemCTPN.Size = new Size(152, 55);
            btnThemCTPN.TabIndex = 0;
            btnThemCTPN.Text = "      Thêm CTPN";
            btnThemCTPN.UseVisualStyleBackColor = false;
            btnThemCTPN.Click += btnThemCTPN_Click;
            // 
            // btnThemPN
            // 
            btnThemPN.BackColor = Color.FromArgb(255, 192, 192);
            btnThemPN.Image = Properties.Resources.more;
            btnThemPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemPN.Location = new Point(74, 26);
            btnThemPN.Margin = new Padding(2);
            btnThemPN.Name = "btnThemPN";
            btnThemPN.Size = new Size(152, 55);
            btnThemPN.TabIndex = 0;
            btnThemPN.Text = "   Thêm PN";
            btnThemPN.UseVisualStyleBackColor = false;
            btnThemPN.Click += btnThemPN_Click;
            // 
            // frmQLNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1577, 795);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvChiTietPN);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLNhapHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhập Hàng";
            Load += frmQLNhapHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPN).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dgvPhieuNhap;
        private DataGridView dgvChiTietPN;
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private Label lblTenTk;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label15;
        private Label label13;
        private Label label14;
        private Label label12;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtTongTien;
        private TextBox txtThanhTien;
        private TextBox txtDonGia;
        private TextBox txtSL;
        private TextBox txtMaPN;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnXoaPN;
        private Button Tìm;
        private Button btnSua;
        private Button btnThemPN;
        private ComboBox cbxMaSP;
        private Button btnThemCTPN;
        private Button btnNCC;
        private ComboBox cbxMaNV;
        private ComboBox cbxMaNCC;
        private Button btnNhanVien;
        private Button btnSanPham;
        private Button button1;
        private CheckBox chkTimTheoNgay;
        private Button btnReset;
    }
}