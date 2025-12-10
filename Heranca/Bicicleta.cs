using System;

namespace Heranca
{
    public class Bicicleta : Veiculo
    {
        #region Properties

        public double VelocidadePedalar { get; set; }

        #endregion

        public void Pedalar()
        {
            Console.WriteLine("Pedalou!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }
    }
}
