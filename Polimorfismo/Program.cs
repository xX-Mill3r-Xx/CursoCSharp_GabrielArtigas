using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comportamento de polimorfismo

            Forma forma = new Forma();
            forma.Desenhar();
            Console.WriteLine();

            Forma circulo = new Circulo();
            circulo.Desenhar();
            circulo.Area();
            Console.WriteLine();

            Forma retangulo = new Retangulo();
            retangulo.Desenhar();
            retangulo.Area();
            Console.WriteLine();

            Forma triangulo = new Triangulo();
            triangulo.Desenhar();
            triangulo.Area();
        }
    }
}
