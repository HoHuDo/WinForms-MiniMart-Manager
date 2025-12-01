using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmLoaiHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLH.Text = dgvLoaiHang.CurrentRow.Cells[0].Value.ToString();
            txtTenLH.Text = dgvLoaiHang.CurrentRow.Cells[1].Value.ToString();
            txtMoTa.Text = dgvLoaiHang.CurrentRow.Cells[2].Value.ToString();
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            if (GlobalData.Quyen == "Nhân Viên")
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnBoQua.Enabled = false;
            }
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvLoaiHang.DataSource = dtBase.ReadData("Select * From LoaiHang");
            dgvLoaiHang.Columns[0].HeaderText = "Mã Loại Hàng";
            dgvLoaiHang.Columns[1].HeaderText = "Tên Loại Hàng";
            dgvLoaiHang.Columns[2].HeaderText = "Mô Tả";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            DataTable dtTongSl = dtBase.ReadData("Select Count(*) from LoaiHang");
            lblTongSLoai.Text = "Tổng Số Loại Hàng: " + dtTongSl.Rows[0][0].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại hàng!");
                txtMaLH.Focus();
                return;
            }
            if (txtTenLH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng!");
                txtTenLH.Focus();
                return;
            }
            if (txtMoTa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mô tả loại hàng!");
                txtMoTa.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * From LoaiHang Where MaLoaiHang=N'" + txtMaLH.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã loại hàng này đã tồn tại, bạn phải nhập mã khác!");
                txtMaLH.Focus();
                return;
            }
            else
            {
                dtBase.UpdateData("Insert into LoaiHang(MaLoaiHang, TenLoaiHang, MoTa) values(N'" + txtMaLH.Text + "', N'" + txtTenLH.Text + "', N'" + txtMoTa.Text + "')");
                MessageBox.Show("Thêm loại hàng thành công!");
                frmLoaiHang_Load(sender, e);
                ResetValues();

            }

        }
        void ResetValues()
        {
            txtMaLH.Clear();
            txtTenLH.Clear();
            txtMoTa.Clear();
            txtMaLH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã loại hàng!");
                txtMaLH.Focus();
                return;
            }
            if (txtTenLH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng!");
                txtTenLH.Focus();
                return;
            }
            if (txtMoTa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mô tả loại hàng!");
                txtMoTa.Focus();
                return;
            }
            DataTable dtSp = dtBase.ReadData("Select * From SanPham Where MaLoaiHang=N'" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'");
            if (dtSp.Rows.Count > 0 && txtMaLH.Text != dgvLoaiHang.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("Loại hàng này đang có sản phẩm, bạn không thể sửa mã loại hàng!");
                txtMaLH.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * From LoaiHang Where MaLoaiHang=N'" + txtMaLH.Text + "'");
            if (dt.Rows.Count > 0 && txtMaLH.Text != dgvLoaiHang.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("Mã loại hàng này đã tồn tại, bạn phải nhập mã khác!");
                txtMaLH.Focus();
                return;
            }
            else
            {
                dtBase.UpdateData("Update LoaiHang Set MaLoaiHang=N'" + txtMaLH.Text + "', TenLoaiHang=N'" + txtTenLH.Text + "', MoTa=N'" + txtMoTa.Text + "' Where MaLoaiHang=N'" + txtMaLH.Text + "'");
                MessageBox.Show("Sửa thành công!");
                frmLoaiHang_Load(sender, e);
                ResetValues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLoaiHang.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa!");
                return;
            }
            else
            {
                DataTable dtSp = dtBase.ReadData("Select * From SanPham Where MaLoaiHang=N'" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'");
                if (dtSp.Rows.Count > 0)
                {
                    MessageBox.Show("Loại hàng này đang có sản phẩm, bạn không thể xóa!");
                    return;
                }
                dtBase.UpdateData("Delete From LoaiHang Where MaLoaiHang=N'" + dgvLoaiHang.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Xóa loại hàng thành công!");
                frmLoaiHang_Load(sender, e);
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
            tenTruong.Range["B2"].Value = "DANH SÁCH LOẠI HÀNG";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Loại Hàng";
            tenTruong.Range["B4"].Value = "Tên Loại Hàng";
            tenTruong.Range["C4"].Value = "Mô Tả";

            string R = dgvLoaiHang.Rows.Count + 5 + "";

            tenTruong.Range["A4:D4"].ColumnWidth = 30;

            tenTruong.Range["A4:D" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:D" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvLoaiHang.Rows.Count - 1; i++)
            {

                tenTruong.Range["A" + Hang.ToString()].Value = dgvLoaiHang.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvLoaiHang.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvLoaiHang.Rows[i].Cells[2].Value.ToString();
                Hang++;

            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 3]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachLoaiHang";
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
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            dgvLoaiHang.DataSource = dtBase.ReadData("Select * From LoaiHang Where TenLoaiHang Like N'%" + txtTimTen.Text + "%'"); ;

            dgvLoaiHang.Columns[0].HeaderText = "Mã Loại Hàng";
            dgvLoaiHang.Columns[1].HeaderText = "Tên Loại Hàng";
            dgvLoaiHang.Columns[2].HeaderText = "Mô Tả";

        }
    }
}