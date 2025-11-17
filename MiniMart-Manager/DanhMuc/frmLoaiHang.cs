using MiniMart_Manager.Classes;

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
        }

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvLoaiHang.DataSource = dtBase.ReadData("Select * From LoaiHang");
            dgvLoaiHang.Columns[0].HeaderText = "Mã Loại Hàng";
            dgvLoaiHang.Columns[1].HeaderText = "Tên Loại Hàng";
            dgvLoaiHang.Columns[2].HeaderText = "Mô Tả";

        }
    }
}
