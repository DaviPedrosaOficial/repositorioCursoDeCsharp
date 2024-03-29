/* ------ Matrizes ------ */

namespace CursoDeCsharp{

    class Aula10_Cap4{

        static void _Aula10_Cap4(string [] arg){

            /* ------ O que são matrizes para a programação? ------
            
            Para a programação, matrizer são arranjos bidimensionais, ou seja, elas possuem linhas e colunas!
            Isso faz com que, para acessarmos elementos é necessário sua localização na linha e na coluna.
            
            ------ Relembrando ------
            Arranjo é uma estrutura de elementos:
            - Homogênia: possui somente elementos do mesmo tipo
            - Ordenada: elementos são acessados a partir de suas coordenadas
            - É alocada de uma vez só: ao ser criada é alocada por completo em um espaço de mémoria
            
            Vantagens:
            - Acesso imediato a elementos a partir de sua posição
            
            Desvantagens:
            - Possui tamanho fixo (Ou seja, o tamanho que a mesma foi criada, será mantido até o encerramento da mesma)
            - Dificuldade de inserção e deleções
            
            ------- Como declarar uma matriz -------
            
            Para declararmos uma matriz, é necessário passarmos de qual tipo a mesma será, depois inserir [,] para que o com-
            pilador entenda que aquele vetor que esta sendo criado é bidimensional (matriz), e ao instanciarmos a mesma, é ne-
            cessário informar o tamanho que a mesma terá dentro dos [x,y].

            Veja a seguir como ficará o processo:                                                                           */

            double[,] matriz = new double[2,3];

            /* ------ Métodos importantes quando tratamos de matrizes ------
            
            --- Length ---
            O método Length é utilizado para descobrirmos quantos elementos existem na matriz, ou seja, o total de elementos.
            
            veja a seguir:                                                                                                 */

            Console.WriteLine(matriz.Length);

            /* --- Rank ---
            O método Rank é utilizado para descobrimos a primeira dimensão de uma matriz, ou seja, a quantidade de linhas da
            mesma.
            
            Veja a seguir:                                                                                                 */

            Console.WriteLine(matriz.Rank);

            /* --- GetLength ---
            O método GetLength é utilizado para descobrirmos as dimensões de nossas matrizes baseadas em suas dimensões, uti-
            lizando os índices para verificá-los.
            
            Veja a seguir:                                                                                                 */

            /* Descobrindo a linha */
            Console.WriteLine(matriz.GetLength(0));

            /* Descobrindo a coluna */
            Console.WriteLine(matriz.GetLength(1));
        }
    }
}