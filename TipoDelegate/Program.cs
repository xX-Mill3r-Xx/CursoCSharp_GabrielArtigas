using System;

namespace TipoDelegate
{
    public class Program
    {
        delegate void Operacao(int n1, int n2);

        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();
            Operacao conta = null;

            conta += matematica.Somar;
            conta += matematica.Subtrair;
            conta += matematica.Multiplicar;
            conta += matematica.Dividir;

            conta(10,2);

            Console.ReadKey();
        }
    }
}
