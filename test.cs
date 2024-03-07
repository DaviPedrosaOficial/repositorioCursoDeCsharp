using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("\r\n------ Exercicio 4 ------");
            Console.Write("Bem vindo ao programa de divisao!\r\nInsira a seguir a quantidade de divisoes que deseja executar: ");
            int qtdDiv = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdDiv; i++)
            {
                Console.Write("Insira a seguir o dividendo da {0}ª divisao: ",i);
                double dividendo = double.Parse(Console.ReadLine());

                Console.Write("Agora o divisor: ");
                double divisor = double.Parse(Console.ReadLine());

                if (divisor == 0)
                {
                    Console.WriteLine("Divisao impossivel!");
                }
                else
                {
                    double divisao = dividendo / divisor;
                    Console.WriteLine("A divisao entre {0} e {1} resultam em: {2:F1}",dividendo,divisor,divisao);
                }
            }
        }
    }
}


