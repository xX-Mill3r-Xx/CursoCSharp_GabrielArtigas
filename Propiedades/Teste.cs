using System;

namespace Propiedades
{
    public class Teste
    {
        private string _nome;
        public string Sobrenome { get; set; }
        public int Idade { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public void Apresentar()
        {
            if(_nome != string.Empty)
                Console.WriteLine($"Bem Vindo {_nome}");
        }
    }
}
