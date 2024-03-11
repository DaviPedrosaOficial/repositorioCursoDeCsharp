/* ------ Começando a resolver um segundo problema exemplo ------ */

using System;

namespace CursoDeCsharp
{
    class Aula4
    {
        static void _Aula4(string[] arg)
        {
            /* Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
             Em seguida:
            - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
            - Realizar uma entrada no estoque e mostrar novamente os dados do produto
            - Realizar uma saída no estoque e mostrar novamente os dados do produto   */

            List<Produto> estoque = new List<Produto>();

            Console.WriteLine("Bem vindo ao programa de estoque do atacadao XP");

            while (true)
            {
                Console.WriteLine("\r\nDigite 1 para adicionar um produto");
                Console.WriteLine("Digite 2 para conferir o total em estoque de algum produto");
                Console.WriteLine("Digite 3 para adicionar uma quantidade ao estoque de algum produto");
                Console.WriteLine("Digite 4 para remover uma quantidade ao estoque de algum produto");
                Console.WriteLine("Digite 5 para encerrar o programa\r\n");
                Console.Write("Insira a seguir o numero correspondente a ação que voce deseja: ");
                int controleEntrada = int.Parse(Console.ReadLine());

                if (controleEntrada == 1)
                {
                    Produto novoProduto = new Produto();
                    
                    Console.Write("\r\nInsira o nome do produto que voce deseja adicionar: ");
                    novoProduto.Nome = Console.ReadLine();

                    Console.Write("Agora, insira o preco do produto: ");
                    novoProduto.Preco = double.Parse(Console.ReadLine());

                    Console.Write("E por fim, insira a quantidade em estoque do produto: ");
                    novoProduto.Quantidade = int.Parse(Console.ReadLine());
                    
                    estoque.Add(novoProduto);
                }
                else if (controleEntrada == 2)
                {
                    Console.Write("\r\nInsira o nome do produto para que possamos verificar o total no sistema: ");
                    string nomeProd = Console.ReadLine();
                    
                    foreach (var produto in estoque)
                    {
                        if (produto.Nome == nomeProd)
                        {
                            Console.WriteLine("\r\nO produto {0} tem em estoque a quantidade de {1}, com o preco total R${2:F2} em estoque!",produto.Nome,produto.Quantidade,produto.ValorTotalEmEstoque());
                        }
                    }
                }
                else if (controleEntrada == 3)
                {
                    Console.Write("\r\nInsira o nome do produto no qual deseja adicionar uma quantidade ao seu estoque\r\n para que possamos encontrá-lo no sistema: ");
                    string nomeProd = Console.ReadLine();

                    foreach (var produto in estoque)
                    {
                        if (produto.Nome == nomeProd)
                        {
                            Console.Write("\r\n{0} encontrado(a), agora insira a quantidade que deseja adicionar ao estoque do mesmo: ",produto.Nome);
                            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Quantia adicionada!\r\n");
                        }
                    }
                }
                else if (controleEntrada == 4)
                {
                    Console.Write("\r\nInsira o nome do produto no qual deseja retirar uma quantidade de seu estoque\r\n para que possamos encontrá-lo no sistema: ");
                    string nomeProd = Console.ReadLine();
                    
                    foreach (var produto in estoque)
                    {
                        if (produto.Nome == nomeProd)
                        {
                            Console.Write("\r\n{0} encontrado(a), agora insira a quantidade que deseja adicionar ao estoque do mesmo: ",produto.Nome);
                            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Quantia retirada!\r\n");
                        }
                    }
                }
                else if (controleEntrada == 5)
                {
                    Console.WriteLine("\r\nO programa sera encerrado!");
                    break;
                }
                else
                {
                    Console.WriteLine("\r\nNumero invalido, tente novamente!");
                }
            }
        }
    }
}