namespace MiniMart_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnDangNhap = new Button();
            btnDoiMK = new Button();
            btnThongTin = new Button();
            btnThoat = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Main;
            pictureBox1.Location = new Point(368, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1016, 1070);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(btnDoiMK);
            panel1.Controls.Add(btnThongTin);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 1070);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.mainMarket;
            pictureBox2.Location = new Point(91, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 316);
            panel2.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.SkyBlue;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            btnDangNhap.ForeColor = SystemColors.MenuHighlight;
            btnDangNhap.Image = Properties.Resources.enter__1_;
            btnDangNhap.Location = new Point(-213, 322);
            btnDangNhap.Margin = new Padding(0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(587, 67);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "                              Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            btnDangNhap.MouseEnter += btnDangNhap_MouseEnter;
            btnDangNhap.MouseHover += btnDangNhap_MouseHover;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = Color.SkyBlue;
            btnDoiMK.FlatAppearance.BorderSize = 0;
            btnDoiMK.FlatStyle = FlatStyle.Flat;
            btnDoiMK.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            btnDoiMK.ForeColor = SystemColors.MenuHighlight;
            btnDoiMK.Image = Properties.Resources.reset_password;
            btnDoiMK.Location = new Point(-209, 410);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(583, 67);
            btnDoiMK.TabIndex = 0;
            btnDoiMK.Text = "                                 Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            btnDoiMK.MouseEnter += btnDangNhap_MouseEnter;
            btnDoiMK.MouseHover += btnDangNhap_MouseHover;
            // 
            // btnThongTin
            // 
            btnThongTin.BackColor = Color.SkyBlue;
            btnThongTin.FlatAppearance.BorderSize = 0;
            btnThongTin.FlatStyle = FlatStyle.Flat;
            btnThongTin.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            btnThongTin.ForeColor = SystemColors.MenuHighlight;
            btnThongTin.Image = Properties.Resources.information;
            btnThongTin.Location = new Point(-205, 498);
            btnThongTin.Name = "btnThongTin";
            btnThongTin.Size = new Size(573, 67);
            btnThongTin.TabIndex = 0;
            btnThongTin.Text = "                            Thông Tin";
            btnThongTin.UseVisualStyleBackColor = false;
            btnThongTin.Click += btnThongTin_Click;
            btnThongTin.MouseEnter += btnDangNhap_MouseEnter;
            btnThongTin.MouseHover += btnDangNhap_MouseHover;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.SkyBlue;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            btnThoat.ForeColor = SystemColors.MenuHighlight;
            btnThoat.Image = Properties.Resources.power_button;
            btnThoat.Location = new Point(-208, 586);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(577, 67);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "                      Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += button4_Click;
            btnThoat.MouseEnter += btnDangNhap_MouseEnter;
            btnThoat.MouseHover += btnDangNhap_MouseHover;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 1068);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 1070);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnThoat;
        private Button btnThongTin;
        private Button btnDoiMK;
        private Button btnDangNhap;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
    }
}
