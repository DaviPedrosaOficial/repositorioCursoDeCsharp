/* Classe referente a aula 2 do 3º capítulo */

namespace CursoDeCsharp
{
    public class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /* Construtor customizado, que permitirá que o objeto seja instanciado com todos seus atributos */
        public Produto2(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        
        /* Construtor customizado, que permitirá que o objeto seja instanciado com apenas 2 atributos (nome e preço)  */
        public Produto2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        
        /* Construtor padrão, ou seja, permitirá que o objeto seja criado sem ter de referênciar seus atributos */
        public Produto2()
        {
        }

        public override string ToString()
        {
            return
                $"DADOS DO PRODUTO: \r\n\r\nNOME DO PRODUTO: {Nome} \r\nPRECO: R${Preco:F2} \r\nQUANTIDADE EM ESTOQUE: {Quantidade}";
        }
    }
}