using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            double? x = null;
            double? y = 27.50;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine("x possui valor? \r\nResposta: {0}",x.HasValue);
            Console.WriteLine("y possui valor? \r\nResposta: {0}",y.HasValue);

            Console.WriteLine("Valor de y: {0}",y.Value);
        }
    }
}


