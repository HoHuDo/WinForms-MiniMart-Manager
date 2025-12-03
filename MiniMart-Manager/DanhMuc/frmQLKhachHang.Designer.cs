namespace MiniMart_Manager.DanhMuc
{
    partial class frmQLKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLKhachHang));
            txtDiaChi = new TextBox();
            dgvKhachHang = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            txtHovaTen = new TextBox();
            txtMaKH = new TextBox();
            lblSDT = new Label();
            btnXuat = new Button();
            lblDiaChi = new Label();
            btnThoat = new Button();
            grbChucNang = new GroupBox();
            btnBoQua = new Button();
            btnThem = new Button();
            lblTen = new Label();
            lblMaKH = new Label();
            grbThongTin = new GroupBox();
            txtSDT = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblTenTK = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblCurrentPage = new Label();
            btnLastPage = new Button();
            btnNextPage = new Button();
            btnPrePage = new Button();
            btnFirstPage = new Button();
            panel3 = new Panel();
            txtTimSĐT = new TextBox();
            txtTimTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            grbChucNang.SuspendLayout();
            grbThongTin.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(626, 48);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(230, 70);
            txtDiaChi.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.Control;
            dgvKhachHang.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.Location = new Point(0, 317);
            dgvKhachHang.Margin = new Padding(2);
            dgvKhachHang.Name = "dgvKhachHang";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(974, 308);
            dgvKhachHang.TabIndex = 13;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.refresh;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(60, 238);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(132, 50);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(60, 332);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(132, 50);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtHovaTen
            // 
            txtHovaTen.Location = new Point(151, 138);
            txtHovaTen.Margin = new Padding(2);
            txtHovaTen.Name = "txtHovaTen";
            txtHovaTen.Size = new Size(201, 30);
            txtHovaTen.TabIndex = 1;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(151, 51);
            txtMaKH.Margin = new Padding(2);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(201, 30);
            txtMaKH.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(498, 138);
            lblSDT.Margin = new Padding(2, 0, 2, 0);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(115, 22);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "Số Điện Thoại";
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Image = Properties.Resources.excel;
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(60, 426);
            btnXuat.Margin = new Padding(2);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(132, 50);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "       Xuất Excel";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(498, 54);
            lblDiaChi.Margin = new Padding(2, 0, 2, 0);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(65, 22);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 192, 192);
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Image = Properties.Resources.logout32px;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(60, 519);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(132, 50);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
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
            grbChucNang.Location = new Point(974, 74);
            grbChucNang.Margin = new Padding(2);
            grbChucNang.Name = "grbChucNang";
            grbChucNang.Padding = new Padding(2);
            grbChucNang.Size = new Size(231, 588);
            grbChucNang.TabIndex = 15;
            grbChucNang.TabStop = false;
            grbChucNang.Text = "Chức Năng";
            // 
            // btnBoQua
            // 
            btnBoQua.Image = Properties.Resources.right_arrow__1_;
            btnBoQua.ImageAlign = ContentAlignment.MiddleLeft;
            btnBoQua.Location = new Point(60, 145);
            btnBoQua.Margin = new Padding(2);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(132, 50);
            btnBoQua.TabIndex = 0;
            btnBoQua.Text = "Bỏ Qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.more;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(60, 51);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(132, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(21, 138);
            lblTen.Margin = new Padding(2, 0, 2, 0);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(84, 22);
            lblTen.TabIndex = 0;
            lblTen.Text = "Họ và Tên";
            // 
            // lblMaKH
            // 
            lblMaKH.AutoSize = true;
            lblMaKH.Location = new Point(22, 54);
            lblMaKH.Margin = new Padding(2, 0, 2, 0);
            lblMaKH.Name = "lblMaKH";
            lblMaKH.Size = new Size(132, 22);
            lblMaKH.TabIndex = 0;
            lblMaKH.Text = "Mã Khách Hàng";
            // 
            // grbThongTin
            // 
            grbThongTin.BackColor = SystemColors.ButtonHighlight;
            grbThongTin.Controls.Add(txtSDT);
            grbThongTin.Controls.Add(txtHovaTen);
            grbThongTin.Controls.Add(txtDiaChi);
            grbThongTin.Controls.Add(txtMaKH);
            grbThongTin.Controls.Add(lblSDT);
            grbThongTin.Controls.Add(lblDiaChi);
            grbThongTin.Controls.Add(lblTen);
            grbThongTin.Controls.Add(lblMaKH);
            grbThongTin.Dock = DockStyle.Top;
            grbThongTin.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            grbThongTin.Location = new Point(0, 74);
            grbThongTin.Margin = new Padding(2);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Padding = new Padding(2);
            grbThongTin.Size = new Size(974, 211);
            grbThongTin.TabIndex = 14;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông Tin";
            grbThongTin.Enter += grbThongTin_Enter;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(626, 138);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(201, 30);
            txtSDT.TabIndex = 1;
            txtSDT.KeyPress += txtSDT_KeyPress;
            // 
            // lblTenTK
            // 
            lblTenTK.AutoSize = true;
            lblTenTK.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            lblTenTK.Location = new Point(626, 24);
            lblTenTK.Margin = new Padding(2, 0, 2, 0);
            lblTenTK.Name = "lblTenTK";
            lblTenTK.Size = new Size(96, 22);
            lblTenTK.TabIndex = 0;
            lblTenTK.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 20F, FontStyle.Bold);
            label1.Location = new Point(21, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Khách Hàng";
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
            panel1.Size = new Size(1205, 74);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lblCurrentPage);
            panel2.Controls.Add(btnLastPage);
            panel2.Controls.Add(btnNextPage);
            panel2.Controls.Add(btnPrePage);
            panel2.Controls.Add(btnFirstPage);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 625);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 37);
            panel2.TabIndex = 2;
            // 
            // lblCurrentPage
            // 
            lblCurrentPage.AutoSize = true;
            lblCurrentPage.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPage.Location = new Point(427, 8);
            lblCurrentPage.Margin = new Padding(2, 0, 2, 0);
            lblCurrentPage.Name = "lblCurrentPage";
            lblCurrentPage.Size = new Size(31, 20);
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
            btnLastPage.Location = new Point(566, 2);
            btnLastPage.Margin = new Padding(2, 2, 2, 2);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(40, 27);
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
            btnNextPage.Location = new Point(522, 2);
            btnNextPage.Margin = new Padding(2, 2, 2, 2);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(40, 27);
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
            btnPrePage.Location = new Point(382, 2);
            btnPrePage.Margin = new Padding(2, 2, 2, 2);
            btnPrePage.Name = "btnPrePage";
            btnPrePage.Size = new Size(40, 27);
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
            btnFirstPage.Location = new Point(338, 2);
            btnFirstPage.Margin = new Padding(2, 2, 2, 2);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(40, 27);
            btnFirstPage.TabIndex = 0;
            btnFirstPage.Text = "<<";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnTrangDau_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(txtTimSĐT);
            panel3.Controls.Add(txtTimTen);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 285);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(974, 32);
            panel3.TabIndex = 16;
            // 
            // txtTimSĐT
            // 
            txtTimSĐT.Location = new Point(626, 4);
            txtTimSĐT.Margin = new Padding(2, 2, 2, 2);
            txtTimSĐT.Name = "txtTimSĐT";
            txtTimSĐT.Size = new Size(201, 27);
            txtTimSĐT.TabIndex = 0;
            txtTimSĐT.TextChanged += txtTimSĐT_TextChanged;
            // 
            // txtTimTen
            // 
            txtTimTen.Location = new Point(151, 5);
            txtTimTen.Margin = new Padding(2, 2, 2, 2);
            txtTimTen.Name = "txtTimTen";
            txtTimTen.Size = new Size(201, 27);
            txtTimTen.TabIndex = 0;
            txtTimTen.TextChanged += txtTimTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 0;
            label2.Text = "Tìm Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold);
            label3.Location = new Point(498, 7);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 0;
            label3.Text = "Tìm SĐT";
            // 
            // frmQLKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 662);
            ControlBox = false;
            Controls.Add(dgvKhachHang);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(grbThongTin);
            Controls.Add(grbChucNang);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "frmQLKhachHang";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmQLKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            grbChucNang.ResumeLayout(false);
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDiaChi;
        private DataGridView dgvKhachHang;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtHovaTen;
        private TextBox txtMaKH;
        private Label lblSDT;
        private Button btnXuat;
        private Label lblDiaChi;
        private Button btnThoat;
        private GroupBox grbChucNang;
        private Button btnThem;
        private Label lblTen;
        private Label lblMaKH;
        private GroupBox grbThongTin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblTenTK;
        private Label label1;
        private Panel panel1;
        private TextBox txtSDT;
        private Panel panel2;
        private Label lblCurrentPage;
        private Button btnLastPage;
        private Button btnNextPage;
        private Button btnPrePage;
        private Button btnFirstPage;
        private Panel panel3;
        private Button btnBoQua;
        private TextBox txtTimSĐT;
        private TextBox txtTimTen;
        private Label label2;
        private Label label3;
    }
}