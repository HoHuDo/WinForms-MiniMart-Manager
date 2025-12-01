namespace MiniMart_Manager.DanhMuc
{
    partial class frmCauHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCauHinh));
            panel1 = new Panel();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            txtDiaChi = new TextBox();
            txtPhienBan = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtTenCuaHang = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnLuuCnn = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            cbxAuth = new ComboBox();
            chkTrust = new CheckBox();
            txtPass = new TextBox();
            txtID = new TextBox();
            txtDataName = new TextBox();
            txtDataSource = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 731);
            panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            btnLuu.Image = Properties.Resources.save;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(601, 648);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(132, 59);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "      Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtPhienBan);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenCuaHang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 40);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(696, 592);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thôn Tin Phần mềm";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(194, 440);
            txtMoTa.Margin = new Padding(2);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(376, 114);
            txtMoTa.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(194, 252);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(376, 92);
            txtDiaChi.TabIndex = 2;
            // 
            // txtPhienBan
            // 
            txtPhienBan.Location = new Point(194, 364);
            txtPhienBan.Margin = new Padding(2);
            txtPhienBan.Name = "txtPhienBan";
            txtPhienBan.Size = new Size(245, 31);
            txtPhienBan.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 185);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(194, 121);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(245, 31);
            txtSDT.TabIndex = 2;
            // 
            // txtTenCuaHang
            // 
            txtTenCuaHang.Location = new Point(194, 60);
            txtTenCuaHang.Margin = new Padding(2);
            txtTenCuaHang.Name = "txtTenCuaHang";
            txtTenCuaHang.Size = new Size(376, 31);
            txtTenCuaHang.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 440);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 0;
            label6.Text = "Mô Tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 252);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 0;
            label4.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 364);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 0;
            label5.Text = "Phiên Bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Cửa Hàng";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuuCnn);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(820, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 731);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(411, 648);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 59);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "       Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuuCnn
            // 
            btnLuuCnn.Image = Properties.Resources.save;
            btnLuuCnn.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuuCnn.Location = new Point(292, 648);
            btnLuuCnn.Margin = new Padding(2);
            btnLuuCnn.Name = "btnLuuCnn";
            btnLuuCnn.Size = new Size(114, 59);
            btnLuuCnn.TabIndex = 1;
            btnLuuCnn.Text = "       Lưu";
            btnLuuCnn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.loupe;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(50, 648);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(196, 59);
            button1.TabIndex = 1;
            button1.Text = "       Kiểm Tra Kết Nối";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxAuth);
            groupBox2.Controls.Add(chkTrust);
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(txtDataName);
            groupBox2.Controls.Add(txtDataSource);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(50, 40);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(474, 592);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cấu Hình Cơ Sở Dữ Liệu";
            // 
            // cbxAuth
            // 
            cbxAuth.FormattingEnabled = true;
            cbxAuth.Items.AddRange(new object[] { "SQL Server Authentication", "Windows Authentication" });
            cbxAuth.Location = new Point(70, 252);
            cbxAuth.Margin = new Padding(2);
            cbxAuth.Name = "cbxAuth";
            cbxAuth.Size = new Size(316, 33);
            cbxAuth.TabIndex = 6;
            cbxAuth.SelectedIndexChanged += cbxAuth_SelectedIndexChanged;
            // 
            // chkTrust
            // 
            chkTrust.AutoSize = true;
            chkTrust.Location = new Point(70, 471);
            chkTrust.Margin = new Padding(2);
            chkTrust.Name = "chkTrust";
            chkTrust.Size = new Size(217, 29);
            chkTrust.TabIndex = 5;
            chkTrust.Text = " Trust Server Certificate";
            chkTrust.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(70, 415);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(226, 31);
            txtPass.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(70, 334);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(226, 31);
            txtID.TabIndex = 3;
            // 
            // txtDataName
            // 
            txtDataName.Location = new Point(70, 172);
            txtDataName.Margin = new Padding(2);
            txtDataName.Name = "txtDataName";
            txtDataName.Size = new Size(368, 31);
            txtDataName.TabIndex = 2;
            // 
            // txtDataSource
            // 
            txtDataSource.Location = new Point(70, 91);
            txtDataSource.Margin = new Padding(2);
            txtDataSource.Name = "txtDataSource";
            txtDataSource.Size = new Size(374, 31);
            txtDataSource.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 144);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 25);
            label9.TabIndex = 0;
            label9.Text = "Database Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 388);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 0;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 306);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 0;
            label10.Text = "UserID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 225);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 0;
            label8.Text = "Authentication";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 66);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 0;
            label7.Text = "DataSource";
            // 
            // frmCauHinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1384, 731);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmCauHinh";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmCauHinh_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label3;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtTenCuaHang;
        private TextBox txtPhienBan;
        private TextBox txtMoTa;
        private Button btnLuu;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label11;
        private ComboBox cbxAuth;
        private CheckBox chkTrust;
        private TextBox txtPass;
        private TextBox txtID;
        private TextBox txtDataName;
        private TextBox txtDataSource;
        private Button btnThoat;
        private Button btnLuuCnn;
        private Button button1;
    }
}