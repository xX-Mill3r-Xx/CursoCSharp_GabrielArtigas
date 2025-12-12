using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo.Entities
{
    public static class ClasseRecursiva
    {
        public static int Fatorial(int n)
        {
            if (n <= 0)
                return 1;

            return n * Fatorial(n - 1);
        }
    }
}
