/* ------ Praticando a utilização de matrizes ------ */

namespace CursoDeCsharp.Cap4.Aulas
{

    class Aula11_Cap4{

        static void _Aula11_Cap4(string [] arg){

            /* Fazer um programa para ler um número inteiro N e uma matriz de ordem N (quadrada) contendo números inteiros.
             Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz */

            Console.Write("Insira a seguir a tamanho de sua matriz quadrada: ");
            int tam = int.Parse(Console.ReadLine());

            int [,] matriz = new int[tam,tam];

            /* Para que possamos percorrer uma matriz é necessário fazermos 2 loops for.
            Isso ocorre devido a bidimensionalidade da mesma, ou seja, para que possamos percorrer uma linha de uma matriz,
            e podermos inserir os elementos de cada coluna, a linha precisa se manter a mesma, para que o processo ocorra.
            
            Como já vimos o conceito do loop for, após sua inicialização, o mesmo só permitirá que o programa continue após
            seu desfecho. Sendo assim, ao criarmos um loop dentro de outro, poderemos percorrer as colunas de uma linha sem
            que a linha mude.
            
            Veja a seguir:                                                                                                */

            /* Loop para as linhas */
            for (int i = 0; i < tam; i++){
               Console.Write("Insira os elementos da {0}ª linha de sua matriz (na mesma linha, separados por espaço): ", i + 1);

               string[] valores = Console.ReadLine().Split(' ');

               /* Loop das colunas */
               for(int j = 0; j < tam; j++){

                   matriz[i,j] = int.Parse(valores[j]);
                }
            }

            /* Agora precisamos pegar a diagonal principal de nosso vetor. Para isso, é importante ressaltar que, a diagonal prin-
            cipal tem o mesmo index para linhas e colunas, ou seja, o primeiro elemento da nossa diagonal estará localizado na
            linha 0 e na coluna 0, o segundo na linha 1 e na coluna 1, o terceiro na linha 2 e coluna 2, ...

            Tendo isso em mente, vamos encontra o de nosso programa:                                                            */

            Console.Write("Diagonal principal: ");

            for (int i = 0; i < tam; i++){
                Console.Write(matriz[i,i] + " ");
            }

            /* E por ultimo, é necessário que encontremos os numeros negativos de nossa matriz, e para isso teremos que mais uma vez
            percorre a matriz ao todo, através de 2 loops for, veja a seguir:                                                     */

            int contagemDeNegativos = 0;
            
            for (int i = 0; i < tam; i++){
                for (int j = 0; j < tam; j++){
                    if(matriz[i,j] < 0){
                        contagemDeNegativos++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade de negativos: {0}", contagemDeNegativos);
        }
    }
}