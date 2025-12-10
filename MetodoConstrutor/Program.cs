using System;

namespace MetodoConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Miller","Martins",1988,37);

            Console.WriteLine($"Pessoa: {pessoa.Nome} {pessoa.Sobrenome}, ano nacimento: {pessoa.AnoNacimento}, idade: {pessoa.Idade}");
            Console.ReadKey();

            #region Pessoa Desconhecida usando a sobrecarga 1
            pessoa.Nome = "Desconhecido";
            pessoa.Sobrenome = "Desconhecido";
            pessoa.Idade = 00;

            pessoa = new Pessoa(pessoa.Nome, pessoa.Sobrenome, pessoa.Idade);
            Console.WriteLine($"Pessoa: {pessoa.Nome} {pessoa.Sobrenome}, idade: {pessoa.Idade}");
            #endregion
            Console.ReadKey();
        }
    }
}
