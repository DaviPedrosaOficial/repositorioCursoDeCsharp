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

            /* Note que ao executarmos o comando acima, não temos nenhuma interferência ou diferença em nosso terminal quanto
            a representação de nosso DateTimes. Como todos, são a mesma data, em nosso terminal, também foi aprensentado cada
            um dos mesmo, com a mesma.
            Isso ocorre, pois o compilador do Csharp, ira considerar que, da maneira com que nos instanciamos o nosso DateTi-
            me, é a maneira na qual o mesmo deve ser demonstrado.

            Então, para que utilizamos o DateTimeKind?

            Para isso, seguir uma breve linha de raciocínio.

            Imagine que estamos criando uma aplicação que poderá ser acessada internacionalmente, e sendo assim, teremos dife-
            rentes lugares do mundo acessando a mesma. O que nos leva a diferentes horário que deverão ser convertidos pela
            aplicação, e sendo assim, teremos de manejar tal conversão.

            E é ai que as funções de nosso DateTime, entram em ação. Vamos ver o exemplo a seguir de como podemos converter
            os DateTimes utilizando os seguintes métodos:

            1) myDate.Kind (nos demonstra de que tipo é o DateTime escolhido)

            2) myDate.ToLocalTime() (passa nosso DateTime para local, ou seja, a partir desse momento, o compilador entenderá que aque-
            le DateTime será o DateTime da "máquina")

            3) myDate.ToUniversalTime() (passa nosso DateTime para UTC, ou seja, o compilador entenderá que aquele DateTime já esta pa-
            relho ao horário universal)

            Então, vamos a prática para ver como ficará a execução de nossos DateTimes:                                              */

            Console.WriteLine("\r\n------ Demonstração dos métodos do DateTime ------");

            Console.Write("\r\n---- myDate1 ---- : ");
            Console.WriteLine(myDate1);

            Console.Write("myDate1.Kind: ");
            Console.WriteLine(myDate1.Kind);

            Console.Write("myDate1.ToLocalTime(): ");
            Console.WriteLine(myDate1.ToLocalTime());

            Console.Write("myDate1.ToUniversalTime(): ");
            Console.WriteLine(myDate1.ToUniversalTime());

            /* Repare que, como o myDate1 esta em Local, ao convertemos o mesmo para local, como esperado, nosso DateTime se mantém
            o mesmo. E ao convertermos o mesmo para UTC, o mesmo adicionou 3 horas ao nosso DateTime, já que estamos no Brasil e nosso
            fuso horário comparado ao de Greenwich é de -3 horas, por isso a adição das mesmas. */

            Console.Write("\r\n---- myDate2 ---- : ");
            Console.WriteLine(myDate2);

            Console.Write("myDate2.Kind: ");
            Console.WriteLine(myDate2.Kind);

            Console.Write("myDate2.ToLocalTime(): ");
            Console.WriteLine(myDate2.ToLocalTime());

            Console.Write("myDate2.ToUniversalTime(): ");
            Console.WriteLine(myDate2.ToUniversalTime());

            Console.Write("\r\n---- myDate3 ---- : ");
            Console.WriteLine(myDate3);

            Console.Write("myDate3.Kind: ");
            Console.WriteLine(myDate3.Kind);

            Console.Write("myDate3.ToLocalTime(): ");
            Console.WriteLine(myDate3.ToLocalTime());

            Console.Write("myDate3.ToUniversalTime(): ");
            Console.WriteLine(myDate3.ToUniversalTime());
        }
    }
}