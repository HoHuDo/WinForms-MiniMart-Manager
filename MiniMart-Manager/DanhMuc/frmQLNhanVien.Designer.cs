namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            panel1 = new Panel();
            lblTenTK = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblNgaySinh = new Label();
            grbThongTin = new GroupBox();
            cbxGioiTinh = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtHvT = new TextBox();
            txtMaNv = new TextBox();
            txtChucVu = new TextBox();
            lblChucVu = new Label();
            lblGioiTinh = new Label();
            lblTen = new Label();
            lblMaNv = new Label();
            btnThem = new Button();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 74);
            panel1.TabIndex = 8;
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
            label1.Size = new Size(324, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(498, 132);
            lblNgaySinh.Margin = new Padding(2, 0, 2, 0);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(89, 22);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(cbxGioiTinh);
            grbThongTin.Controls.Add(dtpNgaySinh);
            grbThongTin.Controls.Add(txtHvT);
            grbThongTin.Controls.Add(txtMaNv);
            grbThongTin.Controls.Add(txtChucVu);
            grbThongTin.Controls.Add(lblNgaySinh);
            grbThongTin.Controls.Add(lblChucVu);
            grbThongTin.Controls.Add(lblGioiTinh);
            grbThongTin.Controls.Add(lblTen);
            grbThongTin.Controls.Add(lblMaNv);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 74);
            grbThongTin.Margin = new Padding(2, 2, 2, 2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2, 2, 2, 2);
            grbThongTin.Size = new Size(984, 274);
            grbThongTin.TabIndex = 10;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // cbxGioiTinh
            // 
            cbxGioiTinh.FormattingEnabled = true;
            cbxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbxGioiTinh.Location = new Point(182, 202);
            cbxGioiTinh.Margin = new Padding(2, 2, 2, 2);
            cbxGioiTinh.Name = "cbxGioiTinh";
            cbxGioiTinh.Size = new Size(146, 30);
            cbxGioiTinh.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(626, 130);
            dtpNgaySinh.Margin = new Padding(2, 2, 2, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(150, 30);
            dtpNgaySinh.TabIndex = 3;
            // 
            // txtHvT
            // 
            txtHvT.Location = new Point(182, 130);
            txtHvT.Margin = new Padding(2, 2, 2, 2);
            txtHvT.Name = "txtHvT";
            txtHvT.Size = new Size(230, 30);
            txtHvT.TabIndex = 1;
            // 
            // txtMaNv
            // 
            txtMaNv.Location = new Point(182, 51);
            txtMaNv.Margin = new Padding(2, 2, 2, 2);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(230, 30);
            txtMaNv.TabIndex = 1;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(626, 54);
            txtChucVu.Margin = new Padding(2, 2, 2, 2);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(230, 30);
            txtChucVu.TabIndex = 1;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(498, 50);
            lblChucVu.Margin = new Padding(2, 0, 2, 0);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(76, 22);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức Vụ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(21, 209);
            lblGioiTinh.Margin = new Padding(2, 0, 2, 0);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(77, 22);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(21, 132);
            lblTen.Margin = new Padding(2, 0, 2, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(84, 22);
            lblTen.TabIndex = 0;
            lblTen.Text = "Họ và Tên";
            // 
            // lblMaNv
            // 
            lblMaNv.AutoSize = true;
            lblMaNv.Location = new Point(22, 54);
            lblMaNv.Margin = new Padding(2, 0, 2, 0);
            lblMaNv.Name = "lblMaNv";
            lblMaNv.Size = new Size(119, 22);
            lblMaNv.TabIndex = 0;
            lblMaNv.Text = "Mã Nhân Viên";
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(60, 68);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(134, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
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
            grbChucNang.Location = new Point(984, 74);
            grbChucNang.Margin = new Padding(2, 2, 2, 2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2, 2, 2, 2);
            grbChucNang.Size = new Size(231, 661);
            grbChucNang.TabIndex = 11;
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
            btnThoat.Location = new Point(60, 558);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(134, 50);
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
            btnXuat.Margin = new Padding(2, 2, 2, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(134, 50);
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
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(134, 50);
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
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(134, 50);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.Control;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 348);
            dgvNhanVien.Margin = new Padding(2, 2, 2, 2);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(984, 387);
            dgvNhanVien.TabIndex = 9;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // frmQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 735);
            Controls.Add(dgvNhanVien);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmQLNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lí Nhân Viên";
            Load += frmQLNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTenTK;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public TextBox txtHovaTen { get; private set; }
        public TextBox txtMaNV { get; private set; }

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox txtTenLH;
        private TextBox txtMaLH;
        private Label lblNgaySinh;
        private GroupBox grbThongTin;
        private Label lblChucVu;
        private Label lblTen;
        private Label lblMaNv;
        private Button btnThem;
        private GroupBox grbChucNang;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvNhanVien;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtChucVu;
        private TextBox txtMaNv;
        private ComboBox cbxGioiTinh;
        private TextBox txtHvT;
        private Label lblGioiTinh;
    }
}