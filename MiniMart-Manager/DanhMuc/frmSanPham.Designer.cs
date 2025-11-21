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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1223, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(2, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 0;
            label1.Text = "Sản phẩm";
            label1.Click += label1_Click;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(792, 28);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(92, 22);
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
            grbThongTin.Location = new Point(0, 74);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(1009, 258);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnLoaiHang
            // 
            btnLoaiHang.Location = new Point(383, 135);
            btnLoaiHang.Margin = new Padding(2);
            btnLoaiHang.Name = "btnLoaiHang";
            btnLoaiHang.Size = new Size(106, 34);
            btnLoaiHang.TabIndex = 5;
            btnLoaiHang.Text = "Loại Hàng";
            btnLoaiHang.UseVisualStyleBackColor = true;
            btnLoaiHang.Click += btnLoaiHang_Click;
            // 
            // cbxLH
            // 
            cbxLH.FormattingEnabled = true;
            cbxLH.Location = new Point(185, 138);
            cbxLH.Margin = new Padding(2);
            cbxLH.Name = "cbxLH";
            cbxLH.Size = new Size(194, 30);
            cbxLH.TabIndex = 4;
            // 
            // cbxDonViTinh
            // 
            cbxDonViTinh.FormattingEnabled = true;
            cbxDonViTinh.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxDonViTinh.Location = new Point(185, 183);
            cbxDonViTinh.Margin = new Padding(2);
            cbxDonViTinh.Name = "cbxDonViTinh";
            cbxDonViTinh.Size = new Size(122, 30);
            cbxDonViTinh.TabIndex = 4;
            cbxDonViTinh.SelectedIndexChanged += cbxDonViTinh_SelectedIndexChanged;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(606, 144);
            txtGiaNhap.Margin = new Padding(2);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(162, 30);
            txtGiaNhap.TabIndex = 3;
            txtGiaNhap.KeyPress += txtSL_KeyPress;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(606, 97);
            txtSL.Margin = new Padding(2);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(69, 30);
            txtSL.TabIndex = 3;
            txtSL.KeyPress += txtSL_KeyPress;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(606, 49);
            txtGiaBan.Margin = new Padding(2);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(162, 30);
            txtGiaBan.TabIndex = 3;
            txtGiaBan.KeyPress += txtSL_KeyPress;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(185, 90);
            txtTenSP.Margin = new Padding(2);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(304, 30);
            txtTenSP.TabIndex = 3;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(185, 44);
            txtMaSP.Margin = new Padding(2);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(150, 30);
            txtMaSP.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 144);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 22);
            label8.TabIndex = 2;
            label8.Text = "Giá nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 97);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 22);
            label7.TabIndex = 2;
            label7.Text = "Số lượng ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 52);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 22);
            label6.TabIndex = 2;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 183);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 2;
            label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 22);
            label4.TabIndex = 2;
            label4.Text = "Mã loại hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 22);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // lblMaSp
            // 
            lblMaSp.AutoSize = true;
            lblMaSp.Location = new Point(31, 46);
            lblMaSp.Margin = new Padding(2, 0, 2, 0);
            lblMaSp.Name = "lblMaSp";
            lblMaSp.Size = new Size(114, 22);
            lblMaSp.TabIndex = 2;
            lblMaSp.Text = "Mã sản phẩm";
            // 
            // btnAnh
            // 
            btnAnh.BackColor = Color.FromArgb(192, 255, 255);
            btnAnh.FlatAppearance.BorderSize = 0;
            btnAnh.Location = new Point(792, 217);
            btnAnh.Margin = new Padding(2);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(174, 27);
            btnAnh.TabIndex = 1;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = false;
            btnAnh.Click += btnAnh_Click;
            // 
            // picAnh
            // 
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(792, 37);
            picAnh.Margin = new Padding(2);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(175, 168);
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
            grbChucNang.Location = new Point(1009, 74);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(214, 658);
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
            btnThoat.Location = new Point(39, 463);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(136, 52);
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
            btnXuat.Location = new Point(39, 368);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(136, 52);
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
            btnXoa.Location = new Point(39, 271);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(136, 52);
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
            btnSua.Location = new Point(39, 175);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(136, 52);
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
            btnThem.Location = new Point(39, 79);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(136, 52);
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
            dgvSanPham.Location = new Point(0, 332);
            dgvSanPham.Margin = new Padding(2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1009, 400);
            dgvSanPham.TabIndex = 3;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 732);
            Controls.Add(dgvSanPham);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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