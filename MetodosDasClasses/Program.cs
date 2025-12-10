using System;

namespace MetodosDasClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();
            var nome = metodos.DefinirNome();

            Console.WriteLine($"O nome do seu personagem é: {nome}");

            int n1 = 100;
            int n2 = 100;

            metodos.Somar(n1, n2);

            metodos.Apresentar("Miller",37);

            metodos.AumentarValor(n1);

            metodos.AumentarValorRef(ref n2);

            Console.WriteLine($"valor: {n1} - referencia: {n2}");

            var nomeCompleto = metodos.MontaNome("miller","martins");
            Console.WriteLine($"O nome completo é: {nomeCompleto}");

            var codigoChar = metodos.CodigoChar('A');

            var retornaPi = metodos.ValorPI();

            Console.WriteLine($"Codigo char de A = {codigoChar}");
            Console.WriteLine($"Valor de PI é: {retornaPi}");

            metodos.Cumprimentar("Miller");
        }
    }
}
