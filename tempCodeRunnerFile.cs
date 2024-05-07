using System;
using CursoDeCsharp.Cap6.Aulas.Entities;
using CursoDeCsharp.Cap6.Aulas.Entities.Enums;
using System.Globalization;

namespace CursoDeCsharp
{    class tempCodeRunnerFile
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            Order pedidoTeste = new Order{
                Id = 1010,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(pedidoTeste);

            /*------ Conversão para string ------*/

            string txt = OrderStatus.Delivered.ToString();

            Console.Write("\r\nConversão para string: ");
            Console.WriteLine(txt);

            /*------ Conversão para Enum ------*/

            OrderStatus order = Enum.Parse<OrderStatus>("PendingPayment");

            Console.Write("Conversão para Enum: ");
            Console.WriteLine(order);
        }
    }
}
