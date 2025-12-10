using System;

namespace Heranca
{
    public abstract class Veiculo
    {
        #region Properties

        public string Cor { get; set; }
        public string Marca { get; set; }

        #endregion

        public abstract void Acelerar();

        public void Frear()
        {
            Console.WriteLine("Freou!");
        }

        public void Parar()
        {
            Console.WriteLine("Parou!");
        }
    }
}
