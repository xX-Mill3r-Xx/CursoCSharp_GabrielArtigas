namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Numéricos Integrais

            #region Integral assinado - suporte a numeros negativos

            sbyte num1 = 10; // 8 bits
            short num2 = 20; // 16 bits
            int num3 = 30; // 32 bits
            long num4 = 40L; // 64bits

            #endregion

            #region Integral sem sinal - sem suporte a numeros negativos

            byte num5 = 10; // 8 bits,
            ushort num6 = 20; // 16 bits
            uint num7 = 30; // 32 bits
            ulong num8 = 40L; // 64 bits

            #endregion

            #endregion

            #region Numéricos Reais

            float real1 = 1.0f;
            double real2 = 1.50;
            decimal real3 = 2.75M;

            #endregion

            #region Caracteres

            char letra = 'c';
            string linha = "Este texto contem uma linha";

            #endregion

            #region Boolean

            bool verdadeiro = true;
            bool falso = false;

            #endregion

            #region Tipo var

            var numero = 0;
            var texto = "texto de exemplo";
            var vetor = new int[] { 1, 2, 3 };

            #endregion

            #region Tipo Object

            // object é a base para todos os outros tipos

            object obj = 100;
            object obj2 = "teste";

            #endregion

            #region Constantes

            const double pi = 3.14;

            #endregion

            #region Enumerações

            var nota = Notas.Media;

            #endregion

            #region Estruturas

            Pessoa p1 = new Pessoa();
            p1.nome = "Pessoa da struct";
            p1.idade = 18;
            p1.altura = 1.68;

            #endregion
        }

        #region Enumerador

        public enum Notas
        {
            None = 0,
            Minimo = 3,
            Media = 6,
            Maxima = 9
        }

        #endregion

        #region Struct

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        #endregion
    }
}
