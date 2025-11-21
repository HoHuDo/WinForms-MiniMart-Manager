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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            grbThongTin = new GroupBox();
            btnKhachHang = new Button();
            btnReset = new Button();
            cbxSP = new ComboBox();
            cbxKhachHang = new ComboBox();
            cbxDonVi = new ComboBox();
            textBox5 = new TextBox();
            txtGia = new TextBox();
            txtSlBan = new TextBox();
            txtSlTrongKho = new TextBox();
            label10 = new Label();
            lblThanhTien = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            grbChucNang = new GroupBox();
            btnXuatE = new Button();
            btnTim = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            lblTenTK = new Label();
            dataGridView1 = new DataGridView();
            dgvChiTietDH = new DataGridView();
            panel2 = new Panel();
            dgvSanPham = new DataGridView();
            label11 = new Label();
            label12 = new Label();
            grbThongTin.SuspendLayout();
            grbChucNang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDH).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = Color.White;
            grbThongTin.Controls.Add(btnKhachHang);
            grbThongTin.Controls.Add(btnReset);
            grbThongTin.Controls.Add(cbxSP);
            grbThongTin.Controls.Add(cbxKhachHang);
            grbThongTin.Controls.Add(cbxDonVi);
            grbThongTin.Controls.Add(textBox5);
            grbThongTin.Controls.Add(txtGia);
            grbThongTin.Controls.Add(txtSlBan);
            grbThongTin.Controls.Add(txtSlTrongKho);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(lblThanhTien);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(grbChucNang);
            grbThongTin.Dock = DockStyle.Right;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(918, 74);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(556, 689);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // btnKhachHang
            // 
            btnKhachHang.Image = Properties.Resources.people;
            btnKhachHang.Location = new Point(385, 74);
            btnKhachHang.Margin = new Padding(2);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(47, 39);
            btnKhachHang.TabIndex = 10;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.reset;
            btnReset.Location = new Point(385, 326);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(47, 32);
            btnReset.TabIndex = 9;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // cbxSP
            // 
            cbxSP.FormattingEnabled = true;
            cbxSP.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxSP.Location = new Point(202, 41);
            cbxSP.Margin = new Padding(2);
            cbxSP.Name = "cbxSP";
            cbxSP.Size = new Size(230, 30);
            cbxSP.TabIndex = 6;
            // 
            // cbxKhachHang
            // 
            cbxKhachHang.FormattingEnabled = true;
            cbxKhachHang.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxKhachHang.Location = new Point(202, 80);
            cbxKhachHang.Margin = new Padding(2);
            cbxKhachHang.Name = "cbxKhachHang";
            cbxKhachHang.Size = new Size(178, 30);
            cbxKhachHang.TabIndex = 6;
            // 
            // cbxDonVi
            // 
            cbxDonVi.Enabled = false;
            cbxDonVi.FormattingEnabled = true;
            cbxDonVi.Items.AddRange(new object[] { "Cái", "Chiếc", "Hộp ", "Lon", "Chai", "Gói", "Vỉ", "Lốc ", "Cuộn" });
            cbxDonVi.Location = new Point(202, 119);
            cbxDonVi.Margin = new Padding(2);
            cbxDonVi.Name = "cbxDonVi";
            cbxDonVi.Size = new Size(99, 30);
            cbxDonVi.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(202, 274);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(58, 30);
            textBox5.TabIndex = 5;
            textBox5.Text = "0";
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtGia
            // 
            txtGia.Enabled = false;
            txtGia.Location = new Point(202, 158);
            txtGia.Margin = new Padding(2);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(230, 30);
            txtGia.TabIndex = 5;
            txtGia.TextChanged += textBox4_TextChanged;
            txtGia.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtSlBan
            // 
            txtSlBan.Location = new Point(202, 235);
            txtSlBan.Margin = new Padding(2);
            txtSlBan.Name = "txtSlBan";
            txtSlBan.Size = new Size(99, 30);
            txtSlBan.TabIndex = 5;
            txtSlBan.TextChanged += textBox4_TextChanged;
            txtSlBan.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // txtSlTrongKho
            // 
            txtSlTrongKho.Enabled = false;
            txtSlTrongKho.Location = new Point(202, 197);
            txtSlTrongKho.Margin = new Padding(2);
            txtSlTrongKho.Name = "txtSlTrongKho";
            txtSlTrongKho.Size = new Size(99, 30);
            txtSlTrongKho.TabIndex = 5;
            txtSlTrongKho.TextChanged += textBox4_TextChanged;
            txtSlTrongKho.KeyPress += txtSlTrongKho_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(277, 276);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(24, 22);
            label10.TabIndex = 4;
            label10.Text = "%";
            // 
            // lblThanhTien
            // 
            lblThanhTien.BorderStyle = BorderStyle.FixedSingle;
            lblThanhTien.Enabled = false;
            lblThanhTien.Location = new Point(202, 331);
            lblThanhTien.Margin = new Padding(2, 0, 2, 0);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(165, 24);
            lblThanhTien.TabIndex = 4;
            lblThanhTien.Text = "0";
            lblThanhTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 326);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 22);
            label9.TabIndex = 4;
            label9.Text = "Thành tiền";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 271);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 22);
            label8.TabIndex = 4;
            label8.Text = "Chiết khấu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 233);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 22);
            label7.TabIndex = 4;
            label7.Text = "Số lượng bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 194);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(158, 22);
            label6.TabIndex = 4;
            label6.Text = "Số lượng trong kho";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 79);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(103, 22);
            label13.TabIndex = 4;
            label13.Text = "Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 156);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 22);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 4;
            label4.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 4;
            label2.Text = "Sản phẩm";
            // 
            // grbChucNang
            // 
            grbChucNang.Controls.Add(btnXuatE);
            grbChucNang.Controls.Add(btnTim);
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnHuy);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(button1);
            grbChucNang.Dock = DockStyle.Bottom;
            grbChucNang.Location = new Point(2, 453);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(552, 234);
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
            btnXuatE.Location = new Point(199, 128);
            btnXuatE.Margin = new Padding(2);
            btnXuatE.Name = "btnXuatE";
            btnXuatE.Size = new Size(142, 64);
            btnXuatE.TabIndex = 0;
            btnXuatE.Text = "       In Hóa Đơn";
            btnXuatE.UseVisualStyleBackColor = false;
            btnXuatE.Click += btnXuatE_Click;
            // 
            // btnTim
            // 
            btnTim.Image = Properties.Resources.loupe;
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(30, 128);
            btnTim.Margin = new Padding(2);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(142, 64);
            btnTim.TabIndex = 0;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 128);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Black;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(368, 128);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(142, 64);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Image = Properties.Resources.delete;
            btnHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuy.Location = new Point(368, 35);
            btnHuy.Margin = new Padding(2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(142, 64);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.save;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(199, 35);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 64);
            btnSua.TabIndex = 0;
            btnSua.Text = "Lưu";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.more;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 35);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(142, 64);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(10, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 46);
            label1.TabIndex = 0;
            label1.Text = "Bán Hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1474, 74);
            panel1.TabIndex = 2;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(918, 32);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(92, 22);
            lblTenTK.TabIndex = 1;
            lblTenTK.Text = "UserName";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(346, 2);
            dataGridView1.TabIndex = 3;
            // 
            // dgvChiTietDH
            // 
            dgvChiTietDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietDH.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDH.Dock = DockStyle.Bottom;
            dgvChiTietDH.Location = new Point(0, 573);
            dgvChiTietDH.Margin = new Padding(2);
            dgvChiTietDH.Name = "dgvChiTietDH";
            dgvChiTietDH.RowHeadersWidth = 62;
            dgvChiTietDH.Size = new Size(918, 190);
            dgvChiTietDH.TabIndex = 4;
            dgvChiTietDH.CellClick += dgvChiTietDH_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(110, 98);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 2);
            panel2.TabIndex = 7;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.WhiteSmoke;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 96);
            dgvSanPham.Margin = new Padding(2);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 62;
            dgvSanPham.Size = new Size(918, 455);
            dgvSanPham.TabIndex = 10;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label11.Location = new Point(0, 74);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 22);
            label11.TabIndex = 11;
            label11.Text = "Sản phẩm";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Bottom;
            label12.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label12.Location = new Point(0, 551);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(147, 22);
            label12.TabIndex = 12;
            label12.Text = "Chi Tiết Đơn hàng";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1474, 763);
            Controls.Add(dgvSanPham);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(panel2);
            Controls.Add(dgvChiTietDH);
            Controls.Add(grbThongTin);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(366, 35);
            Margin = new Padding(2);
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
        private Panel panel2;
        private DataGridView dgvSanPham;
        private Label lblThanhTien;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox5;
        private TextBox txtSlTrongKho;
        private TextBox txtGia;
        private ComboBox cbxDonVi;
        private TextBox txtSlBan;
        private Label label10;
        private Button btnXuatE;
        private Button btnTim;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button button1;
        private Label label11;
        private Label label12;
        private Label lblTenTK;
        private Button btnReset;
        private Button btnKhachHang;
        private ComboBox cbxKhachHang;
        private Label label13;
        private ComboBox cbxSP;
    }
}