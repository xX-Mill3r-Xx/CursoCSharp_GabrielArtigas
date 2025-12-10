using System;

namespace TermoThis
{
    public class Program
    {
        static void Main(string[] args)
        {
            Acessar acessar = new Acessar();

            Console.Write("Digite a senha para acesso: ");
            string senha = Console.ReadLine();

            if (acessar.Login(senha))
                Console.WriteLine("Seja Bem Vindo");
            else
                Console.WriteLine("Login ou senha invalidos!");
        }
    }
}
