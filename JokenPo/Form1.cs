using JokenPo.Enums;
using JokenPo.Game;
using JokenPo.Interfaces;
using JokenPo.Models;
using JokenPo.Repositories;
using JokenPo.Services;
using System;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class FrmPrincipal : Form
    {
        #region Properties

        private Jogo _jogo;

        #endregion

        #region Constructors

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarDependencias();
            ConfigurarBotoes();
        }

        #endregion

        private void ConfigurarDependencias()
        {
            Interfaces.IImageRepository imagemRepo = new ImagemRepository();
            IGeradorJogada gerarJogada = new GeradorJogadaAleatorio();
            IRegrasJogo regras = new RegrasJogoClassico();

            _jogo = new Jogo(imagemRepo, gerarJogada, regras);
        }

        private void ConfigurarBotoes()
        {
            btnPedra.Tag = Jogada.Pedra;
            btnPapel.Tag = Jogada.Papel;
            btnTesoura.Tag = Jogada.Tesoura;

            btnPedra.Click += btnPedra_Click;
            btnPapel.Click += btnPapel_Click;
            btnTesoura.Click += btnTesoura_Click;
        }

        private void ExecutarJogada(Jogada jogada)
        {
            try
            {
                var resultado = _jogo.Jogar(jogada);
                AtualizarInterface(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar jogada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarInterface(ResultadoPartida resultado)
        {
            picJogador.Image = resultado.ImagemJogador;
            picOponente.Image = resultado.ImagemOponente;
            lbResultado.Text = FormatarResultado(resultado.Resultado);

            AplicarFeedBackVisual(resultado.Resultado);
        }

        private string FormatarResultado(Resultado resultado)
        {
            switch (resultado)
            {
                case Resultado.GANHAR:
                    return "Você Venceu!";
                case Resultado.PERDER:
                    return "Você Perdeu!";
                case Resultado.EMPATAR:
                    return "Empate!";
                default:
                    return resultado.ToString();
            }
        }

        private void AplicarFeedBackVisual(Resultado resultado)
        {
            switch (resultado)
            {
                case Resultado.GANHAR:
                    lbResultado.ForeColor = System.Drawing.Color.Green;
                    break;
                case Resultado.PERDER:
                    lbResultado.ForeColor = System.Drawing.Color.Red;
                    break;
                case Resultado.EMPATAR:
                    lbResultado.ForeColor = System.Drawing.Color.Orange;
                    break;
                default:
                    lbResultado.ForeColor = System.Drawing.Color.Black;
                    break;
            }
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            if (sender is Button botao && botao.Tag is Jogada jogada)
                ExecutarJogada(jogada);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            if (sender is Button botao && botao.Tag is Jogada jogada)
                ExecutarJogada(jogada);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            if (sender is Button botao && botao.Tag is Jogada jogada)
                ExecutarJogada(jogada);
        }
    }
}
