using System;

namespace ClassesStaticas
{
    public partial class PessoaAtributos
    {
        public void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }

        public static int CalcularIdade(int anoNacimento)
        {
            return DateTime.Now.Year - anoNacimento;
        }
    }
}
