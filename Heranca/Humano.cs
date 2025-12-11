using System;

namespace Heranca
{
    public class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelo()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    public class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelo()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    public class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelo()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
