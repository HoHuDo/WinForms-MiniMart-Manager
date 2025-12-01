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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTaiKhoan));
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMK = new TextBox();
            txtTenDN = new TextBox();
            grbChucNang = new GroupBox();
            btnBoQua = new Button();
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
            txtTimMa = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(68, 696);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(166, 62);
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
            btnXuat.Location = new Point(68, 574);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(166, 62);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(68, 330);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(166, 62);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(68, 452);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(166, 62);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(189, 172);
            txtMK.Margin = new Padding(2);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(250, 34);
            txtMK.TabIndex = 1;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(189, 64);
            txtTenDN.Margin = new Padding(2);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(250, 34);
            txtTenDN.TabIndex = 1;
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnBoQua);
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(1156, 92);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(289, 843);
            grbChucNang.TabIndex = 7;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(68, 208);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(165, 62);
            btnBoQua.TabIndex = 1;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(68, 86);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(166, 62);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblQuyen
            // 
            lblQuyen.AutoSize = true;
            lblQuyen.Location = new Point(622, 59);
            lblQuyen.Margin = new Padding(2, 0, 2, 0);
            lblQuyen.Name = "lblQuyen";
            lblQuyen.Size = new Size(71, 27);
            lblQuyen.TabIndex = 0;
            lblQuyen.Text = "Quyền";
            // 
            // lblTenDn
            // 
            lblTenDn.AutoSize = true;
            lblTenDn.Location = new Point(28, 68);
            lblTenDn.Margin = new Padding(2, 0, 2, 0);
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
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
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
            cbxQuyen.Margin = new Padding(2);
            cbxQuyen.Name = "cbxQuyen";
            cbxQuyen.Size = new Size(153, 35);
            cbxQuyen.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(782, 172);
            txtMaNV.Margin = new Padding(2);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(235, 36);
            txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(622, 175);
            lblMaNV.Margin = new Padding(2, 0, 2, 0);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(137, 27);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(26, 172);
            lblMatKhau.Margin = new Padding(2, 0, 2, 0);
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
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
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
            label1.Margin = new Padding(2, 0, 2, 0);
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 92);
            panel1.TabIndex = 4;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = SystemColors.Control;
            dgvTaiKhoan.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dgvTaiKhoan.Location = new Point(0, 396);
            dgvTaiKhoan.Margin = new Padding(2);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaiKhoan.Size = new Size(1156, 539);
            dgvTaiKhoan.TabIndex = 5;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            dgvTaiKhoan.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // txtTimMa
            // 
            txtTimMa.Location = new Point(189, 6);
            txtTimMa.Name = "txtTimMa";
            txtTimMa.Size = new Size(250, 31);
            txtTimMa.TabIndex = 0;
            txtTimMa.TextChanged += txtTimMa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(37, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 27);
            label2.TabIndex = 0;
            label2.Text = "Tìm Theo Mã:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(txtTimMa);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(1156, 40);
            panel3.TabIndex = 17;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 3);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 0;
            // 
            // frmQLTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 935);
            ControlBox = false;
            Controls.Add(dgvTaiKhoan);
            Controls.Add(panel3);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLTaiKhoan";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmQLTaiKhoan_Load;
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private TextBox txtTimMa;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Button btnBoQua;
    }
}