using System;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();

            //teste.nome = "João";
            //teste.sobrenome = "Silva";
            //teste.Metodo1(); // Erro de compilação devido ao modificador 'private'
            teste.Executar();

            Homem homem = new Homem();
            Console.WriteLine(homem.RetornaNome());
            Console.WriteLine(homem.RetornaIdade());
        }
    }
}
