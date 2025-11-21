using MiniMart_Manager.Classes;

namespace MiniMart_Manager.DanhMuc
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            lblMota.Text = GlobalData.MoTa;
            lblPhienBan.Text = GlobalData.PhienBan;
        }
    }
}
