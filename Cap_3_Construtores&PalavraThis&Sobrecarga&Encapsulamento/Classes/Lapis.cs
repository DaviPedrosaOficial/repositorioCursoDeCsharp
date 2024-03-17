/* ------ Classe referente a aula 6 do Cap. 3 ------ */

using System.Text.Json;

namespace CursoDeCsharp;
public class Lapis
{
    private string _cor;
    private string _marca;

    public Lapis(string cor, string marca)
    {
        _cor = cor;
        _marca = marca;
    }

    /* ------ Implementação das propriedades ------ */
    public string Cor
    {
        get { return _cor; }
        set {
            if (value != null && value.Length > 1)
            {
                _cor = value;
            }}
    }
    /* Repare que não foi preciso criar as funções a mão, utilizamos a síntaxe par executar os métodos */

    public string marca
    {
        get { return _marca; }
        set {
            if (value != null && value.Length > 1)
            {
                _marca = value;
            }}
    }
}

