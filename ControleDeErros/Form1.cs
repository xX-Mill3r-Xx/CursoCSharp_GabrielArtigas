using System;
using System.Windows.Forms;

namespace ControleDeErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numeros = { 10, 20, 30, 40, 50 };
                string res = "";
                int pos = int.Parse(txtFor.Text);
                for (int i = 0; i < pos; i++)
                {
                    res += numeros[i] + ", ";

                    lbResultado.Text = res;
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                lbResultado.Text = ex.Message;
            }
            finally
            {
                //MessageBox.Show("Operação finalizada");
            }
        }
    }
}
