namespace CursoDeCsharp;

public class CalculadoraEstatica
{
    /* Note que basta colocarmos o prefixo static, que convertemos a classe para uma classe estática */
    public static double Pi = 3.14;
    
    public static double Circunferencia(double r)
    {
        return 2.0 * Pi * r;
    }
    
    public static double Volume(double r)
    {
        return 4.0 / 3.0 * Pi * r * r * r;
    }
}