using JokenPo.Enums;
using JokenPo.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace JokenPo.Repositories
{
    public class ImagemRepository : IImageRepository
    {
        #region Properties

        private readonly Dictionary<Jogada, Image> _imagens;

        #endregion

        public ImagemRepository()
        {
            _imagens = new Dictionary<Jogada, Image>
            {
                {Jogada.Pedra, Image.FromFile("imagens/Pedra.png") },
                {Jogada.Tesoura, Image.FromFile("imagens/Tesoura.png") },
                {Jogada.Papel, Image.FromFile("imagens/Papel.png") },
            };
        }

        public Image ObterImagem(Jogada jogada)
        {
            if (!_imagens.ContainsKey(jogada))
                throw new ArgumentException($"Imagem não encontrada para {jogada}");

            return _imagens[jogada];
        }
    }
}
