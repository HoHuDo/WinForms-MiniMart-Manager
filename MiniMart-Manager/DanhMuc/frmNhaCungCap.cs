using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmNhaCungCap : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        int pageSize = 10;
        int pageIndex = 1;
        int totalPages = 0;
        int totalRecords = 0;

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhacCungCap_Load(object sender, EventArgs e)
        {
            if (GlobalData.Quyen == "Nhân Viên")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnBoQua.Enabled = false;
            }
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;

            CalculatePagination();
            LoadData();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void CalculatePagination()
        {
            string tenNCC = txtTimTen.Text.Trim();
            totalRecords = dtBase.CountNhaCungCap(tenNCC);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            if (totalPages == 0) pageIndex = 1;
            lblTongSo.Text = "Tổng Số Nhà Cung Cấp: " + totalRecords.ToString();
        }

        void LoadData()
        {
            int offset = (pageIndex - 1) * pageSize;
            string tenNCC = txtTimTen.Text.Trim();

            DataTable dt = dtBase.ReadPagedNhaCungCap(offset, pageSize, tenNCC);
            dgvNhaCC.DataSource = dt;

            dgvNhaCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCC.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Số Điện Thoại";
            UpdateUI();
        }

        void UpdateUI()
        {
            lblCurrentPage.Text = $"Trang {pageIndex} / {totalPages}";
            btnFirstPage.Enabled = btnPrePage.Enabled = (pageIndex > 1);
            btnNextPage.Enabled = btnLastPage.Enabled = (pageIndex < totalPages);
        }
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhaCC.Rows.Count - 1)
            {
                txtMaNCC.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();

                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập mã nhà cung cấp!"); txtMaNCC.Focus(); return; }
            if (txtTenNCC.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập tên nhà cung cấp!"); txtTenNCC.Focus(); return; }
            if (txtDiaChi.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp!"); txtDiaChi.Focus(); return; }
            if (txtSDT.Text.Trim() == "") { MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp!"); txtSDT.Focus(); return; }

            DataTable dt = dtBase.ReadData("Select * From NhaCungCap Where MaNhaCungCap=N'" + txtMaNCC.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhà cung cấp này đã tồn tại, bạn phải nhập mã khác!");
                txtMaNCC.Focus();
                return;
            }
            else
            {
                dtBase.UpdateData("Insert into NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, SoDienThoai) values(N'" + txtMaNCC.Text + "', N'" + txtTenNCC.Text + "', N'" + txtDiaChi.Text + "', N'" + txtSDT.Text + "')");
                MessageBox.Show("Thêm nhà cung cấp thành công!");

                CalculatePagination();
                LoadData();
                ResetValues();
            }
        }

        void ResetValues()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMaNCC.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCC.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử đế sửa!");
                return;
            }
            else
            {
                DataTable dtMNCC = dtBase.ReadData("Select * From NhaCungCap Where MaNhaCungCap=N'" + txtMaNCC.Text + "'");
                if (dtMNCC.Rows.Count > 0 && txtMaNCC.Text != dgvNhaCC.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại, bạn phải nhập mã khác!");
                    txtMaNCC.Focus();
                    return;
                }
                DataTable dt = dtBase.ReadData("Select * from PhieuNhap Where MaNhaCungCap=N'" + dgvNhaCC.CurrentRow.Cells[0].Value.ToString() + "'");
                if (dt.Rows.Count > 0 && txtMaNCC.Text != dgvNhaCC.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Nhà cung cấp này đã có trong phiếu nhập, bạn không thể sửa mã nhà cung cấp!");
                    txtMaNCC.Focus();
                    return;
                }
                dtBase.UpdateData("Update NhaCungCap Set MaNhaCungCap=N'" + txtMaNCC.Text + "', TenNhaCungCap=N'" + txtTenNCC.Text + "', DiaChi=N'" + txtDiaChi.Text + "', SoDienThoai=N'" + txtSDT.Text + "' Where MaNhaCungCap=N'" + dgvNhaCC.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");

                LoadData();
                ResetValues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCC.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa!");
                return;
            }
            else
            {
                dtBase.UpdateData("Delete From NhaCungCap Where MaNhaCungCap=N'" + dgvNhaCC.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Xóa nhà cung cấp thành công!");

                CalculatePagination();
                LoadData();
                ResetValues();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            tenTruong.Range["B2"].Value = "DANH SÁCH NHÀ CUNG CẤP";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Nhà Cung Cấp";
            tenTruong.Range["B4"].Value = "Tên Nhà Cung Cấp";
            tenTruong.Range["C4"].Value = "Địa Chỉ";
            tenTruong.Range["D4"].Value = "Số Điện Thoại";

            string R = dgvNhaCC.Rows.Count + 5 + "";
            tenTruong.Range["A4:D4"].ColumnWidth = 30;
            tenTruong.Range["A4:D" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:D" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvNhaCC.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang.ToString()].Value = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
                Hang++;
            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 4]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachNhaCungCap";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            ResetValues();
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

        private void grbChucNang_Enter(object sender, EventArgs e)
        {

        }
    }
}