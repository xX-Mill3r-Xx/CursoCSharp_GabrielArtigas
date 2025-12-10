using System;

namespace MetodosDasClasses
{
    public class Metodos
    {
        #region Propiedades

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int AnoNascimento { get; set; }

        #endregion

        #region metodo simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá seja bem vindo");
        }
        #endregion

        #region metodo com parametro
        public void Somar(int n1, int n2)
        {
            int resultado = n1 + n2;
            Console.WriteLine($"A soma é {resultado}");
        }
        #endregion

        #region metodo com retorno do tipo string
        public string DefinirNome()
        {
            Console.Write("Defina o nome do personagem: ");
            Nome = Console.ReadLine();
            return Nome;
        }

        public string MontaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome; ;
        }
        #endregion

        #region outros métodos
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é: {nome} e tenho {idade} anos");
        }
        #endregion

        #region exercicios - Criar métodos com retorno de cada tipo a fim de treinar e desenvolver a criação.

        #endregion

        #region Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por valor: {valor}");
        }
        #endregion

        #region Passagem de parametros por referencia
        public void AumentarValorRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"Valor final por referencia: {valor}");
        }
        #endregion

        #region Métodos com retorno
        public int CodigoChar(char caractere)
        {
            return caractere;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
        #endregion

        #region Sobrecarga de métodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Olá, meu nome é: {nome}");
        }
        #endregion
    }
}
