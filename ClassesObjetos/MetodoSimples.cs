namespace ClassesObjetos
{
    public class MetodoSimples
    {
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int AnoNacimento { get; set; }

        //Método Simples
        public void Comprimentar()
        {
            Console.WriteLine($"Olá eu sou {Nome} {Sobrenome}");
        }
    }
}
