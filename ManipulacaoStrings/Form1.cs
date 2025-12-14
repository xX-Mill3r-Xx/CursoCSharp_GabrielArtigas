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
            string texto = " Este tipo de variável é alfanumérica";
            string nome = "Martins";
            int numero = 5400;

            #region Métodos para teste

            //VerificacaoContanis(texto);
            //ConverterParaString(numero);
            //CaixaAlta(texto);
            //CaixaBaixa(texto);
            //IndexOf(nome, "Martins");
            //LastIndesxOf(nome, "a");
            //Insert(nome);
            //Replace(nome);
            //Tamanho(nome);
            //SubString(nome);
            //ComandoSplit(texto);

            #endregion
        }

        #region Métodos

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

        private void Insert(string nome)
        {
            string nomeFinal = nome.Insert(0, "Miller ");
            lbTeste.Text = nomeFinal;
        }

        private void Replace(string nome)
        {
            string nomeFinal = nome.Replace("M", "W");
            lbTeste.Text = nomeFinal;
        }

        private void Tamanho(string nome)
        {
            lbTeste.Text = $"O nome: {nome} contem {nome.Length.ToString()} letras";
        }

        private void SubString(string nome)
        {
            string nomeFinal = nome.Substring(2, 3);
            lbTeste.Text = nomeFinal;
        }

        private void ComandoSplit(string texto)
        {
            lbTeste.Text = string.Empty;
            char[] separador = new char[] { ' ' };
            string[] resultados = texto.Split(separador);
            foreach (var item in resultados)
            {
                lbTeste.Text += item + "\n";
            }
        }

        #endregion
    }
}
