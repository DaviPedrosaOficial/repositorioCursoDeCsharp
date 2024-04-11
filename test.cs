using System;
using primeiraAula.Cap4.Classes;
using System.Globalization;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("------ DateTimeKind e suas mudanças ------");

            DateTime myDate1 = new DateTime(2024,04,11,10,38,55, DateTimeKind.Local);
            /* Note que dentro da instanciação, demonstramos que esse nosso DateTime é Local */

            DateTime myDate2 = new DateTime(2024,04,11,10,38,55, DateTimeKind.Utc);
            /* Assim como na instanciação do 1º DateTime, nesse demontramos também seu tipo, onde dessa vez, foi UTC */

            DateTime myDate3 = new DateTime(2024,04,11,10,38,55);
            /* E por ultimo, instanciamos um DateTime sem demonstrarmos o seu tipo */

            /* Agora, vamos ver se há alguma diferença, ao demonstrá-los em nosso terminal, já que todos foram instanciados
            de maneiras diferentes:                                                                                      */

            Console.Write("\r\nmyDate1.DateTimeKind.Local: ");
            Console.WriteLine(myDate1);

            Console.Write("myDate2.DateTimeKind.Utc: ");
            Console.WriteLine(myDate2);

            Console.Write("myDate3: ");
            Console.WriteLine(myDate3);
        }
    }
}


