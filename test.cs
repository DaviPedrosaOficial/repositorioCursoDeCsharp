using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
             Console.Write("Insira a seguir a quantidade de pessoas que voce deseja calcular a media de altura: ");
            int nPessoas = int.Parse(Console.ReadLine());

            /* Criando um vetor (Para isso utilizamos "[]") */
            double[] altura = new double[nPessoas];
            /* Repare que foi colocado a variável nPessoas dentro do segundo [], que determina o tamanho que será o nosso
            vetor */

            /* Inserindo as alturas no vetor */
            for (int i = 0; i < nPessoas; i++){
                Console.Write("Insira a altura da {0}ª pessoa: ", i + 1);
                altura[i] = double.Parse(Console.ReadLine());
            }

            double totalAlturas = 0;

            for (int i = 0; i < nPessoas; i++){
                totalAlturas += altura[i];
            }

            double mediaAlt = totalAlturas / nPessoas;

            Console.WriteLine();
            Console.WriteLine("MEDIA DE ALTURA: {0:F2}", mediaAlt);
        }
    }
}


