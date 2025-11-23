namespace MiniMart_Manager.DanhMuc
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            grbThongTin = new GroupBox();
            btnSĐT = new Button();
            btnKhachHang = new Button();
            cbxSP = new ComboBox();
            cbxKhachHang = new ComboBox();
            cbxDonVi = new ComboBox();
            txtSĐT = new TextBox();
            txtĐc = new TextBox();
            txtGia = new TextBox();
            txtSlBan = new TextBox();
            txtMHD = new TextBox();
            txtSlTrongKho = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label10 = new Label();
            lblThanhTien = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label14 = new Label();
            label15 = new Label();
            label6 = new Label();
            label3 = new Label();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            grbChucNang = new GroupBox();
            btnXuatE = new Button();
            btnNewHĐ = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblTenTK = new Label();
            dgvChiTietDH = new DataGridView();
            dgvSanPham = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            lblTong = new Label();
            panel3 = new Panel();
            cbxDanhMuc = new ComboBox();
            txtTenSp = new TextBox();
            label17 = new Label();
            label16 = new Label();
            panel2 = new Panel();
            lblTongSL = new Label();
            txtGiamGia = new TextBox();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = Color.White;
            grbThongTin.Controls.Add(btnSĐT);
            grbThongTin.Controls.Add(btnKhachHang);
            grbThongTin.Controls.Add(cbxSP);
            grbThongTin.Controls.Add(cbxKhachHang);
            grbThongTin.Controls.Add(cbxDonVi);
            grbThongTin.Controls.Add(txtSĐT);
            grbThongTin.Controls.Add(txtĐc);
            grbThongTin.Controls.Add(txtGia);
            grbThongTin.Controls.Add(txtGiamGia);
            grbThongTin.Controls.Add(txtSlBan);
            grbThongTin.Controls.Add(txtMHD);
            grbThongTin.Controls.Add(txtSlTrongKho);
            grbThongTin.Controls.Add(label19);
            grbThongTin.Controls.Add(label18);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(lblThanhTien);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label14);
            grbThongTin.Controls.Add(label15);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(grbChucNang);
            grbThongTin.Dock = DockStyle.Right;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(871, 131);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(993, 823);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnSĐT
            // 
            btnSĐT.Image = Properties.Resources.loupe;
            btnSĐT.Location = new Point(916, 217);
            btnSĐT.Margin = new Padding(2);
            btnSĐT.Name = "btnSĐT";
            btnSĐT.Size = new Size(42, 45);
            btnSĐT.TabIndex = 10;
            btnSĐT.UseVisualStyleBackColor = true;
            btnSĐT.Click += btnSDT_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Image = Properties.Resources.people;
            btnKhachHang.Location = new Point(916, 40);
            btnKhachHang.Margin = new Padding(2);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(59, 49);
            btnKhachHang.TabIndex = 10;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // cbxSP
            // 
            cbxSP.FormattingEnabled = true;
            cbxSP.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxSP.Location = new Point(206, 110);
            cbxSP.Margin = new Padding(2);
            cbxSP.Name = "cbxSP";
            cbxSP.Size = new Size(286, 35);
            cbxSP.TabIndex = 6;
            cbxSP.SelectedIndexChanged += cbxSP_SelectedIndexChanged_1;
            // 
            // cbxKhachHang
            // 
            cbxKhachHang.FormattingEnabled = true;
            cbxKhachHang.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxKhachHang.Location = new Point(639, 48);
            cbxKhachHang.Margin = new Padding(2);
            cbxKhachHang.Name = "cbxKhachHang";
            cbxKhachHang.Size = new Size(273, 35);
            cbxKhachHang.TabIndex = 6;
            cbxKhachHang.SelectedIndexChanged += cbxKhachHang_SelectedIndexChanged;
            // 
            // cbxDonVi
            // 
            cbxDonVi.Enabled = false;
            cbxDonVi.FormattingEnabled = true;
            cbxDonVi.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxDonVi.Location = new Point(206, 169);
            cbxDonVi.Margin = new Padding(2);
            cbxDonVi.Name = "cbxDonVi";
            cbxDonVi.Size = new Size(123, 35);
            cbxDonVi.TabIndex = 6;
            // 
            // txtSĐT
            // 
            txtSĐT.Location = new Point(639, 217);
            txtSĐT.Margin = new Padding(2);
            txtSĐT.Multiline = true;
            txtSĐT.Name = "txtSĐT";
            txtSĐT.Size = new Size(273, 45);
            txtSĐT.TabIndex = 5;
            txtSĐT.TextChanged += textBox4_TextChanged;
            txtSĐT.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtĐc
            // 
            txtĐc.Enabled = false;
            txtĐc.Location = new Point(639, 111);
            txtĐc.Margin = new Padding(2);
            txtĐc.Multiline = true;
            txtĐc.Name = "txtĐc";
            txtĐc.Size = new Size(273, 92);
            txtĐc.TabIndex = 5;
            txtĐc.TextChanged += textBox4_TextChanged;
            txtĐc.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Location = new Point(206, 228);
            txtGia.Margin = new Padding(2);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(206, 34);
            txtGia.TabIndex = 5;
            txtGia.Text = "0";
            txtGia.TextAlign = HorizontalAlignment.Right;
            txtGia.TextChanged += textBox4_TextChanged;
            txtGia.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtSlBan
            // 
            txtSlBan.Location = new Point(206, 339);
            txtSlBan.Margin = new Padding(2);
            txtSlBan.Name = "txtSlBan";
            txtSlBan.Size = new Size(83, 34);
            txtSlBan.TabIndex = 5;
            txtSlBan.Text = "0";
            txtSlBan.TextAlign = HorizontalAlignment.Right;
            txtSlBan.TextChanged += textBox4_TextChanged;
            txtSlBan.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtMHD
            // 
            txtMHD.Enabled = false;
            txtMHD.Location = new Point(208, 55);
            txtMHD.Margin = new Padding(2);
            txtMHD.Name = "txtMHD";
            txtMHD.Size = new Size(191, 34);
            txtMHD.TabIndex = 5;
            txtMHD.TextChanged += textBox4_TextChanged;
            txtMHD.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtSlTrongKho
            // 
            txtSlTrongKho.Enabled = false;
            txtSlTrongKho.Location = new Point(206, 286);
            txtSlTrongKho.Margin = new Padding(2);
            txtSlTrongKho.Name = "txtSlTrongKho";
            txtSlTrongKho.Size = new Size(83, 34);
            txtSlTrongKho.TabIndex = 5;
            txtSlTrongKho.Text = "0";
            txtSlTrongKho.TextAlign = HorizontalAlignment.Right;
            txtSlTrongKho.TextChanged += textBox4_TextChanged;
            txtSlTrongKho.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(416, 231);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(54, 27);
            label19.TabIndex = 4;
            label19.Text = "VNĐ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(416, 461);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(54, 27);
            label18.TabIndex = 4;
            label18.Text = "VNĐ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 401);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(29, 27);
            label10.TabIndex = 4;
            label10.Text = "%";
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Enabled = false;
            lblThanhTien.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThanhTien.Location = new Point(206, 460);
            lblThanhTien.Margin = new Padding(2, 0, 2, 0);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(206, 30);
            lblThanhTien.TabIndex = 4;
            lblThanhTien.Text = "0";
            lblThanhTien.TextAlign = ContentAlignment.MiddleRight;
            lblThanhTien.Click += lblThanhTien_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 464);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 27);
            label9.TabIndex = 4;
            label9.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 405);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 27);
            label8.TabIndex = 4;
            label8.Text = "Chiết khấu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 346);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 27);
            label7.TabIndex = 4;
            label7.Text = "SL bán";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(503, 228);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(136, 27);
            label14.TabIndex = 4;
            label14.Text = "Số Điện Thoại";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 56);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(123, 27);
            label15.TabIndex = 4;
            label15.Text = "Mã Hóa Đơn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 287);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 27);
            label6.TabIndex = 4;
            label6.Text = "SL trong kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 27);
            label3.TabIndex = 4;
            label3.Text = "Địa Chỉ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(503, 51);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(120, 27);
            label13.TabIndex = 4;
            label13.Text = "Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 228);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 27);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 169);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 27);
            label4.TabIndex = 4;
            label4.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 4;
            label2.Text = "Sản phẩm";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnXuatE);
            grbChucNang.Controls.Add(btnNewHĐ);
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(button1);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Location = new Point(2, 529);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(989, 292);
            grbChucNang.TabIndex = 3;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức năng";
            // 
            // btnXuatE
            // 
            btnXuatE.BackColor = Color.FromArgb(192, 255, 192);
            btnXuatE.FlatAppearance.BorderSize = 0;
            btnXuatE.FlatStyle = FlatStyle.Flat;
            btnXuatE.Image = Properties.Resources.excel;
            btnXuatE.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatE.Location = new Point(401, 171);
            btnXuatE.Margin = new Padding(2);
            btnXuatE.Name = "btnXuatE";
            btnXuatE.Size = new Size(178, 80);
            btnXuatE.TabIndex = 0;
            btnXuatE.Text = "       In Hóa Đơn";
            btnXuatE.UseVisualStyleBackColor = false;
            btnXuatE.Click += btnXuatE_Click;
            // 
            // btnNewHĐ
            // 
            btnNewHĐ.Image = Properties.Resources.add;
            btnNewHĐ.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewHĐ.Location = new Point(134, 171);
            btnNewHĐ.Margin = new Padding(2);
            btnNewHĐ.Name = "btnNewHĐ";
            btnNewHĐ.Size = new Size(178, 80);
            btnNewHĐ.TabIndex = 0;
            btnNewHĐ.Text = "    Hóa Đơn Mới";
            btnNewHĐ.UseVisualStyleBackColor = true;
            btnNewHĐ.Click += btnNewHĐ_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 128);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(689, 171);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(178, 80);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.delete;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(689, 55);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(178, 80);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(401, 55);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(178, 80);
            btnSua.TabIndex = 0;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.more;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(134, 55);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(178, 80);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(11, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 53);
            label1.TabIndex = 0;
            label1.Text = "Bán Hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 131);
            panel1.TabIndex = 2;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(873, 66);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(108, 27);
            lblTenTK.TabIndex = 1;
            lblTenTK.Text = "UserName";
            // 
            // dgvChiTietDH
            // 
            dgvChiTietDH.AllowUserToAddRows = false;
            dgvChiTietDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDH.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDH.Dock = DockStyle.Bottom;
            dgvChiTietDH.Location = new Point(0, 679);
            dgvChiTietDH.Margin = new Padding(2);
            dgvChiTietDH.Name = "dgvChiTietDH";
            dgvChiTietDH.RowHeadersWidth = 62;
            dgvChiTietDH.Size = new Size(871, 238);
            dgvChiTietDH.TabIndex = 4;
            dgvChiTietDH.CellClick += dgvChiTietDH_CellClick;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.WhiteSmoke;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 214);
            dgvSanPham.Margin = new Padding(2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(871, 438);
            dgvSanPham.TabIndex = 10;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label11.Location = new Point(11, 2);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 27);
            label11.TabIndex = 11;
            label11.Text = "Sản phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Bottom;
            label12.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label12.Location = new Point(0, 652);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(173, 27);
            label12.TabIndex = 12;
            label12.Text = "Chi Tiết Đơn hàng";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTong.Location = new Point(11, 5);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(112, 28);
            lblTong.TabIndex = 13;
            lblTong.Text = "Tổng Tiền:";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbxDanhMuc);
            panel3.Controls.Add(txtTenSp);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(871, 83);
            panel3.TabIndex = 14;
            // 
            // cbxDanhMuc
            // 
            cbxDanhMuc.FormattingEnabled = true;
            cbxDanhMuc.Location = new Point(571, 30);
            cbxDanhMuc.Name = "cbxDanhMuc";
            cbxDanhMuc.Size = new Size(245, 33);
            cbxDanhMuc.TabIndex = 13;
            cbxDanhMuc.SelectedIndexChanged += cbxDanhMuc_SelectedIndexChanged;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(150, 31);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(260, 31);
            txtTenSp.TabIndex = 12;
            txtTenSp.TextChanged += txtTenSp_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label17.Location = new Point(463, 31);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(103, 27);
            label17.TabIndex = 11;
            label17.Text = "Danh Mục";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label16.Location = new Point(97, 32);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(48, 27);
            label16.TabIndex = 11;
            label16.Text = "Tên:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTongSL);
            panel2.Controls.Add(lblTong);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 917);
            panel2.Name = "panel2";
            panel2.Size = new Size(871, 37);
            panel2.TabIndex = 15;
            // 
            // lblTongSL
            // 
            lblTongSL.AutoSize = true;
            lblTongSL.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSL.Location = new Point(276, 5);
            lblTongSL.Name = "lblTongSL";
            lblTongSL.Size = new Size(92, 28);
            lblTongSL.TabIndex = 13;
            lblTongSL.Text = "Tổng SL:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(206, 398);
            txtGiamGia.Margin = new Padding(2);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(83, 34);
            txtGiamGia.TabIndex = 5;
            txtGiamGia.Text = "0";
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            txtGiamGia.TextChanged += textBox4_TextChanged;
            txtGiamGia.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1864, 954);
            Controls.Add(dgvSanPham);
            Controls.Add(panel3);
            Controls.Add(label12);
            Controls.Add(dgvChiTietDH);
            Controls.Add(panel2);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(366, 35);
            Margin = new Padding(2);
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            FormClosing += frmBanHang_FormClosing;
            Load += frmBanHang_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvChiTietDH;
        private DataGridView dgvSanPham;
        private Label lblThanhTien;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txtSlTrongKho;
        private TextBox txtGia;
        private ComboBox cbxDonVi;
        private TextBox txtSlBan;
        private Label label10;
        private Button btnXuatE;
        private Button btnNewHĐ;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button button1;
        private Label label11;
        private Label label12;
        private Label lblTenTK;
        private Button btnKhachHang;
        private ComboBox cbxKhachHang;
        private Label label13;
        private ComboBox cbxSP;
        private Label lblTong;
        private TextBox txtSĐT;
        private TextBox txtĐc;
        private Label label14;
        private Label label3;
        private TextBox txtMHD;
        private Label label15;
        private Panel panel3;
        private ComboBox cbxDanhMuc;
        private TextBox txtTenSp;
        private Label label17;
        private Label label16;
        private Label label18;
        private Label label19;
        private Button btnSĐT;
        private Panel panel2;
        private Label lblTongSL;
        private TextBox txtGiamGia;
    }
}