namespace Modificadores
{
    public class Teste
    {
        private string nome;
        private string sobrenome;

        private void Metodo1()
        {

        }

        public void Executar()
        {

        }
    }

    public class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    public class Homem : Humano
    {
        public string RetornaNome()
        {
            nome = "Carlos";
            // sobrenome = "Silva"; // Erro de compilação: 'Humano.sobrenome' é inacessível devido ao seu nível de proteção
            return nome;
        }

        public int RetornaIdade()
        {
            idade = 30;
            return idade;
        }
    }
}
