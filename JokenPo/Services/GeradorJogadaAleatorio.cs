using JokenPo.Enums;
using JokenPo.Interfaces;
using System;

namespace JokenPo.Services
{
    public class GeradorJogadaAleatorio : IGeradorJogada
    {
        #region Properties

        private readonly Random _random;

        #endregion

        public GeradorJogadaAleatorio()
        {
            _random = new Random();
        }

        public Jogada GerarJogada()
        {
            return (Jogada)_random.Next(0, 3);
        }
    }
}
