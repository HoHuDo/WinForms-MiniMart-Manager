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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            dgvTTNV = new DataGridView();
            dgvTK = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblDoanhThu = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            lblLoiNhuanGop = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            btnThoat = new MiniMart_Manager.Classes.RoundedButton();
            btnXuat = new MiniMart_Manager.Classes.RoundedButton();
            customPanel4 = new MiniMart_Manager.Classes.CustomPanel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            customPanel3 = new MiniMart_Manager.Classes.CustomPanel();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            customPanel2 = new MiniMart_Manager.Classes.CustomPanel();
            pictureBox5 = new PictureBox();
            lblTopSp = new Label();
            customPanel1 = new MiniMart_Manager.Classes.CustomPanel();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            dgvTopSp = new DataGridView();
            dgvTCNCC = new DataGridView();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            customPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopSp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTCNCC).BeginInit();
            SuspendLayout();
            // 
            // dgvTTNV
            // 
            dgvTTNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTTNV.BackgroundColor = SystemColors.ButtonFace;
            dgvTTNV.BorderStyle = BorderStyle.None;
            dgvTTNV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTTNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTTNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTTNV.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTTNV.EnableHeadersVisualStyles = false;
            dgvTTNV.GridColor = SystemColors.Window;
            dgvTTNV.Location = new Point(19, 157);
            dgvTTNV.Margin = new Padding(2);
            dgvTTNV.Name = "dgvTTNV";
            dgvTTNV.RowHeadersVisible = false;
            dgvTTNV.RowHeadersWidth = 62;
            dgvTTNV.Size = new Size(509, 210);
            dgvTTNV.TabIndex = 1;
            // 
            // dgvTK
            // 
            dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTK.BackgroundColor = SystemColors.ButtonFace;
            dgvTK.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTK.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTK.EnableHeadersVisualStyles = false;
            dgvTK.GridColor = SystemColors.Window;
            dgvTK.Location = new Point(545, 67);
            dgvTK.Margin = new Padding(2);
            dgvTK.Name = "dgvTK";
            dgvTK.RowHeadersVisible = false;
            dgvTK.RowHeadersWidth = 62;
            dgvTK.Size = new Size(414, 228);
            dgvTK.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblDoanhThu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(45, 38);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 77);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profit__1_;
            pictureBox1.Location = new Point(164, 3);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 65);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold);
            lblDoanhThu.Location = new Point(24, 32);
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
            panel2.Size = new Size(229, 8);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(lblLoiNhuanGop);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(273, 17);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 77);
            panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.profit;
            pictureBox2.Location = new Point(182, 2);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 65);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblLoiNhuanGop
            // 
            lblLoiNhuanGop.AutoSize = true;
            lblLoiNhuanGop.Font = new Font("Segoe UI Variable Text", 10.8F, FontStyle.Bold);
            lblLoiNhuanGop.Location = new Point(34, 32);
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
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnThoat);
            panel5.Controls.Add(btnXuat);
            panel5.Controls.Add(customPanel4);
            panel5.Controls.Add(customPanel3);
            panel5.Controls.Add(customPanel2);
            panel5.Controls.Add(customPanel1);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(dgvTopSp);
            panel5.Controls.Add(dgvTTNV);
            panel5.Controls.Add(dgvTCNCC);
            panel5.Controls.Add(dgvTK);
            panel5.Location = new Point(25, 21);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(983, 664);
            panel5.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.Location = new Point(842, 582);
            btnThoat.Margin = new Padding(2, 2, 2, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 48);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold);
            btnXuat.Location = new Point(692, 582);
            btnXuat.Margin = new Padding(2, 2, 2, 2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(117, 48);
            btnXuat.TabIndex = 10;
            btnXuat.Text = "In Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.FromArgb(255, 192, 192);
            customPanel4.Controls.Add(pictureBox3);
            customPanel4.Controls.Add(label5);
            customPanel4.Location = new Point(19, 98);
            customPanel4.Margin = new Padding(2, 2, 2, 2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(509, 54);
            customPanel4.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.grouping;
            pictureBox3.Location = new Point(12, 13);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label5.Location = new Point(57, 13);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(217, 22);
            label5.TabIndex = 2;
            label5.Text = "Tổng Thu Theo Nhân Viên";
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.FromArgb(255, 255, 192);
            customPanel3.BorderRadius = 20;
            customPanel3.Controls.Add(pictureBox6);
            customPanel3.Controls.Add(label8);
            customPanel3.Location = new Point(19, 370);
            customPanel3.Margin = new Padding(2, 2, 2, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(509, 51);
            customPanel3.TabIndex = 8;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.supplier;
            pictureBox6.Location = new Point(10, 12);
            pictureBox6.Margin = new Padding(2, 2, 2, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 28);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label8.Location = new Point(55, 12);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(202, 22);
            label8.TabIndex = 2;
            label8.Text = "Tổng Chi Nhà Cung Cấp";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(192, 255, 255);
            customPanel2.BorderRadius = 20;
            customPanel2.Controls.Add(pictureBox5);
            customPanel2.Controls.Add(lblTopSp);
            customPanel2.Location = new Point(545, 306);
            customPanel2.Margin = new Padding(2, 2, 2, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(414, 52);
            customPanel2.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.products;
            pictureBox5.Location = new Point(22, 10);
            pictureBox5.Margin = new Padding(2, 2, 2, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 30);
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblTopSp
            // 
            lblTopSp.AutoSize = true;
            lblTopSp.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            lblTopSp.Location = new Point(54, 10);
            lblTopSp.Margin = new Padding(2, 0, 2, 0);
            lblTopSp.Name = "lblTopSp";
            lblTopSp.Size = new Size(202, 22);
            lblTopSp.TabIndex = 2;
            lblTopSp.Text = "Top Sản Phẩm Bán Chạy";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(255, 224, 192);
            customPanel1.BorderRadius = 20;
            customPanel1.Controls.Add(pictureBox4);
            customPanel1.Controls.Add(label7);
            customPanel1.Location = new Point(545, 17);
            customPanel1.Margin = new Padding(2, 2, 2, 2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(414, 46);
            customPanel1.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.warehouse;
            pictureBox4.Location = new Point(22, 10);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 30);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label7.Location = new Point(54, 10);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 22);
            label7.TabIndex = 2;
            label7.Text = "Hàng Tồn Kho ";
            // 
            // dgvTopSp
            // 
            dgvTopSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopSp.BackgroundColor = SystemColors.ButtonFace;
            dgvTopSp.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTopSp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTopSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopSp.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTopSp.EnableHeadersVisualStyles = false;
            dgvTopSp.GridColor = SystemColors.Window;
            dgvTopSp.Location = new Point(545, 362);
            dgvTopSp.Margin = new Padding(2);
            dgvTopSp.Name = "dgvTopSp";
            dgvTopSp.RowHeadersVisible = false;
            dgvTopSp.RowHeadersWidth = 62;
            dgvTopSp.Size = new Size(414, 206);
            dgvTopSp.TabIndex = 1;
            // 
            // dgvTCNCC
            // 
            dgvTCNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTCNCC.BackgroundColor = SystemColors.ButtonFace;
            dgvTCNCC.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTCNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTCNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTCNCC.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTCNCC.EnableHeadersVisualStyles = false;
            dgvTCNCC.GridColor = SystemColors.Window;
            dgvTCNCC.Location = new Point(19, 426);
            dgvTCNCC.Margin = new Padding(2);
            dgvTCNCC.Name = "dgvTCNCC";
            dgvTCNCC.RowHeadersVisible = false;
            dgvTCNCC.RowHeadersWidth = 62;
            dgvTCNCC.Size = new Size(509, 204);
            dgvTCNCC.TabIndex = 2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1038, 714);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmBaoCao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTTNV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTK).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            customPanel3.ResumeLayout(false);
            customPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopSp).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTCNCC).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvTTNV;
        private DataGridView dgvTKC;
        private DataGridView dgvTK;
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
        private Label label6;
        private Label label5;
        private Label label8;
        private DataGridView dgvTCNCC;
        private Label lblTopSp;
        private DataGridView dgvTopSp;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Classes.CustomPanel customPanel1;
        private PictureBox pictureBox4;
        private Label label7;
        private Classes.CustomPanel customPanel4;
        private Classes.CustomPanel customPanel3;
        private Classes.CustomPanel customPanel2;
        private Classes.RoundedButton btnXuat;
        private Classes.RoundedButton btnThoat;
    }
}