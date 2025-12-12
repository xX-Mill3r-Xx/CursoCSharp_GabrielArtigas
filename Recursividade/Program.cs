using System;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursivo recursivo = new Recursivo();

            Console.WriteLine("Executando sem recursividade");
            recursivo.ExecutarSemRecursivo("Recursividade", 5);
            Console.WriteLine();
            Console.WriteLine("Executando com recursividade");
            recursivo.ExecutarRecursivo("Recursividade", 5);
        }
    }
}
