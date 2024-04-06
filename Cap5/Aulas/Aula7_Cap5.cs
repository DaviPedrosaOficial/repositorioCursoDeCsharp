/* ------ Propriedades e Operações com DateTime ------ */

using System;

namespace CursoDeCsharp{

    class Aula7_Cap5{

        static void _Aula7_Cap5(string [] arg){

            /* ------ Propriedades do DateTime ------
            
            O DateTime possui diversas propriedades que podemos utilizar para nos auxiliar em nossos projetos.
            Vamos vê-las a seguir:                                                                            */

            /* Nomenclatura: Propriedade(tipo que retornará a partir da mesma)

            - 1) Date (DateTime) => Retorna a data de nosso DateTime

            - 2) Day (int) => Retorna o dia de nosso DateTime

            - 3) DayOfWeek (DayOfWeek) => Retona o dia da semana em extenso de nosso Datetime

            - 4) DayOfYear (int) => Retorna o total de dias que temos no ano até o dia de nosso DateTime

            - 5) Hour (int) => Retorna a hora referente ao nosso DateTime

            - 6) Kind (DateTimeKind) => Retorna o tipo de nosso DateTime *Se expecificado

            - 7) Millisecond (int) => Retorna os milissegundos de nosso DateTime

            - 8) Minute (int) => Retorna os minutos de nosso DateTime

            - 9) Month (int) => Retorna os meses de nosso DateTime

            - 10) Second (int) => Retorna os segundos de nosso DateTime

            - 11) Ticks (long) => Retorna os ticks de nosso DateTime

            - 12) TimeOfDay (TimeSpan) => Retorna as horas de nosso DateTime por completo

            - 13) Year (int) => Retorna o ano de nosso DateTime
            
            Para ficar de mais fácil de vermos o resultado vamos demonstra-los a seguir:                              */

            DateTime d = new DateTime(2024,04,06,10,30,40,250);

            Console.WriteLine("------ Propriedades do DateTime ------");

            Console.WriteLine("DateTime escolhido: ");
            Console.WriteLine(d);

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