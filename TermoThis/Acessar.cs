namespace TermoThis
{
    public class Acessar
    {
        public string senha { get; set; } = "abc123";
        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
