using MiniMart_Manager.Classes;
namespace MiniMart_Manager.DanhMuc
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }
        private void frmCauHinh_Load(object sender, EventArgs e)
        {
            txtTenCuaHang.Text = GlobalData.TenCuaHang;
            txtSDT.Text = GlobalData.SDT;
            txtEmail.Text = GlobalData.Email;
            txtDiaChi.Text = GlobalData.DiaChi;
            txtPhienBan.Text = GlobalData.PhienBan;
            txtMoTa.Text = GlobalData.MoTa;

            txtDataSource.Text = GlobalData.DataSource;
            txtDataName.Text = GlobalData.DataName;

            if (GlobalData.Authetication == "Windows Authentication")
                cbxAuth.SelectedIndex = 1;
            else
                cbxAuth.SelectedIndex = 0;

            txtPass.PasswordChar = '*';
            txtID.Text = GlobalData.User;
            txtPass.Text = GlobalData.Password;
            chkTrust.Checked = GlobalData.Trust;
        }
        private void cbxAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSqlAuth = cbxAuth.SelectedIndex == 0;
            txtID.Enabled = isSqlAuth;
            txtPass.Enabled = isSqlAuth;
        }
        private void btnLuuCnn_Click(object sender, EventArgs e)
        {
            GlobalData.DataSource = txtDataSource.Text;
            GlobalData.Authetication = cbxAuth.SelectedItem != null ? cbxAuth.SelectedItem.ToString() : "SQL Server Authentication";
            GlobalData.User = txtID.Text;
            GlobalData.Password = txtPass.Text;
            GlobalData.Trust = chkTrust.Checked;

            try
            {
                MessageBox.Show("Đã lưu cấu hình kết nối!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GlobalData.TenCuaHang = txtTenCuaHang.Text;
            GlobalData.SDT = txtSDT.Text;
            GlobalData.Email = txtEmail.Text;
            GlobalData.DiaChi = txtDiaChi.Text;
            GlobalData.PhienBan = txtPhienBan.Text;
            GlobalData.MoTa = txtMoTa.Text;

            try
            {
                MessageBox.Show("Đã lưu thông tin cửa hàng!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}