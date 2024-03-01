using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("\r\n------ Exercicio 6 ------");
            Console.WriteLine("Neste programas verificaremos qual intervalo entre 0 e 100, se localiza um numero de\r\nsua escolha!");
            Console.WriteLine("Entao para que possamos comeca-lo, insira a seguir um numero de sua escolha: ");
            int numCliente = int.Parse(Console.ReadLine());

            /* Processamento e saída */
            if (numCliente < 0 || numCliente > 100)
            {
                Console.WriteLine("\r\nValor fora do intervalo 0 - 100.");   
            }
            else if (numCliente >= 0 && numCliente <= 25)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 0 e 25!");
            }
            else if (numCliente > 25 && numCliente <= 50)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 25 e 50!");
            }
            else if (numCliente > 50 && numCliente <= 75)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 50 e 75!");
            }
            else
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 75 e 100!");
            }
        }
    }
}

