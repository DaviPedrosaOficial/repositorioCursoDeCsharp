/* ------ Operadores lógicos ------ */

using System;

namespace CursoDeCsharp.Cap1.Aulas
{
    class Aula8_Cap1
    {
        static void _Aula8(string[] arg)
        {
            /* Operadores existentes:
             - " && " = ... e ...(para que algo seja verdadeiro, ambas as condições devem verdadeiras)
             - " || " = ... ou ...(para que algo seja verdadeiro, no minímo uma condição deve ser verdadeira)
             - " ! " = ... não ...(negação de uma operação logica, not dos sistemas logicos) */
            
            /* Testando operadores */

            /* ------ && ------ */
            Console.WriteLine("Testando && ( e ), no sistema logico: 2 > 3 && 4 != 5; ");
            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);
            Console.WriteLine("\r\nO resultado deu falso, uma vez que 2 não é maior que 3, sendo assim falso.");
            Console.WriteLine("Como se trata do operador logico 'e', para que o resultado desse verdadeiro,");
            Console.WriteLine("as duas afirmações deveriam ser verdadeiras.");
            
            /* ------ || ------ */
            Console.WriteLine("\r\nTestando || ( ou ), no sistema logico: 2 > 3 || 4 != 5; ");
            bool c2 = 2 > 3 || 4 != 5;
            Console.WriteLine(c2);
            Console.WriteLine("\r\nO resultado deu verdadeiro, uma vez que 4 é de fato diferente de 5, e como estamos");
            Console.WriteLine("utilizando o operador logico 'ou', apenas uma das afirmativas precisam ser verdadeiras ");
            Console.WriteLine("para que o resultado tambem seja verdadeiro. ");
            
            /* ------ ! ------ */
            Console.WriteLine("\r\nTestando ! ( not ), no sistema logico: ! (2 > 3) && 4 != 5; ");
            bool c3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c3);
            Console.WriteLine("\r\nO resultado do operador logico passou a ser verdadeiro, uma vez que com o 'not' ");
            Console.WriteLine("demonstramos que a operação '2 > 3' de fato é falsa, tornando seu resulta em verdadeiro.");
            Console.WriteLine("Sendo assim, ambas as operacoes dentro do teste booleano passaram a ser verdadeiros, e ");
            Console.WriteLine("considerados como verdadeiros pelo operador logico 'e' .");
            
            /* ------ Bônus ------ */
            /* Precedência:
             Os operadores lógicos contam também com a precedência, ou seja, ao se determinar uma estrutura de código,
             algumas operações serão realizadas antes que outras à depender de sua precedência.
             
             No caso dos operadores lógicos, as mesmas ocorrem da seguinte maneira:
             1º - ! (not)
             2º = && (e)
             3º = || (ou)
             Abstraindo o conceito, ao executarmos um comando, o operador lógico "!" será resolvido primeiro, e depois será
             executado o operador "&&", e por fim será executado o operador "||".*/
        }
    }
}