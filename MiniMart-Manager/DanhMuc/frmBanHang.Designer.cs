namespace MiniMart_Manager.DanhMuc
{
    partial class frmBanHang
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
            grbThongTin = new GroupBox();
            cbxDonVi = new ComboBox();
            textBox5 = new TextBox();
            txtGia = new TextBox();
            txtSlBan = new TextBox();
            txtSlTrongKho = new TextBox();
            txtTenSp = new TextBox();
            txtMasp = new TextBox();
            label10 = new Label();
            lblThanhTien = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grbChucNang = new GroupBox();
            btnXuatE = new Button();
            btnNhapLai = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblTenTK = new Label();
            dataGridView1 = new DataGridView();
            dgvChiTietDH = new DataGridView();
            lblTenSp = new Label();
            txtTimTenSp = new TextBox();
            panel2 = new Panel();
            btnTim = new Button();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            dgvSanPham = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDH).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = Color.White;
            grbThongTin.Controls.Add(cbxDonVi);
            grbThongTin.Controls.Add(textBox5);
            grbThongTin.Controls.Add(txtGia);
            grbThongTin.Controls.Add(txtSlBan);
            grbThongTin.Controls.Add(txtSlTrongKho);
            grbThongTin.Controls.Add(txtTenSp);
            grbThongTin.Controls.Add(txtMasp);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(lblThanhTien);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(grbChucNang);
            grbThongTin.Dock = DockStyle.Right;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(1045, 92);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(558, 767);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // cbxDonVi
            // 
            cbxDonVi.FormattingEnabled = true;
            cbxDonVi.Location = new Point(253, 152);
            cbxDonVi.Name = "cbxDonVi";
            cbxDonVi.Size = new Size(123, 35);
            cbxDonVi.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(253, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(71, 34);
            textBox5.TabIndex = 5;
            textBox5.Text = "0";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(253, 199);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(216, 34);
            txtGia.TabIndex = 5;
            txtGia.TextChanged += textBox4_TextChanged;
            // 
            // txtSlBan
            // 
            txtSlBan.Location = new Point(253, 293);
            txtSlBan.Name = "txtSlBan";
            txtSlBan.Size = new Size(123, 34);
            txtSlBan.TabIndex = 5;
            txtSlBan.TextChanged += textBox4_TextChanged;
            // 
            // txtSlTrongKho
            // 
            txtSlTrongKho.Location = new Point(253, 246);
            txtSlTrongKho.Name = "txtSlTrongKho";
            txtSlTrongKho.Size = new Size(123, 34);
            txtSlTrongKho.TabIndex = 5;
            txtSlTrongKho.TextChanged += textBox4_TextChanged;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(253, 105);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(216, 34);
            txtTenSp.TabIndex = 5;
            // 
            // txtMasp
            // 
            txtMasp.Location = new Point(253, 58);
            txtMasp.Name = "txtMasp";
            txtMasp.Size = new Size(123, 34);
            txtMasp.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(325, 344);
            label10.Name = "label10";
            label10.Size = new Size(29, 27);
            label10.TabIndex = 4;
            label10.Text = "%";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Location = new Point(253, 414);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(25, 29);
            lblThanhTien.TabIndex = 4;
            lblThanhTien.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 416);
            label9.Name = "label9";
            label9.Size = new Size(106, 27);
            label9.TabIndex = 4;
            label9.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 340);
            label8.Name = "label8";
            label8.Size = new Size(109, 27);
            label8.TabIndex = 4;
            label8.Text = "Chiết khấu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 293);
            label7.Name = "label7";
            label7.Size = new Size(131, 27);
            label7.TabIndex = 4;
            label7.Text = "Số lượng bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 246);
            label6.Name = "label6";
            label6.Size = new Size(188, 27);
            label6.TabIndex = 4;
            label6.Text = "Số lượng trong kho";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 199);
            label5.Name = "label5";
            label5.Size = new Size(79, 27);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 152);
            label4.Name = "label4";
            label4.Size = new Size(109, 27);
            label4.TabIndex = 4;
            label4.Text = "Đơn vị tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 105);
            label3.Name = "label3";
            label3.Size = new Size(134, 27);
            label3.TabIndex = 4;
            label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 58);
            label2.Name = "label2";
            label2.Size = new Size(134, 27);
            label2.TabIndex = 4;
            label2.Text = "Mã Sản phẩm";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnXuatE);
            grbChucNang.Controls.Add(btnNhapLai);
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(button1);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Location = new Point(3, 532);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(552, 232);
            grbChucNang.TabIndex = 3;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức năng";
            // 
            // btnXuatE
            // 
            btnXuatE.BackColor = Color.FromArgb(192, 255, 192);
            btnXuatE.FlatAppearance.BorderSize = 0;
            btnXuatE.FlatStyle = FlatStyle.Flat;
            btnXuatE.Image = Properties.Resources.excel;
            btnXuatE.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatE.Location = new Point(201, 130);
            btnXuatE.Name = "btnXuatE";
            btnXuatE.Size = new Size(152, 62);
            btnXuatE.TabIndex = 0;
            btnXuatE.Text = "       Xuất Excel";
            btnXuatE.UseVisualStyleBackColor = false;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Image = Properties.Resources.reset;
            btnNhapLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapLai.Location = new Point(37, 130);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(152, 62);
            btnNhapLai.TabIndex = 0;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 128);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(365, 130);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(152, 62);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(365, 44);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(152, 62);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(201, 44);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(152, 62);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.more;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(37, 44);
            button1.Name = "button1";
            button1.Size = new Size(152, 62);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(208, 53);
            label1.TabIndex = 0;
            label1.Text = "Bán Hàng";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1603, 92);
            panel1.TabIndex = 2;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(1049, 40);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(108, 27);
            lblTenTK.TabIndex = 1;
            lblTenTK.Text = "UserName";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(433, 3);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgvChiTietDH
            // 
            dgvChiTietDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDH.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDH.Dock = DockStyle.Bottom;
            dgvChiTietDH.Location = new Point(0, 622);
            dgvChiTietDH.Name = "dgvChiTietDH";
            dgvChiTietDH.RowHeadersWidth = 62;
            dgvChiTietDH.Size = new Size(1045, 237);
            dgvChiTietDH.TabIndex = 4;
            // 
            // lblTenSp
            // 
            lblTenSp.AutoSize = true;
            lblTenSp.BackColor = Color.White;
            lblTenSp.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenSp.Location = new Point(0, 6);
            lblTenSp.Name = "lblTenSp";
            lblTenSp.Size = new Size(144, 27);
            lblTenSp.TabIndex = 5;
            lblTenSp.Text = "Tên sản phẩm: ";
            lblTenSp.Click += lblTenSp_Click;
            // 
            // txtTimTenSp
            // 
            txtTimTenSp.BorderStyle = BorderStyle.None;
            txtTimTenSp.Location = new Point(149, 6);
            txtTimTenSp.Name = "txtTimTenSp";
            txtTimTenSp.Size = new Size(420, 24);
            txtTimTenSp.TabIndex = 6;
            txtTimTenSp.TextChanged += txtTimTenSp_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(138, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 3);
            panel2.TabIndex = 7;
            // 
            // btnTim
            // 
            btnTim.BackColor = SystemColors.GradientInactiveCaption;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.System;
            btnTim.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            btnTim.ForeColor = SystemColors.ActiveCaptionText;
            btnTim.Location = new Point(575, 9);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(112, 36);
            btnTim.TabIndex = 8;
            btnTim.Text = "Tìm Kiếm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(btnTim);
            panel3.Controls.Add(txtTimTenSp);
            panel3.Controls.Add(lblTenSp);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(1045, 58);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(693, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(346, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.WhiteSmoke;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 177);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(1045, 418);
            dgvSanPham.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label11.Location = new Point(0, 150);
            label11.Name = "label11";
            label11.Size = new Size(101, 27);
            label11.TabIndex = 11;
            label11.Text = "Sản phẩm";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Bottom;
            label12.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label12.Location = new Point(0, 595);
            label12.Name = "label12";
            label12.Size = new Size(173, 27);
            label12.TabIndex = 12;
            label12.Text = "Chi Tiết Đơn hàng";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1603, 859);
            Controls.Add(dgvSanPham);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dgvChiTietDH);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Location = new Point(366, 35);
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán Hàng";
            Load += frmBanHang_Load;
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            grbChucNang.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDH).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox grbThongTin;
        private GroupBox grbChucNang;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridView dgvChiTietDH;
        private Label lblTenSp;
        private TextBox txtTimTenSp;
        private Panel panel2;
        private Button btnTim;
        private Panel panel3;
        private DataGridView dgvSanPham;
        private Label lblThanhTien;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox txtSlTrongKho;
        private TextBox txtTenSp;
        private TextBox txtMasp;
        private TextBox txtGia;
        private ComboBox cbxDonVi;
        private TextBox txtSlBan;
        private Label label10;
        private Button btnXuatE;
        private Button btnNhapLai;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnSua;
        private Button button1;
        private Label label11;
        private Label label12;
        private Label lblTenTK;
    }
}