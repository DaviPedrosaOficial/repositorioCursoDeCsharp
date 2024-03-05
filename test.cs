using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("Bem vindo a somador de inteiros!");
            Console.Write("Insira a seguir a quantidade de numeros que voce deseja inserir: ");
            int nums = int.Parse(Console.ReadLine());
            /* Repare que estamos solicitando quantos números serão adicionados, ou seja, temos uma noção prévia de quantas
             vezes teremos de executar o loop */

            int soma = 0;
            for (int i = 1; i <= nums; i++)
            {
                Console.Write("Digite o #{0}: ",i);
                int x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine("Soma = {0}",soma);
        }
    }
}


