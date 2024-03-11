/* ------ Exercícios propostos 2 ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioPropostos2
    {
        static void Ex_Propostos2(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o
             valor de sua área, perímetro e diagonal. Usar uma classe para o retângulo.               */

            Retangulo x = new Retangulo();

            Console.WriteLine("Bem vindo ao calculador de retangulos!");
            Console.Write("Insira a seguir a altura de seu retangulo: ");
            x.Altura = double.Parse(Console.ReadLine());
            Console.Write("Agora, insira a seguir a largura do mesmo: ");
            x.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nEntão vamos ao resultado!");
            Console.WriteLine(x);
        }
    }
}