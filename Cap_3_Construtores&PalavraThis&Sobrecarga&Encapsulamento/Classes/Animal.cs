/* ----- Classe referente a aula 7 do Cap.3 ------ */

namespace CursoDeCsharp;

public class Animal
{
    /* Abaixo, utilizamos a auto-properties e definimos ao mesmo tempo o atributp "Especie e definimos ao deixarmos
     apenas as chamadas get & set, que os mesmos serão publicos */
    public string Especie { get; set; }
   
    /* Já com o atributo "Idade", definimos que apenas o método get poderá ser utilizado por outros arquivos, tornando
     a sua mutação a partir de outro arquivo impossível, a são ser que seja criada uma função em nossa classe que a permita
     alterá-lo*/
    public int Idade { get; private set; }
    
    /* E como teremos uma condicional para o set de nosso atributo "_nome" utilizamos sua propertie para executá-lo */
    private string _nome;

    /* Construtor contendo as auto-properties e propertie */
    public Animal(string especie, int idade, string nome)
    {
        Especie = especie;
        Idade = idade;
        _nome = nome;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }
}