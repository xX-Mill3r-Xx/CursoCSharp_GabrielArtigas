using System;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### MÉDIA GERAL DOS ALUNOS ###";

            Console.Write("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"ALUNO #{i + 1}: Nome..: ");
                string nome = Console.ReadLine();

                Console.Write($"ALUNO #{i + 1}: Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine($"Insira as notas do aluno {nome}");
                alunos[i].InserirNotas();


                Console.WriteLine();
            }

            Console.Clear();

            double mediaGeral = 0.0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {aluno.RetornaMedia()}");
                Console.WriteLine();

                mediaGeral += aluno.RetornaMedia();
            }

            double resultadoFinal = mediaGeral / nAlunos;

            Console.WriteLine($"A média geral dos alunos é: {resultadoFinal}");
        }
    }
}
