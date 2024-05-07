using System;
using CursoDeCsharp.Cap6.Aulas.Entities;
using CursoDeCsharp.Cap6.Aulas.Entities.Enums;
using System.Globalization;

namespace CursoDeCsharp
{    class test
    {        static void Test(string[] arg)
        {
            /* Hub de teste */

            Order pedidoTeste = new Order{
                Id = 1010,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(pedidoTeste);
        }
    }
}


