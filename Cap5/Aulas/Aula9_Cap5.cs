/* ------ DateTimeKind & Padrão ISO 8601 ------ */

using System;

namespace CursoDeCsharp{

    class Aula9_Cap5{

        static void _Aula9_Cap5(string [] arg){

            /* ------ O que é o DateTimeKind? ------

            O DateTimeKind é um tipo enumerado especial que define 3 valores possíveis para a localidade de datas.
            Onde os três são:

            1) Local (Fuso horário do sistema. Exemplo: São Paulo = GMT - 3)
            2) UTC (Fuso horário do GMT [Greenwich mean time])
            3) Unspecified (Não expecificado)

            Boa prática ao utilizar o DateTimeKind:

            - Sempre que formos armazenar datas em nosso projeto, seja ele no Banco de Dados, JSON, ou XML, é aconse-
            lhado que as guardemos utilizado o UTC, e somente quando formos instanciá-la e demonstrá-la, fazemos a
            conversão para o horário local da máquina que estará rodando nosso projeto.

            Mas como fazemos para executar tal conversão?

            1) Para LocalTime => myDate.ToLocalTime()
            2) Para UTC => myDate.ToUniversalTime()

            Para ficar mais claro, vamos demonstrá-los na prática:                                                */

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