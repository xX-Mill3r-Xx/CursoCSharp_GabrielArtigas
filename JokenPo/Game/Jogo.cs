using JokenPo.Enums;
using JokenPo.Interfaces;
using JokenPo.Models;
using System;
using System.Drawing;

namespace JokenPo.Game
{
    public class Jogo
    {
        #region Obsoleto
        //#region properties

        //public static Image[] imagens =
        //{
        //    Image.FromFile("imagens/Pedra.png"),
        //    Image.FromFile("imagens/Tesoura.png"),
        //    Image.FromFile("imagens/Papel.png")
        //};

        //public Image ImgPc { get; private set; }
        //public Image ImgPlayer { get; private set; }

        //#endregion

        //public Resultado Jogar(int jogador)
        //{
        //    int pc = JogadaPC();

        //    ImgPlayer = imagens[jogador];
        //    ImgPc = imagens[pc];

        //    if (jogador == pc)
        //        return Resultado.EMPATAR;
        //    else if ((jogador == 0 && pc == 1)
        //        || (jogador == 1 && pc == 2)
        //        || (jogador == 2 && pc == 0))
        //        return Resultado.GANHAR;
        //    else
        //        return Resultado.PERDER;
        //}

        //private int JogadaPC()
        //{
        //    int mil = DateTime.Now.Millisecond;
        //    if (mil < 333)
        //        return 0;
        //    else if (mil >= 333 && mil < 666)
        //        return 1;
        //    else
        //        return 2;
        //}
        #endregion

        #region Properties

        private readonly IImageRepository _imageRepository;
        private readonly IGeradorJogada _geradorJogada;
        private readonly IRegrasJogo _regrasJogo;

        #endregion

        public Jogo(IImageRepository imageRepository, IGeradorJogada geradorJogada, IRegrasJogo regrasJogo)
        {
            _imageRepository = imageRepository;
            _geradorJogada = geradorJogada;
            _regrasJogo = regrasJogo;
        }

        public ResultadoPartida Jogar(Jogada jogadaJogador)
        {
            var jogadaOponente = _geradorJogada.GerarJogada();
            var resultado = _regrasJogo.DeterminarResultado(jogadaJogador, jogadaOponente);

            return new ResultadoPartida
            {
                JogadaJogador = jogadaJogador,
                JogadaOponente = jogadaOponente,
                ImagemJogador = _imageRepository.ObterImagem(jogadaJogador),
                ImagemOponente = _imageRepository.ObterImagem(jogadaOponente),
                Resultado = resultado
            };
        }
    }
}
