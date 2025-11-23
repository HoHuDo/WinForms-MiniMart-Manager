using MiniMart_Manager.DanhMuc;

namespace MiniMart_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DanhMuc.frmDangNhap frm = new DanhMuc.frmDangNhap();
            frm.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.LightCoral;
        }

        private void btnDangNhap_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            frm.ShowDialog();
        }
    }
}
