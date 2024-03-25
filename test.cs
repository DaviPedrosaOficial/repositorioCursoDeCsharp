using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            int x = 30;
            Calculadora2.Triplica(ref x);
            Console.WriteLine(x);
        }
    }
}


