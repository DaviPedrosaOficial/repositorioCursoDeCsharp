/* ------ Estrutura repetitiva enquanto (while) ------ */

using System;

namespace CursoDeCsharp.Cap1.Aulas
{
    class Aula12_Cap1
    {
        static void _Aula12(string[] arg)
        {
            /* O que é a estrutura while?
             
              A estrutura while nada mais é do que um loop onde o mesmo será executado enquanto sua condicional for verdadeira
             e assim que a mesma se tornar falsa o mesmo se encerrará!
              É interessante salientarmos que sua estrutura é bem semelhante a das estruturas condicionais, tendo como 
             parâmetro uma condicional que determinará se deverá ou não ser executado, e os comandos dentro de seu escopo
             aguardando para serem executados caso o loop seja ativo.
             
             Estrutura do comando:
             
             while (condicional) {
                   comando 1
                   comando 2
                }
                  
             Lembre-se: o loop while, testa uma condição, e se verdadeira ele irá executar os comandos de seu escopo, e 
             assim em que esses se encerrarem, ele voltará a testar a condicional, e se a mesma continuar sendo verdadeira
             ele executará novamente seus comandos até que sua condicional se torne falsa.
             
             Agora vamos demonstrá-lo na prática:   */

            /* Entrada */
            Console.WriteLine("Digite um numero para que possamos lhe voltar sua raiz quadrada: ");
            double numCliente = double.Parse(Console.ReadLine());
            
            /* Processamento & saída (loop while) */
            while (numCliente >= 0)
            {
                double raizCliente = Math.Sqrt(numCliente);
                Console.WriteLine("A raiz quadrada de {0:F2} é {1:F2} !",numCliente,raizCliente);
                Console.WriteLine("\r\nInsira outro numero para calcularmos sua raiz quadrada: ");
                numCliente = double.Parse(Console.ReadLine());

            }
            
            /* Saída (fora do loop) */
            Console.WriteLine("O numero inserido é negativo!");
            
        }
    } 
}

