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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            btnBoQua = new Button();
            btnReset = new Button();
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
            dtpLoc = new DateTimePicker();
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
            panel1.Size = new Size(1942, 138);
            panel1.TabIndex = 0;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserName.Location = new Point(898, 38);
            lbluserName.Margin = new Padding(2, 0, 2, 0);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(113, 27);
            lbluserName.TabIndex = 0;
            lbluserName.Text = "User Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 38);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(349, 53);
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
            grbChucNang.Location = new Point(2, 571);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(1048, 259);
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
            btnThoat.Location = new Point(822, 152);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(175, 69);
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
            btnXuat.Location = new Point(580, 152);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(175, 69);
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
            btnXoaCTHD.Location = new Point(339, 152);
            btnXoaCTHD.Margin = new Padding(2);
            btnXoaCTHD.Name = "btnXoaCTHD";
            btnXoaCTHD.Size = new Size(175, 69);
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
            btnXoaHD.Location = new Point(94, 152);
            btnXoaHD.Margin = new Padding(2);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(175, 69);
            btnXoaHD.TabIndex = 4;
            btnXoaHD.Text = "Xóa HĐ";
            btnXoaHD.UseVisualStyleBackColor = false;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // Tìm
            // 
            Tìm.Image = Properties.Resources.loupe;
            Tìm.ImageAlign = ContentAlignment.MiddleLeft;
            Tìm.Location = new Point(822, 52);
            Tìm.Margin = new Padding(2);
            Tìm.Name = "Tìm";
            Tìm.Size = new Size(175, 69);
            Tìm.TabIndex = 5;
            Tìm.Text = "Tìm";
            Tìm.UseVisualStyleBackColor = true;
            Tìm.Click += Tìm_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(580, 52);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(175, 69);
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
            btnThemCTHD.Location = new Point(339, 52);
            btnThemCTHD.Margin = new Padding(2);
            btnThemCTHD.Name = "btnThemCTHD";
            btnThemCTHD.Size = new Size(175, 69);
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
            btnThemHD.Location = new Point(98, 52);
            btnThemHD.Margin = new Padding(2);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Size = new Size(175, 69);
            btnThemHD.TabIndex = 8;
            btnThemHD.Text = "   Thêm HĐ";
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.WhiteSmoke;
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Info;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Location = new Point(0, 165);
            dgvHoaDon.Margin = new Padding(2);
            dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(890, 508);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(btnBoQua);
            grbThongTin.Controls.Add(btnReset);
            grbThongTin.Controls.Add(grbChucNang);
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
            grbThongTin.Location = new Point(890, 138);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(1052, 832);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.Location = new Point(341, 519);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(59, 52);
            btnBoQua.TabIndex = 33;
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnReset_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(248, 519);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(59, 52);
            btnReset.TabIndex = 33;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 27);
            label5.TabIndex = 9;
            label5.Text = "Mã Hóa Đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(21, 120);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 19;
            label6.Text = "Hóa Đơn";
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.Location = new Point(768, 222);
            btnSanPham.Margin = new Padding(2);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(161, 36);
            btnSanPham.TabIndex = 30;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(628, 120);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 27);
            label7.TabIndex = 10;
            label7.Text = "Chi Tiết Hóa Đơn";
            // 
            // btnKH
            // 
            btnKH.BackColor = Color.Snow;
            btnKH.Location = new Point(248, 222);
            btnKH.Margin = new Padding(2);
            btnKH.Name = "btnKH";
            btnKH.Size = new Size(164, 36);
            btnKH.TabIndex = 29;
            btnKH.Text = "Khách Hàng";
            btnKH.UseVisualStyleBackColor = false;
            btnKH.Click += btnKH_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 185);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(194, 27);
            label8.TabIndex = 11;
            label8.Text = "Mã Nhà Khách Hàng";
            // 
            // cbxMaNV
            // 
            cbxMaNV.FormattingEnabled = true;
            cbxMaNV.Location = new Point(248, 285);
            cbxMaNV.Margin = new Padding(2);
            cbxMaNV.Name = "cbxMaNV";
            cbxMaNV.Size = new Size(314, 35);
            cbxMaNV.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 285);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(104, 27);
            label10.TabIndex = 12;
            label10.Text = "Nhân Viên";
            // 
            // cbxMaKH
            // 
            cbxMaKH.FormattingEnabled = true;
            cbxMaKH.Location = new Point(248, 181);
            cbxMaKH.Margin = new Padding(2);
            cbxMaKH.Name = "cbxMaKH";
            cbxMaKH.Size = new Size(338, 35);
            cbxMaKH.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(878, 408);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(29, 27);
            label16.TabIndex = 13;
            label16.Text = "%";
            label16.Click += label12_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 368);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(97, 27);
            label12.TabIndex = 13;
            label12.Text = "Ngày Lập";
            label12.Click += label12_Click;
            // 
            // cbxMaSP
            // 
            cbxMaSP.FormattingEnabled = true;
            cbxMaSP.Location = new Point(768, 181);
            cbxMaSP.Margin = new Padding(2);
            cbxMaSP.Name = "cbxMaSP";
            cbxMaSP.Size = new Size(266, 35);
            cbxMaSP.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 476);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 27);
            label3.TabIndex = 14;
            label3.Text = "Tổng Tiền";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = " dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(248, 358);
            dtpNgayNhap.Margin = new Padding(2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(255, 34);
            dtpNgayNhap.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(628, 184);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 27);
            label9.TabIndex = 15;
            label9.Text = "Mã Sản Phẩm";
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(248, 465);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(255, 34);
            txtTongTien.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(628, 281);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 27);
            label11.TabIndex = 16;
            label11.Text = "Số Lượng";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(768, 475);
            txtThanhTien.Margin = new Padding(2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(214, 34);
            txtThanhTien.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(628, 411);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 27);
            label4.TabIndex = 17;
            label4.Text = "Giảm Giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(628, 346);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(121, 27);
            label13.TabIndex = 17;
            label13.Text = "Đơn Giá Bán";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(768, 402);
            txtGiamGia.Margin = new Padding(2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(106, 34);
            txtGiamGia.TabIndex = 24;
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            txtGiamGia.KeyPress += txtSL_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(766, 342);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(173, 34);
            txtDonGia.TabIndex = 24;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtSL_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(628, 476);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(109, 27);
            label15.TabIndex = 18;
            label15.Text = "Thành Tiền";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(768, 282);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(106, 34);
            txtSL.TabIndex = 21;
            txtSL.TextChanged += txtSL_TextChanged;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(248, 56);
            txtMaHD.Margin = new Padding(2);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(199, 34);
            txtMaHD.TabIndex = 20;
            txtMaHD.TextChanged += txtMaHD_TextChanged;
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AllowUserToAddRows = false;
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHD.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietHD.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvChiTietHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Dock = DockStyle.Bottom;
            dgvChiTietHD.EnableHeadersVisualStyles = false;
            dgvChiTietHD.GridColor = Color.WhiteSmoke;
            dgvChiTietHD.Location = new Point(0, 700);
            dgvChiTietHD.Margin = new Padding(2);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.RowHeadersVisible = false;
            dgvChiTietHD.RowHeadersWidth = 62;
            dgvChiTietHD.Size = new Size(890, 270);
            dgvChiTietHD.TabIndex = 4;
            dgvChiTietHD.CellClick += dgvChiTietHD_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label1.Location = new Point(0, 138);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 673);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Hóa đơn";
            // 
            // dtpLoc
            // 
            dtpLoc.CustomFormat = "MM/yyyy";
            dtpLoc.Format = DateTimePickerFormat.Custom;
            dtpLoc.Location = new Point(741, 135);
            dtpLoc.Margin = new Padding(2);
            dtpLoc.Name = "dtpLoc";
            dtpLoc.Size = new Size(149, 31);
            dtpLoc.TabIndex = 0;
            dtpLoc.ValueChanged += dtpNgayNhap_ValueChanged;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1942, 970);
            ControlBox = false;
            Controls.Add(dgvHoaDon);
            Controls.Add(label2);
            Controls.Add(dtpLoc);
            Controls.Add(label1);
            Controls.Add(dgvChiTietHD);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmHoaDon";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnBoQua;
        private DateTimePicker dtpLoc;
    }
}