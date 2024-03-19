using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Ponto p1;

            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine("P1");
            Console.Write(p1);
            Console.WriteLine();

            /* Mas é possível também, instanciá-lo */
            Ponto p2 = new Ponto();

            Console.WriteLine("P2");
            Console.Write(p2);
        }
    }
}


