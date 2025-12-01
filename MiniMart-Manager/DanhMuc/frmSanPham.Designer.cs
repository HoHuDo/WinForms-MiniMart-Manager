namespace MiniMart_Manager.DanhMuc
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            panel1 = new Panel();
            label1 = new Label();
            lblTenTK = new Label();
            grbThongTin = new GroupBox();
            btnLoaiHang = new Button();
            cbxLH = new ComboBox();
            cbxDonViTinh = new ComboBox();
            txtGiaNhap = new TextBox();
            txtSL = new TextBox();
            txtGiaBan = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblMaSp = new Label();
            btnAnh = new Button();
            picAnh = new PictureBox();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnBoQua = new Button();
            btnThem = new Button();
            dgvSanPham = new DataGridView();
            panel2 = new Panel();
            lblTongSL = new Label();
            label10 = new Label();
            cbxTimLoaiHang = new ComboBox();
            label9 = new Label();
            label2 = new Label();
            txtTimTen = new TextBox();
            lblCurrentPage = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPrePage = new Button();
            btnFirstPage = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTenTK);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1529, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(2, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 53);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            label1.Click += label1_Click;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(990, 35);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(108, 27);
            lblTenTK.TabIndex = 2;
            lblTenTK.Text = "UserName";
            lblTenTK.Click += lblTenTK_Click;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(btnLoaiHang);
            grbThongTin.Controls.Add(cbxLH);
            grbThongTin.Controls.Add(cbxDonViTinh);
            grbThongTin.Controls.Add(txtGiaNhap);
            grbThongTin.Controls.Add(txtSL);
            grbThongTin.Controls.Add(txtGiaBan);
            grbThongTin.Controls.Add(txtTenSP);
            grbThongTin.Controls.Add(txtMaSP);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(lblMaSp);
            grbThongTin.Controls.Add(btnAnh);
            grbThongTin.Controls.Add(picAnh);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(1261, 322);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnLoaiHang
            // 
            btnLoaiHang.Location = new Point(479, 169);
            btnLoaiHang.Margin = new Padding(2);
            btnLoaiHang.Name = "btnLoaiHang";
            btnLoaiHang.Size = new Size(132, 42);
            btnLoaiHang.TabIndex = 5;
            btnLoaiHang.Text = "Loại Hàng";
            btnLoaiHang.UseVisualStyleBackColor = true;
            btnLoaiHang.Click += btnLoaiHang_Click;
            // 
            // cbxLH
            // 
            cbxLH.FormattingEnabled = true;
            cbxLH.Location = new Point(231, 172);
            cbxLH.Margin = new Padding(2);
            cbxLH.Name = "cbxLH";
            cbxLH.Size = new Size(242, 35);
            cbxLH.TabIndex = 4;
            cbxLH.SelectedIndexChanged += cbxLH_SelectedIndexChanged;
            // 
            // cbxDonViTinh
            // 
            cbxDonViTinh.FormattingEnabled = true;
            cbxDonViTinh.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxDonViTinh.Location = new Point(231, 229);
            cbxDonViTinh.Margin = new Padding(2);
            cbxDonViTinh.Name = "cbxDonViTinh";
            cbxDonViTinh.Size = new Size(152, 35);
            cbxDonViTinh.TabIndex = 4;
            cbxDonViTinh.SelectedIndexChanged += cbxDonViTinh_SelectedIndexChanged;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(758, 180);
            txtGiaNhap.Margin = new Padding(2);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(202, 34);
            txtGiaNhap.TabIndex = 3;
            txtGiaNhap.KeyPress += txtSL_KeyPress;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(758, 121);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(85, 34);
            txtSL.TabIndex = 3;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(758, 61);
            txtGiaBan.Margin = new Padding(2);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(202, 34);
            txtGiaBan.TabIndex = 3;
            txtGiaBan.KeyPress += txtSL_KeyPress;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(231, 112);
            txtTenSP.Margin = new Padding(2);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(379, 34);
            txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(231, 55);
            txtMaSP.Margin = new Padding(2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(242, 34);
            txtMaSP.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(640, 180);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 2;
            label8.Text = "Giá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(640, 121);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 27);
            label7.TabIndex = 2;
            label7.Text = "Số lượng ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(640, 65);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 27);
            label6.TabIndex = 2;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 229);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 27);
            label5.TabIndex = 2;
            label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 172);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 27);
            label4.TabIndex = 2;
            label4.Text = "Loại hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 115);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // lblMaSp
            // 
            lblMaSp.AutoSize = true;
            lblMaSp.Location = new Point(39, 58);
            lblMaSp.Margin = new Padding(2, 0, 2, 0);
            lblMaSp.Name = "lblMaSp";
            lblMaSp.Size = new Size(131, 27);
            lblMaSp.TabIndex = 2;
            lblMaSp.Text = "Mã sản phẩm";
            // 
            // btnAnh
            // 
            btnAnh.BackColor = Color.FromArgb(192, 255, 255);
            btnAnh.FlatAppearance.BorderSize = 0;
            btnAnh.Location = new Point(990, 271);
            btnAnh.Margin = new Padding(2);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(218, 34);
            btnAnh.TabIndex = 1;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = false;
            btnAnh.Click += btnAnh_Click;
            // 
            // picAnh
            // 
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(990, 46);
            picAnh.Margin = new Padding(2);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(218, 210);
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.TabIndex = 0;
            picAnh.TabStop = false;
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnBoQua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(1261, 92);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(268, 823);
            grbChucNang.TabIndex = 2;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            grbChucNang.Enter += grbChucNang_Enter;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = SystemColors.Desktop;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(53, 683);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(170, 65);
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
            btnXuat.ForeColor = SystemColors.Desktop;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(53, 563);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(170, 65);
            btnXuat.TabIndex = 1;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = SystemColors.Desktop;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(53, 443);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(170, 65);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.ForeColor = SystemColors.Desktop;
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(53, 323);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 65);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.BackColor = Color.White;
            btnBoQua.FlatStyle = FlatStyle.Popup;
            btnBoQua.ForeColor = SystemColors.Desktop;
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(53, 203);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(170, 65);
            btnBoQua.TabIndex = 0;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = false;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.ForeColor = SystemColors.Desktop;
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(53, 83);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(170, 65);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(0, 480);
            dgvSanPham.Margin = new Padding(2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1261, 389);
            dgvSanPham.TabIndex = 3;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(lblTongSL);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbxTimLoaiHang);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTimTen);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 414);
            panel2.Name = "panel2";
            panel2.Size = new Size(1261, 66);
            panel2.TabIndex = 7;
            // 
            // lblTongSL
            // 
            lblTongSL.AutoSize = true;
            lblTongSL.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSL.Location = new Point(1135, 19);
            lblTongSL.Name = "lblTongSL";
            lblTongSL.Size = new Size(20, 24);
            lblTongSL.TabIndex = 1;
            lblTongSL.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(470, 18);
            label10.Name = "label10";
            label10.Size = new Size(109, 27);
            label10.TabIndex = 0;
            label10.Text = "Danh Mục:";
            // 
            // cbxTimLoaiHang
            // 
            cbxTimLoaiHang.FormattingEnabled = true;
            cbxTimLoaiHang.Location = new Point(584, 15);
            cbxTimLoaiHang.Margin = new Padding(2);
            cbxTimLoaiHang.Name = "cbxTimLoaiHang";
            cbxTimLoaiHang.Size = new Size(273, 33);
            cbxTimLoaiHang.TabIndex = 4;
            cbxTimLoaiHang.SelectedIndexChanged += cbxTimLoaiHang_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 18);
            label9.Name = "label9";
            label9.Size = new Size(49, 27);
            label9.TabIndex = 0;
            label9.Text = "Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(990, 18);
            label2.Name = "label2";
            label2.Size = new Size(139, 27);
            label2.TabIndex = 0;
            label2.Text = "Tổng Số Loại :";
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(109, 16);
            txtTimTen.Margin = new Padding(2);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(274, 31);
            txtTimTen.TabIndex = 3;
            txtTimTen.TextChanged += txtTimTen_TextChanged;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPage.Location = new Point(534, 10);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(38, 24);
            lblCurrentPage.TabIndex = 1;
            lblCurrentPage.Text = "0/0";
            // 
            // btnLastPage
            // 
            btnLastPage.Cursor = Cursors.Hand;
            btnLastPage.FlatAppearance.BorderSize = 0;
            btnLastPage.FlatStyle = FlatStyle.Flat;
            btnLastPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLastPage.ForeColor = Color.DodgerBlue;
            btnLastPage.Location = new Point(708, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(50, 34);
            btnLastPage.TabIndex = 0;
            btnLastPage.Text = ">>";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnTrangCuoi_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Cursor = Cursors.Hand;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.ForeColor = Color.DodgerBlue;
            btnNextPage.Location = new Point(652, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(50, 34);
            btnNextPage.TabIndex = 0;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnSau_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Cursor = Cursors.Hand;
            btnPrePage.FlatAppearance.BorderSize = 0;
            btnPrePage.FlatStyle = FlatStyle.Flat;
            btnPrePage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrePage.ForeColor = Color.DodgerBlue;
            btnPrePage.Location = new Point(478, 3);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(50, 34);
            btnPrePage.TabIndex = 0;
            btnPrePage.Text = "<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnTruoc_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Cursor = Cursors.Hand;
            btnFirstPage.FlatAppearance.BorderSize = 0;
            btnFirstPage.FlatStyle = FlatStyle.Flat;
            btnFirstPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirstPage.ForeColor = Color.DodgerBlue;
            btnFirstPage.Location = new Point(422, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(50, 34);
            btnFirstPage.TabIndex = 0;
            btnFirstPage.Text = "<<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnTrangDau_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(lblCurrentPage);
            panel3.Controls.Add(btnLastPage);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnPrePage);
            panel3.Controls.Add(btnFirstPage);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 869);
            panel3.Name = "panel3";
            panel3.Size = new Size(1261, 46);
            panel3.TabIndex = 8;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 915);
            ControlBox = false;
            Controls.Add(dgvSanPham);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmSanPham";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private DataGridView dgvSanPham;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private PictureBox picAnh;
        private Button btnAnh;
        private Button btnThoat;
        private Button btnXuat;
        private Label label4;
        private Label label3;
        private Label lblMaSp;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblTenTK;
        private ComboBox cbxDonViTinh;
        private TextBox txtGiaNhap;
        private TextBox txtSL;
        private TextBox txtGiaBan;
        private TextBox txtTenSP;
        private TextBox txtMaSP;
        private ComboBox cbxLH;
        private Button btnLoaiHang;
        private Button btnBoQua;
        private Panel panel2;
        private Label lblTongSL;
        private Label label10;
        private ComboBox cbxTimLoaiHang;
        private Label label9;
        private Label label2;
        private TextBox txtTimTen;
        private Label lblCurrentPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPrePage;
        private Button btnFirstPage;
        private Panel panel3;
    }
}