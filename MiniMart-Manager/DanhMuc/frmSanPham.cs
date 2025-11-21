using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmSanPham : Form
    {
        Classes.ProcessDatabase dtBase = new Classes.ProcessDatabase();
        string imagePath = "";
        private string sourceImagePath = null;
        private string targetDirectory = Path.Combine(Application.StartupPath, "Images");
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            if (GlobalData.Quyen == "Nhân Viên")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnAnh.Enabled = false;
            }
            dgvSanPham.DataSource = dtBase.ReadData("Select * From SanPham");
            DataTable dtLoaiHang = dtBase.ReadData("Select MaLoaiHang, TenLoaiHang From LoaiHang");
            cbxLH.DataSource = dtLoaiHang;
            cbxLH.DisplayMember = "TenLoaiHang";
            cbxLH.ValueMember = "MaLoaiHang";
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã Loại Hàng";
            dgvSanPham.Columns[3].HeaderText = "Đơn Vị Tính";
            dgvSanPham.Columns[4].HeaderText = "Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "Số Lượng Tồn";
            dgvSanPham.Columns[6].HeaderText = "Giá Nhập";
            dgvSanPham.Columns[7].HeaderText = "Ảnh";

            cbxLH.SelectedIndex = -1;

            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
        }

        private void lblTenTK_Click(object sender, EventArgs e)
        {

        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picAnh.ImageLocation = open.FileName;
                sourceImagePath = open.FileName;
                imagePath = System.IO.Path.GetFileName(open.FileName);
            }
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frmLH = new frmLoaiHang();
            frmLH.ShowDialog();
            frmSanPham_Load(sender, e);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            cbxLH.SelectedValue = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            cbxDonViTinh.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtGiaBan.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txtSL.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            txtGiaNhap.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();

            try
            {
                var cellValue = dgvSanPham.CurrentRow.Cells[7].Value;
                string fileName = cellValue != null ? cellValue.ToString().Trim() : "";

                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = Path.Combine(appDirectory, "Images", fileName);

                if (!string.IsNullOrEmpty(fileName) && File.Exists(fullPath))
                {
                    if (picAnh.Image != null) picAnh.Image.Dispose();
                    picAnh.Image = Image.FromFile(fullPath);
                    picAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    if (picAnh.Image != null) picAnh.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm!");
                txtMaSP.Focus();
                return;
            }
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm!");
                txtTenSP.Focus();
                return;
            }
            if (cbxDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn đơn vị tính sản phẩm!");
                cbxDonViTinh.Focus();
                return;
            }
            if (txtGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá bán sản phẩm!");
                txtGiaBan.Focus();
                return;
            }
            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng tồn sản phẩm!");
                txtSL.Focus();
                return;
            }
            if (txtGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá nhập sản phẩm!");
                txtGiaNhap.Focus();
                return;
            }
            if (picAnh.ImageLocation == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh sản phẩm!");
                btnAnh.Focus();
                return;
            }
            if (sourceImagePath == null)
            {
                MessageBox.Show("Chưa lấy được đường dẫn ảnh gốc. Vui lòng chọn lại ảnh.");
                btnAnh.Focus();
                return;
            }
            imagePath = System.IO.Path.GetFileName(picAnh.ImageLocation);
            string targetFilePath = Path.Combine(targetDirectory, imagePath);
            DataTable dt = dtBase.ReadData("Select * From SanPham Where MaSanPham=N'" + txtMaSP.Text + "'");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại, bạn phải nhập mã khác!");
                txtMaSP.Focus();
                return;
            }
            else
            {
                try
                {
                    System.IO.File.Copy(sourceImagePath, targetFilePath, true);
                    dtBase.UpdateData("Insert into SanPham(MaSanPham, TenSanPham, MaLoaiHang, DonViTinh, GiaBan, SoLuongTon, GiaNhap, Anh) values(N'"
                   + txtMaSP.Text
                   + "', N'"
                   + txtTenSP.Text
                   + "', N'"
                   + cbxLH.SelectedValue.ToString()
                   + "', N'"
                   + cbxDonViTinh.Text
                   + "', N'"
                   + txtGiaBan.Text
                   + "', N'"
                   + txtSL.Text
                   + "', N'"
                   + txtGiaNhap.Text
                   + "', N'"
                   + imagePath
                   + "')");
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    frmSanPham_Load(sender, e);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm hoặc lưu ảnh: " + ex.Message);
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để sửa!");
                return;
            }
            else
            {
                DataTable dtCthd = dtBase.ReadData("Select * From ChiTietHoaDon Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtCtpn = dtBase.ReadData("Select * From ChiTietPhieuNhap Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                if ((dtCtpn.Rows.Count > 0 || dtCthd.Rows.Count > 0) && txtMaSP.Text != dgvSanPham.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Bạn không thể sửa mã sản phẩm này!");
                    txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                    txtMaSP.Focus();
                    return;
                }
                DataTable dtMsp = dtBase.ReadData("Select * From SanPham Where MaSanPham=N'" + txtMaSP.Text + "'");
                if (dtMsp.Rows.Count > 0 && txtMaSP.Text != dgvSanPham.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Mã sản phẩm này đã tồn tại, bạn phải nhập mã khác!");
                    txtMaSP.Focus();
                    return;
                }
                dtBase.UpdateData("Update SanPham Set MaSanPham=N'"
                    + txtMaSP.Text
                    + "', TenSanPham=N'"
                    + txtTenSP.Text
                    + "', MaLoaiHang=N'"
                    + cbxLH.SelectedValue.ToString()
                    + "', DonViTinh=N'"
                    + cbxDonViTinh.Text
                    + "', GiaBan=N'"
                    + txtGiaBan.Text
                    + "', SoLuongTon=N'"
                    + txtSL.Text
                    + "', GiaNhap=N'"
                    + txtGiaNhap.Text
                    + "', Anh=N'"
                    + System.IO.Path.GetFileName(picAnh.ImageLocation)
                + "' Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                dtBase.UpdateData("Upadate ChiTietDonNhap Set DonGiaNhap='" + txtGiaNhap.Text + "' Where MaSanPham=N'" + txtMaSP.Text + "'");
                MessageBox.Show("Sửa sản phẩm thành công!");
                frmSanPham_Load(sender, e);
                ResetValues();
            }
        }
        void ResetValues()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cbxLH.SelectedIndex = -1;
            cbxDonViTinh.SelectedIndex = -1;
            txtGiaBan.Clear();
            txtSL.Clear();
            txtGiaNhap.Clear();
            picAnh.Image = null;
            txtMaSP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phần tử để xóa!");
                return;
            }
            else
            {
                DataTable dtCthd = dtBase.ReadData("Select * From ChiTietHoaDon Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                DataTable dtCtpn = dtBase.ReadData("Select * From ChiTietPhieuNhap Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                if (dtCtpn.Rows.Count > 0 || dtCthd.Rows.Count > 0)
                {
                    MessageBox.Show("Sản phẩm này đã có trong phiếu nhập hoặc hóa đơn, bạn không thể xóa!");
                    return;
                }
                dtBase.UpdateData("Delete From SanPham Where MaSanPham=N'" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Xóa sản phẩm thành công!");
                frmSanPham_Load(sender, e);
                ResetValues();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1];

            tenTruong.Range["C2"].Font.Size = 25;
            tenTruong.Range["C2"].Font.Name = "Times New Roman";
            tenTruong.Range["C2"].Font.Color = Color.Blue;
            tenTruong.Range["C2"].Font.Bold = true;
            tenTruong.Range["C2"].Value = "DANH SÁCH SẢN PHẨM";

            tenTruong.Range["A4:H4"].Font.Size = 13;
            tenTruong.Range["A4:H4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:H4"].Font.Color = Color.Black;
            tenTruong.Range["A4:H4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Sản Phẩm";
            tenTruong.Range["B4"].Value = "Tên Sản Phẩm";
            tenTruong.Range["C4"].Value = "Mã Loại Hàng";
            tenTruong.Range["D4"].Value = "Đơn Vị Tính";
            tenTruong.Range["E4"].Value = "Giá Bán";
            tenTruong.Range["F4"].Value = "Số Lượng";
            tenTruong.Range["G4"].Value = "Giá Nhập";
            tenTruong.Range["H4"].Value = "Ảnh";

            string R = dgvSanPham.Rows.Count + 5 + "";

            tenTruong.Range["A4"].ColumnWidth = 10;
            tenTruong.Range["B4"].ColumnWidth = 30;
            tenTruong.Range["C4"].ColumnWidth = 10;
            tenTruong.Range["D4"].ColumnWidth = 10;
            tenTruong.Range["E4"].ColumnWidth = 15;
            tenTruong.Range["F4"].ColumnWidth = 10;
            tenTruong.Range["G4"].ColumnWidth = 15;
            tenTruong.Range["H4"].ColumnWidth = 25;

            tenTruong.Range["A4:H" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:H" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvSanPham.Rows.Count - 1; i++)
            {

                tenTruong.Range["A" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                tenTruong.Range["F" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                tenTruong.Range["G" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[6].Value.ToString();
                tenTruong.Range["H" + Hang.ToString()].Value = dgvSanPham.Rows[i].Cells[7].Value.ToString();
                Hang++;

            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 8]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachSanPham";
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

        private void cbxDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
