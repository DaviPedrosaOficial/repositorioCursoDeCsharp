/* ------ Entrada de dados ------ */

using System;

namespace CursoDeCsharp{
    
        class Aula_5
        {
                static void Main(string[] arg)
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

                        /* Recebendo a entrada: */
                        Console.WriteLine("\r\nInsira a seguir 3 frutas: ");
                        string ent = Console.ReadLine();
                        

                }
        }
}