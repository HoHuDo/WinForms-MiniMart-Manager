using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lblTen.Text = GlobalData.TenDangNhap;
        }

        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            frmTroGiup frm = new frmTroGiup();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tímToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.FromArgb(0, 0, 64), Color.Cornsilk);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();

        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.ShowDialog();
        }

        private void mnuQLSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
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

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();
            frm.ShowDialog();
        }

        private void mnuQLHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.ShowDialog();
        }

        public void GiaoDien(Color color1, Color color2)
        {
            menuStrip1.BackColor = color1;
            menuStrip1.ForeColor = color2;
            pnlLeft.BackColor = color2;
            lblQuyen.BackColor = color1;
            lblQuyen.ForeColor = color2;
            pnlQuyen.BackColor = color1;
            lblTen.BackColor = color2;
            lblTen.ForeColor = color1;
            mnuBanHang.BackColor = color1;
            mnuBanHang.ForeColor = color2;
            mnuQLHoaDon.BackColor = color2;
            mnuQLHoaDon.ForeColor = color1;
            mnuQLSanPham.BackColor = color1;
            mnuQLSanPham.ForeColor = color2;
            mnuQLLoaiHang.BackColor = color2;
            mnuQLLoaiHang.ForeColor = color1;
            mnuQLNhaCungCap.BackColor = color1;
            mnuQLNhaCungCap.ForeColor = color2;
            mnuDangXuat.BackColor = color1;
            mnuDangXuat.ForeColor = color2;
            mnuDoiMK.BackColor = color2;
            mnuDoiMK.ForeColor = color1;
        }
        private void mnuGiaoDien_Click(object sender, EventArgs e)
        {

        }

        private void mnuGDXanh_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.SeaGreen, Color.Cornsilk);
        }

        private void mnuGDDo_Click(object sender, EventArgs e)
        {
            GiaoDien(Color.DarkRed, Color.Cornsilk);
        }
    }
}
