namespace MiniMart_Manager.DanhMuc
{
    partial class frmLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiHang));
            panel1 = new Panel();
            lblTenTK = new Label();
            label1 = new Label();
            dgvLoaiHang = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbThongTin = new GroupBox();
            txtMoTa = new TextBox();
            txtTenLH = new TextBox();
            txtMaLH = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lblMa = new Label();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBoQua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            lblTongSLoai = new Label();
            txtTimTen = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1226, 92);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(375, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Loại Hàng";
            label1.Click += label1_Click;
            // 
            // dgvLoaiHang
            // 
            dgvLoaiHang.AllowUserToAddRows = false;
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.BackgroundColor = SystemColors.Control;
            dgvLoaiHang.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiHang.Dock = DockStyle.Fill;
            dgvLoaiHang.EnableHeadersVisualStyles = false;
            dgvLoaiHang.Location = new Point(0, 401);
            dgvLoaiHang.Margin = new Padding(2);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersVisible = false;
            dgvLoaiHang.RowHeadersWidth = 62;
            dgvLoaiHang.Size = new Size(992, 407);
            dgvLoaiHang.TabIndex = 1;
            dgvLoaiHang.CellClick += dgvLoaiHang_CellClick;
            dgvLoaiHang.CellContentClick += dgvLoaiHang_CellContentClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(txtMoTa);
            grbThongTin.Controls.Add(txtTenLH);
            grbThongTin.Controls.Add(txtMaLH);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(lblMa);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(992, 264);
            grbThongTin.TabIndex = 2;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(601, 69);
            txtMoTa.Margin = new Padding(2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(320, 134);
            txtMoTa.TabIndex = 1;
            // 
            // txtTenLH
            // 
            txtTenLH.Location = new Point(192, 172);
            txtTenLH.Margin = new Padding(2);
            txtTenLH.Name = "txtTenLH";
            txtTenLH.Size = new Size(246, 34);
            txtTenLH.TabIndex = 1;
            // 
            // txtMaLH
            // 
            txtMaLH.Location = new Point(192, 64);
            txtMaLH.Margin = new Padding(2);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(128, 34);
            txtMaLH.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 64);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 27);
            label5.TabIndex = 0;
            label5.Text = "Mô Tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 172);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 27);
            label4.TabIndex = 0;
            label4.Text = "Tên Loại Hàng";
            label4.Click += label4_Click;
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(28, 68);
            lblMa.Margin = new Padding(2, 0, 2, 0);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(135, 27);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã Loại Hàng";
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnBoQua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(992, 92);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(234, 716);
            grbChucNang.TabIndex = 3;
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
            btnThoat.Location = new Point(34, 584);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(171, 70);
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
            btnXuat.Location = new Point(34, 481);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(171, 70);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(34, 275);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(171, 70);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(34, 378);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(171, 70);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(34, 172);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(171, 70);
            btnBoQua.TabIndex = 0;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(34, 69);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(171, 70);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(lblTongSLoai);
            panel2.Controls.Add(txtTimTen);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(992, 45);
            panel2.TabIndex = 4;
            // 
            // lblTongSLoai
            // 
            lblTongSLoai.AutoSize = true;
            lblTongSLoai.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSLoai.Location = new Point(26, 11);
            lblTongSLoai.Margin = new Padding(2, 0, 2, 0);
            lblTongSLoai.Name = "lblTongSLoai";
            lblTongSLoai.Size = new Size(119, 24);
            lblTongSLoai.TabIndex = 0;
            lblTongSLoai.Text = "Tổng Số Loại:";
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(601, 6);
            txtTimTen.Margin = new Padding(2);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(246, 31);
            txtTimTen.TabIndex = 1;
            txtTimTen.TextChanged += txtTimTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 0;
            label2.Text = "Nhập Tên LH:";
            label2.Click += label4_Click;
            // 
            // frmLoaiHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 808);
            ControlBox = false;
            Controls.Add(dgvLoaiHang);
            Controls.Add(panel2);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmLoaiHang";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLoaiHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTenTK;
        private Label label1;
        private DataGridView dgvLoaiHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtMoTa;
        private TextBox txtTenLH;
        private TextBox txtMaLH;
        private Label label5;
        private Label label4;
        private Label lblMa;
        private Button btnBoQua;
        private Panel panel2;
        private Label lblTongSLoai;
        private TextBox txtTimTen;
        private Label label2;
    }
}