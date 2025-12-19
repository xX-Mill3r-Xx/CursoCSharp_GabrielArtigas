using JokenPo.Enums;

namespace JokenPo.Interfaces
{
    public interface IRegrasJogo
    {
        Resultado DeterminarResultado(Jogada jogador, Jogada oponente);
    }
}
