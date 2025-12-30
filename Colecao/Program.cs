using System;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            //Vetores - Array Unidmensional

            /*Em C#, um vetor (array) unidimensional é uma coleção de elementos do mesmo tipo, organizados em uma estrutura de dados indexada. Os elementos do vetor são armazenados em sequência contígua de memória, o que permite o acesso direto a qualquer elemento do vetor.
                Para declarar um vetor unidimensional em C#, é necessário especificar o tipo de dados dos elementos do vetor, seguido pelo nome do vetor e pelo tamanho do vetor entre colchetes. Por exemplo, a declaração de um vetor de inteiros com 5 elementos ficaria assim:*/

            int[] meuVetor = new int[5];

            /*O primeiro elemento do vetor tem índice 0, e o último elemento tem índice tamanho-1. Para acessar um elemento específico do vetor, basta utilizar o operador de índice [], seguido do índice desejado. Por exemplo, para acessar o segundo elemento do vetor acima, utilizamos:*/

            meuVetor[1] = 42;

            /*Podemos percorrer todos os elementos do vetor com um loop for, utilizando o índice do vetor como contador:*/

            for (int i = 0; i < meuVetor.Length; i++)
            {
                Console.WriteLine(meuVetor[i]);
            }
            /*O tamanho do vetor pode ser obtido através da propriedade Length. É importante notar que o tamanho do vetor não pode ser alterado depois de criado, mas podemos alterar os valores dos elementos individualmente.*/

            /*Os vetores unidimensionais em C# são muito úteis para armazenar e manipular coleções de dados, como listas de números, nomes, datas, etc.*/
            #endregion

            #region Matriz
            //Matriz - Array bidimensional

            /*Em C#, uma matriz é uma estrutura de dados que armazena um conjunto de elementos em uma grade com linhas e colunas. É semelhante a um vetor unidimensional, mas em vez de ter apenas uma dimensão, uma matriz tem duas dimensões, formando uma grade retangular.
                Para declarar uma matriz em C#, é preciso especificar o tipo de dados dos elementos da matriz e o número de linhas e colunas que ela terá. Por exemplo, para declarar uma matriz de inteiros com 3 linhas e 4 colunas, fazemos:*/
            int[,] matriz = new int[3, 4];

            /*Para acessar os elementos de uma matriz, utilizamos dois índices, um para a linha e outro para a coluna. Por exemplo, para acessar o elemento da segunda linha e terceira coluna da matriz acima, fazemos:*/

            int elemento = matriz[1, 2];

            /*Podemos inicializar uma matriz com valores na declaração. Por exemplo, para criar uma matriz com valores predefinidos, fazemos:*/

            //int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            /*Com uma matriz, podemos representar dados em duas dimensões, como uma tabela de valores ou uma imagem, por exemplo.*/
            #endregion
        }
    }
}
