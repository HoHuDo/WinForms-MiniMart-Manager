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
            button5 = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).BeginInit();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
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
            panel1.Size = new Size(1226, 92);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(375, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Loại Hàng";
            label1.Click += label1_Click;
            // 
            // dgvLoaiHang
            // 
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.BackgroundColor = SystemColors.Control;
            dgvLoaiHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiHang.Dock = DockStyle.Fill;
            dgvLoaiHang.Location = new Point(0, 356);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersWidth = 62;
            dgvLoaiHang.Size = new Size(992, 451);
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
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(992, 264);
            grbThongTin.TabIndex = 2;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(601, 69);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(320, 134);
            txtMoTa.TabIndex = 1;
            // 
            // txtTenLH
            // 
            txtTenLH.Location = new Point(192, 172);
            txtTenLH.Name = "txtTenLH";
            txtTenLH.Size = new Size(247, 34);
            txtTenLH.TabIndex = 1;
            // 
            // txtMaLH
            // 
            txtMaLH.Location = new Point(192, 64);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(128, 34);
            txtMaLH.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 64);
            label5.Name = "label5";
            label5.Size = new Size(68, 27);
            label5.TabIndex = 0;
            label5.Text = "Mô Tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 172);
            label4.Name = "label4";
            label4.Size = new Size(138, 27);
            label4.TabIndex = 0;
            label4.Text = "Tên Loại Hàng";
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(27, 67);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(135, 27);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã Loại Hàng";
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(button5);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Controls.Add(button1);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(992, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(234, 715);
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
            btnThoat.Location = new Point(57, 577);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(146, 57);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // button5
            // 
            button5.Location = new Point(57, 577);
            button5.Name = "button5";
            button5.Size = new Size(134, 57);
            button5.TabIndex = 0;
            button5.Text = "button1";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(57, 456);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(146, 57);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(57, 214);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 57);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(57, 335);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 57);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(57, 93);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(57, 93);
            button1.Name = "button1";
            button1.Size = new Size(134, 57);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmLoaiHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 807);
            Controls.Add(dgvLoaiHang);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLoaiHang";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Loại Hàng";
            Load += frmLoaiHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiHang).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
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
        private Button button5;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button button1;
        private TextBox txtMoTa;
        private TextBox txtTenLH;
        private TextBox txtMaLH;
        private Label label5;
        private Label label4;
        private Label lblMa;
    }
}