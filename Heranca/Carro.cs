using System;

namespace Heranca
{
    public class Carro : Veiculo
    {
        #region Properties

        public double VelocidadeMaxima { get; set; }

        #endregion

        public void Ligar()
        {
            Console.WriteLine("Ligou o carro!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro");
        }
    }
}
