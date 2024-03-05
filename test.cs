using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("Digite um numero para que possamos lhe voltar sua raiz quadrada: ");
            double numCliente = double.Parse(Console.ReadLine());
            while (numCliente >= 0)
            {
                double raizCliente = Math.Sqrt(numCliente);
                Console.WriteLine("A raiz quadrada de {0:F2} é {1:F2} !",numCliente,raizCliente);
                Console.WriteLine("\r\nInsira outro numero para calcularmos sua raiz quadrada: ");
                numCliente = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("O numero inserido é negativo!");
        }
    }
}


