using System;

namespace SequenciaFibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Quantos Valores: ");
            int valores = int.Parse(Console.ReadLine());

            Console.WriteLine("Sequencia de Fibonacci com " + valores + "Valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
