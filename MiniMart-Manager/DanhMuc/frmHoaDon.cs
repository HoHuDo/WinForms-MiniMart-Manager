using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmHoaDon : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = dtBase.ReadData("Select * from HoaDon");
            dgvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dgvHoaDon.Columns[2].HeaderText = "Mã Nhân Viên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày Lập";
            dgvHoaDon.Columns[4].HeaderText = "Tổng Tiền";



            lbluserName.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;

        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaHoaDon = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dgvChiTietHD.DataSource = dtBase.ReadData("Select * from ChiTietHoaDon where MaHoaDon=N'" + MaHoaDon + "'");
            dgvChiTietHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvChiTietHD.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvChiTietHD.Columns[2].HeaderText = "Số Lượng";
            dgvChiTietHD.Columns[3].HeaderText = "Đơn Giá Bán";
            dgvChiTietHD.Columns[4].HeaderText = "Giảm Giá";
            dgvChiTietHD.Columns[5].HeaderText = "Thành Tiền";

        }
    }
}
