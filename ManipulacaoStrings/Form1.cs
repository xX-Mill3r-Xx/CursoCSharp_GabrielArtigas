using System;
using System.Windows.Forms;

namespace ManipulacaoStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string texto = "Este tipo de variável é alfanumérica";
            string nome = "Miller Martins";
            int numero = 5400;

            #region Métodos para teste

            //VerificacaoContanis(texto);
            //ConverterParaString(numero);
            //CaixaAlta(texto);
            //CaixaBaixa(texto);
            //IndexOf(nome, "Martins");
            //LastIndesxOf(nome, "a");

            #endregion
        }

        private bool VerificacaoContanis(string texto)
        {
            if (texto.Contains("tipo"))
            {
                lbTeste.Text = "Contem";
                return true;
            }

            lbTeste.Text = "Não Contem";
            return false;
        }

        private void ConverterParaString(int numero)
        {
            lbTeste.Text = numero.ToString();
        }

        private void CaixaAlta(string texto)
        {
            lbTeste.Text = texto.ToUpper();
        }

        private void CaixaBaixa(string texto)
        {
            lbTeste.Text = texto.ToLower();
        }

        private void IndexOf(string texto, string posicao)
        {
            lbTeste.Text = texto.IndexOf(posicao).ToString();
        }

        private void LastIndesxOf(string texto, string posicao)
        {
            lbTeste.Text = texto.LastIndexOf(posicao).ToString();
        }
    }
}
