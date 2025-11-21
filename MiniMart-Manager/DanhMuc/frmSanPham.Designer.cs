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
            btnThem = new Button();
            dgvSanPham = new DataGridView();
            panel1.SuspendLayout();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTenTK);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1529, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
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
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1297, 322);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnLoaiHang
            // 
            btnLoaiHang.Location = new Point(421, 172);
            btnLoaiHang.Name = "btnLoaiHang";
            btnLoaiHang.Size = new Size(112, 34);
            btnLoaiHang.TabIndex = 5;
            btnLoaiHang.Text = "Loại Hàng";
            btnLoaiHang.UseVisualStyleBackColor = true;
            btnLoaiHang.Click += btnLoaiHang_Click;
            // 
            // cbxLH
            // 
            cbxLH.FormattingEnabled = true;
            cbxLH.Location = new Point(231, 172);
            cbxLH.Name = "cbxLH";
            cbxLH.Size = new Size(151, 35);
            cbxLH.TabIndex = 4;
            // 
            // cbxDonViTinh
            // 
            cbxDonViTinh.FormattingEnabled = true;
            cbxDonViTinh.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxDonViTinh.Location = new Point(231, 229);
            cbxDonViTinh.Name = "cbxDonViTinh";
            cbxDonViTinh.Size = new Size(151, 35);
            cbxDonViTinh.TabIndex = 4;
            cbxDonViTinh.SelectedIndexChanged += cbxDonViTinh_SelectedIndexChanged;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(722, 177);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(201, 34);
            txtGiaNhap.TabIndex = 3;
            txtGiaNhap.KeyPress += txtSL_KeyPress;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(722, 119);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(85, 34);
            txtSL.TabIndex = 3;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(722, 59);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(201, 34);
            txtGiaBan.TabIndex = 3;
            txtGiaBan.KeyPress += txtSL_KeyPress;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(231, 112);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(302, 34);
            txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(231, 55);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(151, 34);
            txtMaSP.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 177);
            label8.Name = "label8";
            label8.Size = new Size(90, 27);
            label8.TabIndex = 2;
            label8.Text = "Giá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(605, 119);
            label7.Name = "label7";
            label7.Size = new Size(98, 27);
            label7.TabIndex = 2;
            label7.Text = "Số lượng ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 62);
            label6.Name = "label6";
            label6.Size = new Size(79, 27);
            label6.TabIndex = 2;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 229);
            label5.Name = "label5";
            label5.Size = new Size(109, 27);
            label5.TabIndex = 2;
            label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 172);
            label4.Name = "label4";
            label4.Size = new Size(126, 27);
            label4.TabIndex = 2;
            label4.Text = "Mã loại hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 115);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // lblMaSp
            // 
            lblMaSp.AutoSize = true;
            lblMaSp.Location = new Point(39, 58);
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
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(1297, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(232, 952);
            grbChucNang.TabIndex = 2;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = SystemColors.Desktop;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(49, 579);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 65);
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
            btnXuat.Location = new Point(49, 460);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 65);
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
            btnXoa.Location = new Point(49, 339);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 65);
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
            btnSua.Location = new Point(49, 219);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 65);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.ForeColor = SystemColors.Desktop;
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(49, 99);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 65);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.BackgroundColor = Color.WhiteSmoke;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 414);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1297, 630);
            dgvSanPham.TabIndex = 3;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 1044);
            Controls.Add(dgvSanPham);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
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
    }
}