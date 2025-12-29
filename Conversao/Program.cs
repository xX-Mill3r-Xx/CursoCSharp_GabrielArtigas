using System;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implicita

            byte num1 = 100; // 8 bits
            ushort num2; // 16 bits

            num2 = num1;

            Console.WriteLine(num2);

            #endregion

            #region Conversão Explicita

            ushort num3 = 500;
            byte num4 = (byte)num3; // aqui teremos perda de dados;

            Console.WriteLine(num4);

            #endregion

            #region Metodo Parse

            string txtNumero = "1985";
            int numero = int.Parse(txtNumero);

            Console.WriteLine(numero);

            #endregion

            #region Classe Convert

            var texto = Convert.ToInt64(txtNumero);
            Console.WriteLine(texto); // texto convertido em long

            #endregion
        }
    }
}
