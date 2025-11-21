namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiKhoan));
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMK = new TextBox();
            txtTenDN = new TextBox();
            grbChucNang = new GroupBox();
            btnThem = new Button();
            lblQuyen = new Label();
            lblTenDn = new Label();
            grbThongTin = new GroupBox();
            cbxQuyen = new ComboBox();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            lblMatKhau = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTenTK = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgvTaiKhoan = new DataGridView();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(60, 558);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(133, 50);
            btnThoat.TabIndex = 0;
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
            btnXuat.Location = new Point(60, 435);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(133, 50);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(60, 190);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 50);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(60, 313);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 50);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(151, 138);
            txtMK.Margin = new Padding(2);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(201, 30);
            txtMK.TabIndex = 1;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(151, 51);
            txtTenDN.Margin = new Padding(2);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(201, 30);
            txtTenDN.TabIndex = 1;
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(925, 74);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(231, 674);
            grbChucNang.TabIndex = 7;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(60, 68);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Location = new Point(498, 47);
            lblQuyen.Margin = new Padding(2, 0, 2, 0);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(61, 22);
            lblQuyen.TabIndex = 0;
            lblQuyen.Text = "Quyền";
            // 
            // lblTenDn
            // 
            lblTenDn.AutoSize = true;
            lblTenDn.Location = new Point(22, 54);
            lblTenDn.Margin = new Padding(2, 0, 2, 0);
            lblTenDn.Name = "lblTenDn";
            lblTenDn.Size = new Size(127, 22);
            lblTenDn.TabIndex = 0;
            lblTenDn.Text = "Tên Đăng Nhập";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(cbxQuyen);
            grbThongTin.Controls.Add(txtMaNV);
            grbThongTin.Controls.Add(txtMK);
            grbThongTin.Controls.Add(txtTenDN);
            grbThongTin.Controls.Add(lblMaNV);
            grbThongTin.Controls.Add(lblQuyen);
            grbThongTin.Controls.Add(lblMatKhau);
            grbThongTin.Controls.Add(lblTenDn);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 74);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(925, 211);
            grbThongTin.TabIndex = 6;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // cbxQuyen
            // 
            cbxQuyen.FormattingEnabled = true;
            cbxQuyen.Items.AddRange(new object[] { "Admin", "Staff" });
            cbxQuyen.Location = new Point(626, 47);
            cbxQuyen.Margin = new Padding(2);
            cbxQuyen.Name = "cbxQuyen";
            cbxQuyen.Size = new Size(123, 30);
            cbxQuyen.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(626, 138);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(189, 30);
            txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(498, 140);
            lblMaNV.Margin = new Padding(2, 0, 2, 0);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(119, 22);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(21, 138);
            lblMatKhau.Margin = new Padding(2, 0, 2, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(84, 22);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(646, 28);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(96, 22);
            lblTenTK.TabIndex = 0;
            lblTenTK.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(21, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tài Khoản";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 74);
            panel1.TabIndex = 4;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = SystemColors.Control;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 285);
            dgvTaiKhoan.Margin = new Padding(2);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.Size = new Size(925, 463);
            dgvTaiKhoan.TabIndex = 5;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // frmQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 748);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            Load += frmQLTaiKhoan_Load;
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMoTa;
        private TextBox txtMK;
        private TextBox txtTenDN;
        private GroupBox grbChucNang;
        private Button btnThem;
        private Label lblQuyen;
        private Label lblTenDn;
        private GroupBox grbThongTin;
        private Label lblMatKhau;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTenTK;
        private Label label1;
        private Panel panel1;
        private DataGridView dgvTaiKhoan;
        private ComboBox cbxQuyen;
        private TextBox txtMaNV;
        private Label lblMaNV;
    }
}