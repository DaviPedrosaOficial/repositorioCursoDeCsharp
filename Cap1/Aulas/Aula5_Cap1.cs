/* ------ Entrada de dados (Parte 1) ------ */

using System;

namespace CursoDeCsharp{
    
        class Aula5_Cap1
        {
                static void _Aula5(string[] arg)
                {
                        /* O comando utilizado para entrada de dados no C# é o 'Console.ReadLine()', o mesmo
                         serve para receber uma entrada em 'string' enviada pelo usuário, onde a mesma poderá 
                         ser armazenada como variável.*/
                        
                        /* Vale salientar que a entrada serve apenas para 'string', quando precisarmos de uma entrada
                         para um 'int' por exemplo, utilizaremos outra chave de entrada.*/

                        Console.WriteLine("Observando como pode ser utilizada a entrada.");
                        Console.WriteLine("\r\nInsira a seguir o seu nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Olá {0}",nome);
                        
                        /* O comando Console.Readline, fara a leitura daquilo que for inserido no terminal, até que
                         seja apresentado uma quebra de linha, ou seja, até que o cliente aperte a tecla 'Enter'.*/
                        
                        /* Existe outra maneira de inserirmos entradas diferentes em apenas uma linha, onde após o
                         'espaço' será contabilizado uma nova entrada. Porém, para que isso aconteça precisamos 
                         entender como o processo ocorre, já que o mesmo não é a maneira nativa de se obter uma 
                         entrada. */
                        
                        /* Então, para obter tão entrada precisamos utilizar os vetores e um comando chamado 'split',
                         no qual fará a separação de uma entrada para a outra, a partir do parâmetro escolhido pelo dev. 
                         
                         Abstraindo o conceito, o vetor será utilizado para armazenar mais de uma entrada, já que o
                         mesmo tem tal capacidade de armazenamento, e ainda como padrão tem um conceito de localização 
                         nos auxiliando a encontrar cada uma das tais entradas. 
                         E quem fará a separação das variáveis dentro dessa linha sera o comando 'split' que nos 
                         permite como o próprio nome diz, separar o que nesse nosso caso será as variáveis, baseadas
                         no parâmetro que o apresentaremos como separador, nesse caso o espaço(' ').
                         Vamos ver como funciona a seguir:  */

                        /* Primeiro recebemos a entrada em uma variável separada (ent) */
                        Console.WriteLine("\r\nInsira a seguir 3 frutas (na mesma linha): ");
                        string ent = Console.ReadLine();
                        
                        /* Depois criamos um vetor(utilizamos '[]' para defini-lo) baseado na entrada (ent),
                         separando seus parâmetros com base no split, que fará tal separação quando encontrar 
                         espaços ' ' */
                        string[] vetor = ent.Split(' ');
                        
                        /* Agora criamos variáveis para armazenar as entrada armazenadas nos respectivos vetores */
                        string fruta_1 = vetor[0];
                        string fruta_2 = vetor[1];
                        string fruta_3 = vetor[2];
                        
                        /* E pronto, agora basta criar a saída */
                        Console.WriteLine("\r\nAs frutas escolhida foram: \r\n{0}\r\n{1}\r\n{2}",fruta_1,fruta_2,fruta_3);
                        
                        /* Para simplificarmos ainda mais, podemos deixar de lado a primeira variável, para isso
                         basta inserirmos o ReadLine() em sua entrada*/

                        Console.WriteLine("\r\nAgora insira 3 de seus carros preferidos (também na mesma linha):");
                        string[] vetor_2 = Console.ReadLine().Split(' ');

                        string carro_1 = vetor_2[0];
                        string carro_2 = vetor_2[1];
                        string carro_3 = vetor_2[2];

                        Console.WriteLine("\r\n{0}, ficamos felizes de saber que seus carros favoritos são: \r\n- {1}\r\n- {2}\r\n- {3}",nome,carro_1,carro_2,carro_3);
                    
                }
        }
}