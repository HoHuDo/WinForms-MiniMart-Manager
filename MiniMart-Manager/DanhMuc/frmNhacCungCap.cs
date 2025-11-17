using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmNhacCungCap : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmNhacCungCap()
        {
            InitializeComponent();
        }

        private void frmNhacCungCap_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvNhaCC.DataSource = dtBase.ReadData("Select * From NhaCungCap");
            dgvNhaCC.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCC.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCC.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhaCC.Columns[3].HeaderText = "Số Điện Thoại";
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
