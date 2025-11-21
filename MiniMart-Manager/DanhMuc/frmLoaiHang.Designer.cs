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
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
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
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 74);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(318, 46);
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
            dgvLoaiHang.Location = new Point(0, 285);
            dgvLoaiHang.Margin = new Padding(2, 2, 2, 2);
            dgvLoaiHang.Name = "dgvLoaiHang";
            dgvLoaiHang.RowHeadersWidth = 62;
            dgvLoaiHang.Size = new Size(794, 361);
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
            grbThongTin.Location = new Point(0, 74);
            grbThongTin.Margin = new Padding(2, 2, 2, 2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2, 2, 2, 2);
            grbThongTin.Size = new Size(794, 211);
            grbThongTin.TabIndex = 2;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(481, 55);
            txtMoTa.Margin = new Padding(2, 2, 2, 2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(257, 108);
            txtMoTa.TabIndex = 1;
            // 
            // txtTenLH
            // 
            txtTenLH.Location = new Point(154, 138);
            txtTenLH.Margin = new Padding(2, 2, 2, 2);
            txtTenLH.Name = "txtTenLH";
            txtTenLH.Size = new Size(198, 30);
            txtTenLH.TabIndex = 1;
            // 
            // txtMaLH
            // 
            txtMaLH.Location = new Point(154, 51);
            txtMaLH.Margin = new Padding(2, 2, 2, 2);
            txtMaLH.Name = "txtMaLH";
            txtMaLH.Size = new Size(103, 30);
            txtMaLH.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 51);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 0;
            label5.Text = "Mô Tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 138);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 22);
            label4.TabIndex = 0;
            label4.Text = "Tên Loại Hàng";
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(22, 54);
            lblMa.Margin = new Padding(2, 0, 2, 0);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(115, 22);
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
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(794, 74);
            grbChucNang.Margin = new Padding(2, 2, 2, 2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2, 2, 2, 2);
            grbChucNang.Size = new Size(187, 572);
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
            btnThoat.Location = new Point(27, 407);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 56);
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
            btnXuat.Location = new Point(27, 319);
            btnXuat.Margin = new Padding(2, 2, 2, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(137, 56);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(27, 143);
            btnSua.Margin = new Padding(2, 2, 2, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 56);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(27, 231);
            btnXoa.Margin = new Padding(2, 2, 2, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(137, 56);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(27, 55);
            btnThem.Margin = new Padding(2, 2, 2, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 56);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmLoaiHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 646);
            Controls.Add(dgvLoaiHang);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
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
    }
}