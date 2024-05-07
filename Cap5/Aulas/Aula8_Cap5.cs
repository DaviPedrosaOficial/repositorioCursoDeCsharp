/* ------ Propriedades e operações com o TimeSpan ------ */

using System;

namespace CursoDeCsharp.Cap5.Aulas
{

    class Aula8_Cap5{

        static void _Aula8_Cap5(string [] arg){

            /* ------ Propriedades do TimeSpan ------

            Assim como no DateTime, no TimeSpan temos a possibilidade de encontrar suas propriedades através de suas
            palavras chave. Para refrescarmos nossa memoria, vamos demonstra-las a seguir:                        */

            Console.WriteLine("------ Propriedades do TimeSpan ------");

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.Write("\r\nTimeSpan base: ");
            Console.WriteLine(t);

            Console.WriteLine("TimeSpan.Days: " + t.Days);
            Console.WriteLine("TimeSpan.Hours: " + t.Hours);
            Console.WriteLine("TimeSpan.Minutes: " + t.Minutes);
            Console.WriteLine("TimeSpan.Milliseconds: " + t.Milliseconds);
            Console.WriteLine("TimeSpan.Seconds: " + t.Seconds);
            Console.WriteLine("TimeSpan.Ticks: " + t.Ticks);

            /* Agora, vamos explicar o que é o Total... que será utilizado a seguir.

            Reflita sobre o TimeSpan criado acima. Sabemos que por mais que tenhamos apenas 2 dias sendo demonstrados
            o mesmo já percorreu 3 horas, o que nos explicita que parte daquele dia já se passou, então o valor da-
            quele dia já passou de somente 2 (int), devido a essas horas.

            Compreendendo este conceito, podemos compreender melhor o que são os Total... de nosso TimeSpan, onde o
            mesmo, visa entregar o valor exato do tempo percorrido em cada um de seus parâmetro, e para isso ele nos
            retorna em números quebrados o valor de dias, horas, minutos... Buscando nos retornar o valor completo de
            suas propriedades.

            Veja a seguir como fica na prática e tente refletir sobre o que foi descrito acima:                    */

            Console.WriteLine("TimeSpan.TotalDays: " + t.TotalDays);
            Console.WriteLine("TimeSpan.TotalHours: " + t.TotalHours);
            Console.WriteLine("TimeSpan.TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TimeSpan.TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TimeSpan.TotalMilliseconds: " + t.TotalMilliseconds);

            /* ------ Operações com o TimeSpan ------
            
            Existem 4 operações diferentes para o TimeSpan, são elas:
            
            1) Adição => .Add()
            2) Subtração => .Subtract()
            3) Multiplicação => .Multiply()
            4) Divisão => .Divide()
            
            Porém, existem diferenças na implementação das mesma, onde, para a adição e subtração, utilizamos outro
            TimeSpan como parâmetro para somarmos ou subtrairmos, e já para a multiplicação e divisão utilizamos um
            double para a sua implementação.
            
            Vamos vê-las a seguir na prática:                                                                    */

            Console.WriteLine("\r\n------ Operações com o TimeSpan ------");

            TimeSpan tempo1 = new TimeSpan(1,2,30,20);
            TimeSpan tempo2 = new TimeSpan(1,15,10);

            Console.Write("\r\nTimeSpan 1: ");
            Console.WriteLine(tempo1);

            Console.WriteLine("\r\nTimeSpan 2: ");
            Console.WriteLine(tempo2);

            TimeSpan soma = tempo1.Add(tempo2);
            Console.Write("Adição entre TimeSpan 1 & 2: ");
            Console.WriteLine(soma);

            TimeSpan subtracao = tempo1.Subtract(tempo2);
            Console.Write("Subtração entre TimeSpan 1 & 2: ");
            Console.WriteLine(subtracao);

            TimeSpan multiplicacao1 = tempo1.Multiply(2.0);
            Console.Write("Multiplicação TimeSpan 1 * 2: ");
            Console.WriteLine(multiplicacao1);

            TimeSpan multiplicacao2 = tempo2.Multiply(3.0);
            Console.Write("Multiplicação TimeSpan 2 * 3: ");
            Console.WriteLine(multiplicacao2);

            TimeSpan divisao1 = tempo1.Divide(3.0);
            Console.Write("Divisão TimeSpan 1 / 3: ");
            Console.WriteLine(divisao1);

            TimeSpan divisao2 = tempo2.Divide(2.0);
            Console.Write("Divisão TimeSpan 2 / 2: ");
            Console.WriteLine(divisao2);

        }
    }
}