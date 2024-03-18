/* ------ Operadores comparativos ------ */ 

using System;

namespace CursoDeCsharp
{
    class Aula7_Cap1
    {
        static void _Aula7(string[] arg)
        {
            /* Operadores existentes:
             - " > " = Maior que ...
             - " < " = Menor que ...
             - " >= " = Maior ou igual a ...
             - " <= " = Menor ou igual a ...
             - " == " = Igual a ...
             - " != " = Diferente de ... */
            
            /* Testando os operadores */

            Console.WriteLine("Parametro: 10");
            int parametro = 10;
            
            Console.WriteLine("É maior que 10?");
            bool c1 = parametro > 10;
            Console.WriteLine(c1);

            Console.WriteLine("É menor que 10?");
            bool c2 = parametro < 10;
            Console.WriteLine(c2);

            Console.WriteLine("É maior ou igual a 10?");
            bool c3 = parametro >= 10;
            Console.WriteLine(c3);

            Console.WriteLine("É menor ou igual a 10?");
            bool c4 = parametro <= 10;
            Console.WriteLine(c4);

            Console.WriteLine("É igual a 10?");
            bool c5 = parametro == 10;
            Console.WriteLine(c5);

            Console.WriteLine("É igual a 20?");
            bool c6 = parametro == 20;
            Console.WriteLine(c6);

            Console.WriteLine("É diferente de 10?");
            bool c7 = parametro != 10;
            Console.WriteLine(c7);

        }
    }
}