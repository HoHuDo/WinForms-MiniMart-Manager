using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmSanPham : Form
    {
        string userName = "";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            Classes.ProcessDatabase dtBase = new Classes.ProcessDatabase();
            dgvSanPham.DataSource = dtBase.ReadData("Select * From SanPham");
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã Loại Hàng";
            dgvSanPham.Columns[3].HeaderText = "Đơn Vị Tính";
            dgvSanPham.Columns[4].HeaderText = "Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "Số Lượng Tồn";
            dgvSanPham.Columns[6].HeaderText = "Giá Nhập";
            dgvSanPham.Columns[7].HeaderText = "Ảnh";


            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
        }

        private void lblTenTK_Click(object sender, EventArgs e)
        {

        }
    }
}
