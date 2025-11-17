using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            DanhMuc.frmBanHang frm = new DanhMuc.frmBanHang();
            frm.ShowDialog();
        }

        private void mnuQLHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }

        private void mnuQLSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.ShowDialog();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            lblTenTK.Text = GlobalData.TenDangNhap;
        }

        private void lblTenTK_Click(object sender, EventArgs e)
        {

        }

        private void mnuQLNhapHang_Click(object sender, EventArgs e)
        {
            frmQLNhapHang frm = new frmQLNhapHang();
            frm.ShowDialog();
        }

        private void mnuQLLoaiHang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frm = new frmLoaiHang();
            frm.ShowDialog();
        }

        private void mnuQLNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhacCungCap frm = new frmNhacCungCap();
            frm.ShowDialog();
        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            frm.ShowDialog();
        }

        private void quảnTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnTrịToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnuGiaoDich_Click(object sender, EventArgs e)
        {
            BackColor = Color.RoyalBlue;
        }
    }
}
