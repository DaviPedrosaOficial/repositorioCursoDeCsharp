/* ------ DateTime ------ */

using System;
using System.Globalization;

namespace CursoDeCsharp.Cap5.Aulas
{

    class Aula5_Cap5{

        static void _Aula5_Cap5(string [] arg){

            /* ------ O que é o DateTime? ------
            
            DateTime é o recurso utilizado em C# para trabalharmos com datas e horas. Além disso, o DateTime funciona
            através de um INSTANTE, ou seja, o mesmo serve também para armazenar uma data, um horario, ou uma data/horario.
            
            Outro ponto importante que devemos salientar sobre o mesmo é que o DateTime é de tipo struct (tipo valor), ou seja,
            o mesmo já é uma classe pré formada do System, que podemos chamar a qualquer momento, e utilizar suas funções.


            ------ Representação interna ------

            Um objeto DateTime, armazena internamente o número de "ticks"(100 nanosegundos) desde a meia noite do dia 1 de janei-
            ro do ano 1 da era comum (atual). Ou seja, a data que é armazenada é na verdade um número inteiro que o nosso compila-
            dor converterá para aquela data.

            Vamos vé-lo a seguir:                                                                                               */

            /* Lembre-se, para utilizarmos o DateTime é necessário chamarmos no ínicio de nosso código a biblioteca System. */
            Console.WriteLine("------ Instanciação e ticks ------");
            DateTime d1 = DateTime.Now;

            Console.Write("DateTime.Now: ");
            Console.WriteLine(d1);

            /* Comando para que possamos ver os ticks daquela data, demonstrado abaixo: */
            Console.Write("DateTime.Ticks: ");
            Console.WriteLine(d1.Ticks);


            /* ------ Maneiras de instanciarmos nosso DateTime ------
            
            --- Construtores ---
            Ao total, existem 12 construtores que podemos utilizar para instanciarmos nosso DateTime, porém, aqui demonstraremos
            apenas as mais comuns, veja a seguir:

            - DateTime(ano,mes,dia)
            - DateTime(ano,mes,dia,hora,minuto,segundo)
            - DateTime(ano,mes,dia,hora,minuto,segundo,milissegundo)

            Veja a baixo a instanciação das mesmas:                                                                             */

            Console.WriteLine("\r\n------ Construtores do DateTime ------");
            
            DateTime d2 = new DateTime(1999,10,26);
            DateTime d3 = new DateTime(2024,04,06,12,29,05);
            DateTime d4 = new DateTime(2024,02,10,10,20,59,02);
            
            Console.Write("DateTime(ano,mes,dia): ");
            Console.WriteLine(d2);

            Console.Write("DateTime(ano,mes,dia,hora,minuto,segundo): ");
            Console.WriteLine(d3);

            Console.Write("DateTime(ano,mes,dia,hora,minuto,segundo,milissegundo): ");
            Console.WriteLine(d4);
            /* Note que no d4, não será demonstrado os milissegundos, pois, para isso será necessário uma formatação especial, que
            veremos mais a frente em nosso curso!
            Outro ponto importante de ressaltarmos, é que ao instanciarmos utilizando apenas o ano/mes/dia, a data será criada na
            hora 00:00:00 daquele dia.
            
            --- Builders ---
            
            - DateTime.Now (Demonstra a data e hora atual da maquina que esta executando o projeto)
            - DateTime.UtcNow (Demonstra a data e hora atual referente ao horário universal, ou seja, a partir do Greenwich, ou ponto 0)
            - DateTime.Today (Demonstra a data atual as 00:00:00 horas)
            - DateTime.Parse (Converte string em data baseado nos padrões de formatações pre dispostos. Aceita diferentes formatações)
            - DateTime.ParseExact (Converte uma string em data baseado no padrão de formatação feito pelo dev)
            
            Vamos vê-los a seguir na prática:                                                                                       */

            Console.WriteLine("\r\n------ Builders do DateTime ------");
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today;
            
            /* Para o DateTime.Parse, demonstraremos diferentes formatações para que possamos ter uma breve noção das mesmas.
            É interessante informar que todas as formas de formatá-lo podem ser encontradas na web, caso seja necessário. */
            DateTime d8 = DateTime.Parse("2024-04-06");
            DateTime d9 = DateTime.Parse("26/10/1999 09:45:54");
            /* Note também que para demonstrar as horas em string, saltamos após o ultimo elemento da data com um espaço, e assim
            nosso compilador entenderá que a partir daquele ponto será indicado as horas!                                          */

            DateTime d10 = DateTime.ParseExact("1999-10-26" , "yyyy-MM-dd", CultureInfo.InvariantCulture);
            /* Para o ParseExact, são necessários 2 parâmetros como vistos acima. São eles: A demonstração de como a nossa data será
            formatada, utilizando yyyy para ano, MM para mes e dd para os dias, e o Provider ou seja, como o compilador deverá prover
            aquele sistema, que no nosso caso acima utilizamos o CultureInfo.InvariantCulture (é necessário também chamar sua biblio-
            teca: System.Globalization)                                                                                            */

            DateTime d11 = DateTime.ParseExact("11/12/2012 09:59:02" , "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            /* Assim como a data utiliza padrões para determinar seus parâmetros, as horas também utilizam do mesmo, sendo HH para
            hora, mm para minutos e ss para segundos!                                                                             */

            /* Agora vamos ver a execução dos mesmos:                                                                             */

            Console.Write("DateTime.Now: ");
            Console.WriteLine(d5);

            Console.Write("DateTime.UtcNow: ");
            Console.WriteLine(d6);

            Console.Write("DateTime.Today: ");
            Console.WriteLine(d7);

            Console.Write("DateTime.Parse('2024-04-06'): ");
            Console.WriteLine(d8);

            Console.Write("DateTime.Parse('26/10/1999 09:45:54'): ");
            Console.WriteLine(d9);

            Console.Write("DateTime.ParseExact('1999-10-26' , 'yyyy-MM-dd', CultureInfo.InvariantCulture): ");
            Console.WriteLine(d10);

            Console.Write("DateTime.ParseExact('11/12/2012 09:59:02' , 'dd/MM/yyyy HH:mm:ss', CultureInfo.InvariantCulture): ");
            Console.WriteLine(d11);
        }
    }
}