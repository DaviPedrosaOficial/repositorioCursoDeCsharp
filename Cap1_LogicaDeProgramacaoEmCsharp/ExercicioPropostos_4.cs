/* ------ Exercícios propostos 4 ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioPropostos_4
    {
        static void Ex_Propostos4(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha,
             inclusive o X, se for o caso.  */

            /* Entrada */
            Console.WriteLine("Bem vindo ao Odd finder!");
            Console.Write("Insira a seguir um numero inteiro para que possamos demonstrar,\r\ntodos os impares ate chegar no mesmo: ");
            int numRef = int.Parse(Console.ReadLine());
            
            /* Saída */
            Console.WriteLine("\r\nNumero impares de 1 ate {0}: ",numRef);

            /* Processamento */
            for (int i = 1; i <= numRef; i++)
            {
                if (i % 2 != 0)
                {
                    /* Saída */
                    Console.WriteLine(i);
                }
            }
            
            
            
            /* ------ Exercício 2 ------ */
            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
            mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para 
            fora do intervalo).                                        */

            /* Entrada */
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

            Console.WriteLine("\r\nBaseado nos numeros inseridos, {0} estao dentro do intervalo entre 10 e 20,\r\ne {1} estao fora do intervalo!",dentro,fora);
            
        }
    }
}