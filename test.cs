using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("\r\n------ Exercicio 7 ------");
            Console.Write("Insira a seguir um numero inteiro positivo para que possamos transformá-lo: ");
            int numLinhas = int.Parse(Console.ReadLine());
            
            /* Processamento e saída */
            for (int i = 1; i <= numLinhas; i++)
            {
                Console.WriteLine("{0} {1} {2}",i , Math.Pow(i,2), Math.Pow(i,3));
            }
        }
    }
}


