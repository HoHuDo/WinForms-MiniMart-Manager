using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            lblPhienBan.Text = GlobalData.PhienBan;
            lblMoTa.Text = GlobalData.MoTa;
            lblLienHe.Text = "SĐT: " + GlobalData.SDT + "/ Email: " + GlobalData.Email + ".";
            lblDBName.Text = GlobalData.DataName + ".";
        }
    }
}
