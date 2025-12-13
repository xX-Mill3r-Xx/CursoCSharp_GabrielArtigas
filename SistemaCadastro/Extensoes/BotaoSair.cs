using SistemaCadastro.Funcoes;

namespace SistemaCadastro.Extensoes
{
    public class BotaoSair : Botoes
    {
        public override void ComportamentoBotaoEntrar(System.Windows.Forms.Button button, System.Drawing.Color cor)
        {
            button.BackColor = cor;
            button.ForeColor = System.Drawing.Color.White;
        }

        public override void ComportamentoBotaoSair(System.Windows.Forms.Button button, System.Drawing.Color cor)
        {
            button.BackColor = cor;
            button.ForeColor = System.Drawing.Color.Black;
        }
    }
}
