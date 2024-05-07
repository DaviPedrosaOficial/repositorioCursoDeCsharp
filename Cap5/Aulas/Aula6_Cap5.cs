/* ------ TimeSpan ------ */

using System;

namespace CursoDeCsharp.Cap5.Aulas
{

    class Aula6_Cap5{

        static void _Aula6_Cap5(string [] arg){

            /* ------ O que é o TimeSpan ------
            
            Assim como o TimeDate, o TimeSpan é um objeto do tipo struct, onde esse diferente do TimeDate, representa a DURAÇÂO de
            algo.
            
            Internamente, o TimeSpan funciona da mesma maneira que o TimeDate, armazenando a duração na forma de "ticks". Ou seja,
            o nosso compilador ira guardar um numero inteiro daquela duração e quando solicitado será feito a sua conversão para um
            tempo real da maneira que conhecemos.

            Além disso, temos de lembrar que como ambos são structs padrões da linguagem C#, para que possamos utilizá-los é necessá-
            rio chamar a biblioteca System no ínicio de nosso código.
            
            Vamos ver sua instanciação a seguir:                                                                                 */

            Console.WriteLine("------ Instanciando e ticks ------");
            TimeSpan t1 = new TimeSpan(00, 01, 30);
            /* Representação de seus parâmetros: (hora, minutos, segundos) */

            Console.Write("TimeSpan: ");
            Console.WriteLine(t1);

            Console.Write("TimeSpan.Ticks: ");
            Console.WriteLine(t1.Ticks);


            /* ------ Maneiras de instanciarmos nosso TimeSpan ------
            
            --- Construtores ---
            - TimeSpan() [Cria um TimeSpan 00:00:00]
            - TimeSpan(12300L) [Cria o TimeSpan baseado nos ticks informados{Deve ser colocado o L no final para demonstrar que é
            um Long}]
            - TimeSpan(00,01,30)
            
            Vamos vê-los na prática:                                                                                              */

            Console.WriteLine("\r\n------ Construtores ------");

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(00,02,30);
            TimeSpan t5 = new TimeSpan(1,10,25,30);
            TimeSpan t6 = new TimeSpan(10,2,30,59,500);

            Console.Write("TimeSpan(): ");
            Console.WriteLine(t2);

            Console.Write("TimeSpan(900000000L) [Ticks]: ");
            Console.WriteLine(t3);

            Console.Write("TimeSpan(00,02,30) [hora,minuto,segundo]: ");
            Console.WriteLine(t4);

            Console.Write("TimeSpan(1,10,25,30) [dia,hora,minuto,segundo]: ");
            Console.WriteLine(t5);
            /* Note que no terminal a nomenclatura para representar os dias é diferente do que as horas, minutos e segundos. */

            Console.Write("TimeSpan(10,2,30,59,500) [dia,hora,minuto,segundo,milissegundo]: ");
            Console.WriteLine(t6);

            /* --- Construtor + From ---
            
            O método From, nos permite instanciarmos durações equivalentes aos parâmetros apresentados, ou seja, imagine que é
            de nosso desejo criar uma duração de 1 dia e 1/2, para isso utilizaremos a instanciação TimeSpan.FromDays(1.5).
            
            Veja a seguir todas as suas possibilidades:
            
            - TimeSpan.FromDays() [Equivalente a tantos dias]
            - TimeSpan.FromHours() [Equivalente a tantas horas]
            - TimeSpan.FromMinutes() [Equivalente a tantos minutos]
            - TimeSpan.FromSeconds() [Equivalente a tantos segundos]
            - TimeSpan.FromMilliseconds() [Equivalente a tantos milissegundos]
            - TimeSpan.FromTicks() [Equivalente a tantos ticks]
            
            Veja excecução dos mesmos a seguir para tornar mais didática a compreensão:                                       */

            /*
            TimeSpan t7 = new TimeSpan.FromDays(1.5);
            TimeSpan t8 = new TimeSpan.FromHours(2.3);
            TimeSpan t9 = new TimeSpan.FromMinutes(3.5);
            TimeSpan t10 = new TimeSpan.FromSeconds(55.2);
            TimeSpan t11 = new TimeSpan.FromMilliseconds(1000.2);
            TimeSpan t12 = new TimeSpan.FromTicks(8000000000L);

            Console.WriteLine("\r\n------ Contrutor + From ------");

            Console.Write("TimeSpan.FromDays(1.5): ");
            Console.WriteLine(t7);

            Console.Write("TimeSpan.FromHours(2.3): ");
            Console.WriteLine(t8);

            Console.Write("TimeSpan.FromMinutes(3.5): ");
            Console.WriteLine(t9);

            Console.Write("TimeSpan.FromSeconds(55.2): ");
            Console.WriteLine(t10);

            Console.Write("TimeSpan.FromMilliseconds(1000.2): ");
            Console.WriteLine(t11);

            Console.Write("TimeSpan.FromTicks(8000000000L): ");
            Console.WriteLine(t12);

            O meu visual studio não esta reconhecendo os métodos From, então foi necessário transformá-los em comentarios.      */
        }
    }
}