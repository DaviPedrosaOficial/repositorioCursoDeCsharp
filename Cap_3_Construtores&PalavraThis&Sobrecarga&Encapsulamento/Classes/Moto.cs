namespace CursoDeCsharp;

public class Moto
{
    public string Modelo;
    public string Marca;
    public int Ano;

    /* Construtor da classe */
    public Moto(string modelo, string marca, int ano)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"Dados da moto: \r\nModelo: {Modelo} \r\nMarca: {Marca} \r\nAno: {Ano}";
    }
}