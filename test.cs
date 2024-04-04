﻿using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.Write("Insira a seguir o valor total da compra: ");
            double val = double.Parse(Console.ReadLine());

            double totalComDesconto = 0;
            
            if (val < 20){
                totalComDesconto += val - val * 0.1;
                Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalComDesconto);
            }
            else{
                totalComDesconto += val - val * 0.4;
                Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalComDesconto);
            }

            /* Como vimos acima, foi montada uma estrutura condicional para conceber descontos nas compra, baseados no
            valor total da mesma. Agora, vamos ver como a mesma condicional ficaria se utilizassemos as condicionais ter-
            nárias:                                                                                                   */
            
            Console.Write("Insira a seguir o valor total da compra: ");
            double val2 = double.Parse(Console.ReadLine());

            double totalC_Desc = (val2 < 20) ? val2 - val2 * 0.1 : val2 - val2 * 0.4;
            /* Note a quantidade linhas que economizamos ao utilizarmos dessa nova sintaxe.
            Lembrando que a sintaxe da mesma fica da seguinte maneira:
            (condição) ? valor_se_verdadeiro : valor_se_falso; */

            Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalC_Desc);
        }
    }
}


