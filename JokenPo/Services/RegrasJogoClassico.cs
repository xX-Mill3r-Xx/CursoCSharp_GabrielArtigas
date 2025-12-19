using JokenPo.Enums;
using JokenPo.Interfaces;
using System.Collections.Generic;

namespace JokenPo.Services
{
    public class RegrasJogoClassico : IRegrasJogo
    {
        #region Properties

        private readonly Dictionary<Jogada, Jogada> _venceSobre;

        #endregion

        public RegrasJogoClassico()
        {
            _venceSobre = new Dictionary<Jogada, Jogada>
            {
                { Jogada.Pedra, Jogada.Tesoura },
                { Jogada.Tesoura, Jogada.Papel },
                { Jogada.Papel, Jogada.Pedra }
            };
        }

        public Resultado DeterminarResultado(Jogada jogador, Jogada oponente)
        {
            if (jogador == oponente)
                return Resultado.EMPATAR;

            if (_venceSobre[jogador] == oponente)
                return Resultado.GANHAR;

            return Resultado.PERDER;
        }
    }
}
