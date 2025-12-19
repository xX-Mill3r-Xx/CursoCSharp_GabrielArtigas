using JokenPo.Enums;
using System.Drawing;

namespace JokenPo.Models
{
    public class ResultadoPartida
    {
        public Jogada JogadaJogador { get; set; }
        public Jogada JogadaOponente { get; set; }
        public Image ImagemJogador { get; set; }
        public Image ImagemOponente { get; set; }
        public Resultado Resultado { get; set; }
    }
}
