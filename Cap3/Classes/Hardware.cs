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

    public Hardware(string tipo, string modelo, string marca, double preco) : this(tipo, modelo, marca)
    {
        _preco = preco;
    }
    
    /* Agora, criaremos as funções que permitirão alterar os atributos de nosso objetos. Sendo Get() para retornar o valor
     do atributo, e Set() para alterarmos seus valores */

    public string GetTipo()
    {
        return _tipo;
    }
    
    /* Outra vantagem de se utilizar os mêtodos para receber mudanças nos atributos, é que podemos definir condicionais
     para que o mesmo ocorra somente dentro dos parâmetros desejados, como foi feito em nossos atributos */
    public void SetTipo(string tipo)
    {
        if (tipo != null && tipo.Length > 1)
        {
            _tipo = tipo;
        }
    }

    public string GetModelo()
    {
        return _modelo;
    }

    public void SetModelo(string modelo)
    {
        if (modelo != null && modelo.Length > 1)
        {
            _modelo = modelo;
        }
    }

    public string GetMarca()
    {
        return _marca;
    }

    public void SetMarca(string marca)
    {
        if (marca != null && marca.Length > 1)
        {
            _marca = marca;
        }
    }

    public double GetPreco()
    {
        return _preco;
    }

    public void SetPreco(double preco)
    {
        if (preco != null && preco > 0)
        {
            _preco = preco;
        }
    }

    public override string ToString()
    {
        return
            $"------ DADOS DO HARDWARE ------ \r\nTIPO: {_tipo} \r\nMODELO: {_modelo} \r\nMARCA: {_marca} \r\nPREÇO: R${_preco:F2}";
    }
}