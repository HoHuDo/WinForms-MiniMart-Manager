using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmBanHang : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.Quyen + ": " + GlobalData.TenDangNhap;
            dgvSanPham.DataSource = dtBase.ReadData("Select * from SanPham");
            dgvSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dgvSanPham.Columns[2].HeaderText = "Mã Loại Hàng";
            dgvSanPham.Columns[3].HeaderText = "Đơn Vị Tính";
            dgvSanPham.Columns[4].HeaderText = "Giá Bán";
            dgvSanPham.Columns[5].HeaderText = "Số Lượng Tồn";
            dgvSanPham.Columns[6].HeaderText = "Giá Nhập";
            dgvSanPham.Columns[7].HeaderText = "Ảnh";

            dgvChiTietDH.DataSource = dtBase.ReadData("Select * from ChiTietHoaDon");
            dgvChiTietDH.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvChiTietDH.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgvChiTietDH.Columns[2].HeaderText = "Số Lượng";
            dgvChiTietDH.Columns[3].HeaderText = "Đơn Giá Bán";
            dgvChiTietDH.Columns[4].HeaderText = "Giảm Giá";
            dgvChiTietDH.Columns[5].HeaderText = "Thành Tiền";


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTimTenSp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTenSp_Click(object sender, EventArgs e)
        {
            txtTimTenSp.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
