using System;

namespace EstruturasCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Tomando decisões com o comando if-else");

            // Operadores boleanos;
            // ==, !=, >, <, >=, <=,

            Console.Write("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            int res = 500;

            if ((a + b) > res)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
