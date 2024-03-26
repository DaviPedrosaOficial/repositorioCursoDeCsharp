/* ------ List (listas) ------ */
using System.Collections.Generic;

namespace CursoDeCsharp{

    class Aula9_Cap4{

        static void _Aula9_Cap4(string [] arg){

            /* ------ O que são as listas? ------
            
            Listas são na prática uma estrutura de dados:
            
            - Homogênia: é compostas por dados do mesmo tipo
            - Ordenada: seus elementos podem ser acessados através de sua posição na mesma
            - Iniciada vazia: seu elementos são armazenados sob demanda (diferente dos vetores, no qual já temos de de-
            finir o tamanho do mesmo em sua instanciação)
            - Seus elementos ocupam um nó: isso se deve a maneira como as listas funcionam, para ser mais preciso, os
            elementos de uma lista tem uma maneira única de serem armazenados. Quando são inseridos na lista, temos um
            espaço reservados aos mesmos como uma espécie de "caixinha" que conterá seu atributos, e ao lado terá uma
            outra caixinha, que armazenará a referência (coordenada) do próximo elemento da lista. Isso nos demonstra
            como a maneira de percorrer os elementos em uma lista pode ser diferente de um vetor, por exemplo.*/
        
            /* Para que possamos criar uma lista em C#, devemos usar a classe List, e para isso precisaremos chamar no
            ínicio de nosso código a biblioteca: System.Collections.Generic.
            
            Então vamos ver a nomenclatura de uma lista: */

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

            foreach (string nome in listaDeNomes){
                Console.WriteLine(nome);
            }

            /* Utilizando Insert (index , elemento) */
            listaDeNomes.Insert(0,"Paulo");
            listaDeNomes.Insert(2, "Flavia");

            foreach (string nome in listaDeNomes){
                Console.WriteLine(nome);
            }
            /* Repare que após a utilização do insert, os nomes Paulo e Flavia foram alocados em nossa lista na coordenada
            indicada na chamada do insert (Paulo = 0, Flavia = 2)
            
            ------ Achando o tamanho de uma lista ------
            Para que possamos descobrir o tamanho de uma lista utilizamos a chamada Count, onde a mesma funcionará de forma
            similar a chamada Length, retornando para nos, o tamanho da mesma
            
            Veja a seguir sua execução:                                                                                  */
            
            Console.WriteLine(listaDeNomes.Count);
        }
    }
}