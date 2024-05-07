/* ------ Conversão implícita e casting ------ */

using System;

namespace CursoDeCsharp.Cap1.Aulas
{
    class Aula3_Cap1
    {
        static void _3Aula(string[] arg)
        {
            /* ------ Conversão implícita entre tipos ------ */
            
            /* A conversão é o processo onde um conteúdo de um certo tipo, como por exemplo 'int',
             é aderido a uma variável de outro tipo, como 'float' por exemplo. 
             
              O processo é permitido sem problemas pela linguagem, uma vez que o número inteiro é 
              compatível com um float, ou seja, a padronização em bits de um int, permite sem problemas
              a conversão para float. Veja no exemplo abaixo: */

            int a = 10;
            float b = a;
            Console.WriteLine("Demonstração da conversão implícita");
            Console.WriteLine(b);
            
            /* Já se tentarmos fazer a atribuição de um double em um float, o código não aceitará a conversão
             implícita, uma vez que o double é constituido por 8 bits e um float por 4 bits, podendo assim perder-se 
             informação durante a conversão. Se tornando assim, impróprio para a conversão. 
              Outro problema que poderiamos ter, se daria ao tentarmos passar um double para um inteiro, que como sabemos
              não aceita números que apresentam dizimas, tornando-se imprópria a conversão. */
            
            /* Como a intenção desse projeto é executar os comandos e averiguar suas funcionalidades, não estarei
             colocando o exemplo como execução, mas basta testar a conversão a seguir em seu console e averiguar
             o erro:
             double db = 5.1;
             float fl = db;*/


            /* ------ Casting ------ */
            /* O Casting se trata de uma conversão explícita entre tipos compatíveis, ou seja, quando uma conversão
             como a apresentada acima precisa ser feita, temos uma forma de salientar o compilador que se caso
             alguma informação seja perdida no processo, estaremos de acordo. */
            
            /* Sendo assim, para utilizarmos o Casting, colocaremos em parenteses o tipo que desejamos fazer a
             conversão. Veja o exemplo a seguir: */
            
            double db = 5.1;
            float fl = (float)db;
            Console.WriteLine("\r\nDemonstração do casting");
            Console.WriteLine(fl);
            
            /* ------ Bônus ------ */
            /* Outro problema que podemos observar esta relacionado a um calculo entre duas variáveis inteiras, que
             terão seu resultado apresentado em double. No exemplo a seguir, mostramos que ao dividirmos dois
             números inteiros e armazenarmos o resultado de sua divisão em um double que em teoria estaria apto
             a aceitar as casas onde terão dizimas, o mesmo não as demonstrará. Isso ocorre, pois o compilador
             entenderá que ao estarmos dividindo dois inteiros, o resultado desejado será também um inteiro, perdendo 
             assim a fração resultante.
              Veja a seguir:*/

            int c = 5;
            int d = 2;
            double resultado = c / d;
            Console.WriteLine("\r\nDemonstração de como ocorre o armazenamento em double, onde temos uma divisão entre inteiros");
            Console.WriteLine(resultado);
            
            /* Caso desejarmos obter tal fração que seria perdido no processo, precisamos utilizar o Casting e assim
             obteremos o resultado exato da divisão em double.
             Veja a seguir: */

            Console.WriteLine("\r\nDemontrando que obtemos o resultado correto utilizando o Casting");
            double resCasting = (double)c / d;
            Console.WriteLine(resCasting);
        }
    }
}