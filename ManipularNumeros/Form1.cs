using System;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //MetodoTryParse();
            //MetodoToString();
            //ConverterHexaDecimal();
            //ConverterFormatoMonetarios();
            ConverterToString();
        }

        private void MetodoTryParse()
        {
            int numero;
            string numeroString = "1985";
            string textoInvalido = "abcd";

            if (int.TryParse(numeroString + textoInvalido, out numero))
                lbResultado.Text = numero.ToString();
            else
                lbResultado.Text = "Conversão inválida!";

            // se retirar o textoInvalido, a conversão será bem-sucedida
        }

        private void MetodoToString()
        {
            double numero = 2024.5;
            lbResultado.Text = numero.ToString("0000.00");
        }

        private void ConverterHexaDecimal()
        {
            int num = 10;
            lbResultado.Text = num.ToString("X");
        }

        private void ConverterFormatoMonetarios()
        {
            decimal valor = 10.00M;
            lbResultado.Text = valor.ToString("C");
        }

        private void ConverterToString()
        {
            int num = 10;
            lbResultado.Text = Convert.ToString(num, 16);
        }
    }
}
