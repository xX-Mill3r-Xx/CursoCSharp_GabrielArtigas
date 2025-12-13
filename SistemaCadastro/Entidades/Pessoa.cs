using System;

namespace SistemaCadastro.Entidades
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropia { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }
    }
}
