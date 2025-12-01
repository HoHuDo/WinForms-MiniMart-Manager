using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLTaiKhoan : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvTaiKhoan.DataSource = dtBase.ReadData("Select * from TaiKhoan");
            dgvTaiKhoan.Columns[0].HeaderText = "Tên Tài Khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            dgvTaiKhoan.Columns[2].HeaderText = "Quyền";
            dgvTaiKhoan.Columns[3].HeaderText = "Mã Nhân Viên";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập!");
                txtTenDN.Focus();
                return;
            }
            if (txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!");
                txtMK.Focus();
                return;
            }
            if (cbxQuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn quyền!");
                cbxQuyen.Focus();
                return;
            }
            DataTable dtTDN = dtBase.ReadData("Select * From TaiKhoan Where TenDangNhap=N'" + txtTenDN.Text + "'");
            DataTable dtMNV = dtBase.ReadData("Select * From TaiKhoan Where MaNhanVien=N'" + txtMaNV.Text + "'");
            if (dtTDN.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, bạn phải nhập tên đăng nhập khác!");
                txtTenDN.Focus();
                return;
            }
            if (dtMNV.Rows.Count > 0)
            {
                MessageBox.Show("Mã nhân viên đã có tài khoản, bạn không thể tạo thêm tài khoản cho nhân viên này!");
                txtMaNV.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * from NhanVien Where MaNhanVien=N'" + txtMaNV.Text + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            dtBase.UpdateData("Insert into TaiKhoan(TenDangNhap, MatKhau, Quyen, MaNhanVien) values(N'"
                + txtTenDN.Text
                + "', N'"
                + txtMK.Text
                + "', N'"
                + cbxQuyen.Text
                + "', N'"
                + txtMaNV.Text
                + "')");
            frmQLTaiKhoan_Load(sender, e);
            ResetValues();
            MessageBox.Show("Cập nhật thàng công");


        }
        private void ResetValues()
        {
            txtTenDN.Clear();
            txtMK.Clear();
            cbxQuyen.SelectedIndex = -1;
            txtMaNV.Clear();
            txtTenDN.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.Rows.Count == null)
            {
                MessageBox.Show("Bạn phản chọn phần tử để sửa");
                return;
            }
            else
            {
                DataTable dtTDN = dtBase.ReadData("Select * From TaiKhoan Where TenDangNhap=N'" + txtTenDN.Text + "'");
                if (dtTDN.Rows.Count > 0 && txtTenDN.Text != dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại, bạn phải nhập tên đăng nhập khác!");
                    txtTenDN.Focus();
                    return;
                }
                DataTable dtMNV = dtBase.ReadData("Select * From TaiKhoan Where MaNhanVien=N'" + txtMaNV.Text + "'");
                if (dtMNV.Rows.Count > 0 && txtMaNV.Text != dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString())
                {
                    MessageBox.Show("Mã nhân viên đã có tài khoản, bạn không thể tạo thêm tài khoản cho nhân viên này!");
                    txtMaNV.Focus();
                    return;
                }
                DataTable dt = dtBase.ReadData("Select * from NhanVien Where MaNhanVien=N'" + txtMaNV.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!");
                    return;
                }
                dtBase.UpdateData("Update TaiKhoan Set TenDangNhap=N'" + txtTenDN.Text + "', MatKhau=N'"
                    + txtMK.Text
                    + "', Quyen=N'"
                    + cbxQuyen.Text
                    + "', MaNhanVien=N'"
                    + txtMaNV.Text
                    + "' Where TenDangNhap=N'" + dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString() + "'");
                frmQLTaiKhoan_Load(sender, e);
                ResetValues();
                MessageBox.Show("Cập nhật thàng công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa");
                return;
            }
            else
            {
                dtBase.UpdateData("Delete From TaiKhoan Where TenDangNhap=N'" + dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString() + "'");
                frmQLTaiKhoan_Load(sender, e);
                ResetValues();
                MessageBox.Show("Xóa thàng công");
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
            tenTruong.Range["B2"].Value = "DANH SÁCH TÀI KHOẢN";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Tên Đăng Nhập";
            tenTruong.Range["B4"].Value = "Mật Khẩu";
            tenTruong.Range["C4"].Value = "Quyền";
            tenTruong.Range["D4"].Value = "Mã Nhân Viên";

            string R = dgvTaiKhoan.Rows.Count + 5 + "";

            tenTruong.Range["A4:D4"].ColumnWidth = 30;

            tenTruong.Range["A4:D" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:D" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvTaiKhoan.Rows.Count - 1; i++)
            {

                tenTruong.Range["A" + Hang.ToString()].Value = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvTaiKhoan.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvTaiKhoan.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvTaiKhoan.Rows[i].Cells[3].Value.ToString();
                Hang++;

            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 5]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachTaiKhoan";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
            txtTenDN.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            cbxQuyen.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimMa_TextChanged(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = dtBase.ReadData("Select * from TaiKhoan where MaNhanVien Like N'%" + txtTimMa.Text + "%'");
            dgvTaiKhoan.Columns[0].HeaderText = "Tên Tài Khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Mật Khẩu";
            dgvTaiKhoan.Columns[2].HeaderText = "Quyền";
            dgvTaiKhoan.Columns[3].HeaderText = "Mã Nhân Viên";
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            ResetValues();
        }
    }
}