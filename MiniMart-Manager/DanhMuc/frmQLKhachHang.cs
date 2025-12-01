using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLKhachHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        int pageSize = 10;
        int pageIndex = 1;
        int totalPages = 0;
        int totalRecords = 0;

        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            CalculatePagination();
            LoadData();
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số Điện Thoại";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        void CalculatePagination()
        {
            string tenKhach = txtTimTen.Text.Trim();
            string sdt = txtTimSĐT.Text.Trim();

            totalRecords = dtBase.CountRecordsWithFilter(tenKhach, sdt);
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            if (totalPages == 0) pageIndex = 1;
        }

        void LoadData()
        {
            int offset = (pageIndex - 1) * pageSize;
            string tenKhach = txtTimTen.Text.Trim();
            string sdt = txtTimSĐT.Text.Trim();

            DataTable dt = dtBase.ReadPagedDataWithFilter(offset, pageSize, tenKhach, sdt);

            dgvKhachHang.DataSource = dt;
            UpdateUI();
        }

        void UpdateUI()
        {
            lblCurrentPage.Text = $"Trang {pageIndex} / {totalPages}";
            btnFirstPage.Enabled = btnPrePage.Enabled = (pageIndex > 1);
            btnNextPage.Enabled = btnLastPage.Enabled = (pageIndex < totalPages);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            pageIndex = 1;
            CalculatePagination();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count - 1)
            {
                txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtHovaTen.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            }
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách hàng!");
                txtMaKH.Focus();
                return;
            }
            if (txtHovaTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập họ và tên khách hàng!");
                txtHovaTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng!");
                txtDiaChi.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng!");
                txtSDT.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * From KhachHang Where MaKhachHang=N'" + txtMaKH.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải nhập mã khác!");
                txtMaKH.Clear();
                txtMaKH.Focus();
                return;
            }
            dtBase.UpdateData("Insert into KhachHang(MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) values(N'" + txtMaKH.Text + "', N'" + txtHovaTen.Text + "', N'" + txtDiaChi.Text + "', N'" + txtSDT.Text + "')");

            CalculatePagination();
            LoadData();
            ResetValues();
            MessageBox.Show("Cập nhật thành công");
        }

        void ResetValues()
        {
            txtMaKH.Clear();
            txtHovaTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để sửa");
                return;
            }
            else
            {
                bool k = true;
                DataTable dtMKH = dtBase.ReadData("Select * From KhachHang Where MaKhachHang=N'" + txtMaKH.Text + "'");
                if (dtMKH.Rows.Count > 0 && txtMaKH.Text != dgvKhachHang.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại, bạn phải nhập mã khác!");
                    txtMaKH.Clear();
                    txtMaKH.Focus();
                    return;
                }
                DataTable dtHd = dtBase.ReadData("Select * from HoaDon Where MaKhachHang=N'" + dgvKhachHang.CurrentRow.Cells[0].Value.ToString() + "'");
                if (txtMaKH.Text != dgvKhachHang.CurrentRow.Cells[0].Value.ToString())
                {
                    if (dtHd.Rows.Count > 0)
                    {
                        MessageBox.Show("Khách hàng này đang có đơn hàng, vui lòng xóa đơn hàng trước để có thể sửa mã Khách hàng!");
                        k = false;
                    }
                }
                if (k)
                {
                    dtBase.UpdateData("Update KhachHang Set MaKhachHang=N'" + txtMaKH.Text + "', TenKhachHang=N'" + txtHovaTen.Text + "', DiaChi=N'" + txtDiaChi.Text + "', SoDienThoai=N'" + txtSDT.Text + "' Where MaKhachHang=N'" + dgvKhachHang.CurrentRow.Cells[0].Value.ToString() + "'");

                    LoadData();
                    ResetValues();
                    MessageBox.Show("Cập nhật thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa");
                return;
            }
            else
            {
                DataTable dtHd = dtBase.ReadData("Select * from HoaDon Where MaKhachHang=N'" + dgvKhachHang.CurrentRow.Cells[0].Value.ToString() + "'");
                if (dtHd.Rows.Count > 0)
                    MessageBox.Show("Khách hàng này đang có đơn hàng, vui lòng xóa đơn hàng trước để tiếp tục!");
                else
                {
                    dtBase.UpdateData("delete KhachHang where MaKhachHang=N'" + dgvKhachHang.CurrentRow.Cells[0].Value.ToString() + "';");

                    CalculatePagination();
                    LoadData();
                    ResetValues();
                    MessageBox.Show("Xóa thành công");
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            tenTruong.Range["B2"].Value = "DANH SÁCH KHÁCH HÀNG";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Khách Hàng";
            tenTruong.Range["B4"].Value = "Tên Khách Hàng";
            tenTruong.Range["C4"].Value = "Địa Chỉ";
            tenTruong.Range["D4"].Value = "Số Điện Thoại";

            string R = dgvKhachHang.Rows.Count + 5 + "";

            tenTruong.Range["A4:D4"].ColumnWidth = 30;

            tenTruong.Range["A4:D" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:D" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang.ToString()].Value = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvKhachHang.Rows[i].Cells[3].Value.ToString();
                Hang++;
            }
            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 4]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachKhachHang";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }

        private void txtTimSĐT_TextChanged(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(sender, e);
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void grbThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}