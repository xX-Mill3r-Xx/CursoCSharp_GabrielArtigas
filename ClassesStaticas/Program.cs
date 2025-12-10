using System;

namespace ClassesStaticas
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Classes Staticas
            CalcularTaxas.Taxa = 0.02M;
            Console.WriteLine($"O valor do acrescimo é: {CalcularTaxas.Acrescimo(2.00M)}");
            Console.WriteLine($"O valor do desconto é: {CalcularTaxas.Desconto(1.00M)}");
            #endregion

            #region Membros Staticos
            PessoaAtributos.MaiorIdade = 21;

            PessoaAtributos pessoa = new PessoaAtributos();
            pessoa.Nome = "Miller";
            pessoa.Idade = PessoaAtributos.CalcularIdade(1988);

            Console.WriteLine($"Olá, eu sou {pessoa.Nome} e tenho {pessoa.Idade} anos");
            #endregion

            Console.ReadKey();
        }
    }
}
