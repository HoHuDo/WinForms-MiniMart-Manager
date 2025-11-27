
using MiniMart_Manager.Classes;
using System.Data;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmBanHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        string currentMaHD = "";
        bool isLoading = false;

        public frmBanHang()
        {
            InitializeComponent();
        }
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 1;
            bool dung = false;
            string ma = "";

            while (dung == false)
            {
                string maKiemTra = MaBatDau + id.ToString("000");

                DataTable dm = dtBase.ReadData("Select * from " + TenBang + " where " + TruongMa + "='" + maKiemTra + "'");

                if (dm.Rows.Count == 0)
                {
                    ma = maKiemTra;
                    dung = true;
                }
                else
                {
                    id++;
                }
            }
            return ma;
        }
        private void TaoMoiHoaDon()
        {
            if (!string.IsNullOrEmpty(currentMaHD))
            {
                return;
            }
            string prefixNgay = "HDB_" + DateTime.Now.ToString("ddMMyyyy");

            currentMaHD = SinhMaTuDong("HoaDon", prefixNgay, "MaHoaDon");

            string ngayLap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string maKH = "KH001";
            if (cbxKhachHang.Items.Count > 0 && cbxKhachHang.SelectedValue != null)
            {
                maKH = cbxKhachHang.SelectedValue.ToString();
            }

            try
            {
                dtBase.UpdateData("INSERT INTO HoaDon(MaHoaDon, MaKhachHang, MaNhanVien, NgayLap, TongTien) VALUES(N'"
                    + currentMaHD + "', N'"
                    + maKH + "', N'"
                    + GlobalData.MaNV + "', '"
                    + ngayLap + "', 0)");
                LoadDataChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo hóa đơn mới: " + ex.Message);
            }
        }
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            LoadDataSanPham();
            LoadDataChiTiet();
            DataTable dtLoaiHang = dtBase.ReadData("SELECT MaLoaiHang, TenLoaiHang FROM LoaiHang");
            cbxDanhMuc.DataSource = dtLoaiHang;
            DataRow RowAll = dtLoaiHang.NewRow();
            RowAll["MaLoaiHang"] = 0;
            RowAll["TenLoaiHang"] = "Tất Cả";
            dtLoaiHang.Rows.InsertAt(RowAll, 0);
            cbxDanhMuc.ValueMember = "MaLoaiHang";
            cbxDanhMuc.DisplayMember = "TenLoaiHang";
            cbxDanhMuc.SelectedIndex = 0;
            cbxKhachHang.DataSource = dtBase.ReadData("Select MaKhachHang, TenKhachHang From KhachHang");
            cbxKhachHang.DisplayMember = "TenKhachHang";
            cbxKhachHang.ValueMember = "MaKhachHang";
            cbxKhachHang.SelectedIndex = -1;

            cbxSP.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham From SanPham");
            cbxSP.DisplayMember = "TenSanPham";
            cbxSP.ValueMember = "MaSanPham";
            cbxSP.SelectedIndex = -1;
            cbxKhachHang.SelectedIndex = -1;
            TaoMoiHoaDon();
            txtMHD.Text = currentMaHD;

        }

        private void LoadDataSanPham()
        {
            dgvSanPham.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham, MaLoaiHang, DonViTinh, GiaBan, SoLuongTon From SanPham");
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Mã LH";
            dgvSanPham.Columns[3].HeaderText = "Đơn Vị";
            dgvSanPham.Columns[4].HeaderText = "Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "SL Tồn";
        }



        private void LoadDataChiTiet()
        {
            dgvChiTietDH.DataSource = dtBase.ReadData("Select * from ChiTietHoaDon Where MaHoaDon = N'" + currentMaHD + "'");
            dgvChiTietDH.Columns[0].HeaderText = "Mã HĐ";
            dgvChiTietDH.Columns[1].HeaderText = "Mã SP";
            dgvChiTietDH.Columns[2].HeaderText = "SL";
            dgvChiTietDH.Columns[3].HeaderText = "Giá Bán";
            dgvChiTietDH.Columns[4].HeaderText = "Giảm Giá";
            dgvChiTietDH.Columns[5].HeaderText = "Thành Tiền";

            NumberFormatInfo nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = ".";
            DataTable dtTT = dtBase.ReadData("Select ISNULL(SUM(ThanhTien), 0) From ChiTietHoaDon Where MaHoaDon='" + currentMaHD + "'");
            lblTong.Text = "Tổng Tiền: " + double.Parse(dtTT.Rows[0][0].ToString()).ToString("N0", nfi) + " VNĐ";
            DataTable dtTSL = dtBase.ReadData("Select ISNULL(SUM(SoLuong), 0) From ChiTietHoaDon Where MaHoaDon='" + currentMaHD + "'");
            lblTongSL.Text = "Tổng SL: " + dtTSL.Rows[0][0].ToString();

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            isLoading = true;
            cbxSP.SelectedValue = dgvSanPham.CurrentRow.Cells["MaSanPham"].Value.ToString();
            cbxDonVi.Text = dgvSanPham.CurrentRow.Cells["DonViTinh"].Value.ToString();
            txtGia.Text = dgvSanPham.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtSlTrongKho.Text = dgvSanPham.CurrentRow.Cells["SoLuongTon"].Value.ToString();
            txtSlBan.Text = "1";
            txtGiamGia.Text = "0";
            isLoading = false;

            TinhThanhTien();
        }

        private void dgvChiTietDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietDH.CurrentRow == null) return;

            isLoading = true;
            string maSP = dgvChiTietDH.CurrentRow.Cells["MaSanPham"].Value.ToString();
            cbxSP.SelectedValue = maSP;

            DataTable dtSP = dtBase.ReadData("Select DonViTinh, SoLuongTon From SanPham Where MaSanPham = N'" + maSP + "'");
            if (dtSP.Rows.Count > 0)
            {
                cbxDonVi.Text = dtSP.Rows[0]["DonViTinh"].ToString();
                txtSlTrongKho.Text = dtSP.Rows[0]["SoLuongTon"].ToString();
            }

            txtSlBan.Text = dgvChiTietDH.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtGia.Text = dgvChiTietDH.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtGiamGia.Text = dgvChiTietDH.CurrentRow.Cells["GiamGia"].Value.ToString();
            lblThanhTien.Text = dgvChiTietDH.CurrentRow.Cells["ThanhTien"].Value.ToString();
            isLoading = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbxSP.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn sản phẩm!"); return; }
            if (cbxKhachHang.SelectedIndex == -1) { MessageBox.Show("Vui lòng chọn khách hàng"); return; }
            if (string.IsNullOrEmpty(txtSlBan.Text) || int.Parse(txtSlBan.Text) <= 0) { MessageBox.Show("Số lượng bán không hợp lệ!"); return; }

            string maSP = cbxSP.SelectedValue.ToString();
            int slBan = int.Parse(txtSlBan.Text);
            int slKho = int.Parse(txtSlTrongKho.Text);

            if (slBan > slKho)
            {
                MessageBox.Show("Không đủ hàng trong kho! Tồn: " + slKho);
                return;
            }

            DataTable dtCheck = dtBase.ReadData("Select * From ChiTietHoaDon Where MaHoaDon = N'" + currentMaHD + "' AND MaSanPham = N'" + maSP + "'");
            if (dtCheck.Rows.Count > 0)
            {
                MessageBox.Show("Sản phẩm này đã có trong đơn hàng. Vui lòng chọn Sửa hoặc xóa đi thêm lại.");
                return;
            }

            try
            {
                dtBase.UpdateData("INSERT INTO ChiTietHoaDon(MaHoaDon, MaSanPham, SoLuong, DonGiaBan, GiamGia, ThanhTien) VALUES(N'"
                    + currentMaHD + "', N'"
                    + maSP + "', "
                    + slBan + ", "
                    + txtGia.Text + ", "
                    + txtGiamGia.Text + ", "
                    + lblThanhTien.Text + ")");

                dtBase.UpdateData("UPDATE SanPham SET SoLuongTon = SoLuongTon - " + slBan + " WHERE MaSanPham = N'" + maSP + "'");

                UpdateTongTienHoaDon();
                LoadDataSanPham();
                LoadDataChiTiet();
                MessageBox.Show("Đã thêm sản phẩm vào đơn hàng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            cbxKhachHang.Enabled = false;
            txtSĐT.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDH.CurrentRow == null) { MessageBox.Show("Chọn dòng trong chi tiết đơn hàng để sửa!"); return; }

            string maSP = cbxSP.SelectedValue.ToString();
            int slMoi = int.Parse(txtSlBan.Text);
            int slCu = int.Parse(dgvChiTietDH.CurrentRow.Cells["SoLuong"].Value.ToString());

            int slTonHienTai = int.Parse(txtSlTrongKho.Text);
            int tongKhaDung = slTonHienTai + slCu;

            if (slMoi > tongKhaDung)
            {
                MessageBox.Show("Kho không đủ hàng để sửa! Tổng khả dụng: " + tongKhaDung);
                return;
            }

            try
            {
                dtBase.UpdateData("UPDATE SanPham SET SoLuongTon = SoLuongTon + " + slCu + " WHERE MaSanPham = N'" + maSP + "'");

                dtBase.UpdateData("UPDATE ChiTietHoaDon SET SoLuong = " + slMoi + ", GiamGia = " + txtGiamGia.Text + ", ThanhTien = " + lblThanhTien.Text +
                                  " WHERE MaHoaDon = N'" + currentMaHD + "' AND MaSanPham = N'" + maSP + "'");
                dtBase.UpdateData("UPDATE SanPham SET SoLuongTon = SoLuongTon - " + slMoi + " WHERE MaSanPham = N'" + maSP + "'");

                UpdateTongTienHoaDon();
                LoadDataSanPham();
                LoadDataChiTiet();
                MessageBox.Show("Đã cập nhật đơn hàng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvChiTietDH.CurrentRow == null) return;

            if (MessageBox.Show("Xóa sản phẩm này khỏi đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string maSP = dgvChiTietDH.CurrentRow.Cells["MaSanPham"].Value.ToString();
                int slCu = int.Parse(dgvChiTietDH.CurrentRow.Cells["SoLuong"].Value.ToString());

                dtBase.UpdateData("UPDATE SanPham SET SoLuongTon = SoLuongTon + " + slCu + " WHERE MaSanPham = N'" + maSP + "'");

                dtBase.UpdateData("DELETE FROM ChiTietHoaDon WHERE MaHoaDon = N'" + currentMaHD + "' AND MaSanPham = N'" + maSP + "'");

                UpdateTongTienHoaDon();
                LoadDataSanPham();
                LoadDataChiTiet();
            }
        }

        private void UpdateTongTienHoaDon()
        {
            DataTable dtSum = dtBase.ReadData("SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHoaDon = N'" + currentMaHD + "'");
            string tongTien = "0";
            if (dtSum.Rows.Count > 0 && dtSum.Rows[0][0].ToString() != "")
            {
                tongTien = dtSum.Rows[0][0].ToString();
            }
            string maKH = (cbxKhachHang.SelectedValue != null) ? cbxKhachHang.SelectedValue.ToString() : "KH001";

            dtBase.UpdateData("UPDATE HoaDon SET TongTien = " + tongTien + ", MaKhachHang = N'" + maKH + "' WHERE MaHoaDon = N'" + currentMaHD + "'");
        }

        private void TinhThanhTien()
        {
            if (isLoading) return;

            double soLuong = 0;
            double donGia = 0;
            double chietKhau = 0;

            double.TryParse(txtSlBan.Text, out soLuong);
            double.TryParse(txtGia.Text, out donGia);
            double.TryParse(txtGiamGia.Text, out chietKhau);

            double thanhTien = (soLuong * donGia) * (1 - chietKhau / 100);
            lblThanhTien.Text = thanhTien.ToString("0.##");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void cbxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading && cbxSP.SelectedIndex != -1)
            {
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSlBan.Clear();
            txtGiamGia.Text = "0";
            lblThanhTien.Text = "0";
            cbxSP.SelectedIndex = -1;
            txtGia.Clear();
            txtSlTrongKho.Clear();
            cbxDonVi.SelectedIndex = -1;
            cbxKhachHang.SelectedIndex = -1;
        }

        private void txtSlTrongKho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXuatE_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];

            try
            {
                exRange.Range["A1:F1"].MergeCells = true;
                exRange.Range["A1:F1"].Font.Size = 18;
                exRange.Range["A1:F1"].Font.Name = "Times New Roman";
                exRange.Range["A1:F1"].Font.Bold = true;
                exRange.Range["A1:F1"].Font.Color = Color.Blue;
                exRange.Range["A1:F1"].Value = "SIÊU THỊ MINIMART";
                exRange.Range["A1:F1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exRange.Range["A2:F2"].MergeCells = true;
                exRange.Range["A2:F2"].Font.Size = 16;
                exRange.Range["A2:F2"].Font.Bold = true;
                exRange.Range["A2:F2"].Value = "HÓA ĐƠN BÁN HÀNG";
                exRange.Range["A2:F2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exRange.Range["A3:F6"].Font.Size = 12;
                exRange.Range["A3:F6"].Font.Name = "Times New Roman";

                exRange.Range["B3"].Value = "Mã Hóa Đơn:";
                exRange.Range["C3"].Value = currentMaHD;

                exRange.Range["B4"].Value = "Khách Hàng:";
                exRange.Range["C4"].Value = cbxKhachHang.Text;

                exRange.Range["B5"].Value = "Nhân Viên:";
                exRange.Range["C5"].Value = GlobalData.TenDangNhap;

                exRange.Range["B6"].Value = "In Lúc:";
                exRange.Range["C6"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                exRange.Range["C6"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                exRange.Range["A8:F8"].Font.Size = 11;
                exRange.Range["A8:F8"].Font.Name = "Times New Roman";
                exRange.Range["A8:F8"].Font.Bold = true;
                exRange.Range["A8:F8"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                exRange.Range["A8"].Value = "STT";
                exRange.Range["B8"].Value = "Tên Món";
                exRange.Range["C8"].Value = "SL";
                exRange.Range["D8"].Value = "Đơn Giá";
                exRange.Range["E8"].Value = "C.Khấu (%)";
                exRange.Range["F8"].Value = "Thành Tiền";

                exRange.Range["A8"].ColumnWidth = 5;
                exRange.Range["B8"].ColumnWidth = 35;
                exRange.Range["C8"].ColumnWidth = 8;
                exRange.Range["D8"].ColumnWidth = 15;
                exRange.Range["E8"].ColumnWidth = 10;
                exRange.Range["F8"].ColumnWidth = 18;

                int hang = 9;
                int stt = 1;
                double tongSoLuong = 0;
                double tongTienHang = 0;

                for (int i = 0; i < dgvChiTietDH.Rows.Count - 1; i++)
                {
                    string maSP = dgvChiTietDH.Rows[i].Cells["MaSanPham"].Value.ToString();
                    double soLuong = double.Parse(dgvChiTietDH.Rows[i].Cells["SoLuong"].Value.ToString());
                    double donGia = double.Parse(dgvChiTietDH.Rows[i].Cells["DonGiaBan"].Value.ToString());
                    double giamGia = double.Parse(dgvChiTietDH.Rows[i].Cells["GiamGia"].Value.ToString());
                    double thanhTien = double.Parse(dgvChiTietDH.Rows[i].Cells["ThanhTien"].Value.ToString());

                    string tenSP = maSP;
                    DataTable dtTen = dtBase.ReadData("Select TenSanPham From SanPham Where MaSanPham=N'" + maSP + "'");
                    if (dtTen.Rows.Count > 0) tenSP = dtTen.Rows[0][0].ToString();

                    exRange.Range["A" + hang].Value = stt;
                    exRange.Range["B" + hang].Value = tenSP;
                    exRange.Range["C" + hang].Value = soLuong;
                    exRange.Range["D" + hang].Value = donGia;
                    exRange.Range["E" + hang].Value = giamGia;
                    exRange.Range["F" + hang].Value = thanhTien;

                    tongSoLuong += soLuong;
                    tongTienHang += thanhTien;

                    stt++;
                    hang++;
                }

                Excel.Range bangDuLieu = exSheet.Range["A8", "F" + (hang - 1)];
                bangDuLieu.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                bangDuLieu.Borders.Weight = Excel.XlBorderWeight.xlThin;

                int hangTong = hang + 1;

                exRange.Range["B" + hangTong].Value = "Tổng số lượng:";
                exRange.Range["B" + hangTong].Font.Bold = true;
                exRange.Range["C" + hangTong].Value = tongSoLuong;

                exRange.Range["E" + hangTong].Value = "TỔNG TIỀN:";
                exRange.Range["E" + hangTong].Font.Bold = true;
                exRange.Range["F" + hangTong].Value = tongTienHang;
                exRange.Range["F" + hangTong].Font.Bold = true;
                exRange.Range["F" + hangTong].NumberFormat = "#,##0";

                exRange.Range["A" + (hangTong + 1) + ":F" + (hangTong + 1)].MergeCells = true;
                exRange.Range["A" + (hangTong + 1)].Value = "Bằng chữ: " + DocSoThanhChu(tongTienHang);
                exRange.Range["A" + (hangTong + 1)].Font.Italic = true;

                int hangCuoi = hangTong + 3;
                exRange.Range["A" + hangCuoi + ":F" + hangCuoi].MergeCells = true;
                exRange.Range["A" + hangCuoi].Value = "CẢM ƠN QUÝ KHÁCH!";
                exRange.Range["A" + hangCuoi].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A" + hangCuoi].Font.Bold = true;

                exRange.Range["A" + (hangCuoi + 1) + ":F" + (hangCuoi + 1)].MergeCells = true;
                exRange.Range["A" + (hangCuoi + 1)].Value = "HẸN GẶP LẠI";
                exRange.Range["A" + (hangCuoi + 1)].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A" + (hangCuoi + 1)].Font.Italic = true;

                exSheet.Name = "HoaDon_" + currentMaHD;
                exBook.Activate();
                SaveFileDialog dlFile = new SaveFileDialog();
                dlFile.Filter = "Excel Files|*.xlsx;*.xls";
                dlFile.FileName = "HoaDon_" + currentMaHD + ".xlsx";

                if (dlFile.ShowDialog() == DialogResult.OK)
                {
                    exBook.SaveAs(dlFile.FileName);
                    MessageBox.Show("Xuất Hóa Đơn thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in hóa đơn: " + ex.Message);
            }
            finally
            {
                exApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
            }
        }

        private string DocSoThanhChu(double soTien)
        {
            return string.Format("{0:N0} VNĐ", soTien);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dtMasp = dtBase.ReadData("Select * from SanPham Where MaSanPham='" + cbxSP.SelectedValue.ToString() + "'");
            if (dtMasp.Rows.Count > 0)
            {
                dgvSanPham.DataSource = dtMasp;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm!");
            }
        }

        private void cbxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKhachHang = cbxKhachHang.SelectedValue?.ToString() ?? string.Empty;
            DataTable dt = dtBase.ReadData("Select DiaChi,SoDienThoai From KhachHang Where MaKhachHang='" + maKhachHang + "'");
            if (dt.Rows.Count > 0)
            {
                txtĐc.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSĐT.Text = dt.Rows[0]["SoDienThoai"].ToString();
            }
            else
            {
                txtĐc.Text = "";
                txtSĐT.Text = "";
            }
        }

        private void cbxSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string maSP = cbxSP.SelectedValue?.ToString() ?? string.Empty;
            DataTable dt = dtBase.ReadData("Select DonViTinh, GiaBan,  SoLuongTon From SanPham where MaSanPham='" + maSP + "'");
            if (dt.Rows.Count > 0)
            {
                cbxDonVi.Text = dt.Rows[0]["DonViTinh"].ToString();
                txtGia.Text = dt.Rows[0]["GiaBan"].ToString();
                txtSlTrongKho.Text = dt.Rows[0]["SoLuongTon"].ToString();
            }
            else
            {
                cbxDonVi.Text = "";
                txtGia.Text = "";
                txtSlTrongKho.Text = "";
            }
        }

        private void btnNewHĐ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn tạo hóa đơn mới không? Hóa đơn hiện tại (" + currentMaHD + ") sẽ được lưu.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvChiTietDH.Rows.Count == 0)
                {
                    dtBase.UpdateData("DELETE FROM HoaDon WHERE MaHoaDon = N'" + currentMaHD + "'");
                }
                currentMaHD = "";
                cbxKhachHang.Enabled = true;
                txtSĐT.Enabled = true;
                frmBanHang_Load(sender, e);
            }
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn thoát không? Hóa đơn hiện tại (" + currentMaHD + ") sẽ được lưu.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvChiTietDH.Rows.Count == 0)
                {
                    MessageBox.Show("Chi Tiết Hóa Đơn trống! Hóa Đơn này sẽ bị xóa");
                    dtBase.UpdateData("DELETE FROM HoaDon WHERE MaHoaDon = N'" + currentMaHD + "'");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDanhMuc.SelectedIndex == 0)
            {
                LoadDataSanPham();
            }
            else
            {
                dgvSanPham.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham, MaLoaiHang, DonViTinh, GiaBan, SoLuongTon From SanPham Where MaLoaiHang='" + cbxDanhMuc.SelectedValue.ToString() + "'");
                dgvSanPham.Columns[0].HeaderText = "Mã SP";
                dgvSanPham.Columns[1].HeaderText = "Tên SP";
                dgvSanPham.Columns[2].HeaderText = "Mã LH";
                dgvSanPham.Columns[3].HeaderText = "Đơn Vị";
                dgvSanPham.Columns[4].HeaderText = "Giá Bán";
                dgvSanPham.Columns[5].HeaderText = "SL Tồn";
            }
        }

        private void txtTenSp_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = dtBase.ReadData("Select MaSanPham, TenSanPham, MaLoaiHang, DonViTinh, GiaBan, SoLuongTon From SanPham Where TenSanPham Like N'%" + txtTenSp.Text + "%'");
            dgvSanPham.Columns[0].HeaderText = "Mã SP";
            dgvSanPham.Columns[1].HeaderText = "Tên SP";
            dgvSanPham.Columns[2].HeaderText = "Mã LH";
            dgvSanPham.Columns[3].HeaderText = "Đơn Vị";
            dgvSanPham.Columns[4].HeaderText = "Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "SL Tồn";
        }

        private void btnSDT_Click(object sender, EventArgs e)
        {
            DataTable dt = dtBase.ReadData("Select MaKhachHang From KhachHang Where SoDienThoai='" + txtSĐT.Text + "'");
            if (dt.Rows.Count > 0)
            {
                cbxKhachHang.SelectedValue = dt.Rows[0]["MaKhachHang"];
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có số điện thoại này");
            }
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
    }
}