namespace MiniMart_Manager.DanhMuc
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            txtDiaChi = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label5 = new Label();
            lblMa = new Label();
            grbThongTin = new GroupBox();
            txtSDT = new TextBox();
            label2 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvNhaCC = new DataGridView();
            lblTenTK = new Label();
            label1 = new Label();
            panel1 = new Panel();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(781, 76);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(323, 139);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(225, 269);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(301, 34);
            txtTenNCC.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(225, 116);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(145, 34);
            txtMaNCC.TabIndex = 1;
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
            grbChucNang.Location = new Point(1134, 92);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(237, 698);
            grbChucNang.TabIndex = 7;
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
            btnThoat.Location = new Point(54, 552);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(149, 62);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "&Thoát";
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
            btnXuat.Location = new Point(54, 433);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(149, 62);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất &Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(54, 195);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(149, 62);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(54, 314);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(149, 62);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(54, 76);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(149, 62);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 119);
            label5.Name = "label5";
            label5.Size = new Size(76, 27);
            label5.TabIndex = 0;
            label5.Text = "Địa Chỉ";
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(27, 119);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(175, 27);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã Nhà Cung Cấp";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtSDT);
            grbThongTin.Controls.Add(txtTenNCC);
            grbThongTin.Controls.Add(txtMaNCC);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(lblMa);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1134, 427);
            grbThongTin.TabIndex = 6;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(781, 269);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(323, 34);
            txtSDT.TabIndex = 1;
            txtSDT.TextChanged += txtSDT_TextChanged;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 269);
            label2.Name = "label2";
            label2.Size = new Size(136, 27);
            label2.TabIndex = 0;
            label2.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 269);
            label4.Name = "label4";
            label4.Size = new Size(178, 27);
            label4.TabIndex = 0;
            label4.Text = "Tên Nhà Cung Cấp";
            // 
            // dgvNhaCC
            // 
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCC.BackgroundColor = SystemColors.Control;
            dgvNhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCC.Dock = DockStyle.Fill;
            dgvNhaCC.Location = new Point(0, 519);
            dgvNhaCC.Name = "dgvNhaCC";
            dgvNhaCC.RowHeadersWidth = 62;
            dgvNhaCC.Size = new Size(1134, 271);
            dgvNhaCC.TabIndex = 5;
            dgvNhaCC.CellClick += dgvNhaCC_CellClick;
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
            label1.Size = new Size(455, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 92);
            panel1.TabIndex = 4;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 790);
            Controls.Add(dgvNhaCC);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lí Nhà Cung Cấp";
            Load += frmNhacCungCap_Load;
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDiaChi;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private GroupBox grbChucNang;
        private Label label5;
        private Label lblMa;
        private GroupBox grbThongTin;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvNhaCC;
        private Label lblTenTK;
        private Label label1;
        private Panel panel1;
        private TextBox txtSDT;
        private Label label2;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}