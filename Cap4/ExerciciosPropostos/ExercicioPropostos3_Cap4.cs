/* ------ Exercício proposto 3 do Cap 4 ------ */

namespace CursoDeCsharp.Cap4.ExercicioPropostos
{

    class ExercicioPropostos3_Cap4{

        static void Ex_Propostos3_Cap4(string [] arg){

            /* Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por
            N colunas contendo números inteiros, podendo haver repetições.
            Em seguida, ler um número inteiro X que pertence à matriz.
            Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver. */

            Console.Write("Insira a seguir o tamanho de sua matriz (linhas e colunas separados por espaco): ");
            string[] recebeTam = Console.ReadLine().Split(' ');

            int linha = int.Parse(recebeTam[0]);
            int coluna = int.Parse(recebeTam[1]);

            int[,] matriz = new int[linha,coluna];

            for(int i = 0; i < linha; i++){
                Console.WriteLine();
                Console.WriteLine("Insira os elementos da {0}ª linha de sua matriz (separando os elementos por espaco):", i + 1);

                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++){
                    matriz[i,j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Agora, insira um numero presente em sua matriz para que possamos demonstrar os elementos que estao\r\nacima, a esquerda e a direita do mesmo: ");
            int elementoEscolhido = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++){

                for (int j = 0; j < coluna; j++){

                    if(matriz[i,j] == elementoEscolhido){

                        Console.WriteLine("Elemento {0} encontrado na posicao [{1},{2}]", elementoEscolhido, i, j);

                        if(matriz.GetLength(0) == 1 && matriz.GetLength(1) == 1){
                            Console.WriteLine("A matriz possue apenas 1 elmento, portanto nao tera numeros em outras posicoes!");
                        }
                        else if (i == 0){
                            if(j == 0){
                                Console.WriteLine("Elemento a direita: {0}", matriz[i , j + 1]);
                            }
                            else if (j == matriz.GetLength(1) - 1){
                                Console.WriteLine("Elemento a sua esquerda: {0}", matriz[i , j - 1]);
                            }
                            else{
                                Console.WriteLine("Elemento a sua esquerda: {0}", matriz[i , j - 1]);
                                Console.WriteLine("Elemento a sua direita: {0}", matriz[i , j + 1]);
                            }
                        }
                        else {
                            if (j == 0){
                                Console.WriteLine("Elemento acima: {0}", matriz[i - 1, j]);
                                Console.WriteLine("Elemento a sua direita: {0}", matriz[i , j + 1]);
                            }
                            else if (j == matriz.GetLength(1) - 1){
                                Console.WriteLine("Elemento acima: {0}", matriz[i - 1, j]);
                                Console.WriteLine("Elemento a sua esquerda: {0}", matriz[i , j - 1]);
                            }
                            else{
                                Console.WriteLine("Elemento acima: {0}", matriz[i - 1, j]);
                                Console.WriteLine("Elemento a sua esquerda: {0}", matriz[i , j - 1]);
                                Console.WriteLine("Elemento a sua direita: {0}", matriz[i , j + 1]);
                            }
                        }
                    }
                }
            }
        }
    }
}