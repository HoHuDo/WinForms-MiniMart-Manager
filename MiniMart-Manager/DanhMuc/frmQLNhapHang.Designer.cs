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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhapHang));
            panel1 = new Panel();
            lblTenTk = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvPhieuNhap = new DataGridView();
            dgvChiTietPN = new DataGridView();
            grbThongTin = new GroupBox();
            btnBoQua = new Button();
            btnReset = new Button();
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
            btnXoaCTPN = new Button();
            btnXoaPN = new Button();
            Tìm = new Button();
            btnSua = new Button();
            btnThemCTPN = new Button();
            btnThemPN = new Button();
            dtpLoc = new DateTimePicker();
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
            panel1.Size = new Size(1971, 138);
            panel1.TabIndex = 0;
            // 
            // lblTenTk
            // 
            lblTenTk.AutoSize = true;
            lblTenTk.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTk.Location = new Point(842, 58);
            lblTenTk.Margin = new Padding(2, 0, 2, 0);
            lblTenTk.Name = "lblTenTk";
            lblTenTk.Size = new Size(113, 27);
            lblTenTk.TabIndex = 0;
            lblTenTk.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(401, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhập Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 27);
            label2.TabIndex = 0;
            label2.Text = "Phiếu Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label3.Location = new Point(0, 609);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(189, 27);
            label3.TabIndex = 0;
            label3.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.WhiteSmoke;
            dgvPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.Dock = DockStyle.Fill;
            dgvPhieuNhap.Location = new Point(0, 165);
            dgvPhieuNhap.Margin = new Padding(2);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(825, 444);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // dgvChiTietPN
            // 
            dgvChiTietPN.AllowUserToAddRows = false;
            dgvChiTietPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPN.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietPN.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvChiTietPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvChiTietPN.DefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietPN.Dock = DockStyle.Bottom;
            dgvChiTietPN.Location = new Point(0, 636);
            dgvChiTietPN.Margin = new Padding(2);
            dgvChiTietPN.Name = "dgvChiTietPN";
            dgvChiTietPN.ReadOnly = true;
            dgvChiTietPN.RowHeadersVisible = false;
            dgvChiTietPN.RowHeadersWidth = 62;
            dgvChiTietPN.Size = new Size(825, 358);
            dgvChiTietPN.TabIndex = 2;
            dgvChiTietPN.CellClick += dgvChiTietPN_CellClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(btnBoQua);
            grbThongTin.Controls.Add(btnReset);
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
            grbThongTin.Location = new Point(825, 138);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(1146, 856);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(866, 537);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(118, 59);
            btnBoQua.TabIndex = 9;
            btnBoQua.Text = "      Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += button2_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(997, 537);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(59, 59);
            btnReset.TabIndex = 8;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.Snow;
            btnNhanVien.Location = new Point(226, 368);
            btnNhanVien.Margin = new Padding(2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(164, 36);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNV_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.Snow;
            btnSanPham.Location = new Point(829, 245);
            btnSanPham.Margin = new Padding(2);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(161, 36);
            btnSanPham.TabIndex = 6;
            btnSanPham.Text = "Sản Phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSP_Click;
            // 
            // btnNCC
            // 
            btnNCC.BackColor = Color.Snow;
            btnNCC.Location = new Point(226, 245);
            btnNCC.Margin = new Padding(2);
            btnNCC.Name = "btnNCC";
            btnNCC.Size = new Size(164, 36);
            btnNCC.TabIndex = 6;
            btnNCC.Text = "Nhà Cung Cấp";
            btnNCC.UseVisualStyleBackColor = false;
            btnNCC.Click += btnNCC_Click;
            // 
            // cbxMaNV
            // 
            cbxMaNV.FormattingEnabled = true;
            cbxMaNV.Location = new Point(226, 326);
            cbxMaNV.Margin = new Padding(2);
            cbxMaNV.Name = "cbxMaNV";
            cbxMaNV.Size = new Size(314, 35);
            cbxMaNV.TabIndex = 5;
            // 
            // cbxMaNCC
            // 
            cbxMaNCC.FormattingEnabled = true;
            cbxMaNCC.Location = new Point(226, 204);
            cbxMaNCC.Margin = new Padding(2);
            cbxMaNCC.Name = "cbxMaNCC";
            cbxMaNCC.Size = new Size(402, 35);
            cbxMaNCC.TabIndex = 5;
            // 
            // cbxMaSP
            // 
            cbxMaSP.FormattingEnabled = true;
            cbxMaSP.Location = new Point(829, 204);
            cbxMaSP.Margin = new Padding(2);
            cbxMaSP.Name = "cbxMaSP";
            cbxMaSP.Size = new Size(266, 35);
            cbxMaSP.TabIndex = 5;
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = " dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(226, 450);
            dtpNgayNhap.Margin = new Padding(2);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(255, 34);
            dtpNgayNhap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Enabled = false;
            txtTongTien.Location = new Point(226, 508);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(255, 34);
            txtTongTien.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(826, 441);
            txtThanhTien.Margin = new Padding(2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(214, 34);
            txtThanhTien.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(826, 384);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(173, 34);
            txtDonGia.TabIndex = 1;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            txtDonGia.KeyPress += txtSL_KeyPress;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(826, 320);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(106, 34);
            txtSL.TabIndex = 1;
            txtSL.TextChanged += txtSL_TextChanged;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(226, 80);
            txtMaPN.Margin = new Padding(2);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(199, 34);
            txtMaPN.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(679, 452);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(109, 27);
            label15.TabIndex = 0;
            label15.Text = "Thành Tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(679, 388);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(136, 27);
            label13.TabIndex = 0;
            label13.Text = "Đơn Giá Nhập";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(679, 328);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(98, 27);
            label11.TabIndex = 0;
            label11.Text = "Số Lượng";
            label11.Click += label11_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(679, 208);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(133, 27);
            label9.TabIndex = 0;
            label9.Text = "Mã Sản Phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 515);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(101, 27);
            label14.TabIndex = 0;
            label14.Text = "Tổng Tiền";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 451);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(113, 27);
            label12.TabIndex = 0;
            label12.Text = "Ngày Nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 332);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(137, 27);
            label10.TabIndex = 0;
            label10.Text = "Mã Nhân Viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 208);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 27);
            label8.TabIndex = 0;
            label8.Text = "Mã Nhà Cung Cấp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(679, 144);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(189, 27);
            label7.TabIndex = 0;
            label7.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(18, 144);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 27);
            label6.TabIndex = 0;
            label6.Text = "Phiếu Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 0;
            label5.Text = "Mã Phiếu Nhập";
            label5.Click += label5_Click;
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnXoaCTPN);
            grbChucNang.Controls.Add(btnXoaPN);
            grbChucNang.Controls.Add(Tìm);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThemCTPN);
            grbChucNang.Controls.Add(btnThemPN);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(2, 618);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(1142, 236);
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
            btnThoat.Location = new Point(864, 132);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(190, 69);
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
            btnXuat.Location = new Point(606, 132);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(190, 69);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "      Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnXoaCTPN
            // 
            btnXoaCTPN.BackColor = Color.FromArgb(255, 224, 192);
            btnXoaCTPN.Image = Properties.Resources.delete;
            btnXoaCTPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaCTPN.Location = new Point(349, 132);
            btnXoaCTPN.Margin = new Padding(2);
            btnXoaCTPN.Name = "btnXoaCTPN";
            btnXoaCTPN.Size = new Size(190, 69);
            btnXoaCTPN.TabIndex = 0;
            btnXoaCTPN.Text = "     Xóa CTPN";
            btnXoaCTPN.UseVisualStyleBackColor = false;
            btnXoaCTPN.Click += btnXoaCTPN_Click;
            // 
            // btnXoaPN
            // 
            btnXoaPN.BackColor = Color.FromArgb(255, 192, 192);
            btnXoaPN.Image = Properties.Resources.delete;
            btnXoaPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaPN.Location = new Point(92, 132);
            btnXoaPN.Margin = new Padding(2);
            btnXoaPN.Name = "btnXoaPN";
            btnXoaPN.Size = new Size(190, 69);
            btnXoaPN.TabIndex = 0;
            btnXoaPN.Text = "Xóa PN";
            btnXoaPN.UseVisualStyleBackColor = false;
            btnXoaPN.Click += btnXoaPN_Click;
            // 
            // Tìm
            // 
            Tìm.Image = Properties.Resources.loupe;
            Tìm.ImageAlign = ContentAlignment.MiddleLeft;
            Tìm.Location = new Point(864, 32);
            Tìm.Margin = new Padding(2);
            Tìm.Name = "Tìm";
            Tìm.Size = new Size(190, 69);
            Tìm.TabIndex = 0;
            Tìm.Text = "Tìm";
            Tìm.UseVisualStyleBackColor = true;
            Tìm.Click += Tìm_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(606, 32);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(190, 69);
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
            btnThemCTPN.Location = new Point(349, 32);
            btnThemCTPN.Margin = new Padding(2);
            btnThemCTPN.Name = "btnThemCTPN";
            btnThemCTPN.Size = new Size(190, 69);
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
            btnThemPN.Location = new Point(92, 32);
            btnThemPN.Margin = new Padding(2);
            btnThemPN.Name = "btnThemPN";
            btnThemPN.Size = new Size(190, 69);
            btnThemPN.TabIndex = 0;
            btnThemPN.Text = "   Thêm PN";
            btnThemPN.UseVisualStyleBackColor = false;
            btnThemPN.Click += btnThemPN_Click;
            // 
            // dtpLoc
            // 
            dtpLoc.CustomFormat = "MM/yyyy";
            dtpLoc.Format = DateTimePickerFormat.Custom;
            dtpLoc.Location = new Point(696, 134);
            dtpLoc.Name = "dtpLoc";
            dtpLoc.Size = new Size(129, 31);
            dtpLoc.TabIndex = 4;
            dtpLoc.ValueChanged += dtpLoc_ValueChanged;
            // 
            // frmQLNhapHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1971, 994);
            ControlBox = false;
            Controls.Add(dtpLoc);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvChiTietPN);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLNhapHang";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnXoaCTPN;
        private Button btnReset;
        private Button btnBoQua;
        private DateTimePicker dtpLoc;
    }
}