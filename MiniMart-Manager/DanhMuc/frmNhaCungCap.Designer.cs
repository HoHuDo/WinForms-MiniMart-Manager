namespace MiniMart_Manager.DanhMuc
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            txtDiaChi = new TextBox();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            grbChucNang = new GroupBox();
            btnThoat = new Button();
            btnXuat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBoQua = new Button();
            btnThem = new Button();
            label5 = new Label();
            lblMa = new Label();
            grbThongTin = new GroupBox();
            panel2 = new Panel();
            txtTimTen = new TextBox();
            label3 = new Label();
            lblTongSo = new Label();
            txtSDT = new TextBox();
            label2 = new Label();
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvNhaCC = new DataGridView();
            lblTenTK = new Label();
            label1 = new Label();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            lblCurrentPage = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPrePage = new Button();
            btnFirstPage = new Button();
            panel3 = new Panel();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(781, 76);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(323, 139);
            txtDiaChi.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(225, 269);
            txtTenNCC.Margin = new Padding(2);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(302, 34);
            txtTenNCC.TabIndex = 1;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(225, 116);
            txtMaNCC.Margin = new Padding(2);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(145, 34);
            txtMaNCC.TabIndex = 1;
            // 
            // grbChucNang
            // 
            grbChucNang.BackColor = SystemColors.ButtonHighlight;
            grbChucNang.Controls.Add(btnThoat);
            grbChucNang.Controls.Add(btnXuat);
            grbChucNang.Controls.Add(btnSua);
            grbChucNang.Controls.Add(btnXoa);
            grbChucNang.Controls.Add(btnBoQua);
            grbChucNang.Controls.Add(btnThem);
            grbChucNang.Dock = DockStyle.Right;
            grbChucNang.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbChucNang.Location = new Point(1144, 92);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(238, 815);
            grbChucNang.TabIndex = 7;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            grbChucNang.Enter += grbChucNang_Enter;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(31, 666);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(174, 62);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "&Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(31, 553);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(174, 62);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất &Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(31, 327);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(174, 62);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(31, 440);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(174, 62);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(31, 214);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(174, 62);
            btnBoQua.TabIndex = 0;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(31, 101);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(174, 62);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 119);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 27);
            label5.TabIndex = 0;
            label5.Text = "Địa Chỉ";
            // 
            // lblMa
            // 
            lblMa.AutoSize = true;
            lblMa.Location = new Point(28, 119);
            lblMa.Margin = new Padding(2, 0, 2, 0);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(175, 27);
            lblMa.TabIndex = 0;
            lblMa.Text = "Mã Nhà Cung Cấp";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(panel2);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtSDT);
            grbThongTin.Controls.Add(txtTenNCC);
            grbThongTin.Controls.Add(txtMaNCC);
            grbThongTin.Controls.Add(label2);
            grbThongTin.Controls.Add(label5);
            grbThongTin.Controls.Add(label4);
            grbThongTin.Controls.Add(lblMa);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 92);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(1144, 389);
            grbThongTin.TabIndex = 6;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(txtTimTen);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTongSo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(2, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 53);
            panel2.TabIndex = 8;
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(223, 9);
            txtTimTen.Margin = new Padding(2);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(246, 34);
            txtTimTen.TabIndex = 3;
            txtTimTen.TextChanged += txtTimTen_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 24);
            label3.TabIndex = 2;
            label3.Text = "Nhập Tên NCC:";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(600, 16);
            lblTongSo.Margin = new Padding(2, 0, 2, 0);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(58, 27);
            lblTongSo.TabIndex = 0;
            lblTongSo.Text = "Tổng";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(781, 269);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(323, 34);
            txtSDT.TabIndex = 1;
            txtSDT.TextChanged += txtSDT_TextChanged;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 269);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(136, 27);
            label2.TabIndex = 0;
            label2.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 269);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 27);
            label4.TabIndex = 0;
            label4.Text = "Tên Nhà Cung Cấp";
            // 
            // dgvNhaCC
            // 
            dgvNhaCC.AllowUserToAddRows = false;
            dgvNhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCC.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhaCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhaCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhaCC.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhaCC.Dock = DockStyle.Fill;
            dgvNhaCC.EnableHeadersVisualStyles = false;
            dgvNhaCC.GridColor = SystemColors.Window;
            dgvNhaCC.Location = new Point(0, 481);
            dgvNhaCC.Margin = new Padding(2);
            dgvNhaCC.Name = "dgvNhaCC";
            dgvNhaCC.RowHeadersVisible = false;
            dgvNhaCC.RowHeadersWidth = 62;
            dgvNhaCC.Size = new Size(1144, 426);
            dgvNhaCC.TabIndex = 5;
            dgvNhaCC.CellClick += dgvNhaCC_CellClick;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(808, 35);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(113, 27);
            lblTenTK.TabIndex = 0;
            lblTenTK.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(26, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(455, 53);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(lblTenTK);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 92);
            panel1.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPage.Location = new Point(534, 10);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(38, 24);
            lblCurrentPage.TabIndex = 1;
            lblCurrentPage.Text = "0/0";
            // 
            // btnLastPage
            // 
            btnLastPage.Cursor = Cursors.Hand;
            btnLastPage.FlatAppearance.BorderSize = 0;
            btnLastPage.FlatStyle = FlatStyle.Flat;
            btnLastPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLastPage.ForeColor = Color.DodgerBlue;
            btnLastPage.Location = new Point(708, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(50, 34);
            btnLastPage.TabIndex = 0;
            btnLastPage.Text = ">>";
            btnLastPage.UseVisualStyleBackColor = true;
            btnLastPage.Click += btnTrangCuoi_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Cursor = Cursors.Hand;
            btnNextPage.FlatAppearance.BorderSize = 0;
            btnNextPage.FlatStyle = FlatStyle.Flat;
            btnNextPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPage.ForeColor = Color.DodgerBlue;
            btnNextPage.Location = new Point(652, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(50, 34);
            btnNextPage.TabIndex = 0;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnSau_Click;
            // 
            // btnPrePage
            // 
            btnPrePage.Cursor = Cursors.Hand;
            btnPrePage.FlatAppearance.BorderSize = 0;
            btnPrePage.FlatStyle = FlatStyle.Flat;
            btnPrePage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrePage.ForeColor = Color.DodgerBlue;
            btnPrePage.Location = new Point(478, 3);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(50, 34);
            btnPrePage.TabIndex = 0;
            btnPrePage.Text = "<";
            btnPrePage.UseVisualStyleBackColor = true;
            btnPrePage.Click += btnTruoc_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.Cursor = Cursors.Hand;
            btnFirstPage.FlatAppearance.BorderSize = 0;
            btnFirstPage.FlatStyle = FlatStyle.Flat;
            btnFirstPage.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirstPage.ForeColor = Color.DodgerBlue;
            btnFirstPage.Location = new Point(422, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(50, 34);
            btnFirstPage.TabIndex = 0;
            btnFirstPage.Text = "<<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnTrangDau_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(lblCurrentPage);
            panel3.Controls.Add(btnLastPage);
            panel3.Controls.Add(btnNextPage);
            panel3.Controls.Add(btnPrePage);
            panel3.Controls.Add(btnFirstPage);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 861);
            panel3.Name = "panel3";
            panel3.Size = new Size(1144, 46);
            panel3.TabIndex = 8;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 907);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(dgvNhaCC);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmNhaCungCap";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmNhacCungCap_Load;
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtDiaChi;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private GroupBox grbChucNang;
        private Label label5;
        private Label lblMa;
        private GroupBox grbThongTin;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvNhaCC;
        private Label lblTenTK;
        private Label label1;
        private Panel panel1;
        private TextBox txtSDT;
        private Label label2;
        private Button btnThoat;
        private Button btnXuat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel2;
        private Button btnBoQua;
        private Label lblTongSo;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtTimTen;
        private Label label3;
        private Label lblCurrentPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPrePage;
        private Button btnFirstPage;
        private Panel panel3;
    }
}