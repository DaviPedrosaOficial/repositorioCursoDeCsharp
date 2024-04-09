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

            /* Além de propriedades temos também diferentes maneiras de formatarmos o DateTime, vamos ver algumas delas a
            seguir:                                                                                                      */

            Console.WriteLine("\r\n------ Formatação do DateTime ------");

            /* A primeira maneira que temos é o ToLongDateString(), onde esta demonstra no terminal a data de uma forma mais
            completa, demonstrando o dia e o mes por extenso, sem as horas.
            É importante salientar, que o processo que esta ocorrendo ao formatar o nosso DateTime é uma tranformação do struct
            para uma string, ou seja, se quisessemos armazenar o resultado do mesmo dentro de uma variável string seria possível!
            Veja a seguir a implementação do mesmo:                                                                            */

            Console.Write("ToLongDateString(): ");
            Console.WriteLine(d.ToLongDateString());

            /* A próxima formatação que teremos é o ToLongTimeString, onde neste teremos a transformação das horas de nosso Date-
            Time em uma string. E nessa será demonstrado as horas por completo, demonstrando as horas, minutos e segundos.
            Veja a seguir:                                                                                                     */

            Console.WriteLine("ToLongTimeString(): ");
            Console.WriteLine(d.ToLongTimeString());

            /* Temos também o ToShortDateString(), que ao contrario do ToLongDateString(), esse demonstrará a data de forma resu-
            mida, apresentando somente os números.
            Veja a seguir:                                                                                                     */

            Console.Write("ToShortDateString(): ");
            Console.WriteLine(d.ToShortDateString());

            /* Assim como o ToShortDateString, teremos o ToShortTimeString(), que demonstra as horas de nosso DateTime de maneira
            resumida, apresentando somente as horas e os minutos.
            Veja a seguir:                                                                                                     */

            Console.Write("ToShortTimeString(): ");
            Console.WriteLine(d.ToShortTimeString());

            /* E por último demonstraremos o ToString(), no qual este demonstrará a data de forma resumida, apresentando somente
            os números para a data e a hora. Além disso, é possível formatá-lo de diversas maneiras, como veremos a seguir:   */

            Console.Write("ToString(): ");
            Console.WriteLine(d.ToString());

            /* Como dito acima temos diferentes maneiras de formatarmos o ToString(), e estas se baseam na forma apresentada pelo
            dev, utilizando a nomenclatura correta para demonstrar a maneira como será apresentado o ToString().
            E para isso, utilizamos o "yyyy" para o ano, "MM" para o mes, "dd" para os dias, "HH" para as horas, "mm" para os mi-
            nutos, "ss" para segundos e "fff..." para os milissegundos.
            Veja os a seguir na prática:                                                                                       */

            Console.WriteLine("ToString('yyyy/MM/dd HH:mm:ss'): ");
            Console.WriteLine(d.ToString("yyyy/MM/dd HH:mm:ss"));




        }
    }
}