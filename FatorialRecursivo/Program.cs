using FatorialRecursivo.Entities;
using System;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### FATORIAL RECURSIVO ###";

            Console.Write("Calcular fatorial de qual valor? ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {numero} é: {ClasseRecursiva.Fatorial(numero)}");
        }
    }
}
