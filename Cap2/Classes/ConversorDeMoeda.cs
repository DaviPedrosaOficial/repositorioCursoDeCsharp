namespace CursoDeCsharp.Cap2.Classes
{
    public class ConversorDeMoeda
    {
        public static double IOF = 0.06; /* Imposto IOF 6% */

        public static double Conversao(double Dolar, double quantiaReais)
        {
            double valorSemImposto = quantiaReais * Dolar;
            return valorSemImposto + valorSemImposto * IOF;
        }
    }
}

