using System;

namespace Polimorfismo
{
    public class Forma
    {
        #region Properties

        public int X { get; set; }
        public int Y { get; set; }
        public int Altura { get; set; } = 10;
        public int Largura { get; set; } = 15;
        public double Raio { get; set; } = 3.0;

        #endregion

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar");
        }

        public virtual void Area()
        {

        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um circulo");
        }

        public override void Area()
        {
            double area = Math.PI * Raio * Raio;
            Console.WriteLine("Área do círculo: " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retângulo");
        }
        public override void Area()
        {
            int area = Altura * Largura;
            Console.WriteLine("Área do retângulo: " + area);
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um triângulo");
        }
        public override void Area()
        {
            double area = (Altura * Largura) / 2.0;
            Console.WriteLine("Área do triângulo: " + area);
        }
    }
}
