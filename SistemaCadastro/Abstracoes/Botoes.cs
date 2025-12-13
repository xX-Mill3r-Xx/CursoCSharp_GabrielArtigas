using System.Drawing;
using System.Windows.Forms;

namespace SistemaCadastro.Funcoes
{
    public abstract class Botoes
    {
        public abstract void ComportamentoBotaoEntrar(Button button, Color cor);

        public abstract void ComportamentoBotaoSair(Button button, Color cor);
    }
}
