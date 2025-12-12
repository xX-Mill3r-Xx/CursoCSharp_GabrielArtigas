using System;

namespace Recursividade
{
    public class Recursivo
    {
        public void ExecutarSemRecursivo(string msg, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{msg} - #{i + 1}");
            }
        }

        public void ExecutarRecursivo(string msg, int n)
        {
            if(n > 0)
            {
                Console.WriteLine($"{msg} - #{n}");
                ExecutarRecursivo(msg, n - 1);
            }
        }
    }
}
