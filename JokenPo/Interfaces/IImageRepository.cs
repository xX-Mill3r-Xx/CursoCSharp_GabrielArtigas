using JokenPo.Enums;
using System.Drawing;

namespace JokenPo.Interfaces
{
    public interface IImageRepository
    {
        Image ObterImagem(Jogada jogada);
    }
}
