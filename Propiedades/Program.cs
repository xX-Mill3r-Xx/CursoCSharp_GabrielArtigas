namespace Propiedades
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();
            teste.Nome = "João";
            teste.Sobrenome = "Silva";
            teste.Idade = 30;
            teste.Apresentar();
        }
    }
}
