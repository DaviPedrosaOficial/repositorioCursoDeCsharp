using System;
using primeiraAula.Cap4.Classes;
using System.Globalization;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

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

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
        }
    }
}


