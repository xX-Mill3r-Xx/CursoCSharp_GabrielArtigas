using SistemaLogin.Seg;
using System;
using System.Windows.Forms;

namespace SistemaLogin.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Logar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void Logar()
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();
            if (CadastroUsuarios.ValidarUsuario(usuario, senha))
            {
                Close();
            }   
            else
            {
                MessageBox.Show("Usuário e/ou Senha incorretas.", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Retry;
                Close();
            }
        }
    }
}
