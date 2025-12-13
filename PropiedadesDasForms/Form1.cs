using System;
using System.Drawing;
using System.Windows.Forms;

namespace PropiedadesDasForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DefineNomeDoFormulario("Propriedades das Forms");
            DefineTamanhoForm(300, 300);
            DefineControlBox();
        }

        #region Metodos de definição das propiedades do Formulario

        private string DefineNomeDoFormulario(string nomeForm)
        {
            Text = nomeForm;
            return Text;
        }

        private void DefineTamanhoForm(int x, int y)
        {
            Size tamanho = new Size();
            tamanho.Width = x;
            tamanho.Height = y;

            Size = tamanho;
        }

        private void DefineControlBox(bool controle = true)
        {
            ControlBox = controle;
        }

        private void DefineCorDeFundo()
        {
            this.BackColor = Color.LightGray;
        }

        private void MeuMetodo(object sender, EventArgs e)
        {
            MessageBox.Show("Meu método foi chamado");
        }

        private void DefineCorBotaoAoEntrar(Button button)
        {
            button.BackColor = Color.OrangeRed;
            button.ForeColor = Color.White;
            lbMessage.Text = $"Você está sobre o botão {button.Text}";
        }

        private void DefineCorDoBotaoAoSair(Button button)
        {
            button.BackColor = SystemColors.Control;
            button.ForeColor = Color.Black;
            lbMessage.Text = $"Você saiu do botão {button.Text}";
        }

        #endregion

        #region Estudos sobre os eventos de um formulario

        private void Form1_Load(object sender, System.EventArgs e)
        {
            DefineCorDeFundo();
        }

        private void Form1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Você clicou no formulário!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja fechar o formulario?",
                                                    "Atenção",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Propiedades dos controles

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lbMessage.Text = "Clicando no botão executar";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbMessage.Text = string.Empty;
        }

        private void btnExecutar_MouseEnter(object sender, EventArgs e)
        {
            DefineCorBotaoAoEntrar(btnExecutar);
        }

        private void btnExecutar_MouseLeave(object sender, EventArgs e)
        {
            DefineCorDoBotaoAoSair(btnExecutar);
        }

        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            DefineCorBotaoAoEntrar(btnLimpar);
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            DefineCorDoBotaoAoSair(btnLimpar);
        }

        #endregion
    }
}
