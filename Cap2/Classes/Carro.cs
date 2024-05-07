namespace CursoDeCsharp.Cap2.Classes
{
    public class Carro
    {
        public int Ano;
        public string Marca;
        public string Modelo;

        public override string ToString()
        {
            return "Carro da Marca: "
                + Marca
                + "\r\nModelo: "
                + Modelo
                + "\r\nAno: "
                + Ano;
        }
    }
}