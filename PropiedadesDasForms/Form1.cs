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
    }
}
