using SistemaCadastro.Extensoes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        #region Properties

        private BotaoSair _botaoSair;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
            _botaoSair = new BotaoSair();
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            _botaoSair.ComportamentoBotaoEntrar(btnFechar, Color.Red);
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            _botaoSair.ComportamentoBotaoSair(btnFechar, SystemColors.Control);
        }
    }
}
