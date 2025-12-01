using MiniMart_Manager.Classes;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmHoaDon : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        bool isLoading = false;

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            if (GlobalData.Quyen == "Nhân Viên")
            {
                btnXoaHD.Enabled = false;
                btnXoaCTHD.Enabled = false;
                btnThemHD.Enabled = false;
                btnThemCTHD.Enabled = false;
                btnSua.Enabled = false;
                btnKH.Enabled = false;
                btnBoQua.Enabled = false;
                btnReset.Enabled = false;
            }



            lbluserName.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;



            cbxMaSP.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham From SanPham");
            cbxMaSP.DisplayMember = "TenSanPham";
            cbxMaSP.ValueMember = "MaSanPham";

            cbxMaKH.DataSource = dtBase.ReadData("Select MaKhachHang, TenKhachHang From KhachHang");
            cbxMaKH.DisplayMember = "TenKhachHang";
            cbxMaKH.ValueMember = "MaKhachHang";

            cbxMaNV.DataSource = dtBase.ReadData("Select MaNhanVien, TenNhanVien From NhanVien");
            cbxMaNV.DisplayMember = "TenNhanVien";
            cbxMaNV.ValueMember = "MaNhanVien";

            btnSua.Enabled = false;
            btnXoaCTHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnBoQua.Enabled = false;

            int thang = dtpLoc.Value.Month;
            int nam = dtpLoc.Value.Year;

            DateTime start = new DateTime(nam, thang, 1);
            DateTime end = start.AddMonths(1);

            string sql = $@"
                            SELECT *
                            FROM HoaDon
                            WHERE TRY_CONVERT(datetime, NgayLap, 120) >= '{start:yyyy-MM-dd}'
                            AND TRY_CONVERT(datetime, NgayLap, 120) <  '{end:yyyy-MM-dd}'";

            DataTable dtHoaDon = dtBase.ReadData(sql);
            dgvHoaDon.DataSource = dtHoaDon;
            dgvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dgvHoaDon.Columns[2].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns[4].HeaderText = "Tổng Tiền";

            ResetValues();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            string MaHoaDon = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            txtMaHD.Text = MaHoaDon;

            dgvChiTietHD.DataSource = dtBase.ReadData("Select * From ChiTietHoaDon where MaHoaDon=N'" + MaHoaDon + "'");
            dgvChiTietHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvChiTietHD.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvChiTietHD.Columns[2].HeaderText = "Số Lượng";
            dgvChiTietHD.Columns[3].HeaderText = "Đơn Giá Bán";
            dgvChiTietHD.Columns[4].HeaderText = "Giảm Giá (%)";
            dgvChiTietHD.Columns[5].HeaderText = "Thành Tiền";

            isLoading = true;
            dtpNgayNhap.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();

            DataTable dtKH = dtBase.ReadData("Select TenKhachHang From KhachHang Where MaKhachHang=N'" + dgvHoaDon.CurrentRow.Cells[1].Value.ToString() + "'");
            if (dtKH.Rows.Count != 0)
                cbxMaKH.Text = dtKH.Rows[0][0].ToString();
            else cbxMaKH.Text = "";

            DataTable dtNV = dtBase.ReadData("Select TenNhanVien From NhanVien Where MaNhanVien=N'" + dgvHoaDon.CurrentRow.Cells[2].Value.ToString() + "'");
            if (dtNV.Rows.Count != 0)
                cbxMaNV.Text = dtNV.Rows[0][0].ToString();
            else cbxMaNV.Text = "";

            isLoading = false;
            btnThemHD.Enabled = false;
            btnSua.Enabled = true;
            btnXoaHD.Enabled = true;
            btnBoQua.Enabled = true;
            btnXoaCTHD.Enabled = false;
        }

        private void dgvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietHD.CurrentRow == null) return;

            isLoading = true;
            DataTable dtTenSp = dtBase.ReadData("Select TenSanPham From SanPham Where MaSanPham=N'" + dgvChiTietHD.CurrentRow.Cells[1].Value.ToString() + "'");
            if (dtTenSp.Rows.Count != 0)
                cbxMaSP.Text = dtTenSp.Rows[0][0].ToString();
            else cbxMaSP.Text = "";

            txtSL.Text = dgvChiTietHD.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvChiTietHD.CurrentRow.Cells[3].Value.ToString();
            txtGiamGia.Text = dgvChiTietHD.CurrentRow.Cells[4].Value.ToString();
            txtThanhTien.Text = dgvChiTietHD.CurrentRow.Cells[5].Value.ToString();

            if (dgvHoaDon.CurrentRow != null)
                txtTongTien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();

            isLoading = false;
            btnSua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnXoaHD.Enabled = false;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn!");
                txtMaHD.Focus();
                return;
            }
            if (cbxMaKH.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải chọn khách hàng!");
                cbxMaKH.Focus();
                return;
            }

            DataTable dt = dtBase.ReadData("Select * From HoaDon Where MaHoaDon=N'" + txtMaHD.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại, bạn phải nhập mã khác!");
                txtMaHD.Focus();
                return;
            }

            dtBase.UpdateData("Insert into HoaDon(MaHoaDon, MaKhachHang, MaNhanVien, NgayLap, TongTien) values(N'"
                + txtMaHD.Text
                + "', N'"
                + cbxMaKH.SelectedValue.ToString()
                + "', N'"
                + GlobalData.MaNV
                + "', N'"
                + dtpNgayNhap.Value.ToString("yyyy-MM-dd HH:mm:ss")
                + "', 0)");

            MessageBox.Show("Thêm hóa đơn thành công!");
            frmHoaDon_Load(sender, e);
            ResetValues();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn hóa đơn trước khi thêm chi tiết!");
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
                MessageBox.Show("Bạn phải nhập đơn giá bán!");
                txtDonGia.Focus();
                return;
            }
            if (txtGiamGia.Text.Trim() == "") txtGiamGia.Text = "0";

            int slMua = int.Parse(txtSL.Text);
            DataTable dtKho = dtBase.ReadData("Select SoLuongTon From SanPham Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
            if (dtKho.Rows.Count > 0)
            {
                int slTon = int.Parse(dtKho.Rows[0][0].ToString());
                if (slMua > slTon)
                {
                    MessageBox.Show("Số lượng tồn kho không đủ để bán! Hiện tại chỉ còn: " + slTon);
                    return;
                }
            }

            DataTable dt = dtBase.ReadData("Select * From ChiTietHoaDon Where MaHoaDon=N'" + txtMaHD.Text + "' and MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong chi tiết hóa đơn!");
                cbxMaSP.Focus();
                return;
            }

            dtBase.UpdateData("Insert into ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong, DonGiaBan, GiamGia, ThanhTien) values(N'"
                + txtMaHD.Text
                + "', N'"
                + cbxMaSP.SelectedValue.ToString()
                + "', N'"
                + txtSL.Text
                + "', N'"
                + txtDonGia.Text
                + "', N'"
                + txtGiamGia.Text
                + "', N'"
                + txtThanhTien.Text
                + "')");

            DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietHoaDon Where MaHoaDon=N'" + txtMaHD.Text + "'");
            dtBase.UpdateData("Update HoaDon set TongTien =N'" + dtTongTien.Rows[0][0].ToString() + "' Where MaHoaDon=N'" + txtMaHD.Text + "'");

            dtBase.UpdateData("Update SanPham Set SoLuongTon = SoLuongTon - " + txtSL.Text + " Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");

            MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
            frmHoaDon_Load(sender, e);
            LoadChiTietHoaDon(txtMaHD.Text);
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn hóa đơn để sửa!");
                return;
            }

            DataTable dtMHD = dtBase.ReadData("Select * From HoaDon Where MaHoaDon=N'" + txtMaHD.Text + "'");
            if (dtMHD.Rows.Count > 0 && txtMaHD.Text != dgvHoaDon.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!");
                txtMaHD.Focus();
                return;
            }

            if (cbxMaSP.SelectedIndex == -1 && txtSL.Text == "" && txtDonGia.Text == "")
            {
                dtBase.UpdateData("Update HoaDon Set MaHoaDon=N'"
                    + txtMaHD.Text
                    + "', MaKhachHang=N'"
                    + cbxMaKH.SelectedValue.ToString()
                    + "', MaNhanVien=N'"
                    + GlobalData.MaNV
                    + "', NgayLap=N'"
                    + dtpNgayNhap.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    + "', TongTien=N'"
                    + txtTongTien.Text
                    + "' Where MaHoaDon=N'" + dgvHoaDon.CurrentRow.Cells[0].Value.ToString() + "'");
                MessageBox.Show("Đã Lưu Thông Tin Hóa Đơn");
                frmHoaDon_Load(sender, e);
            }
            else
            {
                string maHD = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                string maSPCu = dgvChiTietHD.CurrentRow.Cells[1].Value.ToString();
                int slCu = int.Parse(dgvChiTietHD.CurrentRow.Cells[2].Value.ToString());

                dtBase.UpdateData("Update SanPham Set SoLuongTon = SoLuongTon + " + slCu + " Where MaSanPham=N'" + maSPCu + "'");

                int slMoi = int.Parse(txtSL.Text);
                DataTable dtKho = dtBase.ReadData("Select SoLuongTon From SanPham Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");
                int slTon = int.Parse(dtKho.Rows[0][0].ToString());

                if (slMoi > slTon)
                {
                    MessageBox.Show("Kho không đủ hàng để sửa đổi! Tồn kho hiện tại (đã cộng lại hàng cũ): " + slTon);
                    dtBase.UpdateData("Update SanPham Set SoLuongTon = SoLuongTon - " + slCu + " Where MaSanPham=N'" + maSPCu + "'");
                    return;
                }

                dtBase.UpdateData("Update ChiTietHoaDon Set MaSanPham='" + cbxMaSP.SelectedValue.ToString()
                    + "', SoLuong='" + txtSL.Text
                    + "', DonGiaBan='" + txtDonGia.Text
                    + "', GiamGia='" + txtGiamGia.Text
                    + "', ThanhTien='" + txtThanhTien.Text
                    + "' Where MaHoaDon='" + txtMaHD.Text + "' and MaSanPham='" + maSPCu + "'");

                dtBase.UpdateData("Update SanPham Set SoLuongTon = SoLuongTon - " + slMoi + " Where MaSanPham=N'" + cbxMaSP.SelectedValue.ToString() + "'");

                MessageBox.Show("Đã Lưu Chi Tiết");

                DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietHoaDon Where MaHoaDon=N'" + txtMaHD.Text + "'");
                dtBase.UpdateData("Update HoaDon set TongTien =N'" + dtTongTien.Rows[0][0].ToString() + "' Where MaHoaDon=N'" + txtMaHD.Text + "'");

                LoadChiTietHoaDon(txtMaHD.Text);
                ResetValues();
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null || dgvHoaDon.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("Bạn phải chọn hóa đơn để xóa!");
                return;
            }

            string maHD = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn " + maHD + " và tất cả chi tiết? Thao tác này sẽ HOÀN LẠI số lượng tồn kho!",
                "Xác Nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    string sqlSelectDetails = "SELECT MaSanPham, SoLuong FROM ChiTietHoaDon WHERE MaHoaDon=N'" + maHD + "'";
                    DataTable dtChiTiet = dtBase.ReadData(sqlSelectDetails);

                    if (dtChiTiet.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtChiTiet.Rows)
                        {
                            string maSP = row["MaSanPham"].ToString();
                            int soLuongHoanLai = Convert.ToInt32(row["SoLuong"]);
                            string sqlUpdateStock = "UPDATE SanPham SET SoLuongTon = SoLuongTon + " + soLuongHoanLai + " WHERE MaSanPham=N'" + maSP + "'";
                            dtBase.UpdateData(sqlUpdateStock);
                        }
                    }

                    dtBase.UpdateData("DELETE FROM ChiTietHoaDon WHERE MaHoaDon=N'" + maHD + "'");
                    dtBase.UpdateData("DELETE FROM HoaDon WHERE MaHoaDon=N'" + maHD + "'");

                    frmHoaDon_Load(sender, e);
                    ResetValues();
                    MessageBox.Show("Xóa hóa đơn và cập nhật tồn kho thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message);
                }
            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHD.Rows.Count == null || dgvChiTietHD.CurrentRow == null)
            {
                MessageBox.Show("Bạn phải chọn chi tiết hóa đơn để xóa!");
                return;
            }

            string maHD = dgvChiTietHD.CurrentRow.Cells[0].Value.ToString();
            string maSP = dgvChiTietHD.CurrentRow.Cells[1].Value.ToString();
            int soLuong = int.Parse(dgvChiTietHD.CurrentRow.Cells[2].Value.ToString());

            dtBase.UpdateData("Update SanPham Set SoLuongTon = SoLuongTon + " + soLuong + " Where MaSanPham=N'" + maSP + "'");

            dtBase.UpdateData("Delete From ChiTietHoaDon Where MaHoaDon=N'" + maHD + "' and MaSanPham=N'" + maSP + "'");

            DataTable dtTongTien = dtBase.ReadData("Select SUM(ThanhTien) From ChiTietHoaDon Where MaHoaDon=N'" + txtMaHD.Text + "'");
            string tongTienMoi = "0";
            if (dtTongTien.Rows.Count > 0 && dtTongTien.Rows[0][0].ToString() != "")
                tongTienMoi = dtTongTien.Rows[0][0].ToString();

            dtBase.UpdateData("Update HoaDon set TongTien =N'" + tongTienMoi + "' Where MaHoaDon=N'" + txtMaHD.Text + "'");

            LoadChiTietHoaDon(maHD);
            ResetValues();
            MessageBox.Show("Xóa chi tiết hóa đơn thành công!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            frmHoaDon_Load(sender, e);
            btnSua.Enabled = false;
            btnXoaHD.Enabled = false;
            btnXoaCTHD.Enabled = false;
            btnThemHD.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tìm_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM HoaDon WHERE 1=1";
                string kq = "";

                if (!string.IsNullOrEmpty(txtMaHD.Text))
                {
                    sql += " AND MaHoaDon LIKE N'%" + txtMaHD.Text.Trim() + "%'";
                    kq += "Mã Hóa Đơn chứa '" + txtMaHD.Text.Trim() + "' \n";
                }
                if (cbxMaKH.SelectedValue != null && cbxMaKH.SelectedIndex != -1)
                {
                    sql += " AND MaKhachHang = N'" + cbxMaKH.SelectedValue.ToString() + "'";
                    kq += "Khách Hàng: '" + cbxMaKH.Text + "' \n";
                }
                if (cbxMaNV.SelectedValue != null && cbxMaNV.SelectedIndex != -1)
                {
                    sql += " AND MaNhanVien = N'" + cbxMaNV.SelectedValue.ToString() + "'";
                    kq += "Nhân Viên: '" + cbxMaNV.Text + "' \n";
                }
                if (cbxMaSP.SelectedValue != null && cbxMaSP.SelectedIndex != -1)
                {
                    sql += " AND MaHoaDon IN (SELECT MaHoaDon FROM ChiTietHoaDon WHERE MaSanPham = N'" + cbxMaSP.SelectedValue.ToString() + "')";
                    kq += "Sản Phẩm: '" + cbxMaSP.Text + "' \n";
                }

                DataTable dtResult = dtBase.ReadData(sql);
                dgvHoaDon.DataSource = dtResult;

                if (dtResult.Rows.Count > 0)
                {
                    dgvHoaDon.ClearSelection();
                    dgvHoaDon.Rows[0].Selected = true;
                    dgvHoaDon.CurrentCell = dgvHoaDon.Rows[0].Cells[0];
                    dgvHoaDon_CellClick(dgvHoaDon, new DataGridViewCellEventArgs(0, 0));
                }
                else
                {
                    dgvChiTietHD.DataSource = null;
                    MessageBox.Show("Không tìm thấy hóa đơn nào thỏa mãn các tiêu chí:\n" + kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
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
            tenTruong.Range["B2"].Value = "DANH SÁCH HÓA ĐƠN";

            tenTruong.Range["A4:H4"].Font.Size = 13;
            tenTruong.Range["A4:H4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:H4"].Font.Color = Color.Black;
            tenTruong.Range["A4:H4"].Font.Bold = true;

            tenTruong.Range["A4"].Value = "Mã Hóa Đơn";
            tenTruong.Range["B4"].Value = "Mã Khách Hàng";
            tenTruong.Range["C4"].Value = "Mã Nhân Viên";
            tenTruong.Range["D4"].Value = "Ngày Lập";
            tenTruong.Range["E4"].Value = "Tổng Tiền";

            string R = dgvHoaDon.Rows.Count + 5 + "";

            tenTruong.Range["A4"].ColumnWidth = 10;
            tenTruong.Range["B4"].ColumnWidth = 20;
            tenTruong.Range["C4"].ColumnWidth = 20;
            tenTruong.Range["D4"].ColumnWidth = 20;
            tenTruong.Range["E4"].ColumnWidth = 15;

            tenTruong.Range["A4:H" + R].VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
            tenTruong.Range["A4:H" + R].Columns.WrapText = true;
            int Hang = 5;
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang.ToString()].Value = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang.ToString()].Value = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang.ToString()].Value = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang.ToString()].Value = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang.ToString()].Value = dgvHoaDon.Rows[i].Cells[4].Value.ToString();
                Hang++;
            }

            Excel.Range range = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[int.Parse(R) - 2, 5]];
            range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            string R2 = (dgvHoaDon.Rows.Count + 8).ToString();
            tenTruong.Range["B" + R2].Font.Size = 25;
            tenTruong.Range["B" + R2].Font.Name = "Times New Roman";
            tenTruong.Range["B" + R2].Font.Color = Color.Blue;
            tenTruong.Range["B" + R2].Font.Bold = true;
            tenTruong.Range["B" + R2].Value = "CHI TIẾT HÓA ĐƠN";
            string K = (5 + int.Parse(R2)).ToString();

            tenTruong.Range["A" + K + ":H" + K].Font.Size = 13;
            tenTruong.Range["A" + K + ":H" + K].Font.Name = "Times New Roman";
            tenTruong.Range["A" + K + ":H" + K].Font.Color = Color.Black;
            tenTruong.Range["A" + K + ":H" + K].Font.Bold = true;

            tenTruong.Range["A" + K].Value = "Mã Hóa Đơn";
            tenTruong.Range["B" + K].Value = "Mã Sản Phẩm";
            tenTruong.Range["C" + K].Value = "Số Lượng";
            tenTruong.Range["D" + K].Value = "Đơn Giá Bán";
            tenTruong.Range["E" + K].Value = "Giảm Giá (%)";
            tenTruong.Range["F" + K].Value = "Thành Tiền";

            int Hang2 = int.Parse(K) + 1;
            for (int i = 0; i < dgvChiTietHD.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[4].Value.ToString();
                tenTruong.Range["F" + Hang2.ToString()].Value = dgvChiTietHD.Rows[i].Cells[5].Value.ToString();
                Hang2++;
            }

            int HangKetThucDuLieuCT = Hang2 - 1;
            Excel.Range range2 = exSheet.Range[exSheet.Cells[int.Parse(K), 1], exSheet.Cells[HangKetThucDuLieuCT, 6]];
            range2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range2.Borders.Weight = Excel.XlBorderWeight.xlThin;
            range2.Borders.ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic;

            exSheet.Name = "DanhSachHoaDon";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất File Excel thành công");
            }
            exApp.Quit();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang f = new frmQLKhachHang();
            f.ShowDialog();
            cbxMaKH.DataSource = dtBase.ReadData("Select MaKhachHang, TenKhachHang From KhachHang");
            cbxMaKH.DisplayMember = "TenKhachHang";
            cbxMaKH.ValueMember = "MaKhachHang";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien f = new frmQLNhanVien();
            f.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
            cbxMaSP.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham From SanPham");
            cbxMaSP.DisplayMember = "TenSanPham";
            cbxMaSP.ValueMember = "MaSanPham";
        }

        private void LoadChiTietHoaDon(string maHD)
        {
            string sqlChiTiet = "SELECT * FROM ChiTietHoaDon WHERE MaHoaDon = N'" + maHD + "'";
            dgvChiTietHD.DataSource = dtBase.ReadData(sqlChiTiet);
        }

        void ResetValues()
        {
            txtMaHD.Clear();
            cbxMaKH.SelectedIndex = -1;
            cbxMaKH.Text = "";
            cbxMaNV.SelectedIndex = -1;
            cbxMaNV.Text = "";
            dtpNgayNhap.Value = DateTime.Now;
            txtTongTien.Clear();

            cbxMaSP.SelectedIndex = -1;
            cbxMaSP.Text = "";
            txtSL.Clear();
            txtDonGia.Clear();
            txtGiamGia.Clear();
            txtThanhTien.Clear();

            txtMaHD.Focus();

        }

        private void TuDongTinhToan(object sender, EventArgs e)
        {
            double soLuong = 0;
            double donGia = 0;
            double giamGia = 0;

            double.TryParse(txtSL.Text, out soLuong);
            double.TryParse(txtDonGia.Text, out donGia);
            double.TryParse(txtGiamGia.Text, out giamGia);

            double thanhTienMoi = (soLuong * donGia) * (1 - giamGia / 100);
            txtThanhTien.Text = thanhTienMoi.ToString("0.##");

            double tongTienDaLuu = 0;
            string maSPDangChon = "";
            if (cbxMaSP.SelectedValue != null)
            {
                maSPDangChon = cbxMaSP.SelectedValue.ToString();
            }

            if (dgvChiTietHD.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvChiTietHD.Rows)
                {
                    if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() != "")
                    {
                        if (maSPDangChon != "" && maSPDangChon == row.Cells[1].Value.ToString())
                        {
                            continue;
                        }
                        tongTienDaLuu += Convert.ToDouble(row.Cells[5].Value);
                    }
                }
            }

            double tongTienHienThi = tongTienDaLuu + thanhTienMoi;
            txtTongTien.Text = tongTienHienThi.ToString("0.##");
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading) TuDongTinhToan(sender, e);
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading) TuDongTinhToan(sender, e);
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (!isLoading) TuDongTinhToan(sender, e);
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            int thang = dtpLoc.Value.Month;
            int nam = dtpLoc.Value.Year;

            DateTime start = new DateTime(nam, thang, 1);
            DateTime end = start.AddMonths(1);

            string sql = $@"
                            SELECT *
                            FROM HoaDon
                            WHERE TRY_CONVERT(datetime, NgayLap, 120) >= '{start:yyyy-MM-dd}'
                            AND TRY_CONVERT(datetime, NgayLap, 120) <  '{end:yyyy-MM-dd}'";

            DataTable dtHoaDon = dtBase.ReadData(sql);
            dgvHoaDon.DataSource = dtHoaDon;
            dgvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dgvHoaDon.Columns[2].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns[4].HeaderText = "Tổng Tiền";
        }
    }
}