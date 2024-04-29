using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace WinFormsApp5
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtUsuario.Select();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //botao entrar
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();

        }
    }
}
