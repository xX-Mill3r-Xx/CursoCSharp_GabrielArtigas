using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        /* Este App de calculadora foi desenvolvido por mim*/

        static void Main(string[] args)
        {
        Inicio:
            Console.Write("Digite o primeiro numero ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a opreração: ( + - X / ): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção invalida");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é " + resultado);
                    break;
                case '/':

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0");


                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é " + resultado);
                    }
                    break;
            }
            Console.Write("Continuar na Aplicção (s / n)? ");
            string opcao = Console.ReadLine();
            if (opcao == "s")
            {
                goto Inicio;
            }
            Console.ReadKey();
        }
    }
}
