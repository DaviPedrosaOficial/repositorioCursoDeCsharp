/* ------ Exercícios propostos 2 ------ */

using System;
using System.Threading.Channels;

namespace CursoDeCsharp
{
    class ExercicioPropostos_2
    {
        static void Main(string[] arg)
        {
            /* ------ 1º Exercício ------ */
            /* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. */

            /* Entrada */
            Console.WriteLine("------ Exercicio 1 ------");
            Console.WriteLine("Insira a seguir um numero inteiro de sua escolha, e diremos se ele e positivo ou negativo: ");
            int numPosNeg = int.Parse(Console.ReadLine());
            
            /* Processamento & saída */
            if (numPosNeg >= 0)
            {
                Console.WriteLine("O numero {0} e positivo!",numPosNeg);
            }
            else
            {
                Console.WriteLine("O numero {0} e negativo!",numPosNeg);
            }
            
            
            
            /* ------- Exercício 2 ------- */
            /* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 2 ------");
            Console.WriteLine("Insira a seguir um numero inteiro de sua escolha, e diremos se ele e par ou impar: ");
            int numParImp = int.Parse(Console.ReadLine());
            
            /* Processamento & saída */

            if (numParImp % 2 == 0)
            {
                Console.WriteLine("O numero {0} e par!", numParImp);
            }
            else
            {
                Console.WriteLine("O numero {0} e impar!",numParImp);
            }
            
            
            
            /* ------ Exercício 3 ------ */
            /* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser 
            digitados em ordem crescente ou decrescente. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 3 ------");
            Console.WriteLine("Nesse exercicio, precisaremos de 2 numeros inteiros para calcularmos se os mesmos sao");
            Console.WriteLine("multiplos de entre si. \r\nDigite a seguir o primeiro numero: ");
            int numMult1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo numero: ");
            int numMult2 = int.Parse(Console.ReadLine());

            /* Processamento & saída */
            if (numMult1 > numMult2)
            {
                if (numMult1 % numMult2 == 0)
                {
                    Console.WriteLine("\r\nO numero {0} e multiplo de {1} !",numMult1,numMult2);
                }
                else
                {
                    Console.WriteLine("\r\nO numero {0} nao e multiplo de {1} !",numMult1,numMult2);
                }
            }
            else if (numMult1 == numMult2)
            {
                Console.WriteLine("\r\nOs numeros sao iguais, e por isso nao sao multiplos!");
            }
            else
            {
                if (numMult2 % numMult1 == 0)
                {
                    Console.WriteLine("\r\nO numero {0} e multiplo de {1} !",numMult2,numMult1);
                }
                else
                {
                    Console.WriteLine("\r\nO numero {0} nao e multiplo de {1} !",numMult2,numMult1);
                }
            }
        }
    }
}