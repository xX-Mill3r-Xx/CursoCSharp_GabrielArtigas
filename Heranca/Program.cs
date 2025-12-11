using System;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte Heranca

            //Carro carro = new Carro();
            //Bicicleta bicicleta = new Bicicleta();

            //carro.Cor = "Vermelho";
            //carro.Ligar();
            //carro.Acelerar();
            //carro.Frear();
            //carro.Parar();

            //Console.WriteLine();

            //bicicleta.Cor = "Azul";
            //bicicleta.Pedalar();
            //bicicleta.Acelerar();
            //bicicleta.Frear();
            //bicicleta.Parar();

            #endregion

            #region Aula sobre Metodos Selead

            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            Console.WriteLine("Humano");
            humano.Olhos();
            humano.Cabelo();

            Console.WriteLine();
            Console.WriteLine("Pessoa");
            pessoa.Olhos();
            pessoa.Cabelo();

            Console.WriteLine();
            Console.WriteLine("Homem");
            homem.Olhos();
            homem.Cabelo();

            #endregion

            Console.ReadKey();
        }
    }
}
