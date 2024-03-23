using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
              Produto3 x;

            Console.Write("Insira a seguir a quantidade produtos que voce deseja inserir ao estoque: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            Produto3[] estoque = new Produto3[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++){
                Console.Write("Insira a seguir o nome do {0}º produto: ", i + 1);
                string nome = Console.ReadLine();
                Console.Write("Agora, insira o preco do {0}º produto: ", i + 1);
                double preco = double.Parse(Console.ReadLine());

                x = new Produto3 (nome,preco);
                estoque[i] = x;
            }

            double media = 0.0;

            for (int i = 0; i < qtdProdutos; i++){
                media += estoque[i].Preco;
            }

            double calcMedia = media / qtdProdutos;

            Console.WriteLine("\r\nMEDIA DE PRECO: R${0:F2}",calcMedia);
        }
    }
}


