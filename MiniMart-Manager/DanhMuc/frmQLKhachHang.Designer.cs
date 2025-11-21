namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKhachHang));
            txtDiaChi = new TextBox();
            dgvKhachHang = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            txtHovaTen = new TextBox();
            txtMaKH = new TextBox();
            lblSDT = new Label();
            btnXuat = new Button();
            lblDiaChi = new Label();
            btnThoat = new Button();
            grbChucNang = new GroupBox();
            btnThem = new Button();
            lblTen = new Label();
            lblMaKH = new Label();
            grbThongTin = new GroupBox();
            txtSDT = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTenTK = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(782, 60);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(287, 87);
            txtDiaChi.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 356);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(1217, 645);
            dgvKhachHang.TabIndex = 13;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
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
            // txtHovaTen
            // 
            txtHovaTen.Location = new Point(189, 172);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(250, 34);
            txtHovaTen.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(189, 64);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(250, 34);
            txtMaKH.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(623, 172);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(136, 27);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "Số Điện Thoại";
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
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(623, 67);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(76, 27);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa Chỉ";
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
            grbChucNang.Location = new Point(1217, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(289, 909);
            grbChucNang.TabIndex = 15;
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
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(26, 172);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(100, 27);
            lblTen.TabIndex = 0;
            lblTen.Text = "Họ và Tên";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(27, 67);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(153, 27);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã Khách Hàng";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(txtSDT);
            grbThongTin.Controls.Add(txtHovaTen);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtMaKH);
            grbThongTin.Controls.Add(lblSDT);
            grbThongTin.Controls.Add(lblDiaChi);
            grbThongTin.Controls.Add(lblTen);
            grbThongTin.Controls.Add(lblMaKH);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1217, 264);
            grbThongTin.TabIndex = 14;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(782, 172);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 34);
            txtSDT.TabIndex = 1;
            txtSDT.TextChanged += txtSDT_TextChanged;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(809, 30);
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
            label1.Size = new Size(413, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1506, 92);
            panel1.TabIndex = 12;
            // 
            // frmQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 1001);
            Controls.Add(dgvKhachHang);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmQLKhachHang";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lí Khách Hàng";
            Load += frmQLKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDiaChi;
        private DataGridView dgvKhachHang;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtHovaTen;
        private TextBox txtMaKH;
        private Label lblSDT;
        private Button btnXuat;
        private Label lblDiaChi;
        private Button btnThoat;
        private GroupBox grbChucNang;
        private Button btnThem;
        private Label lblTen;
        private Label lblMaKH;
        private GroupBox grbThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTenTK;
        private Label label1;
        private Panel panel1;
        private TextBox txtSDT;
    }
}