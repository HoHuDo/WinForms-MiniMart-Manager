using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLNhapHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        bool isLoading = false;
        public frmQLNhapHang()
        {
            InitializeComponent();
        }

        private void frmQLNhapHang_Load(object sender, EventArgs e)
        {
            lblTenTk.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            DataTable dtPhieuNhap = dtBase.ReadData("Select * From PhieuNhap");
            dgvPhieuNhap.DataSource = dtPhieuNhap;
            dgvPhieuNhap.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dgvPhieuNhap.Columns[2].HeaderText = "Mã Mã Nhân Viên";
            dgvPhieuNhap.Columns[3].HeaderText = "Ngày Nhập";
            dgvPhieuNhap.Columns[4].HeaderText = "Tổng Tiền";

            cbxMaSP.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham From SanPham");
            cbxMaSP.DisplayMember = "TenSanPham";
            cbxMaSP.ValueMember = "MaSanPham";

            cbxMaNCC.DataSource = dtBase.ReadData("Select MaNhaCungCap, TenNhaCungCap From NhaCungCap");
            cbxMaNCC.DisplayMember = "TenNhaCungCap";
            cbxMaNCC.ValueMember = "MaNhaCungCap";

            cbxMaNV.DataSource = dtBase.ReadData("Select MaNhanVien, TenNhanVien From NhanVien");
            cbxMaNV.DisplayMember = "TenNhanVien";
            cbxMaNV.ValueMember = "MaNhanVien";

            cbxMaSP.SelectedIndex = -1;
            cbxMaNCC.SelectedIndex = -1;
            cbxMaNV.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaPhieuNhap = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            txtMaPN.Text = MaPhieuNhap;
            dgvChiTietPN.DataSource = dtBase.ReadData("Select * From ChiTietPhieuNhap where MaPhieuNhap=N'" + MaPhieuNhap + "'");
            dgvChiTietPN.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgvChiTietPN.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvChiTietPN.Columns[2].HeaderText = "Số Lượng";
            dgvChiTietPN.Columns[3].HeaderText = "Đơn Giá Nhập";
            dgvChiTietPN.Columns[4].HeaderText = "Thành Tiền";
            isLoading = true;
            dtpNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dgvPhieuNhap.CurrentRow.Cells[4].Value.ToString();
            DataTable dtNCC = dtBase.ReadData("Select TenNhaCungCap From NhaCungCap Where MaNhaCungCap=N'" + dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString() + "'");
            if (dtNCC.Rows.Count != 0)
                cbxMaNCC.Text = dtNCC.Rows[0][0].ToString();
            else cbxMaNCC.Text = "";
            DataTable dtNV = dtBase.ReadData("Select TenNhanVien From NhanVien Where MaNhanVien=N'" + dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString() + "'");
            if (dtNV.Rows.Count != 0)
                cbxMaNV.Text = dtNV.Rows[0][0].ToString();
            else cbxMaNV.Text = "";
            isLoading = false;
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isLoading = true;
            DataTable dtTenSp = dtBase.ReadData("Select TenSanPham From SanPham Where MaSanPham=N'" + dgvChiTietPN.CurrentRow.Cells[1].Value.ToString() + "'");
            if (dtTenSp.Rows.Count != 0)
                cbxMaSP.Text = dtTenSp.Rows[0][0].ToString();
            else cbxMaSP.Text = "";


            txtSL.Text = dgvChiTietPN.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvChiTietPN.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvChiTietPN.CurrentRow.Cells[4].Value.ToString();
            txtTongTien.Text = dgvPhieuNhap.CurrentRow.Cells[4].Value.ToString();
            isLoading = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã phiếu nhập!");
                txtMaPN.Focus();
                return;
            }
            if (cbxMaNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn nhà cung cấp!");
                cbxMaNCC.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * From PhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã phiếu nhập này đã tồn tại, bạn phải nhập mã khác!");
                txtMaPN.Focus();
                return;
            }
            dtBase.UpdateData("Insert into PhieuNhap(MaPhieuNhap, MaNhaCungCap, MaNhanVien, NgayNhap, TongTien) values(N'"
                + txtMaPN.Text
                + "', N'"
                + cbxMaNCC.SelectedValue.ToString()
                + "', N'"
                + GlobalData.MaNV
                + "', N'"
                + dtpNgayNhap.Value.ToString("yyyy-MM-dd")
                + "', N'"
                + "0"
                + "')");
            MessageBox.Show("Thêm phiếu nhập thành công!");
            frmQLNhapHang_Load(sender, e);
            ResetValues();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phiếu nhập để sửa!");
                return;
            }
            else
            {
                DataTable dtMPN = dtBase.ReadData("Select * From PhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "'");
                if (dtMPN.Rows.Count > 0 && txtMaPN.Text != dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại, bạn phải nhập mã khác!");
                    txtMaPN.Focus();
                    return;
                }
                if (cbxMaSP.SelectedIndex == -1 && txtSL.Text == "" && txtDonGia.Text == "")
                {
                    dtBase.UpdateData("Update PhieuNhap Set MaPhieuNhap=N'"
                    + txtMaPN.Text
                    + "', MaNhaCungCap=N'"
                    + cbxMaNCC.SelectedValue.ToString()
                    + "', MaNhanVien=N'"
                    + GlobalData.MaNV
                    + "', NgayNhap=N'"
                    + dtpNgayNhap.Value.ToString("yyyy-MM-dd HH:mm:ss.000")
                    + "', TongTien=N'"
                    + txtTongTien.Text
                    + "' Where MaPhieuNhap=N'" + dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString() + "'");
                    MessageBox.Show("Đã Lưu");
                }
                else
                {
                    DataTable dtMsp = dtBase.ReadData("Select * From ChiTietPhieuNhap Where MasanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
                    if (dtMsp.Rows.Count > 0 && txtMaPN.Text != dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Sản phẩm này đã có trong chi tiết phiếu nhập, bạn phải chọn sản phẩm khác!");
                        cbxMaSP.Focus();
                        return;
                    }
                    dtBase.UpdateData("Update ChiTietPhieuNhap Set MaSanPham ='" + cbxMaSP.SelectedValue.ToString() + "', SoLuongNhap='" + txtSL.Text + "',DonGiaNhap='" + txtDonGia.Text + "',ThanhTien='" + txtThanhTien.Text + "' Where MaPhieuNhap='" + txtMaPN.Text + "' and MaSanPham='" + cbxMaSP.SelectedValue.ToString() + "'");
                    MessageBox.Show("Đã Lưu");
                    DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietPhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
                    dtBase.UpdateData("Update PhieuNhap set TongTien =N'" + dtTongTien.Rows[0][0].ToString() + "' Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
                    DataTable dtTongSL = dtBase.ReadData("Select SUM(SoLuongNhap) From ChiTietPhieuNhap Where MaSanPham='" + cbxMaSP.SelectedValue.ToString() + "'");
                    dtBase.UpdateData("Update SanPham Set SoLuongTon=N'" + dtTongSL.Rows[0][0].ToString() + "' Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "';");
                    dtBase.UpdateData("Update SanPham Set GiaNhap=N'" + txtDonGia.Text + "' Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
                    LoadChiTietPhieuNhap(txtMaPN.Text);
                    ResetValues();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void Tìm_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM PhieuNhap WHERE 1=1";
                string kq = "";
                if (!string.IsNullOrEmpty(txtMaPN.Text))
                {
                    sql += " AND MaPhieuNhap LIKE N'%" + txtMaPN.Text.Trim() + "%'";
                    kq += "Mã Phiếu Nhập chứa '" + txtMaPN.Text.Trim() + "' \n";
                }

                if (cbxMaNCC.SelectedValue != null && cbxMaNCC.SelectedIndex != -1)
                {
                    sql += " AND MaNhaCungCap = N'" + cbxMaNCC.SelectedValue.ToString() + "'";
                    kq += "Nhà Cung Cấp: '" + cbxMaNCC.Text + "' \n";
                }

                if (cbxMaNV.SelectedValue != null && cbxMaNV.SelectedIndex != -1)
                {
                    sql += " AND MaNhanVien = N'" + cbxMaNV.SelectedValue.ToString() + "'";
                    kq += "Nhân Viên: '" + cbxMaNV.Text + "' \n";
                }
                if (chkTimTheoNgay.Checked)
                {
                    string ngayNhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
                    sql += " AND CONVERT(DATE, NgayNhap) = '" + ngayNhap + "'";
                    kq += "Ngày Nhập: '" + ngayNhap + "' \n";
                }
                DataTable dtResult = dtBase.ReadData(sql);
                dgvPhieuNhap.DataSource = dtResult;
                if (dtResult.Rows.Count > 0)
                {
                    dgvPhieuNhap.ClearSelection();
                    dgvPhieuNhap.Rows[0].Selected = true;
                    dgvPhieuNhap.CurrentCell = dgvPhieuNhap.Rows[0].Cells[0];
                    dgvPhieuNhap_CellClick(dgvPhieuNhap, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    dgvChiTietPN.DataSource = null;
                }
                if (dtResult.Rows.Count > 0)
                {
                    string maPNDauTien = dtResult.Rows[0]["MaPhieuNhap"].ToString();
                    LoadChiTietPhieuNhap(maPNDauTien);
                }
                else
                {
                    dgvChiTietPN.DataSource = null;
                    MessageBox.Show("Không tìm thấy phiếu nhập nào thỏa mãn các tiêu chí:\n" + kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void LoadChiTietPhieuNhap(string maPN)
        {
            string sqlChiTiet = "SELECT * FROM ChiTietPhieuNhap WHERE MaPhieuNhap = N'" + maPN + "'";
            dgvChiTietPN.DataSource = dtBase.ReadData(sqlChiTiet);
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
            tenTruong.Range["B2"].Value = "DANH SÁCH PHIẾU NHẬP";

            tenTruong.Range["A4:H4"].Font.Size = 13;
            tenTruong.Range["A4:H4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:H4"].Font.Color = Color.Black;
            tenTruong.Range["A4:H4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Phiếu Nhập";
            tenTruong.Range["B4"].Value = "Tên Phiếu Nhập";
            tenTruong.Range["C4"].Value = "Mã Nhân Viên";
            tenTruong.Range["D4"].Value = "Ngày Nhập";
            tenTruong.Range["E4"].Value = "Tổng Tiền";

            string R = dgvPhieuNhap.Rows.Count + 5 + "";

            tenTruong.Range["A4"].ColumnWidth = 10;
            tenTruong.Range["B4"].ColumnWidth = 30;
            tenTruong.Range["C4"].ColumnWidth = 20;
            tenTruong.Range["D4"].ColumnWidth = 20;
            tenTruong.Range["E4"].ColumnWidth = 15;

            tenTruong.Range["A4:H" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:H" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvPhieuNhap.Rows.Count - 1; i++)
            {

                tenTruong.Range["A" + Hang.ToString()].Value = dgvPhieuNhap.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvPhieuNhap.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvPhieuNhap.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvPhieuNhap.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang.ToString()].Value = dgvPhieuNhap.Rows[i].Cells[4].Value.ToString();
                Hang++;

            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 5]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;
            string R2 = (dgvPhieuNhap.Rows.Count + 8).ToString();
            tenTruong.Range["B" + R2].Font.Size = 25;
            tenTruong.Range["B" + R2].Font.Name = "Times New Roman";
            tenTruong.Range["B" + R2].Font.Color = Color.Blue;
            tenTruong.Range["B" + R2].Font.Bold = true;
            tenTruong.Range["B" + R2].Value = "CHI TIẾT PHIẾU NHẬP";
            string K = (5 + int.Parse(R2)).ToString();

            tenTruong.Range["A" + K + ":H" + K].Font.Size = 13;
            tenTruong.Range["A" + K + ":H" + K].Font.Name = "Times New Roman";
            tenTruong.Range["A" + K + ":H" + K].Font.Color = Color.Black;
            tenTruong.Range["A" + K + ":H" + K].Font.Bold = true;

            tenTruong.Range["A" + K].Value = "Mã Phiếu Nhập";
            tenTruong.Range["B" + K].Value = "Mã Sản Phẩm";
            tenTruong.Range["C" + K].Value = "Số Lượng Nhập";
            tenTruong.Range["D" + K].Value = "Đơn Giá Nhập";
            tenTruong.Range["E" + K].Value = "Thành Tiền";
            int Hang2 = int.Parse(K) + 1;
            for (int i = 0; i < dgvChiTietPN.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang2.ToString()].Value = dgvChiTietPN.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang2.ToString()].Value = dgvChiTietPN.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang2.ToString()].Value = dgvChiTietPN.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang2.ToString()].Value = dgvChiTietPN.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang2.ToString()].Value = dgvChiTietPN.Rows[i].Cells[4].Value.ToString();
                Hang2++;
            }
            Excel.Range range2 = exSheet.Range[exSheet.Cells[K, 1], exSheet.Cells[Hang2 - 1, 5]];
            range2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range2.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range2.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachPhieuNhap";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }
        private void TuDongTinhToan(object sender, EventArgs e)
        {
            double soLuong = 0;
            double donGia = 0;


            double.TryParse(txtSL.Text, out soLuong);
            double.TryParse(txtDonGia.Text, out donGia);

            double thanhTienMoi = soLuong * donGia;
            txtThanhTien.Text = thanhTienMoi.ToString("0.##");
            double tongTienDaLuu = 0;
            string maSPDangChon = "";
            if (cbxMaSP.SelectedValue != null)
            {
                maSPDangChon = cbxMaSP.SelectedValue.ToString();
            }
            if (dgvChiTietPN.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvChiTietPN.Rows)
                {
                    if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() != "")
                    {
                        if (maSPDangChon != "" && maSPDangChon == row.Cells[1].Value.ToString())
                        {
                            continue;
                        }

                        tongTienDaLuu += Convert.ToDouble(row.Cells[4].Value);
                    }
                }
            }

            double tongTienHienThi = tongTienDaLuu + thanhTienMoi;
            txtTongTien.Text = tongTienHienThi.ToString("0.##");
        }
        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                TuDongTinhToan(sender, e);

            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                TuDongTinhToan(sender, e);
            }
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            f.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.ShowDialog();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        void ResetValues()
        {
            txtMaPN.Clear();
            cbxMaNCC.SelectedIndex = -1;
            cbxMaNV.SelectedIndex = -1;
            dtpNgayNhap.Value = DateTime.Now;
            txtTongTien.Clear();
            cbxMaSP.SelectedIndex = -1;
            txtSL.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtMaPN.Focus();
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn phiếu nhập trước khi thêm chi tiết phiếu nhập!");
                return;
            }
            if (cbxMaSP.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn sản phẩm!");
                cbxMaSP.Focus();
                return;
            }
            if (txtSL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng!");
                txtSL.Focus();
                return;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá!");
                txtDonGia.Focus();
                return;
            }
            DataTable dt = dtBase.ReadData("Select * From ChiTietPhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "' and MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết phiếu nhập, bạn phải chọn sản phẩm khác!");
                cbxMaSP.Focus();
                return;
            }
            dtBase.UpdateData("Insert into ChiTietPhieuNhap(MaPhieuNhap, MaSanPham, SoLuongNhap, DonGiaNhap, ThanhTien) values(N'"
                + txtMaPN.Text
                + "', N'"
                + cbxMaSP.SelectedValue.ToString()
                + "', N'"
                + txtSL.Text
                + "', N'"
                + txtDonGia.Text
                + "', N'"
                + txtThanhTien.Text
                + "')");
            DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietPhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
            dtBase.UpdateData("Update PhieuNhap set TongTien =N'" + dtTongTien.Rows[0][0].ToString() + "' Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
            DataTable dtTongSL = dtBase.ReadData("Select SUM(SoLuongNhap) From ChiTietPhieuNhap Where MaSanPham='" + cbxMaSP.SelectedValue.ToString() + "'");
            dtBase.UpdateData("Update SanPham Set SoLuongTon=N'" + dtTongSL.Rows[0][0].ToString() + "' Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "';");
            MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
            LoadChiTietPhieuNhap(txtMaPN.Text);
            ResetValues();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.CurrentRow == null || dgvPhieuNhap.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Bạn phải chọn phiếu nhập để xóa!");
                return;
            }

            string maPN = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu nhập " + maPN + " và tất cả chi tiết không? Thao tác này sẽ GIẢM số lượng tồn kho!",
                "Xác Nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sqlSelectDetails = "SELECT MaSanPham, SoLuongNhap FROM ChiTietPhieuNhap WHERE MaPhieuNhap=N'" + maPN + "'";
                    DataTable dtChiTiet = dtBase.ReadData(sqlSelectDetails);

                    if (dtChiTiet.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtChiTiet.Rows)
                        {
                            string maSP = row["MaSanPham"].ToString();
                            int soLuongHoanLai = Convert.ToInt32(row["SoLuongNhap"]);
                            string sqlUpdateStock = "UPDATE SanPham SET SoLuongTon = SoLuongTon - " + soLuongHoanLai + " WHERE MaSanPham=N'" + maSP + "'";

                            dtBase.UpdateData(sqlUpdateStock);
                        }
                    }
                    dtBase.UpdateData("DELETE FROM ChiTietPhieuNhap WHERE MaPhieuNhap=N'" + maPN + "'");
                    dtBase.UpdateData("DELETE FROM PhieuNhap WHERE MaPhieuNhap=N'" + maPN + "'");
                    frmQLNhapHang_Load(sender, e);
                    ResetValues();
                    MessageBox.Show("Xóa phiếu nhập và cập nhật tồn kho thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu nhập: " + ex.Message, "Lỗi Xóa Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPN.Rows.Count == null)
            {
                MessageBox.Show("Bạn phải chọn chi tiết phiếu nhập để xóa!");
                return;
            }
            else
            {
                dtBase.UpdateData("Delete From ChiTietPhieuNhap Where MaPhieuNhap=N'" + dgvChiTietPN.CurrentRow.Cells[0].Value.ToString() + "' and MaSanPham=N'" + dgvChiTietPN.CurrentRow.Cells[1].Value.ToString() + "'");
                DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietPhieuNhap Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
                dtBase.UpdateData("Update PhieuNhap set TongTien =N'" + dtTongTien.Rows[0][0].ToString() + "' Where MaPhieuNhap=N'" + txtMaPN.Text + "';");
                DataTable dtTongSL = dtBase.ReadData("Select SUM(SoLuongNhap) From ChiTietPhieuNhap Where MaSanPham='" + cbxMaSP.SelectedValue.ToString() + "'");
                dtBase.UpdateData("Update SanPham Set SoLuongTon=N'" + dtTongSL.Rows[0][0].ToString() + "' Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "';");
                frmQLNhapHang_Load(sender, e);
                ResetValues();
                MessageBox.Show("Xóa chi tiết phiếu nhập thành công!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            frmQLNhapHang_Load(sender, e);
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
