/* ------ Operadores de atribuição ------ */

using System;

namespace CursoDeCsharp.Cap1.Aulas
{
    class Aula2_Cap1
    {
        static void _2Aula(string[] arg)
        {
            /* num Recebe 10 */
            int num = 10;
            Console.WriteLine("Entrada");
            Console.WriteLine(num);

            /* num Recebe +2 */
            num += 2;
            Console.WriteLine("\r\n+2");
            Console.WriteLine(num);

            /* num Recebe -2 */
            num -= 2;
            Console.WriteLine("\r\n-2");
            Console.WriteLine(num);

            /* num Recebe *2 (multiplicação por 2) */
            num *= 2;
            Console.WriteLine("\r\n*2");
            Console.WriteLine(num);
            
            /* num Recebe /2 (divisão por 2) */
            num /= 2;
            Console.WriteLine("\r\n/2");
            Console.WriteLine(num);
            
            /* num Recebe %2 (resto da divisão por 2) */
            num %= 2;
            Console.WriteLine("\r\n%2");
            Console.WriteLine(num);
            
            /* Bônus */
            /* A atribuição ' += ' também funciona para strings como o exemplo a seguir: */
            string s = "ABC";
            Console.WriteLine("\r\n{0}",s);
            
            /* Atribuindo a string */
            s += "DEF";
            Console.WriteLine(s);
            
            
            /* ------ Operadores aritméticos / atribuição ------ */

            int num2 = 50;
            Console.WriteLine("\r\n{0}",num2);
            
            /* Atribuindo +1 (com num2++) */
            num2++;
            Console.WriteLine("\r\n+1");
            Console.WriteLine(num2);
            
            /* Atribuindo -1 (com num2--) */
            num2--;
            Console.WriteLine("\r\n-1");
            Console.WriteLine(num2);
            
            /* --- Atenção ---*/
            /* Se tentarmos colocar em outra variável as chamadas ++ ou -- como o exemplo abaixo,
             a variável primeiro receberá o valor real e depois atribuirá +1 ou -1 */

            int demontracao = num2++;
            Console.WriteLine("\r\nDemonstração de como funciona a atribuição em variaveis");
            Console.WriteLine(demontracao);
            Console.WriteLine(num2);
            
            /* Note que, a variável 'num2' tinha o valor de 50 ao ser chamada, e este valor foi aderido pela
             variável 'demonstracao', e somente após esse processo o código adicionou +1 a variável 'num2' */
            
            /* Para que o código adicione +1 ou -1 antes de atribuir o valor a variável, devemos colocar ++ ou --
             antes da variável que teremos como parâmetro, assim como o exemplo a segiur */

            int demo = 10;
            Console.WriteLine("\r\nParametro: {0}",demo);
            int add = ++demo;
            Console.WriteLine("Parametro após a chamada da função de atribuição: {0}",demo);
            Console.WriteLine("Variável que recebeu o parametro: {0}",add);



        }
    }
}