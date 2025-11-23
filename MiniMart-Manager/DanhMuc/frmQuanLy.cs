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
            frmNhaCungCap frm = new frmNhaCungCap();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void GiaoDien(Color color1, Color color2)
        {
            menuStrip1.BackColor = color1;
            menuStrip1.ForeColor = color2;
            pnlLeft.BackColor = color2;
            lblQuyen.BackColor = color1;
            lblQuyen.ForeColor = color2;
            pnlQuyen.BackColor = color1;
            lblTenTK.BackColor = color2;
            lblTenTK.ForeColor = color1;
            mnuBanHang.BackColor = color1;
            mnuBanHang.ForeColor = color2;
            mnuQLHoaDon.BackColor = color2;
            mnuQLHoaDon.ForeColor = color1;
            mnuQLNhapHang.BackColor = color1;
            mnuQLNhapHang.ForeColor = color2;
            mnuQLSanPham.BackColor = color1;
            mnuQLSanPham.ForeColor = color2;
            mnuQLLoaiHang.BackColor = color2;
            mnuQLLoaiHang.ForeColor = color1;
            mnuQLNhaCungCap.BackColor = color1;
            mnuQLNhaCungCap.ForeColor = color2;
            mnuQLTaiKhoan.BackColor = color1;
            mnuQLTaiKhoan.ForeColor = color2;
            mnuQLNhanVien.BackColor = color2;
            mnuQLNhanVien.ForeColor = color1;
            mnuQLKhachHang.BackColor = color1;
            mnuQLKhachHang.ForeColor = color2;
            mnuDangXuat.BackColor = color1;
            mnuDangXuat.ForeColor = color2;
            mnuDoiMK.BackColor = color2;
            mnuDoiMK.ForeColor = color1;
            mnuCauHinh.BackColor = color1;
            mnuCauHinh.ForeColor = color2;
        }

        private void xanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.SeaGreen, Color.Cornsilk);
        }

        private void tímToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.FromArgb(0, 0, 64), Color.Cornsilk);
        }

        private void đỏToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.DarkRed, Color.Cornsilk);
        }

        private void mnuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQLTaiKhoan frm = new frmQLTaiKhoan();
            frm.ShowDialog();
        }

        private void mnuQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frm = new frmQLNhanVien();
            frm.ShowDialog();
        }

        private void mnuQLKhachHang_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.ShowDialog();
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.ShowDialog();
        }

        private void mnuCauHinh_Click(object sender, EventArgs e)
        {
            frmCauHinh frm = new frmCauHinh();
            frm.ShowDialog();

        }

        private void mnuGiaoDien_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            frm.ShowDialog();
        }
    }
}
