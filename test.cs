using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

           List<string> listaDeNomes;
            /* Note que para criarmos uma lista é necessário colocar entre os sinais <>, o tipo da mesma.
            Outro fator importante é que não precisamos instanciar a mesma em sua criação, mas caso seja de nosso desejo
            poderemos fazer o mesmo!
            Veja o exemplo abaixo:                                                                                    */

            List<string> listaDeObjetos = new List<string>();
            listaDeNomes = new List<string>();
            
            /* ------ Vantagens: -------
            - Tamanho variável: o tamanho de uma lista não é estático como de um vetor, o mesmo pode ser alterado durante
            o desenvolvimento baseado na necessidade do dev
            - Facilidade de inserções e deleções: diferentemente dos vetores, ao utilizarmos listas, temos facilidade ao
            inserir e retirar elementos da mesma, e sem deixar um espaço vázio em nossa lista quando retirarmos elementos.
            
            ------ Desvantagens: ------
            - Acesso sequencial aos elementos: para que possamos acessar elementos de uma lista, precisamos percorre-lá se-
            quencialmente, ou seja, imagine que temos uma lista de 1000 elementos, para acessarmos o elemento 900, teremos 
            de percorrer 899 elementos para chegar no desejado, o que gasta processamento. 
            Porém, vale ressaltar que existem maneiras otimizadas de utilizarmos as listas, onde podemos inclusive otimizar 
            esse processo de acesso sequencial, deixando-o parecido ao de um vetor
            
            ------- Inserindo elementos a lista ------
            Existem duas maneiras de inserirmos elementos em uma lista, a primeira é através do Add, que irá inserir o ele-
            mento no final de nossa lista, e a segunda é através do Insert, no qual permitirá que um elemento seja inserido
            na posição em que desejarmos. 
            
            Vamos ver abaixo a execução de ambos:                                                                        */

            /* Utilizando Add */
            listaDeNomes.Add("Maria");
            listaDeNomes.Add("João");
            listaDeNomes.Add("Pedro");
            listaDeNomes.Add("Davi");

            Console.WriteLine("------- Lista de nomes utilizando Add ------- ");

            foreach (string nome in listaDeNomes){
                Console.WriteLine(nome);
            }

            /* Utilizando Insert (index , elemento) */
            listaDeNomes.Insert(0,"Paulo");
            listaDeNomes.Insert(2, "Flavia");

            Console.WriteLine();
            Console.WriteLine("------- Lista de nomes utilizando Insert ------- ");

            foreach (string nome in listaDeNomes){
                Console.WriteLine(nome);
            }
            /* Repare que após a utilização do insert, os nomes Paulo e Flavia foram alocados em nossa lista na coordenada
            indicada na chamada do insert (Paulo = 0, Flavia = 2)
            
            ------ Achando o tamanho de uma lista ------
            Para que possamos descobrir o tamanho de uma lista utilizamos a chamada Count, onde a mesma funcionará de forma
            similar a chamada Length, retornando para nos, o tamanho da mesma
            
            Veja a seguir sua execução:                                                                                  */

            Console.WriteLine();
            Console.WriteLine("Tamanho da lista (utilizando o .Count): " + listaDeNomes.Count);

            /* ------ Encontrar o primeiro e o ultimo elemento de uma lista que satisfaça um predicado ------
            Ao utilizarmos a lista, podemos utilizar algumas chamadas para que possamos encontrar elementos que satisfação
            determinada condição. Essas chamadas são o Find (encontra o primeiro elemento que satisfaz nossa condição) e
            FindLast (encontra o ultimo elemento que satisfaz nossa condição).
            
            É importante explicarmos o que seria tal predicado, já que esse é necessário executar nossa chamada. A ideia de
            predicado esta ligada a um conceito que veremos mais a frente no curso, a de conceito de lambda, que se trata de
            uma função gênerica que podemos criar sem a necessidade de criarmos uma função em nosso código. Porém, como ainda
            não chegamos a tal parte de nosso curso, vamos entender esse predicado com uma função que tenhamos criado.
            
            Sendo assim, conseguimos entender que para que as chamada sejam executadas, precisaremos de uma função que demons-
            tre ao nosso compilador, qual o primeiro ou o ultimo elemento que desejamos encontrar baseado no parâmetro de nossa
            função.
            
            Veja abaixo a execução (Ps.: Foi criada uma função no final do código para que pudessemos utilizar a chamada):  */

            /* Veja que baseado na função feita no final do programa, conseguimos utilizar o mesmo como parâmetro para nossas
            chamadas Find & FindLast */

            Console.WriteLine();
            Console.WriteLine("------- Utilizando o Find & FindLast -------");
            Console.WriteLine();
            
            string primeiroNomeComP = listaDeNomes.Find(comecaEmP);
            Console.WriteLine("Primeiro nome que começa com 'P': " + primeiroNomeComP);

            string ultimoNomeComP = listaDeNomes.FindLast(comecaEmP);
            Console.WriteLine("Ultimo nome que começa com 'P': " + ultimoNomeComP);

            /* Além disso, podemos notar também a nomenclatura utilizada para a chamada:

            nomeDoConjunto.Find(parâmetro)
            nomeDoConjunto.FindLast(parâmetro)
            
            Porém, existe outra maneira de executarmos a mesma chamada sem termos de desenvolver uma função. Para isso, utiliza-
            mos funções lambdas, veja a seguir a implementação da mesma:                                                      */

        }
         public static bool comecaEmP (string nome){
            return nome[0] == 'P';
        }
    }
}


