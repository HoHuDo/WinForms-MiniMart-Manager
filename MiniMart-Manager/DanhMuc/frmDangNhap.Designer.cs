
namespace MiniMart_Manager.DanhMuc
{
    partial class frmDangNhap
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
            pictureBox1 = new PictureBox();
            lblDangNhap = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            chkHienMK = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblNhapLai = new Label();
            lblThoat = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            groupBox1 = new GroupBox();
            picThoat = new PictureBox();
            btnDangNhap = new MiniMart_Manager.Classes.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.Market;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 514);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Arial", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangNhap.ForeColor = Color.DeepSkyBlue;
            lblDangNhap.Location = new Point(458, 40);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(254, 51);
            lblDangNhap.TabIndex = 3;
            lblDangNhap.Text = "Đăng Nhập";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Password;
            pictureBox2.Location = new Point(362, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.User;
            pictureBox3.Location = new Point(349, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Cursor = Cursors.Hand;
            chkHienMK.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienMK.ForeColor = Color.DeepSkyBlue;
            chkHienMK.Location = new Point(362, 298);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(167, 31);
            chkHienMK.TabIndex = 6;
            chkHienMK.Text = "Hiện mật khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(362, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 3);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Location = new Point(362, 269);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 3);
            panel2.TabIndex = 8;
            // 
            // lblNhapLai
            // 
            lblNhapLai.AutoSize = true;
            lblNhapLai.Cursor = Cursors.Hand;
            lblNhapLai.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNhapLai.ForeColor = Color.DeepSkyBlue;
            lblNhapLai.Location = new Point(708, 300);
            lblNhapLai.Name = "lblNhapLai";
            lblNhapLai.Size = new Size(87, 27);
            lblNhapLai.TabIndex = 10;
            lblNhapLai.Text = "Nhập lại";
            lblNhapLai.Click += lblNhapLai_Click;
            // 
            // lblThoat
            // 
            lblThoat.AutoSize = true;
            lblThoat.BackColor = SystemColors.ButtonHighlight;
            lblThoat.Cursor = Cursors.Hand;
            lblThoat.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThoat.ForeColor = Color.FromArgb(255, 128, 128);
            lblThoat.Location = new Point(726, 425);
            lblThoat.Name = "lblThoat";
            lblThoat.Size = new Size(67, 27);
            lblThoat.TabIndex = 10;
            lblThoat.Text = "&Thoát";
            lblThoat.Click += lblThoat_Click_1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.FromArgb(255, 128, 128);
            txtMatKhau.Location = new Point(422, 224);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(371, 39);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.TextChanged += chkHienMK_CheckedChanged;
            txtMatKhau.KeyPress += txtMatKhau_KeyPress;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = SystemColors.HotTrack;
            txtTaiKhoan.Location = new Point(422, 119);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(371, 39);
            txtTaiKhoan.TabIndex = 0;
            txtTaiKhoan.KeyPress += txtTaiKhoan_KeyPress;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(626, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // picThoat
            // 
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.logout;
            picThoat.Location = new Point(702, 429);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(24, 24);
            picThoat.SizeMode = PictureBoxSizeMode.AutoSize;
            picThoat.TabIndex = 5;
            picThoat.TabStop = false;
            picThoat.Click += lblThoat_Click_1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DeepSkyBlue;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(362, 360);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(433, 47);
            btnDangNhap.TabIndex = 13;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(911, 514);
            ControlBox = false;
            Controls.Add(btnDangNhap);
            Controls.Add(groupBox1);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(lblThoat);
            Controls.Add(lblNhapLai);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chkHienMK);
            Controls.Add(picThoat);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblDangNhap);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblDangNhap;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private CheckBox chkHienMK;
        private Panel panel1;
        private Panel panel2;
        private Label lblNhapLai;
        private Label lblThoat;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private GroupBox groupBox1;
        private PictureBox picThoat;
        private Classes.RoundedButton btnDangNhap;
    }
}