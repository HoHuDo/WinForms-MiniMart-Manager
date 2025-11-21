using MiniMart_Manager.Classes;
using System.Data;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmDoiMatKhau : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
            txtMKMoi.PasswordChar = '*';
            txtXacNhan.PasswordChar = '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblThoat_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtTK.Text.Trim();
            string pass = txtMK.Text.Trim();
            string newpass1 = txtMKMoi.Text.Trim();
            string newpass2 = txtXacNhan.Text.Trim();
            if (user == "" || pass == "" || newpass1 == "" || newpass2 == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường!");
                return;
            }
            if (newpass2 != newpass1)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!");
                return;
            }
            DataTable dt = dtBase.ReadData("Select * from TaiKhoan Where TenDangNhap=N'" + user + "' and MatKhau=N'" + pass + "'");
            if (dt.Rows.Count > 0)
            {
                dtBase.UpdateData("Update TaiKhoan set MatKhau=N'" + newpass1 + "' where TenDangNhap=N'" + user + "'");
                MessageBox.Show("Cập nhật thành công!");
                txtMK.Clear();
                txtMK.Clear();
                txtMKMoi.Clear();
                txtXacNhan.Clear();
                txtTK.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                txtMK.Clear();
                txtTK.Focus();
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtMK.PasswordChar = '\0';
                txtMKMoi.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
                txtMKMoi.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';
            }
        }
    }
}
