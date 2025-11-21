namespace MiniMart_Manager.DanhMuc
{
    partial class frmDoiMatKhau
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
            lblTenTK = new Label();
            lblMatKhau = new Label();
            lblMatKhauMoi = new Label();
            lblConfirm = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtTK = new TextBox();
            txtMK = new TextBox();
            txtMKMoi = new TextBox();
            txtXacNhan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            picThoat = new PictureBox();
            lblThoat = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            SuspendLayout();
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(70, 221);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(111, 22);
            lblTenTK.TabIndex = 0;
            lblTenTK.Text = "Tên tài khoản";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblMatKhau.Location = new Point(70, 291);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(143, 22);
            lblMatKhau.TabIndex = 0;
            lblMatKhau.Text = "Mật khẩu hiện tại";
            lblMatKhau.Click += label2_Click;
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblMatKhauMoi.Location = new Point(70, 361);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(116, 22);
            lblMatKhauMoi.TabIndex = 0;
            lblMatKhauMoi.Text = "Mật khẩu mới";
            lblMatKhauMoi.Click += label2_Click;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblConfirm.Location = new Point(70, 431);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(157, 22);
            lblConfirm.TabIndex = 0;
            lblConfirm.Text = "Xác nhận mật khẩu";
            lblConfirm.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(74, 249);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 4);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Location = new Point(74, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 4);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.Location = new Point(74, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(610, 4);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Location = new Point(74, 459);
            panel4.Name = "panel4";
            panel4.Size = new Size(610, 4);
            panel4.TabIndex = 2;
            // 
            // txtTK
            // 
            txtTK.BorderStyle = BorderStyle.None;
            txtTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            txtTK.ForeColor = SystemColors.HotTrack;
            txtTK.Location = new Point(286, 221);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(398, 23);
            txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.None;
            txtMK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            txtMK.ForeColor = Color.FromArgb(255, 128, 128);
            txtMK.Location = new Point(286, 290);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(398, 23);
            txtMK.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            txtMKMoi.BorderStyle = BorderStyle.None;
            txtMKMoi.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            txtMKMoi.ForeColor = Color.FromArgb(0, 192, 0);
            txtMKMoi.Location = new Point(286, 361);
            txtMKMoi.Name = "txtMKMoi";
            txtMKMoi.Size = new Size(398, 23);
            txtMKMoi.TabIndex = 2;
            // 
            // txtXacNhan
            // 
            txtXacNhan.BorderStyle = BorderStyle.None;
            txtXacNhan.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            txtXacNhan.ForeColor = Color.FromArgb(0, 192, 0);
            txtXacNhan.Location = new Point(286, 429);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(398, 23);
            txtXacNhan.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 218);
            label1.Name = "label1";
            label1.Size = new Size(14, 22);
            label1.TabIndex = 0;
            label1.Text = ":";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 289);
            label2.Name = "label2";
            label2.Size = new Size(14, 22);
            label2.TabIndex = 0;
            label2.Text = ":";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 361);
            label3.Name = "label3";
            label3.Size = new Size(14, 22);
            label3.TabIndex = 0;
            label3.Text = ":";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 429);
            label4.Name = "label4";
            label4.Size = new Size(14, 22);
            label4.TabIndex = 0;
            label4.Text = ":";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(70, 507);
            button1.Name = "button1";
            button1.Size = new Size(614, 56);
            button1.TabIndex = 4;
            button1.Text = "Đổi Mật Khẩu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reset_password__2_;
            pictureBox1.Location = new Point(286, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // picThoat
            // 
            picThoat.Image = Properties.Resources.logout;
            picThoat.Location = new Point(580, 604);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(28, 27);
            picThoat.TabIndex = 5;
            picThoat.TabStop = false;
            picThoat.Click += lblThoat_Click_2;
            // 
            // lblThoat
            // 
            lblThoat.AutoSize = true;
            lblThoat.ForeColor = Color.LightCoral;
            lblThoat.Location = new Point(608, 601);
            lblThoat.Name = "lblThoat";
            lblThoat.Size = new Size(53, 22);
            lblThoat.TabIndex = 5;
            lblThoat.Text = "Thoát";
            lblThoat.Click += lblThoat_Click_2;
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(746, 673);
            ControlBox = false;
            Controls.Add(lblThoat);
            Controls.Add(picThoat);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMKMoi);
            Controls.Add(txtMK);
            Controls.Add(txtTK);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(lblConfirm);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenTK);
            Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmDoiMatKhau_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenTK;
        private Label lblMatKhau;
        private Label lblMatKhauMoi;
        private Label lblConfirm;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtTK;
        private TextBox txtMK;
        private TextBox txtMKMoi;
        private TextBox txtXacNhan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox picThoat;
        private Label lblThoat;
    }
}