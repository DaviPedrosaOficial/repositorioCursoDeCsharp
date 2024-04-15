using System;
using primeiraAula.Cap4.Classes;
using System.Globalization;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

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

            /* ------ Padrão ISO 8601 ------

            O padrão ISO 8601 é uma maneira de formatarmos um DateTime, na qual o mesmo já faz por padrão a formatação de nossa data.
            E isso ocorre da senguinte forma, ao utilizarmos a sua formatação ao criarmos nosso DateTime, nosso compilador já criará o
            mesmo em padrão Universal (Utc) e fará a conversão automaticamente do DateTime para Local. Ou seja, ao demonstrarmos (ins-
            tanciarmos) o nosso DateTime, o mesmo será demonstrado utilizando o tipo Local, para se alinhar com a maquina na qual nosso
            projeto está rodando, mas em seu core, o mesmo DateTime estará em padrão Utc.

            Além disso, é necessário salientar que o padrão ISO 8601, é aceito pelo nosso compilador apenas através de String, ou seja
            para criarmos um DateTime utilizando o mesmo padrão, deveremos criar seu tempo em String, como veremos abaixo.

            Outro ponto importante é como criar um DateTime em tal padrão, e para isso, utilizaremos da seguinte nomenclatura:
            yyyy-MM-ddTHH:mm:ssZ (Basicamente a nomenclatura normal que utilizamos, com a adição do T entre os dias e as horas, e o Z
            ao final)

            Agora, vamos a prática, para que possamos entender de fato a sua execução e funcionalidade:                             */

            Console.WriteLine("\r\n------ Padrão ISO 8601 ------");

            /* Criando o nosso DateTime, utilizando o padrão ISO 8601. */
            Console.WriteLine("\r\nData que foi apresentada para nosso DateTime padraoISO: 2024-04-15T10:44:00Z");
            DateTime padraoISO = DateTime.Parse("2024-04-15T10:44:00Z");

            Console.Write("DateTime padraoISO: ");
            Console.WriteLine(padraoISO);
            /* Note na execução do terminal, que ao chamarmos nosso DateTime, o mesmo ja foi informado na formatação Local de nossa ma-
            quina, onde o horário que demos foi 10:44:00, e o ser demonstrado foi retornado 07:44:00, já que estamos no Brasil, e nosso
            horário comparado ao de Greenwich é -3 horas */

            Console.Write("padraoISO.Kind: ");
            Console.WriteLine(padraoISO.Kind);
            /* E consequentemente, nosso tipo de DateTime, passou também a ser Local, já que ao utilizarmos o padrão ISO, o mesmo pas-
            sou o nosso DateTime para Local. */

            Console.Write("padraoISO.ToLocalTime(): ");
            Console.WriteLine(padraoISO.ToLocalTime());

            Console.Write("padraoISO.ToUniversalTime(): ");
            Console.WriteLine(padraoISO.ToUniversalTime());
        }
    }
}


