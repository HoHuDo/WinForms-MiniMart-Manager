using MiniMart_Manager.Classes;
using System.Data;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQLNhapHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
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



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaPhieuNhap = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            txtMaPN.Text = MaPhieuNhap;
            dgvChiTietPN.DataSource = dtBase.ReadData("Select * From PhieuNhap where MaPhieuNhap=N'" + MaPhieuNhap + "'");
            dgvChiTietPN.Columns[0].HeaderText = "Mã Phiếu Nhập";
            dgvChiTietPN.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvChiTietPN.Columns[2].HeaderText = "Số Lượng";
            dgvChiTietPN.Columns[3].HeaderText = "Đơn Giá Nhập";
            dgvChiTietPN.Columns[4].HeaderText = "Thành Tiền";

        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
