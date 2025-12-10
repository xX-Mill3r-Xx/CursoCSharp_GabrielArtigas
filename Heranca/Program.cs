using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Bicicleta bicicleta = new Bicicleta();

            carro.Cor = "Vermelho";
            carro.Ligar();
            carro.Acelerar();
            carro.Frear();
            carro.Parar();

            Console.WriteLine();

            bicicleta.Cor = "Azul";
            bicicleta.Pedalar();
            bicicleta.Acelerar();
            bicicleta.Frear();
            bicicleta.Parar();
        }
    }
}
