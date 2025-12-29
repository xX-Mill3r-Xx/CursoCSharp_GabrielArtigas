using System;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, aux;

            #region Entrada de dados

            Console.Write("Digite o nome 1: ");
            nome1 = Console.ReadLine();

            Console.Write("Digite o nome 2: ");
            nome2 = Console.ReadLine();

            Console.Write("Digite o nome 3: ");
            nome3 = Console.ReadLine();

            Console.Write("Digite o nome 4: ");
            nome4 = Console.ReadLine();

            Console.WriteLine();

            #endregion

            #region Mecanismo para inverter nomes

            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;

            Console.WriteLine("Nomes Inseridos na sequencia invertida");
            Console.WriteLine($"{nome1} - {nome2} - {nome3} - {nome4}");

            #endregion

            Console.ReadKey();
        }
    }
}
