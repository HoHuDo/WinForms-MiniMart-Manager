namespace MiniMart_Manager.DanhMuc
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void lblThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblNhapLai_Click(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            txtTaiKhoan.Clear();

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtMatKhau.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmQuanLy frm = new frmQuanLy();
            frm.ShowDialog();
            this.Close();
        }
    }
}