using System;

namespace Encapsulamento
{
    public class Conta
    {
        #region Properties

        private string Cliente { get; set; }
        private double Saldo { get; set; }
        private double TaxaSaque { get; set; } = 10;

        #endregion

        private void LogarCliente(string cliente)
        {
            Cliente = cliente;
            Console.WriteLine($"Cliente logado: {cliente}");
        }

        private void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Valor Depositado: R${valor:F2}");
            Console.WriteLine($"Saldo atual: R${Saldo:F2}");
            Console.WriteLine();
        }

        private void Sacar(double valor)
        {
            double valorTotal = valor + TaxaSaque;
            Saldo -= valorTotal;
            Console.WriteLine($"Valor Sacado: R${valor:F2}");
            Console.WriteLine($"Taxa de saque: {TaxaSaque:F2}");
            Console.WriteLine($"Total debitado: R${valorTotal:F2}");
            Console.WriteLine($"Saldo atual: R${Saldo:F2}");
            Console.WriteLine();
        }

        public string Operacoes()
        {
            Console.Write("Entre com o nome do cliente: ");
            string cliente = Console.ReadLine();
            LogarCliente(cliente);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            Depositar(valorDeposito);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            Sacar(valorSaque);
            Console.WriteLine();

            return $"{cliente}, Saldo após depósito de {valorDeposito} e saque de {valorSaque}: {Saldo}";
        }
    }
}
