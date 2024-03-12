/* ------ Estruturas condicionais (if-else ------ */

using System;

namespace CursoDeCsharp
{
    class Aula_9
    {
        static void _Aula9(string[] arg)
        {
            /* Estruturas condicionais, como o próprio nome diz, são estruturas que farão algo acontecer, a depender
             das condições predefinidas para ela.
             
             Existem 3 tipos de estruturas condicionais, são elas:
             - Simples 
             - Composta
             - Encadeamentos 
             
             Para facilitar o compreendimento, vamos vê-las na prática. */
            
            /* ------ Estrutura simples ------ */
            /* A estrutura simples remete a uma condicional única, ou seja, onde somente um parametro será utilizado como
             determinante para sua execução. 
             
              Além disso, é importante salientarmos como funciona a estrutura de uma condicional. 
              Para começarmos a entender, é preciso entender o comandos que as executam. No caso da estrutura simples, 
             quem fará esse papel será a chamada "if" do inglês "se", ou seja, "se" algo acontecer, executaremos suas
             especificações. 
              
              Veja a seguir sua estrutura:
              
              if (  condição ) {
                   comando 1
                   comando 2 
                }                        
                
                Agora, vamos vê-la na prática:     */

            int determinante = 10;

            if (determinante == 10)
            {
                Console.WriteLine("Estrutura simples executando comando, após a condicional ser verdadeira");
            }
            
            /* ------ Estrutura composta ------ */
            /* A estrutura composta é uma condição um pouco mais robusta do que a simples, uma vez que a mesma implementa
             a funcionalidade "else" do inglês "senão". Ou seja, se a operação "se", não se encaixa na condicional, o 
             comando programado na condicional else sera executado.
             
             Veja a seguir sua estrutura:
             
             if ( condição ) { 
                  comando 1
                  comando 2
                }
             else {
                  comando 1
                  comando 2
                }
                
                Agora, vamos vê-la na pratica:     */
            
            int determinante1 = 20;

            if (determinante1 == 10)
            {
                Console.WriteLine("Como a condição não é valida, essa linha não será executada");
            }
            else
            {
                Console.WriteLine("\r\nEstrutura composta 'else' executando a linha, apos verificar que a condicional 'se'\r\nnão se encaixa a condicao apresentada.");
            }
            
            
            /* ------ Estrutura de encadeamento ------ */
            /* A estrutura de encadeamento é a estrutura mais robusta entre todas as apresentadas, uma vez que a mesma
             adere a função "else if" do inglês "senão se", ou seja, a mesma é uma adição de parametro as condicionais 
             "se" de seu código. Para sintetizar e ficar mais fácil a compreensão, seria como se dissésemos que caso
             a condição "se" não se encaixa-se, deveriamos testar a condição "senão se" para que pudessemos executar outra
             função, baseada na condição da função "senão se", antes de enviarmos a condicional "else". 
             
             Veja a seguir sua estrutura: 
             
             if ( condição ) { 
                  comando 1
                  comando 2
                }
             else if ( condição ) {
                        comando 1
                        comando 2
                }
             else if ( condição ) {
                        comando 1
                        comando 2
                }   
             else {
                  comando 1
                  comando 2
                }
                
                * Podemos ter inúmeros else if!
             
             Agora, vamos vê-la na prática:     */

            int determinante2 = 30;

            if (determinante2 == 10)
            {
                Console.WriteLine("Mais uma vez, a condicional 'if' não sera executada, pois sua condicional não e valida");
            }
            else if (determinante2 % 2 == 0)
            {
                Console.WriteLine("\r\nEstrutura de encadeamento 'else if' executando a linha, apos verificar a validade de sua condicional!");
            }
            else
            {
                Console.WriteLine("Nesse caso, como a condicao de encadeamento foi constada, o 'else' tambem nao sera executado");
            }


        }
    }
}