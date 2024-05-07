namespace CursoDeCsharp.Cap2.Classes
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            this.Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            this.Quantidade -= qtd;
        }
    }
}