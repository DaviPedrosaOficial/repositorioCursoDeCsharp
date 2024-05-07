namespace CursoDeCsharp.Cap2.Classes
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Area = "
                + Area().ToString("F2")
                + "\r\nPerimetro = "
                + Perimetro().ToString("F2")
                + "\r\nDiagonal = "
                + Diagonal().ToString("F2");
        }
    }
}