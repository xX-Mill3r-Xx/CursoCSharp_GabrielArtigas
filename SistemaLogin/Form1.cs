using SistemaLogin.UI;
using System;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarLogin();
        }

        private void MostrarLogin()
        {
            FrmLogin login = new FrmLogin();
            DialogResult result = login.ShowDialog();

            if (result == DialogResult.Retry)
            {
                Hide();

                FrmLogin novoLogin = new FrmLogin();
                novoLogin.ShowDialog();
            }
            else if(result == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
