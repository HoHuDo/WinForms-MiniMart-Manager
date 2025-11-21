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
            btnThoat.Location = new Point(75, 697);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 62);
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
            btnXuat.Location = new Point(75, 544);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(150, 62);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(75, 238);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 62);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(75, 391);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 62);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(189, 172);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(250, 34);
            txtMK.TabIndex = 1;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(189, 64);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(250, 34);
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
            grbChucNang.Location = new Point(1156, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(289, 843);
            grbChucNang.TabIndex = 7;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(75, 85);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 62);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Location = new Point(623, 59);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(71, 27);
            lblQuyen.TabIndex = 0;
            lblQuyen.Text = "Quyền";
            // 
            // lblTenDn
            // 
            lblTenDn.AutoSize = true;
            lblTenDn.Location = new Point(27, 67);
            lblTenDn.Name = "lblTenDn";
            lblTenDn.Size = new Size(148, 27);
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
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1156, 264);
            grbThongTin.TabIndex = 6;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // cbxQuyen
            // 
            cbxQuyen.FormattingEnabled = true;
            cbxQuyen.Items.AddRange(new object[] { "Admin", "Staff" });
            cbxQuyen.Location = new Point(782, 59);
            cbxQuyen.Name = "cbxQuyen";
            cbxQuyen.Size = new Size(148, 35);
            cbxQuyen.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(782, 177);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(148, 27);
            txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(623, 175);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(137, 27);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(26, 172);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(97, 27);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(808, 35);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(113, 27);
            lblTenTK.TabIndex = 0;
            lblTenTK.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 53);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 92);
            panel1.TabIndex = 4;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = SystemColors.Control;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 356);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 62;
            dgvTaiKhoan.Size = new Size(1156, 579);
            dgvTaiKhoan.TabIndex = 5;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // frmQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 935);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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