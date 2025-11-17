namespace MiniMart_Manager.DanhMuc
{
    partial class frmHoaDon
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
            lbluserName = new Label();
            label14 = new Label();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvHoaDon = new DataGridView();
            grbThongTin = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox8 = new TextBox();
            textBox2 = new TextBox();
            textBox9 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            label8 = new Label();
            label10 = new Label();
            label13 = new Label();
            label9 = new Label();
            label7 = new Label();
            label3 = new Label();
            dgvChiTietHD = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lbluserName);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1666, 138);
            panel1.TabIndex = 0;
            // 
            // lbluserName
            // 
            lbluserName.AutoSize = true;
            lbluserName.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserName.Location = new Point(897, 37);
            lbluserName.Name = "lbluserName";
            lbluserName.Size = new Size(113, 27);
            lbluserName.TabIndex = 0;
            lbluserName.Text = "User Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(22, 37);
            label14.Name = "label14";
            label14.Size = new Size(349, 53);
            label14.TabIndex = 0;
            label14.Text = "Quản Lý Hóa Đơn";
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnTim);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(897, 654);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Size = new Size(753, 259);
            grbChucNang.TabIndex = 1;
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
            btnThoat.Location = new Point(496, 160);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(156, 60);
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
            btnXuat.Location = new Point(273, 160);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(156, 60);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "     Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            btnTim.Image = Properties.Resources.loupe;
            btnTim.ImageAlign = ContentAlignment.MiddleLeft;
            btnTim.Location = new Point(50, 160);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(156, 60);
            btnTim.TabIndex = 0;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.ButtonHighlight;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(496, 65);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(156, 60);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xỏa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(273, 65);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(156, 60);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(46, 65);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(156, 60);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.WhiteSmoke;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(0, 174);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.Size = new Size(891, 288);
            dgvHoaDon.TabIndex = 2;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(textBox7);
            grbThongTin.Controls.Add(textBox6);
            grbThongTin.Controls.Add(textBox5);
            grbThongTin.Controls.Add(textBox4);
            grbThongTin.Controls.Add(textBox3);
            grbThongTin.Controls.Add(textBox8);
            grbThongTin.Controls.Add(textBox2);
            grbThongTin.Controls.Add(textBox9);
            grbThongTin.Controls.Add(textBox1);
            grbThongTin.Controls.Add(label6);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label12);
            grbThongTin.Controls.Add(label11);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(label8);
            grbThongTin.Controls.Add(label10);
            grbThongTin.Controls.Add(label13);
            grbThongTin.Controls.Add(label9);
            grbThongTin.Controls.Add(label7);
            grbThongTin.Controls.Add(label3);
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(897, 163);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(753, 485);
            grbThongTin.TabIndex = 3;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(537, 401);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 34);
            textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(537, 342);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(85, 34);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(537, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 34);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(537, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(85, 34);
            textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(537, 165);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 34);
            textBox3.TabIndex = 1;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(209, 282);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 34);
            textBox8.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 34);
            textBox2.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(209, 44);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(328, 34);
            textBox9.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 34);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 286);
            label6.Name = "label6";
            label6.Size = new Size(101, 27);
            label6.TabIndex = 0;
            label6.Text = "Tổng Tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 227);
            label5.Name = "label5";
            label5.Size = new Size(98, 27);
            label5.TabIndex = 0;
            label5.Text = "Số Lượng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 224, 192);
            label12.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label12.Location = new Point(387, 109);
            label12.Name = "label12";
            label12.Size = new Size(150, 24);
            label12.TabIndex = 0;
            label12.Text = "Chi Tiết Hóa đơn";
            label12.Click += label4_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(255, 192, 192);
            label11.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold);
            label11.Location = new Point(58, 109);
            label11.Name = "label11";
            label11.Size = new Size(81, 24);
            label11.TabIndex = 0;
            label11.Text = "Hóa đơn";
            label11.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 168);
            label4.Name = "label4";
            label4.Size = new Size(133, 27);
            label4.TabIndex = 0;
            label4.Text = "Mã Sản Phẩm";
            label4.Click += label4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 168);
            label8.Name = "label8";
            label8.Size = new Size(153, 27);
            label8.TabIndex = 0;
            label8.Text = "Mã Khách Hàng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(387, 286);
            label10.Name = "label10";
            label10.Size = new Size(83, 27);
            label10.TabIndex = 0;
            label10.Text = "Đơn Giá";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(387, 411);
            label13.Name = "label13";
            label13.Size = new Size(109, 27);
            label13.TabIndex = 0;
            label13.Text = "Thành Tiền";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(387, 350);
            label9.Name = "label9";
            label9.Size = new Size(110, 27);
            label9.TabIndex = 0;
            label9.Text = "Chiết Khấu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 227);
            label7.Name = "label7";
            label7.Size = new Size(137, 27);
            label7.TabIndex = 0;
            label7.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 47);
            label3.Name = "label3";
            label3.Size = new Size(121, 27);
            label3.TabIndex = 0;
            label3.Text = "Mã Hóa đơn";
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHD.BackgroundColor = Color.WhiteSmoke;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.GridColor = Color.WhiteSmoke;
            dgvChiTietHD.Location = new Point(0, 513);
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.RowHeadersWidth = 62;
            dgvChiTietHD.Size = new Size(891, 400);
            dgvChiTietHD.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label1.Location = new Point(0, 141);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 0;
            label1.Text = "Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(0, 485);
            label2.Name = "label2";
            label2.Size = new Size(163, 27);
            label2.TabIndex = 0;
            label2.Text = "Chi Tiết Hóa đơn";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1666, 925);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvChiTietHD);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(dgvHoaDon);
            Controls.Add(panel1);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hóa Đơn";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox grbChucNang;
        private DataGridView dgvHoaDon;
        private GroupBox grbThongTin;
        private DataGridView dgvChiTietHD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label12;
        private Label label11;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label13;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnTim;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label lbluserName;
        private Label label14;
    }
}