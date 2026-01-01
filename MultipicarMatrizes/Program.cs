using System;

namespace MultipicarMatrizes
{
    internal class Program
    {
        /* Este Algoritimo realiza o calculo de uma matriz bidmensional, ou seja, uma matriz com linhas e colunas.
         no caso deste, temos uma matriz com duas linhas e tres colunas multiplicada por outr matriz de tres linhas
        e duas colunas.*/

        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3]; // a matriz1 contem 2 linhas e 3 colunas;
            int[,] matriz2 = new int[3, 2]; // a matriz2 contem 3 linhas e 2 colunas;
            int[,] resultado = new int[2, 2]; // o resultado exibe a soma das multiplicações em 2 linhas e 2 colunas;

            Console.WriteLine("Preencher a matriz #1"); // exibe o texto entre parenteses;

            for (int linha = 0; linha < 2; linha++) // percorre da linha 0 a linha 2 da matriz1;
            {
                for (int coluna = 0; coluna < 3; coluna++) // percorre da coluna 0 a coluna 3 da matriz1; 
                {
                    Console.Write("#1. posição [ " + linha + "][ " + coluna + "]:"); // exibe a posição #1 linha/coluna matriz1;
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Preencher a matriz #2"); // exibe o texto entre parenteses;

            for (int linha = 0; linha < 3; linha++) // percorre da linha 0 a linha 3 da matriz2;
            {
                for (int coluna = 0; coluna < 2; coluna++) // percorre da coluna 0 a coluna 2 da matriz2;
                {
                    Console.Write("#2. posição [ " + linha + "][ " + coluna + "]:"); // exibe a posição #2 linha/coluna matriz2;
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nResultado da matriz #1 X matriz #2"); // exibe o resultado matriz1 X matriz2;

            resultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);

            resultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);

            resultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);

            resultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "]");

            Console.ReadKey();

        }
    }
}
