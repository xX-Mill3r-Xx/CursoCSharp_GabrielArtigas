using System;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(); 
            conta.Operacoes();
            
            Console.ReadKey();
        }
    }
}
