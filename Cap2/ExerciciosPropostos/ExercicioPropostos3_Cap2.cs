/* ------ Exercícios propostos 3 ------ */

using CursoDeCsharp.Cap2.Classes;

namespace CursoDeCsharp
{
    class ExercicioPropostos3_Cap2
    {
        static void Ex_Propostos3(string[] arg)
        {
            /* Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa
            em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que
            pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos. */

            Console.Write("Insira a seguir a cotacao do dolar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a quantia na qual voce deseja comprar do mesmo: ");
            double qtdCompra = double.Parse(Console.ReadLine());

            Console.WriteLine("Na cotacao de R${0:F2} do Dolar, para comprar ${1:F2},",cotacao,qtdCompra);
            Console.WriteLine("Voce devera pagar R${0:F2}",ConversorDeMoeda.Conversao(cotacao,qtdCompra));
        }
    }
}

