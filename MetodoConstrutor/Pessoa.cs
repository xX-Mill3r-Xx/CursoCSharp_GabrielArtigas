namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int AnoNacimento { get; set; }
        public int Idade { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome, int ano, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            AnoNacimento = ano;
            Idade = CalcularIdade();
        }

        #region Sobrecarga de construtor
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
        #endregion

        private int CalcularIdade()
        {
            return 2025 - AnoNacimento;
        }

    }
}
