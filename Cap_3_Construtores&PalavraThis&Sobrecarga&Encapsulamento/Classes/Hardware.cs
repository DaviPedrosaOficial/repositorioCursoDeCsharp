namespace CursoDeCsharp;

public class Hardware
{
    /* Definindo que os atributos só poderão ser alterados manualmente na classe, através do pré-fixo "private" */
    /* A nomenclatura para atributos privados em C# é feita com letra minúscula e um "_" de prefixo, assim como
     representado abaixo: */
    private string _tipo;
    private string _modelo;
    private string _marca;
    private double _preco;

    /* Construtores */
    public Hardware()
    {
        _preco = 0.0;
    }

    public Hardware(string tipo, string modelo) : this()
    {
        _tipo = tipo;
        _modelo = modelo;
    }

    public Hardware(string tipo, string modelo, string marca) : this(tipo, modelo)
    {
        _marca = marca;
    }
}