using System;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            #region Texto simples

            //MessageBox.Show("Teste de caixa de texto!"); // faz parte do using System.Windows.Forms

            #endregion

            #region Texto + Titulo

            //MessageBox.Show("Mensagem", "Titulo"); // Exibe a msg e o titulo da msg

            #endregion

            #region Fechar Janela

            //if (MessageBox.Show("Confirma fechamento da form?",
            //    "Fechar Janela?",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question) == DialogResult.Yes)
            //    lblResultado.Text = $"Clicou no Yes - Aqui a form seria fechada.";
            //else
            //    lblResultado.Text = $"Clicou no No - Aqui, nada acontece";

            #endregion

            #region Mensagem de erro

            //MessageBox.Show("Mensagem de Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            #endregion

            #region Seleção de botão por padrão

            MessageBox.Show("Botão selecionado por padrão", "Padrão", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

            #endregion
        }

        private void btnRandon_Click(object sender, EventArgs e)
        {
            Random randon = new Random(DateTime.Now.Millisecond);

            #region Gerar numeros aleatórios

            lblResultado.Text = $"O numero aleatório gerado foi: {randon.Next(10000)}";

            #endregion
        }
    }
}
