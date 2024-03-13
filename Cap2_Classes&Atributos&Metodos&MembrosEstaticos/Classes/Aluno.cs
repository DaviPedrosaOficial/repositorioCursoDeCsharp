namespace CursoDeCsharp;

public class Aluno
{
    public double PrimeiroSemestre;
    public double SegundoSemestre;
    public double TerceiroSemestre;

    public double NotaFinal()
    {
        return PrimeiroSemestre + SegundoSemestre + TerceiroSemestre;
    }

    public override string ToString()
    {
        if (NotaFinal() >= 60)
        {
            return "Nota final: " + NotaFinal().ToString("F2") + "\r\nAprovado";
        }
        else
        {
            return "Nota final: " + NotaFinal().ToString("F2") + "\r\nReprovado \r\nFaltaram: " +
                   (60.0 - NotaFinal()).ToString("F2");
        }
    }
}