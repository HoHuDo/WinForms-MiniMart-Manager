using MiniMart_Manager.Classes;
using System.Data;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmBaoCao : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();

        public frmBaoCao()
        {
            InitializeComponent();
        }
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();

            nfi.NumberGroupSeparator = ".";

            DataTable dtĐoanhThu = dtBase.ReadData("Select SUM(ThanhTien) from ChiTietHoaDon");
            lblDoanhThu.Text = double.Parse(dtĐoanhThu.Rows[0][0].ToString()).ToString("N0", nfi) + "  VNĐ";
            string sqlLN = @"SELECT 
                           ISNULL(SUM(CT.ThanhTien), 0) AS DoanhThu,
                           ISNULL(SUM(CT.ThanhTien - (CT.SoLuong * SP.GiaNhap)), 0) AS LoiNhuan
                           FROM ChiTietHoaDon CT
                           JOIN SanPham SP ON CT.MaSanPham = SP.MaSanPham
                           JOIN HoaDon HD ON CT.MaHoaDon = HD.MaHoaDon";
            DataTable dtLoiNhuan = dtBase.ReadData(sqlLN);
            lblLoiNhuanGop.Text = double.Parse(dtLoiNhuan.Rows[0][1].ToString()).ToString("N0", nfi) + "  VNĐ";
            string sqlNV = @"WITH NhanVienDoanhSo AS (
                            SELECT
                                HD.MaNhanVien,
                                NV.TenNhanVien,
                                ISNULL(SUM(HD.TongTien), 0) AS TongTienBanDuoc
                            FROM
                                HoaDon HD
                            JOIN
                                NhanVien NV ON HD.MaNhanVien = NV.MaNhanVien
                            GROUP BY
                                HD.MaNhanVien, NV.TenNhanVien
                            )
                            SELECT
                            RANK() OVER (ORDER BY TongTienBanDuoc DESC) AS Hang,
                            MaNhanVien,TenNhanVien,TongTienBanDuoc
                            FROM NhanVienDoanhSo
                            ORDER BY Hang ASC, TongTienBanDuoc DESC;";

            dgvTTNV.DataSource = dtBase.ReadData(sqlNV);
            dgvTTNV.Columns[0].HeaderText = "Hạng";
            dgvTTNV.Columns[1].HeaderText = "Mã Nhân Viên";
            dgvTTNV.Columns[2].HeaderText = "Tên Nhân Viên";
            dgvTTNV.Columns[3].HeaderText = "Tổng Doanh Số";

            string sqlNCC = @"WITH NhaCungCapChiPhi AS (
                            SELECT
                                PN.MaNhaCungCap,
                                NCC.TenNhaCungCap,
                                ISNULL(SUM(PN.TongTien), 0) AS TongChiNhapHang
                            FROM
                                PhieuNhap PN
                            JOIN
                                NhaCungCap NCC ON PN.MaNhaCungCap = NCC.MaNhaCungCap
                            GROUP BY
                                PN.MaNhaCungCap, NCC.TenNhaCungCap
                             )
                            SELECT
                            RANK() OVER (ORDER BY TongChiNhapHang DESC) AS Hang,
                            MaNhaCungCap,  TenNhaCungCap,  TongChiNhapHang
                            FROM  NhaCungCapChiPhi
                            ORDER BY  Hang ASC, TongChiNhapHang DESC;";
            dgvTCNCC.DataSource = dtBase.ReadData(sqlNCC);
            dgvTCNCC.Columns[0].HeaderText = "Hạng";
            dgvTCNCC.Columns[1].HeaderText = "Mã Nhà Cung Cấp";
            dgvTCNCC.Columns[2].HeaderText = "Tên Nhà Cung Cấp";
            dgvTCNCC.Columns[3].HeaderText = "Tổng Chi Phí";
            dgvTK.DataSource = dtBase.ReadData("SELECT RANK() OVER (ORDER BY SoLuongTon ASC) AS HangCanMua, MaSanPham, TenSanPham, SoLuongTon FROM SanPham ORDER BY SoLuongTon ASC;");
            dgvTK.Columns[0].HeaderText = "Mức Ưu Tiên";
            dgvTK.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvTK.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvTK.Columns[3].HeaderText = "Số Lượng Tồn";

            dgvTopSp.DataSource = dtBase.ReadData(@"WITH SanPhamBanChay AS (
                                                    SELECT
                                                        CT.MaSanPham,
                                                        SP.TenSanPham,
                                                        ISNULL(SUM(CT.SoLuong), 0) AS TongSoLuongBan
                                                    FROM
                                                        ChiTietHoaDon CT
                                                    JOIN
                                                        SanPham SP ON CT.MaSanPham = SP.MaSanPham
                                                    GROUP BY
                                                        CT.MaSanPham, SP.TenSanPham
                                                    )
                                                    SELECT
                                                    RANK() OVER (ORDER BY TongSoLuongBan DESC) AS HangBanChay,
                                                    MaSanPham,  TenSanPham,  TongSoLuongBan
                                                    FROM SanPhamBanChay
                                                    ORDER BY TongSoLuongBan DESC;");
            dgvTopSp.Columns[0].HeaderText = "Hạng";
            dgvTopSp.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvTopSp.Columns[2].HeaderText = "Tên Sản Phẩm";
            dgvTopSp.Columns[3].HeaderText = "Số Lượng Bán";

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
            tenTruong.Range["B2"].Font.Size = 20;
            tenTruong.Range["B2"].Font.Name = "Times New Roman";
            tenTruong.Range["B2"].Font.Color = Color.Blue;
            tenTruong.Range["B2"].Font.Bold = true;
            tenTruong.Range["B2"].Value = "BÁO CÁO DOANH SỐ NHÂN VIÊN";
            tenTruong.Range["A4:D4"].Font.Size = 13;
            tenTruong.Range["A4:D4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:D4"].Font.Color = Color.Black;
            tenTruong.Range["A4:D4"].Font.Bold = true;
            tenTruong.Range["A4:D4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            tenTruong.Range["A4"].Value = "Xếp Hạng";
            tenTruong.Range["B4"].Value = "Mã Nhân Viên";
            tenTruong.Range["C4"].Value = "Tên Nhân Viên";
            tenTruong.Range["D4"].Value = "Tổng Doanh Số";
            tenTruong.Range["A4"].ColumnWidth = 10;
            tenTruong.Range["B4"].ColumnWidth = 15;
            tenTruong.Range["C4"].ColumnWidth = 25;
            tenTruong.Range["D4"].ColumnWidth = 20;

            int Hang = 5;
            for (int i = 0; i < dgvTTNV.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang].Value = dgvTTNV.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang].Value = dgvTTNV.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang].Value = dgvTTNV.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang].Value = dgvTTNV.Rows[i].Cells[3].Value.ToString();
                Hang++;
            }

            string R1 = (dgvTTNV.Rows.Count + 5).ToString();
            Excel.Range range1 = exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[Hang - 1, 4]];
            range1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range1.Borders.Weight = Excel.XlBorderWeight.xlThin;


            int DongTieuDe2 = Hang + 3;
            string Pos2 = "B" + DongTieuDe2;

            tenTruong.Range[Pos2].Font.Size = 20;
            tenTruong.Range[Pos2].Font.Name = "Times New Roman";
            tenTruong.Range[Pos2].Font.Color = Color.Blue;
            tenTruong.Range[Pos2].Font.Bold = true;
            tenTruong.Range[Pos2].Value = "CHI PHÍ THEO NHÀ CUNG CẤP";

            int Header2 = DongTieuDe2 + 2;
            string K2 = Header2.ToString();

            tenTruong.Range["A" + K2 + ":D" + K2].Font.Size = 13;
            tenTruong.Range["A" + K2 + ":D" + K2].Font.Bold = true;
            tenTruong.Range["A" + K2 + ":D" + K2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            tenTruong.Range["A" + K2].Value = "Xếp Hạng";
            tenTruong.Range["B" + K2].Value = "Mã NCC";
            tenTruong.Range["C" + K2].Value = "Tên Nhà Cung Cấp";
            tenTruong.Range["D" + K2].Value = "Tổng Chi Phí";

            int Hang2 = Header2 + 1;
            for (int i = 0; i < dgvTCNCC.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang2].Value = dgvTCNCC.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang2].Value = dgvTCNCC.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang2].Value = dgvTCNCC.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang2].Value = dgvTCNCC.Rows[i].Cells[3].Value.ToString();
                Hang2++;
            }

            Excel.Range range2 = exSheet.Range[exSheet.Cells[Header2, 1], exSheet.Cells[Hang2 - 1, 4]];
            range2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range2.Borders.Weight = Excel.XlBorderWeight.xlThin;


            int DongTieuDe3 = Hang2 + 3;
            string Pos3 = "B" + DongTieuDe3;

            tenTruong.Range[Pos3].Font.Size = 20;
            tenTruong.Range[Pos3].Font.Name = "Times New Roman";
            tenTruong.Range[Pos3].Font.Color = Color.Red;
            tenTruong.Range[Pos3].Font.Bold = true;
            tenTruong.Range[Pos3].Value = "BÁO CÁO TỒN KHO (CẦN NHẬP)";

            int Header3 = DongTieuDe3 + 2;
            string K3 = Header3.ToString();

            tenTruong.Range["A" + K3 + ":D" + K3].Font.Size = 13;
            tenTruong.Range["A" + K3 + ":D" + K3].Font.Bold = true;
            tenTruong.Range["A" + K3 + ":D" + K3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            tenTruong.Range["A" + K3].Value = "Mức Ưu Tiên";
            tenTruong.Range["B" + K3].Value = "Mã Sản Phẩm";
            tenTruong.Range["C" + K3].Value = "Tên Sản Phẩm";
            tenTruong.Range["D" + K3].Value = "Số Lượng Tồn";

            int Hang3 = Header3 + 1;
            for (int i = 0; i < dgvTK.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang3].Value = dgvTK.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang3].Value = dgvTK.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang3].Value = dgvTK.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang3].Value = dgvTK.Rows[i].Cells[3].Value.ToString();
                Hang3++;
            }

            Excel.Range range3 = exSheet.Range[exSheet.Cells[Header3, 1], exSheet.Cells[Hang3 - 1, 4]];
            range3.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range3.Borders.Weight = Excel.XlBorderWeight.xlThin;


            int DongTieuDe4 = Hang3 + 3;
            string Pos4 = "B" + DongTieuDe4;

            tenTruong.Range[Pos4].Font.Size = 20;
            tenTruong.Range[Pos4].Font.Name = "Times New Roman";
            tenTruong.Range[Pos4].Font.Color = Color.Green;
            tenTruong.Range[Pos4].Font.Bold = true;
            tenTruong.Range[Pos4].Value = "TOP SẢN PHẨM BÁN CHẠY";

            int Header4 = DongTieuDe4 + 2;
            string K4 = Header4.ToString();

            tenTruong.Range["A" + K4 + ":D" + K4].Font.Size = 13;
            tenTruong.Range["A" + K4 + ":D" + K4].Font.Bold = true;
            tenTruong.Range["A" + K4 + ":D" + K4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            tenTruong.Range["A" + K4].Value = "Xếp Hạng";
            tenTruong.Range["B" + K4].Value = "Mã Sản Phẩm";
            tenTruong.Range["C" + K4].Value = "Tên Sản Phẩm";
            tenTruong.Range["D" + K4].Value = "Số Lượng Bán";

            int Hang4 = Header4 + 1;
            for (int i = 0; i < dgvTopSp.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + Hang4].Value = dgvTopSp.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + Hang4].Value = dgvTopSp.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + Hang4].Value = dgvTopSp.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + Hang4].Value = dgvTopSp.Rows[i].Cells[3].Value.ToString();
                Hang4++;
            }

            Excel.Range range4 = exSheet.Range[exSheet.Cells[Header4, 1], exSheet.Cells[Hang4 - 1, 4]];
            range4.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            range4.Borders.Weight = Excel.XlBorderWeight.xlThin;

            exSheet.Name = "BaoCaoTongHop";
            exBook.Activate();
            SaveFileDialog dlFile = new SaveFileDialog();
            if (dlFile.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlFile.FileName.ToString());
                MessageBox.Show("Xuất Báo Cáo Tổng Hợp thành công!");
            }
            exApp.Quit();
        }

        private void lblDoanhThu_Click(object sender, EventArgs e)
        {

        }
    }
}
