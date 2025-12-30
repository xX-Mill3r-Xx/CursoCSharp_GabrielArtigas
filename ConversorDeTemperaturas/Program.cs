using System;

namespace ConversorDeTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("Conversor de temperaturas");
            Console.Write("Informe o valor da temperatura em celcius: ");
            c = double.Parse(Console.ReadLine());

            f = CalcularF(c);
            k = CalculaK(c);

            Console.WriteLine($"O valor em F: {f}");
            Console.WriteLine($"O valor em K: {k}");
        }

        static double CalcularF(double c)
        {
            // para calcular f: (c * 9 / 5) + 32 = f

            const int val1 = 9;
            const int val2 = 5;
            const int val3 = 32;

            double res = (c * val1 / val2) + val3;
            return res;
        }

        static double CalculaK(double c)
        {
            // para calcular k: c + 273,15

            const double val1 = 273.15;

            double res = c + val1;
            return res;
        }
    }
}
