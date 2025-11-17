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
    }
}
