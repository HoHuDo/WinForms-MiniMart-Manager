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
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            button2 = new Button();
            btnXuat = new Button();
            panel8 = new Panel();
            label7 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            panel9 = new Panel();
            label8 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 196);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(492, 225);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(538, 399);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(360, 225);
            dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(538, 74);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(360, 225);
            dataGridView4.TabIndex = 3;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(51, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 96);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label2.Location = new Point(48, 47);
            label2.Name = "label2";
            label2.Size = new Size(70, 27);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 8F);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 1;
            label1.Text = "Doanh Thu";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 10);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(311, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(232, 96);
            panel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label4.Location = new Point(49, 47);
            label4.Name = "label4";
            label4.Size = new Size(70, 27);
            label4.TabIndex = 2;
            label4.Text = "label2";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(232, 10);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 8F);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 1;
            label3.Text = "Lợi Nhuận Gộp";
            label3.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(button2);
            panel5.Controls.Add(btnXuat);
            panel5.Controls.Add(dataGridView3);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(dataGridView4);
            panel5.Location = new Point(31, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(920, 739);
            panel5.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            button2.Location = new Point(745, 651);
            button2.Name = "button2";
            button2.Size = new Size(153, 67);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI Variable Display Semib", 9F, FontStyle.Bold);
            btnXuat.Location = new Point(538, 651);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(153, 67);
            btnXuat.TabIndex = 4;
            btnXuat.Text = "In Báo Cáo";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Location = new Point(538, 21);
            panel8.Name = "panel8";
            panel8.Size = new Size(360, 47);
            panel8.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label7.Location = new Point(50, 5);
            label7.Name = "label7";
            label7.Size = new Size(200, 27);
            label7.TabIndex = 2;
            label7.Text = "Hàng Tồn Kho Thấp";
            label7.Click += label2_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(label6);
            panel7.Location = new Point(538, 346);
            panel7.Name = "panel7";
            panel7.Size = new Size(360, 47);
            panel7.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label6.Location = new Point(50, 10);
            label6.Name = "label6";
            label6.Size = new Size(188, 27);
            label6.TabIndex = 2;
            label6.Text = "Hàng Tồn Kho Cao";
            label6.Click += label2_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Location = new Point(23, 440);
            panel9.Name = "panel9";
            panel9.Size = new Size(492, 47);
            panel9.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label8.Location = new Point(50, 10);
            label8.Name = "label8";
            label8.Size = new Size(236, 27);
            label8.TabIndex = 2;
            label8.Text = "Tổng Chi Nhà Cung Cấp";
            label8.Click += label2_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Location = new Point(23, 134);
            panel6.Name = "panel6";
            panel6.Size = new Size(489, 56);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text", 10F, FontStyle.Bold);
            label5.Location = new Point(45, 16);
            label5.Name = "label5";
            label5.Size = new Size(260, 27);
            label5.TabIndex = 2;
            label5.Text = "Tổng Thu Theo Nhân Viên";
            label5.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 493);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(492, 225);
            dataGridView1.TabIndex = 2;
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(990, 803);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBaoCao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo";
            Load += frmBaoCao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btnXuat;
    }
}