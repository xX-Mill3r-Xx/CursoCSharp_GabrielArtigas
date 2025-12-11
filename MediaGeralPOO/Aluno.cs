using System;

namespace MediaGeralPOO
{
    public class Aluno
    {
        #region Properties

        public string Nome { get; private set; }
        public double Media { get; }
        private double[] _notas;

        #endregion

        #region Constructors

        public Aluno(string anluno, int provas)
        {
            Nome = anluno;
            _notas = new double[provas];
        }

        #endregion

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write($"Nota # {i + 1}: ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                total += _notas[i];
            }

            return total / _notas.Length;
        }

        public double RetornaMedia()
        {
            return CalcularMedia();
        }
    }
}
