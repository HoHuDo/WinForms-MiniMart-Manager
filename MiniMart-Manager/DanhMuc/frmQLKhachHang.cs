using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLKhachHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvKhachHang.DataSource = dtBase.ReadData("Select * From KhachHang");
            dgvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số Điện Thoại";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHovaTen.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
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
            frmQLKhachHang_Load(sender, e);
            ResetValues();
            MessageBox.Show("Cập nhật thàng công");

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
            if (dgvKhachHang.Rows.Count == null)
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
                    frmQLKhachHang_Load(sender, e);
                    ResetValues();
                    MessageBox.Show("Cập nhật thàng công");
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
                    frmQLKhachHang_Load(sender, e);
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

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
