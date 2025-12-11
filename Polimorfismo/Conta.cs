using System;

namespace Polimorfismo
{
    public class CaixaEletronico : IConta
    {
        public string Usuario { get; set; }

        public void Depositar(double valor)
        {

        }

        public void Sacar(double valor)
        {

        }

        public double VerSaldo()
        {
            throw new NotImplementedException();
        }
    }

    public interface IConta
    {
        string Usuario { get; set; }

        void Sacar(double valor);
        void Depositar(double valor);
        double VerSaldo();
    }
}
