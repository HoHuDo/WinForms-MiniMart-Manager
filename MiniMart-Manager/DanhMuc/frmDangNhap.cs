using MiniMart_Manager.Classes;
using System.Data;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmDangNhap : Form
    {
        ProcessDatabase dtBase = new ProcessDatabase();
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
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập đủ Tài khoản và Mật khẩu");
                return;
            }
            DataTable dtTaiKhoan = dtBase.ReadData("Select * from TaiKhoan where TenDangNhap=N'" + user + "' and MatKhau=N'" + pass + "'");

            if (dtTaiKhoan.Rows.Count > 0)
            {
                DataRow row = dtTaiKhoan.Rows[0];
                string MaNhanVien = row["MaNhanVien"].ToString();
                DataTable dtNhanVien = dtBase.ReadData("Select * from NhanVien where MaNhanVien=N'" + MaNhanVien + "'");
                DataRow rowNv = dtNhanVien.Rows[0];
                GlobalData.TenDangNhap = rowNv["TenNhanVien"].ToString();
                GlobalData.MaNV = rowNv["MaNhanVien"].ToString();

                this.DialogResult = DialogResult.OK;

                if (row["Quyen"].ToString() == "Admin")
                {
                    GlobalData.Quyen = "Admin";
                    frmQuanLy frm = new frmQuanLy();
                    frm.ShowDialog();
                }
                else
                {
                    GlobalData.Quyen = "Nhân Viên";
                    frmNhanVien frm = new frmNhanVien();
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tên Đăng Nhập hoặc mật khẩu không đúng vui lòng nhập lại");
                txtMatKhau.Clear();
                txtTaiKhoan.Focus();
            }



        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnDangNhap_Click(btnDangNhap, e);
            }

        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lblThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}