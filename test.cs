using System;
using primeiraAula.Cap4.Classes;
using System.Globalization;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            DateTime d = new DateTime(2024,04,06,10,30,40,250);

            Console.WriteLine("------ Propriedades do DateTime ------");

            Console.Write("DateTime escolhido: ");
            Console.WriteLine(d + "\r\n");

            Console.WriteLine("1) Date: " + d.Date);

            Console.WriteLine("2) Day: " + d.Day);

            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);

            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);

            Console.WriteLine("5) Hour: " + d.Hour);

            Console.WriteLine("6) Kind: " + d.Kind);

            Console.WriteLine("7) Millisecond: " + d.Millisecond);

            Console.WriteLine("8) Minute: " + d.Minute);

            Console.WriteLine("9) Month: " + d.Month);

            Console.WriteLine("10) Second: " + d.Second);

            Console.WriteLine("11) Ticks: " + d.Ticks);

            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);

            Console.WriteLine("13) Year: " + d.Year);

        }
    }
}


