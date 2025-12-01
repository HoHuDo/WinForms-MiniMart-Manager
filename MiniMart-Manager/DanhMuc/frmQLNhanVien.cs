using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLNhanVien : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();

        int pageSize = 10;
        int pageIndex = 1;
        int totalPages = 0;
        int totalRecords = 0;

        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;

            CalculatePagination();
            LoadData();

            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns[3].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[4].HeaderText = "Ngày Sinh";
            btnSua.Enabled = btnXoa.Enabled = false;
            DataTable slnv = dtBase.ReadData("Select COUNT(MaNhanVien) as SLNV From NhanVien");
            lblSLNV.Text = "Số Lượng Nhân Viên: " + slnv.Rows[0]["SLNV"].ToString();
        }
        void CalculatePagination()
        {
            string tenNV = txtTimTen.Text.Trim();

            totalRecords = dtBase.CountNhanVien(tenNV);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            if (totalPages == 0) pageIndex = 1;
        }

        void LoadData()
        {
            int offset = (pageIndex - 1) * pageSize;
            string tenNV = txtTimTen.Text.Trim();

            DataTable dt = dtBase.ReadPagedNhanVien(offset, pageSize, tenNV);
            dgvNhanVien.DataSource = dt;

            UpdateUI();
        }

        void UpdateUI()
        {
            lblCurrentPage.Text = $"Trang {pageIndex} / {totalPages}";
            btnFirstPage.Enabled = btnPrePage.Enabled = (pageIndex > 1);
            btnNextPage.Enabled = btnLastPage.Enabled = (pageIndex < totalPages);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 1;
            CalculatePagination();
            LoadData();
        }

        private void btnTrangDau_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            LoadData();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (pageIndex > 1)
            {
                pageIndex--;
                LoadData();
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (pageIndex < totalPages)
            {
                pageIndex++;
                LoadData();
            }
        }

        private void btnTrangCuoi_Click(object sender, EventArgs e)
        {
            pageIndex = totalPages;
            LoadData();
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count - 1)
            {
                txtMaNv.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHvT.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
                txtChucVu.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
                cbxGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            }
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNv.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập mã nhân viên!"); txtMaNv.Focus(); return; }
            if (txtHvT.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập họ và tên nhân viên!"); txtHvT.Focus(); return; }
            if (txtChucVu.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập chức vụ nhân viên!"); txtChucVu.Focus(); return; }
            if (cbxGioiTinh.Text.Trim() == "") { MessageBox.Show("Bạn phải chọn giới tính nhân viên!"); cbxGioiTinh.Focus(); return; }

            DataTable dtNv = dtBase.ReadData("Select * From NhanVien Where MaNhanVien=N'" + txtMaNv.Text + "'");
            if (dtNv.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại, bạn phải nhập mã khác!");
                txtMaNv.Focus();
                return;
            }

            dtBase.UpdateData("Insert into NhanVien(MaNhanVien, TenNhanVien, ChucVu, GioiTinh, NgaySinh) values(N'" + txtMaNv.Text + "', N'" + txtHvT.Text + "', N'" + txtChucVu.Text + "', N'" + cbxGioiTinh.Text + "', N'" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "')");

            CalculatePagination();
            LoadData();
            ResetValues();
            MessageBox.Show("Thêm nhân viên thành công!");
        }

        void ResetValues()
        {
            txtMaNv.Text = "";
            txtHvT.Text = "";
            txtChucVu.Text = "";
            cbxGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtMaNv.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để sửa");
                return;
            }
            else
            {
                bool k = true;
                DataTable dtMaNv = dtBase.ReadData("Select * from NhanVien Where MaNhanVien=N'" + txtMaNv.Text + "'");
                if (dtMaNv.Rows.Count > 0 && txtMaNv.Text != dgvNhanVien.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại, bạn phải nhập mã khác!");
                    txtMaNv.Focus();
                    return;
                }
                DataTable dtHd = dtBase.ReadData("Select * from HoaDon Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtPn = dtBase.ReadData("Select * from PhieuNhap Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtTk = dtBase.ReadData("Select * from TaiKhoan Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");

                if (txtMaNv.Text != dgvNhanVien.CurrentRow.Cells[0].Value.ToString())
                {
                    if (dtHd.Rows.Count > 0 || dtPn.Rows.Count > 0 || dtTk.Rows.Count > 0)
                    {
                        MessageBox.Show("Không thể sửa mã cho nhân viên này!");
                        k = false;
                    }
                }
                if (k)
                {
                    dtBase.UpdateData("Update NhanVien Set MaNhanVien=N'" + txtMaNv.Text + "', TenNhanVien=N'" + txtHvT.Text + "', ChucVu=N'" + txtChucVu.Text + "', GioiTinh=N'" + cbxGioiTinh.Text + "', NgaySinh=N'" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "' Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");

                    LoadData();
                    ResetValues();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa");
                return;
            }
            else
            {
                DataTable dtHd = dtBase.ReadData("Select * from HoaDon Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtPn = dtBase.ReadData("Select * from PhieuNhap Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtTk = dtBase.ReadData("Select * from TaiKhoan Where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "'");
                if (dtHd.Rows.Count > 0 || dtPn.Rows.Count > 0 || dtTk.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa nhân viên với mã nhân viên hiện tại");
                    return;
                }
                else
                {
                    dtBase.UpdateData("delete NhanVien where MaNhanVien=N'" + dgvNhanVien.CurrentRow.Cells[0].Value.ToString() + "';");

                    CalculatePagination();
                    LoadData();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1];
            tenTruong.Range["B2"].Font.Size = 25;
            tenTruong.Range["B2"].Font.Name = "Times New Roman";
            tenTruong.Range["B2"].Font.Color = Color.Blue;
            tenTruong.Range["B2"].Font.Bold = true;
            tenTruong.Range["B2"].Value = "DANH SÁCH NHÂN VIÊN";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Nhân Viên";
            tenTruong.Range["B4"].Value = "Tên Nhân Viên";
            tenTruong.Range["C4"].Value = "Chức Vụ";
            tenTruong.Range["D4"].Value = "Giới Tính";
            tenTruong.Range["E4"].Value = "Ngày Sinh";

            string R = dgvNhanVien.Rows.Count + 5 + "";

            tenTruong.Range["A4:E4"].ColumnWidth = 30;

            tenTruong.Range["A4:D" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:D" + R].Columns.WrapText = true;

            int Hang = 5;
            for (int i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang.ToString()].Value = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang.ToString()].Value = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
                Hang++;
            }
            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 5]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachNhanVien";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}