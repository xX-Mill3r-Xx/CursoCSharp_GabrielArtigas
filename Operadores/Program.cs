using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  Operadores aritméticos em C# são utilizados para realizar operações matemáticas entre variáveis numéricas. Os principais operadores aritméticos são:
                Soma (+): utilizado para somar valores;
                Subtração (-): utilizado para subtrair valores;
                Multiplicação (*): utilizado para multiplicar valores;
                Divisão (/): utilizado para dividir valores;
                Módulo (%): utilizado para obter o resto de uma divisão inteira.
                Esses operadores podem ser aplicados em variáveis do tipo inteiro, double, float e decimal, entre outros. É importante lembrar que a precedência dos operadores é a mesma da matemática: primeiro multiplicação e divisão, depois soma e subtração. Para alterar a ordem de precedência, é possível utilizar parênteses.*/

            #region Operadores Aritimeticos

            //int dez = 10;
            //int dois = 2;

            //int resultadoSoma = dez + dois;
            //int resuldatoSubtracao = dez - dois;
            //int resultadoMultiplicacao = dez * dois;
            //int resultadoDivisao = dez / dois;
            //int resultadoMod = dez % dois;

            //Console.WriteLine(resultadoSoma);
            //Console.WriteLine(resuldatoSubtracao);
            //Console.WriteLine(resultadoMultiplicacao);
            //Console.WriteLine(resultadoDivisao);
            //Console.WriteLine(resultadoMod);

            #endregion

            #region Precedencia dos operadores

            //int cem = 100;
            //int dez = 10;
            //int cinco = 5;

            //int resultado = cem + dez * cinco;
            //int resultadoParenteses = (cem + dez) * cinco;
            //int resultadoComDivisao = (cem + dez) * cinco / 2;

            //Console.WriteLine(resultado);
            //Console.WriteLine(resultadoParenteses);
            //Console.WriteLine(resultadoComDivisao);

            #endregion

            #region Operadores de incremento e decremento
            /*Na linguagem C#, os operadores de incremento e decremento são utilizados para aumentar ou diminuir em 1 o valor de uma variável numérica. Existem duas      formas de se usar esses operadores: pré-fixada e pós-fixada.
                     A forma pré-fixada é representada pelos símbolos "++" e "--", e ela adiciona ou subtrai 1 do valor da variável antes de qualquer outra operação na linha de código. Por exemplo:*/

            int a = 5;
            int b = ++a;

            /*Nesse caso, a variável "a" é incrementada em 1 antes de ser atribuída à variável "b". Portanto, o valor de "a" será 6 e o valor de "b" também será 6.
                Já a forma pós-fixada é representada pelos símbolos "++" e "--" colocados depois do nome da variável. Nesse caso, a adição ou subtração de 1 ocorre após todas as outras operações da linha de código. Por exemplo:*/

            a = 5;
            b = a++;

            /*Nesse caso, a variável "a" é atribuída à variável "b" antes de ser incrementada em 1. Portanto, o valor de "a" será 6 e o valor de "b" será 5.
                Os operadores de incremento e decremento são bastante úteis em laços de repetição e outras situações onde é necessário manipular o valor de uma variável numérica. Porém, é importante usá-los com cuidado, pois podem causar efeitos colaterais indesejados em certas situações.*/
            #endregion

            #region Operadores de concatenação
            /*Os operadores de concatenação em C# são usados para juntar duas ou mais strings em uma única string. O operador de concatenação padrão é o sinal de mais (+). Por exemplo:*/
            string s1 = "Olá";
            string s2 = "mundo!";
            string s3 = s1 + " " + s2; // s3 agora contém "Olá mundo!"

            /*Além disso, o C# também oferece o operador de atribuição composta de concatenação (+=), que permite adicionar uma string a uma variável de string existente. Por exemplo:*/

            s1 = "Olá";
            s2 = "mundo!";
            s1 += " " + s2; // s1 agora contém "Olá mundo!"

            /*É importante lembrar que a concatenação de strings pode ser uma operação custosa em termos de desempenho, especialmente quando muitas strings são concatenadas em um loop. Nesses casos, é recomendável o uso da classe StringBuilder para construir a string de forma mais eficiente.*/

            #endregion

            #region Operadores de atribuição
            /*Em C#, operadores de atribuição são usados para atribuir um valor a uma variável. O operador de atribuição básico é o "=" (sinal de igual), que atribui o valor do lado direito à variável do lado esquerdo. Por exemplo:*/
            int x = 10; // atribui o valor 10 à variável x
            /*Outros operadores de atribuição combinam o operador de atribuição "=" com outro operador, realizando uma operação e atribuindo o resultado à variável. Por exemplo:*/
            x += 5; // adiciona 5 ao valor atual de x e atribui o resultado a x
            x *= 2; // multiplica o valor atual de x por 2 e atribui o resultado a x
            /*Alguns dos operadores de atribuição combinados mais comuns em C# são:

                += (adição e atribuição)
                -= (subtração e atribuição)
                *= (multiplicação e atribuição)
                /= (divisão e atribuição)
                %= (módulo e atribuição)*/
            #endregion

            #region Operadores de igualdade
            /*Os operadores de igualdade em C# são usados para comparar se dois valores são iguais ou diferentes. Existem dois operadores de igualdade: "==" e "!=".
                O operador "==" verifica se dois valores são iguais. Se forem iguais, ele retorna verdadeiro (true), caso contrário, retorna falso (false). Por exemplo:*/
            a = 5;
            b = 5;
            if (a == b) // retorna true
            {
                Console.WriteLine("Os valores de a e b são iguais.");
            }
            /*O operador "!=" verifica se dois valores são diferentes. Se forem diferentes, ele retorna verdadeiro (true), caso contrário, retorna falso (false). Por exemplo:*/
            a = 5;
            b = 10;
            if (a != b) // retorna true
            {
                Console.WriteLine("Os valores de a e b são diferentes.");
            }
            /*É importante lembrar que o operador "==" é diferente do operador de atribuição "=". O operador de atribuição é usado para atribuir um valor a uma variável, enquanto o operador "==" é usado para comparar valores.*/
            #endregion

            #region Operadores relacionais
            /*Os operadores relacionais em C# são usados para comparar valores e retornar um resultado booleano (verdadeiro ou falso). Os operadores relacionais disponíveis em C# são:

                == : verifica se dois valores são iguais;
                != : verifica se dois valores são diferentes;
                < : verifica se um valor é menor que outro;
                : verifica se um valor é maior que outro;

                <= : verifica se um valor é menor ou igual a outro;
                = : verifica se um valor é maior ou igual a outro.

                Esses operadores são frequentemente usados ​​em expressões condicionais, como em instruções if e loops while. Por exemplo, um if pode ser usado para verificar se uma variável é maior que outra:*/
            a = 10;
            b = 5;
            if (a > b)
            {
                Console.WriteLine("a é maior que b");
            }
            /*Este exemplo usa o operador > para comparar as variáveis a e b. Como a é maior que b, a mensagem "a é maior que b" será impressa na tela.*/
            #endregion

            #region Operadores logicos
            /*Os operadores lógicos são usados para comparar valores booleanos e retornar um resultado booleano. Em C#, existem três operadores lógicos principais: AND (&&), OR (||) e NOT (!).

                O operador AND retorna true apenas se as duas expressões booleanas que estão sendo comparadas forem verdadeiras. Caso contrário, retorna false.

                O operador OR retorna true se pelo menos uma das expressões booleanas que estão sendo comparadas for verdadeira. Se ambas as expressões forem falsas, retorna false.

                O operador NOT retorna o valor oposto da expressão booleana que está sendo comparada. Se a expressão for verdadeira, o NOT retorna false e se a expressão for falsa, o NOT retorna true.

                Esses operadores são muito úteis em expressões condicionais, onde é necessário avaliar várias condições e tomar decisões com base nelas.*/
            #endregion
        }
    }
}
