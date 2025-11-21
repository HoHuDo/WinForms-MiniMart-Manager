namespace MiniMart_Manager.DanhMuc
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            dgvTTNV = new DataGridView();
            dgvTK = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            lblDoanhThu = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lblLoiNhuanGop = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            btnThoat = new Button();
            btnXuat = new Button();
            panel8 = new Panel();
            label7 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel10 = new Panel();
            lblTopSp = new Label();
            dgvTopSp = new DataGridView();
            panel6 = new Panel();
            label5 = new Label();
            dgvTCNCC = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopSp).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTCNCC).BeginInit();
            SuspendLayout();
            // 
            // dgvTTNV
            // 
            dgvTTNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTTNV.BackgroundColor = SystemColors.ButtonFace;
            dgvTTNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTTNV.Location = new Point(19, 157);
            dgvTTNV.Margin = new Padding(2);
            dgvTTNV.Name = "dgvTTNV";
            dgvTTNV.RowHeadersWidth = 62;
            dgvTTNV.Size = new Size(509, 210);
            dgvTTNV.TabIndex = 1;
            // 
            // dgvTK
            // 
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTK.BackgroundColor = SystemColors.ButtonFace;
            dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTK.Location = new Point(545, 67);
            dgvTK.Margin = new Padding(2);
            dgvTK.Name = "dgvTK";
            dgvTK.RowHeadersWidth = 62;
            dgvTK.Size = new Size(414, 228);
            dgvTK.TabIndex = 3;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblDoanhThu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(41, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 77);
            panel1.TabIndex = 4;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold);
            lblDoanhThu.Location = new Point(34, 32);
            lblDoanhThu.Margin = new Padding(2, 0, 2, 0);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(18, 24);
            lblDoanhThu.TabIndex = 2;
            lblDoanhThu.Text = "1";
            lblDoanhThu.Click += lblDoanhThu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 7.8F);
            label1.Location = new Point(2, 8);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Doanh Thu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 67);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 8);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblLoiNhuanGop);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(273, 17);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 77);
            panel3.TabIndex = 4;
            // 
            // lblLoiNhuanGop
            // 
            lblLoiNhuanGop.AutoSize = true;
            lblLoiNhuanGop.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold);
            lblLoiNhuanGop.Location = new Point(50, 32);
            lblLoiNhuanGop.Margin = new Padding(2, 0, 2, 0);
            lblLoiNhuanGop.Name = "lblLoiNhuanGop";
            lblLoiNhuanGop.Size = new Size(18, 24);
            lblLoiNhuanGop.TabIndex = 2;
            lblLoiNhuanGop.Text = "1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 67);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 8);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 7.8F);
            label3.Location = new Point(2, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 1;
            label3.Text = "Lợi Nhuận Gộp";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(btnThoat);
            panel5.Controls.Add(btnXuat);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(dgvTopSp);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(dgvTTNV);
            panel5.Controls.Add(dgvTCNCC);
            panel5.Controls.Add(dgvTK);
            panel5.Location = new Point(25, 21);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(982, 663);
            panel5.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(832, 576);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(127, 54);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(646, 576);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(138, 54);
            btnXuat.TabIndex = 4;
            btnXuat.Text = "        In Báo Cáo";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Location = new Point(545, 17);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(414, 45);
            panel8.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label7.Location = new Point(130, 9);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 22);
            label7.TabIndex = 2;
            label7.Text = "Hàng Tồn Kho ";
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Location = new Point(19, 384);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(509, 48);
            panel9.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label8.Location = new Point(132, 10);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(202, 22);
            label8.TabIndex = 2;
            label8.Text = "Tổng Chi Nhà Cung Cấp";
            // 
            // panel10
            // 
            panel10.Controls.Add(lblTopSp);
            panel10.Location = new Point(545, 312);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(414, 45);
            panel10.TabIndex = 2;
            // 
            // lblTopSp
            // 
            lblTopSp.AutoSize = true;
            lblTopSp.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            lblTopSp.Location = new Point(101, 12);
            lblTopSp.Margin = new Padding(2, 0, 2, 0);
            lblTopSp.Name = "lblTopSp";
            lblTopSp.Size = new Size(202, 22);
            lblTopSp.TabIndex = 2;
            lblTopSp.Text = "Top Sản Phẩm Bán Chạy";
            // 
            // dgvTopSp
            // 
            dgvTopSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopSp.BackgroundColor = SystemColors.ButtonFace;
            dgvTopSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopSp.Location = new Point(545, 362);
            dgvTopSp.Margin = new Padding(2);
            dgvTopSp.Name = "dgvTopSp";
            dgvTopSp.RowHeadersWidth = 62;
            dgvTopSp.Size = new Size(414, 206);
            dgvTopSp.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Location = new Point(18, 107);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(509, 45);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label5.Location = new Point(121, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(217, 22);
            label5.TabIndex = 2;
            label5.Text = "Tổng Thu Theo Nhân Viên";
            // 
            // dgvTCNCC
            // 
            dgvTCNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTCNCC.BackgroundColor = SystemColors.ButtonFace;
            dgvTCNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTCNCC.Location = new Point(19, 426);
            dgvTCNCC.Margin = new Padding(2);
            dgvTCNCC.Name = "dgvTCNCC";
            dgvTCNCC.RowHeadersWidth = 62;
            dgvTCNCC.Size = new Size(509, 204);
            dgvTCNCC.TabIndex = 2;
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1038, 714);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo";
            Load += frmBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopSp).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTCNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvTTNV;
        private DataGridView dgvTKC;
        private DataGridView dgvTK;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label lblDoanhThu;
        private Label label3;
        private Label lblLoiNhuanGop;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private Label label8;
        private DataGridView dgvTCNCC;
        private Button btnThoat;
        private Button btnXuat;
        private Panel panel10;
        private Label lblTopSp;
        private DataGridView dgvTopSp;
    }
}