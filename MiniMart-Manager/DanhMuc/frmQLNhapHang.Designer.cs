namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLNhapHang
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
            panel1 = new Panel();
            lblTenTk = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvPhieuNhap = new DataGridView();
            dgvChiTietPN = new DataGridView();
            grbThongTin = new GroupBox();
            dtpNgayNhap = new DateTimePicker();
            txtTongTien = new TextBox();
            txtThanhTien = new TextBox();
            txtDonGia = new TextBox();
            txtSL = new TextBox();
            txtMaNV = new TextBox();
            txtMaSP = new TextBox();
            txtNhaCC = new TextBox();
            txtMaPN = new TextBox();
            label15 = new Label();
            label13 = new Label();
            label11 = new Label();
            label9 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnXoa = new Button();
            Tìm = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPN).BeginInit();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTk);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1761, 138);
            panel1.TabIndex = 0;
            // 
            // lblTenTk
            // 
            lblTenTk.AutoSize = true;
            lblTenTk.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTk.Location = new Point(979, 58);
            lblTenTk.Name = "lblTenTk";
            lblTenTk.Size = new Size(113, 27);
            lblTenTk.TabIndex = 0;
            lblTenTk.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(401, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhập Hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 510);
            label2.Name = "label2";
            label2.Size = new Size(189, 27);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label3.Location = new Point(0, 141);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 0;
            label3.Text = "Phiếu Nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.BackgroundColor = Color.WhiteSmoke;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Location = new Point(0, 169);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersWidth = 62;
            dgvPhieuNhap.Size = new Size(973, 338);
            dgvPhieuNhap.TabIndex = 1;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            dgvPhieuNhap.CellContentClick += dgvPhieuNhap_CellContentClick;
            // 
            // dgvChiTietPN
            // 
            dgvChiTietPN.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietPN.Location = new Point(0, 542);
            dgvChiTietPN.Name = "dgvChiTietPN";
            dgvChiTietPN.RowHeadersWidth = 62;
            dgvChiTietPN.Size = new Size(973, 358);
            dgvChiTietPN.TabIndex = 2;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(dtpNgayNhap);
            grbThongTin.Controls.Add(txtTongTien);
            grbThongTin.Controls.Add(txtThanhTien);
            grbThongTin.Controls.Add(txtDonGia);
            grbThongTin.Controls.Add(txtSL);
            grbThongTin.Controls.Add(txtMaNV);
            grbThongTin.Controls.Add(txtMaSP);
            grbThongTin.Controls.Add(txtNhaCC);
            grbThongTin.Controls.Add(txtMaPN);
            grbThongTin.Controls.Add(label15);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(label11);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label14);
            grbThongTin.Controls.Add(label12);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(979, 169);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(770, 489);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(230, 322);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(219, 34);
            dtpNgayNhap.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(230, 380);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(199, 34);
            txtTongTien.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(591, 377);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(173, 34);
            txtThanhTien.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(591, 319);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(173, 34);
            txtDonGia.TabIndex = 1;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(591, 255);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(106, 34);
            txtSL.TabIndex = 1;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(230, 252);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(199, 34);
            txtMaNV.TabIndex = 1;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(591, 191);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(173, 34);
            txtMaSP.TabIndex = 1;
            // 
            // txtNhaCC
            // 
            txtNhaCC.Location = new Point(230, 194);
            txtNhaCC.Name = "txtNhaCC";
            txtNhaCC.Size = new Size(199, 34);
            txtNhaCC.TabIndex = 1;
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(230, 66);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(199, 34);
            txtMaPN.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(455, 386);
            label15.Name = "label15";
            label15.Size = new Size(109, 27);
            label15.TabIndex = 0;
            label15.Text = "Thành Tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(455, 322);
            label13.Name = "label13";
            label13.Size = new Size(136, 27);
            label13.TabIndex = 0;
            label13.Text = "Đơn Giá Nhập";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(455, 258);
            label11.Name = "label11";
            label11.Size = new Size(98, 27);
            label11.TabIndex = 0;
            label11.Text = "Số Lượng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(455, 194);
            label9.Name = "label9";
            label9.Size = new Size(133, 27);
            label9.TabIndex = 0;
            label9.Text = "Mã Sản Phẩm";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 386);
            label14.Name = "label14";
            label14.Size = new Size(101, 27);
            label14.TabIndex = 0;
            label14.Text = "Tổng Tiền";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(49, 322);
            label12.Name = "label12";
            label12.Size = new Size(113, 27);
            label12.TabIndex = 0;
            label12.Text = "Ngày Nhập";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 258);
            label10.Name = "label10";
            label10.Size = new Size(137, 27);
            label10.TabIndex = 0;
            label10.Text = "Mã Nhân Viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 194);
            label8.Name = "label8";
            label8.Size = new Size(175, 27);
            label8.TabIndex = 0;
            label8.Text = "Mã Nhà Cung Cấp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(455, 130);
            label7.Name = "label7";
            label7.Size = new Size(189, 27);
            label7.TabIndex = 0;
            label7.Text = "Chi Tiết Phiếu Nhập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(49, 130);
            label6.Name = "label6";
            label6.Size = new Size(114, 27);
            label6.TabIndex = 0;
            label6.Text = "Phiếu Nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 66);
            label5.Name = "label5";
            label5.Size = new Size(147, 27);
            label5.TabIndex = 0;
            label5.Text = "Mã Phiếu Nhập";
            label5.Click += label5_Click;
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(Tìm);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(979, 664);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(770, 236);
            grbChucNang.TabIndex = 4;
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
            btnThoat.Location = new Point(521, 142);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 69);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(305, 142);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(154, 69);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "      Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(521, 42);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(154, 69);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // Tìm
            // 
            Tìm.Image = Properties.Resources.loupe;
            Tìm.ImageAlign = ContentAlignment.MiddleLeft;
            Tìm.Location = new Point(89, 142);
            Tìm.Name = "Tìm";
            Tìm.Size = new Size(154, 69);
            Tìm.TabIndex = 0;
            Tìm.Text = "Tìm";
            Tìm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(305, 42);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(154, 69);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(89, 42);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 69);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // frmQLNhapHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1761, 903);
            Controls.Add(grbChucNang);
            Controls.Add(grbThongTin);
            Controls.Add(dgvChiTietPN);
            Controls.Add(label2);
            Controls.Add(dgvPhieuNhap);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "frmQLNhapHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhập Hàng";
            Load += frmQLNhapHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPN).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dgvPhieuNhap;
        private DataGridView dgvChiTietPN;
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private Label lblTenTk;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label15;
        private Label label13;
        private Label label14;
        private Label label12;
        private DateTimePicker dtpNgayNhap;
        private TextBox txtTongTien;
        private TextBox txtThanhTien;
        private TextBox txtDonGia;
        private TextBox txtSL;
        private TextBox txtMaNV;
        private TextBox txtMaSP;
        private TextBox txtNhaCC;
        private TextBox txtMaPN;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnXoa;
        private Button Tìm;
        private Button btnSua;
        private Button btnThem;
    }
}