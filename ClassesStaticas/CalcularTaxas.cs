namespace ClassesStaticas
{
    public static class CalcularTaxas
    {
        public static decimal Taxa { get; set; }

        public static decimal Acrescimo(decimal valor)
        {
            return valor + Taxa;
        }

        public static decimal Desconto(decimal valor)
        {
            return valor - Taxa;
        }
    }
}
