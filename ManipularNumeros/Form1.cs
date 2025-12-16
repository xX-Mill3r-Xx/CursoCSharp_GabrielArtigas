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
            //ConverterToString();
            ClasseMath();
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

        private void ClasseMath()
        {
            //lbResultado.Text = Math.PI.ToString("#.00");
            //lbResultado.Text = Math.Cos(3).ToString("#.00");
            //lbResultado.Text = Math.Sin(3).ToString("#.00");
            //lbResultado.Text = Math.E.ToString("#.00");
            //lbResultado.Text = Math.Pow(2,2).ToString("#.00");
            //lbResultado.Text = Math.Sqrt(49).ToString("#.00");
            //lbResultado.Text = Math.Round(158.75).ToString("#.00");
            //lbResultado.Text = Math.Truncate(32.57).ToString("#.00");
            //lbResultado.Text = Math.Floor(3.5).ToString("#.00");
            lbResultado.Text = Math.Ceiling(52.25).ToString("#.00");
        }
    }
}
