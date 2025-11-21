namespace MiniMart_Manager.DanhMuc
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            panel1 = new Panel();
            lbluserName = new Label();
            label14 = new Label();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnXoaCTHD = new Button();
            btnXoaHD = new Button();
            Tìm = new Button();
            btnSua = new Button();
            btnThemCTHD = new Button();
            btnThemHD = new Button();
            dgvHoaDon = new DataGridView();
            grbThongTin = new GroupBox();
            btnReset = new Button();
            chkTimTheoNgay = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            btnSanPham = new Button();
            label7 = new Label();
            btnKH = new Button();
            label8 = new Label();
            cbxMaNV = new ComboBox();
            label10 = new Label();
            cbxMaKH = new ComboBox();
            label16 = new Label();
            label12 = new Label();
            cbxMaSP = new ComboBox();
            label3 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label9 = new Label();
            txtTongTien = new TextBox();
            label11 = new Label();
            txtThanhTien = new TextBox();
            label4 = new Label();
            label13 = new Label();
            txtGiamGia = new TextBox();
            txtDonGia = new TextBox();
            label15 = new Label();
            txtSL = new TextBox();
            txtMaHD = new TextBox();
            dgvChiTietHD = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lbluserName);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1554, 110);
            panel1.TabIndex = 0;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserName.Location = new Point(718, 30);
            lbluserName.Margin = new Padding(2, 0, 2, 0);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(96, 22);
            lbluserName.TabIndex = 0;
            lbluserName.Text = "User Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 30);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(297, 46);
            label14.TabIndex = 0;
            label14.Text = "Quản Lý Hóa Đơn";
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnXoaCTHD);
            grbChucNang.Controls.Add(btnXoaHD);
            grbChucNang.Controls.Add(Tìm);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThemCTHD);
            grbChucNang.Controls.Add(btnThemHD);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(2, 475);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(838, 207);
            grbChucNang.TabIndex = 1;
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
            btnThoat.Location = new Point(658, 122);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(140, 55);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(464, 122);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(140, 55);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "      Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnXoaCTHD
            // 
            btnXoaCTHD.BackColor = Color.FromArgb(255, 224, 192);
            btnXoaCTHD.Image = Properties.Resources.delete;
            btnXoaCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaCTHD.Location = new Point(271, 122);
            btnXoaCTHD.Margin = new Padding(2);
            btnXoaCTHD.Name = "btnXoaCTHD";
            btnXoaCTHD.Size = new Size(140, 55);
            btnXoaCTHD.TabIndex = 3;
            btnXoaCTHD.Text = "     Xóa CTHĐ";
            btnXoaCTHD.UseVisualStyleBackColor = false;
            btnXoaCTHD.Click += btnXoaCTHD_Click;
            // 
            // btnXoaHD
            // 
            btnXoaHD.BackColor = Color.FromArgb(255, 192, 192);
            btnXoaHD.Image = Properties.Resources.delete;
            btnXoaHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaHD.Location = new Point(75, 122);
            btnXoaHD.Margin = new Padding(2);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(140, 55);
            btnXoaHD.TabIndex = 4;
            btnXoaHD.Text = "Xóa HĐ";
            btnXoaHD.UseVisualStyleBackColor = false;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // Tìm
            // 
            Tìm.Image = Properties.Resources.loupe;
            Tìm.ImageAlign = ContentAlignment.MiddleLeft;
            Tìm.Location = new Point(658, 42);
            Tìm.Margin = new Padding(2);
            Tìm.Name = "Tìm";
            Tìm.Size = new Size(140, 55);
            Tìm.TabIndex = 5;
            Tìm.Text = "Tìm";
            Tìm.UseVisualStyleBackColor = true;
            Tìm.Click += Tìm_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(464, 42);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 55);
            btnSua.TabIndex = 6;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThemCTHD
            // 
            btnThemCTHD.BackColor = Color.FromArgb(255, 224, 192);
            btnThemCTHD.Image = Properties.Resources.more;
            btnThemCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemCTHD.Location = new Point(271, 42);
            btnThemCTHD.Margin = new Padding(2);
            btnThemCTHD.Name = "btnThemCTHD";
            btnThemCTHD.Size = new Size(140, 55);
            btnThemCTHD.TabIndex = 7;
            btnThemCTHD.Text = "      Thêm CTHĐ";
            btnThemCTHD.UseVisualStyleBackColor = false;
            btnThemCTHD.Click += btnThemCTHD_Click;
            // 
            // btnThemHD
            // 
            btnThemHD.BackColor = Color.FromArgb(255, 192, 192);
            btnThemHD.Image = Properties.Resources.more;
            btnThemHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHD.Location = new Point(78, 42);
            btnThemHD.Margin = new Padding(2);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new Size(140, 55);
            btnThemHD.TabIndex = 8;
            btnThemHD.Text = "   Thêm HĐ";
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.WhiteSmoke;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.Location = new Point(0, 132);
            dgvHoaDon.Margin = new Padding(2);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(712, 320);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(btnReset);
            grbThongTin.Controls.Add(grbChucNang);
            grbThongTin.Controls.Add(chkTimTheoNgay);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(btnSanPham);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(btnKH);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(cbxMaNV);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(cbxMaKH);
            grbThongTin.Controls.Add(label16);
            grbThongTin.Controls.Add(label12);
            grbThongTin.Controls.Add(cbxMaSP);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(dtpNgayNhap);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(txtTongTien);
            grbThongTin.Controls.Add(label11);
            grbThongTin.Controls.Add(txtThanhTien);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(txtGiamGia);
            grbThongTin.Controls.Add(txtDonGia);
            grbThongTin.Controls.Add(label15);
            grbThongTin.Controls.Add(txtSL);
            grbThongTin.Controls.Add(txtMaHD);
            grbThongTin.Dock = DockStyle.Right;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(712, 110);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(842, 684);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(198, 415);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 42);
            btnReset.TabIndex = 33;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // chkTimTheoNgay
            // 
            chkTimTheoNgay.AutoSize = true;
            chkTimTheoNgay.Location = new Point(407, 290);
            chkTimTheoNgay.Margin = new Padding(2);
            chkTimTheoNgay.Name = "chkTimTheoNgay";
            chkTimTheoNgay.Size = new Size(60, 26);
            chkTimTheoNgay.TabIndex = 32;
            chkTimTheoNgay.Text = "Tìm";
            chkTimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 45);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 22);
            label5.TabIndex = 9;
            label5.Text = "Mã Hóa Đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(17, 96);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 22);
            label6.TabIndex = 19;
            label6.Text = "Hóa Đơn";
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.Location = new Point(614, 178);
            btnSanPham.Margin = new Padding(2);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(129, 29);
            btnSanPham.TabIndex = 30;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(502, 96);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 22);
            label7.TabIndex = 10;
            label7.Text = "Chi Tiết Hóa Đơn";
            // 
            // btnKH
            // 
            btnKH.BackColor = Color.Snow;
            btnKH.Location = new Point(198, 178);
            btnKH.Margin = new Padding(2);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(131, 29);
            btnKH.TabIndex = 29;
            btnKH.Text = "Khách Hàng";
            btnKH.UseVisualStyleBackColor = false;
            btnKH.Click += btnKH_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 148);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(168, 22);
            label8.TabIndex = 11;
            label8.Text = "Mã Nhà Khách Hàng";
            // 
            // cbxMaNV
            // 
            cbxMaNV.Enabled = false;
            cbxMaNV.FormattingEnabled = true;
            cbxMaNV.Location = new Point(198, 228);
            cbxMaNV.Margin = new Padding(2);
            cbxMaNV.Name = "cbxMaNV";
            cbxMaNV.Size = new Size(252, 30);
            cbxMaNV.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 226);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(119, 22);
            label10.TabIndex = 12;
            label10.Text = "Mã Nhân Viên";
            // 
            // cbxMaKH
            // 
            cbxMaKH.FormattingEnabled = true;
            cbxMaKH.Location = new Point(198, 145);
            cbxMaKH.Margin = new Padding(2);
            cbxMaKH.Name = "cbxMaKH";
            cbxMaKH.Size = new Size(271, 30);
            cbxMaKH.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(702, 326);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(24, 22);
            label16.TabIndex = 13;
            label16.Text = "%";
            label16.Click += label12_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 294);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 22);
            label12.TabIndex = 13;
            label12.Text = "Ngày Lập";
            label12.Click += label12_Click;
            // 
            // cbxMaSP
            // 
            cbxMaSP.FormattingEnabled = true;
            cbxMaSP.Location = new Point(614, 145);
            cbxMaSP.Margin = new Padding(2);
            cbxMaSP.Name = "cbxMaSP";
            cbxMaSP.Size = new Size(214, 30);
            cbxMaSP.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 381);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 22);
            label3.TabIndex = 14;
            label3.Text = "Tổng Tiền";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = " dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(198, 286);
            dtpNgayNhap.Margin = new Padding(2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(205, 30);
            dtpNgayNhap.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(502, 147);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(116, 22);
            label9.TabIndex = 15;
            label9.Text = "Mã Sản Phẩm";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(198, 372);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(205, 30);
            txtTongTien.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(502, 225);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(82, 22);
            label11.TabIndex = 16;
            label11.Text = "Số Lượng";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(614, 380);
            txtThanhTien.Margin = new Padding(2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(172, 30);
            txtThanhTien.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 329);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 17;
            label4.Text = "Giảm Giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(502, 277);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 22);
            label13.TabIndex = 17;
            label13.Text = "Đơn Giá Bán";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(614, 322);
            txtGiamGia.Margin = new Padding(2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(86, 30);
            txtGiamGia.TabIndex = 24;
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            txtGiamGia.KeyPress += txtSL_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(613, 274);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(139, 30);
            txtDonGia.TabIndex = 24;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtSL_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(502, 381);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(94, 22);
            label15.TabIndex = 18;
            label15.Text = "Thành Tiền";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(614, 226);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(86, 30);
            txtSL.TabIndex = 21;
            txtSL.TextChanged += txtSL_TextChanged;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(198, 45);
            txtMaHD.Margin = new Padding(2);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(160, 30);
            txtMaHD.TabIndex = 20;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHD.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Dock = DockStyle.Bottom;
            dgvChiTietHD.GridColor = Color.WhiteSmoke;
            dgvChiTietHD.Location = new Point(0, 474);
            dgvChiTietHD.Margin = new Padding(2);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.RowHeadersWidth = 62;
            dgvChiTietHD.Size = new Size(712, 320);
            dgvChiTietHD.TabIndex = 4;
            dgvChiTietHD.CellClick += dgvChiTietHD_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label1.Location = new Point(0, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 452);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Hóa đơn";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1554, 794);
            Controls.Add(dgvHoaDon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvChiTietHD);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hóa Đơn";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox grbChucNang;
        private DataGridView dgvHoaDon;
        private GroupBox grbThongTin;
        private DataGridView dgvChiTietHD;
        private Label label1;
        private Label label2;
        private Label lbluserName;
        private Label label14;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnXoaCTHD;
        private Button btnXoaHD;
        private Button Tìm;
        private Button btnSua;
        private Button btnThemCTHD;
        private Button btnThemHD;
        private Button btnReset;
        private CheckBox chkTimTheoNgay;
        private Label label5;
        private Label label6;
        private Button btnSanPham;
        private Label label7;
        private Button btnKH;
        private Label label8;
        private ComboBox cbxMaNV;
        private Label label10;
        private ComboBox cbxMaKH;
        private Label label12;
        private ComboBox cbxMaSP;
        private Label label3;
        private DateTimePicker dtpNgayNhap;
        private Label label9;
        private TextBox txtTongTien;
        private Label label11;
        private TextBox txtThanhTien;
        private Label label13;
        private TextBox txtDonGia;
        private Label label15;
        private TextBox txtSL;
        private TextBox txtMaHD;
        private Label label4;
        private TextBox txtGiamGia;
        private Label label16;
    }
}