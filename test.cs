using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("\r\n------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo ao identificador de intervalos!");
            Console.WriteLine("Insira a seguir a quantidade de numeros inteiros, na qual voce ira efetuar a verificacao");
            Console.Write("se os mesmos fazem ou nao parte do intervalo entre 10 e 20: ");
            int qtdNum = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;
            
            /* Processamento */
            for (int i = 1; i <= qtdNum; i++)
            {
                Console.Write("Insira o {0}º numero: ",i);
                int verif = int.Parse(Console.ReadLine());

                if (verif < 10 || verif > 20)
                {
                    fora += 1;
                }
                else
                {
                    dentro += 1;
                }
            }

            Console.WriteLine("\r\nBaseado nos numeros inseridos, {0} esta(o) dentro do intervalo entre 10 e 20,\r\ne {1} esta(o) fora do intervalo!",dentro,fora);

        }
    }
}


