﻿using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Console.Write("Insira a seguir a cotacao do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a quantia na qual voce deseja comprar do mesmo: ");
            double qtdCompra = double.Parse(Console.ReadLine());

            Console.WriteLine("Na cotacao de R${0:F2} do Dolar, para comprar ${1:F2},",cotacao,qtdCompra);
            Console.WriteLine("Voce devera pagar R${0:F2}",ConversorDeMoeda.Conversao(cotacao,qtdCompra));
        }
    }
}


