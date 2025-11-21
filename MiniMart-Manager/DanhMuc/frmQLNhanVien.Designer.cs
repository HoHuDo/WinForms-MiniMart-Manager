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
            panel1.Name = "panel1";
            panel1.Size = new Size(1519, 92);
            panel1.TabIndex = 8;
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
            label1.Size = new Size(382, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(623, 165);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(104, 27);
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
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1230, 343);
            grbThongTin.TabIndex = 10;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // cbxGioiTinh
            // 
            cbxGioiTinh.FormattingEnabled = true;
            cbxGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbxGioiTinh.Location = new Point(228, 253);
            cbxGioiTinh.Name = "cbxGioiTinh";
            cbxGioiTinh.Size = new Size(182, 35);
            cbxGioiTinh.TabIndex = 4;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(782, 162);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(187, 34);
            dtpNgaySinh.TabIndex = 3;
            // 
            // txtHvT
            // 
            txtHvT.Location = new Point(228, 162);
            txtHvT.Name = "txtHvT";
            txtHvT.Size = new Size(287, 34);
            txtHvT.TabIndex = 1;
            // 
            // txtMaNv
            // 
            txtMaNv.Location = new Point(228, 64);
            txtMaNv.Name = "txtMaNv";
            txtMaNv.Size = new Size(287, 34);
            txtMaNv.TabIndex = 1;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(782, 67);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(287, 34);
            txtChucVu.TabIndex = 1;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(623, 62);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(89, 27);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức Vụ";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(26, 261);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(91, 27);
            lblGioiTinh.TabIndex = 0;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(26, 165);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(100, 27);
            lblTen.TabIndex = 0;
            lblTen.Text = "Họ và Tên";
            // 
            // lblMaNv
            // 
            lblMaNv.AutoSize = true;
            lblMaNv.Location = new Point(27, 67);
            lblMaNv.Name = "lblMaNv";
            lblMaNv.Size = new Size(137, 27);
            lblMaNv.TabIndex = 0;
            lblMaNv.Text = "Mã Nhân Viên";
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
            grbChucNang.Location = new Point(1230, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(289, 827);
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
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.Control;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 435);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 62;
            dgvNhanVien.Size = new Size(1230, 484);
            dgvNhanVien.TabIndex = 9;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // frmQLNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 919);
            Controls.Add(dgvNhanVien);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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