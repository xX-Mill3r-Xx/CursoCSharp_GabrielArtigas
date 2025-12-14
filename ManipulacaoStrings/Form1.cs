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
            string texto = " - Este tipo de variável é alfanumérica - ";
            string nome = "Martins";
            int numero = 5400;
            decimal valor = 1540.45M;
            DateTime data = DateTime.Now;

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
            //StartWith(nome);
            //EndsWith(nome);
            //Trim(texto);
            //TrimStart(texto);
            //TrimEnd(texto);
            //Equals(nome);
            //CompareTo(nome);
            //Format(valor);
            Format(data);

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

        private void StartWith(string nome)
        {
            if(nome.StartsWith("M", StringComparison.OrdinalIgnoreCase))
                lbTeste.Text = "Começa com M";
            else
                lbTeste.Text = "Não começa com M";
        }

        private void EndsWith(string nome)
        {
            if(nome.EndsWith("b", StringComparison.OrdinalIgnoreCase))
                lbTeste.Text = "Termina com b";
            else
                lbTeste.Text = "Não termina com b";
        }

        private void Trim(string texto)
        {
            char[] c = new char[] { ' ', '-', '/' };
            string nova = texto.Trim(c);
            lbTeste.Text = nova;
        }

        private void TrimStart(string texto)
        {
            char[] c = new char[] { ' ', '-', '/' };
            string nova = texto.TrimStart(c);
            lbTeste.Text = nova;
        }

        private void TrimEnd(string texto)
        {
            char[] c = new char[] { ' ', '-', '/' };
            string nova = texto.TrimEnd(c);
            lbTeste.Text = nova;
        }

        private void Equals(string nome)
        {
            if(nome.Equals("Teste"))
                lbTeste.Text = "Igual";
            else
                lbTeste.Text = "Diferente";
        }

        private void CompareTo(string nome)
        {
            if(nome.CompareTo("Martins") == 0)
                lbTeste.Text = "Igual";
            else
                lbTeste.Text = "Diferente";
        }

        private void Format(decimal valor)
        {
            lbTeste.Text = string.Format("O valor do produto é {0:C2}", valor);
        }

        private void Format(DateTime data)
        {
            lbTeste.Text = string.Format("A data é: {0:dd/MM/yyy} e são {0:HH:mm:ss}", data);
        }

        #endregion
    }
}
