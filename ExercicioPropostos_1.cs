/* ------ Exercícios propostos 1 ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioPropostos_1
    {
        static void Main(string[] arg)
        {
            /* ------ 1º Exercício ------ */
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números
             com uma mensagem explicativa, conforme exemplos. 
             
             Exemplo:
             Entrada: 10                       Saida: Soma = 30 
                      20                                         */

            Console.WriteLine(" ------ Exercicio 1 ------");
            Console.WriteLine("Insira a seguir 2 numeros de sua escolha que serão somados (somente inteiros): ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("\r\nSoma = {0}",soma);
            
            
            
            /* ------ 2º Exercício ------ */
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste
             círculo com quatro casas decimais conforme exemplos.
             
             Fórmula da área: area = π . raio2
             Considere o valor de π = 3.14159 
             
             Exemplo:
             Entrada: 2,00                     Saída: A = 12.5664
             */

            Console.WriteLine("\r\n ------ Exercicio 2 ------");
            Console.WriteLine("Insira a seguir o valor do raio de um circulo, para que possamos calcular sua area: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double area = pi * (Math.Pow(raio, 2));
            Console.WriteLine("\r\nArea do circulo: {0:F4}",area);
            
            
            
            
            /* ------ 3º Execício ------ */
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença
             do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

            Console.WriteLine("\r\n ------ Exercicio 3 ------");
            Console.WriteLine("Insira a seguir 4 numeros inteiros para que possamos calcular a seguinte formula (A * B - C * D) ");
            
            Console.WriteLine("Insira o primeiro numero: ");
            int num_1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\r\nInsira o segundo numero: ");
            int num_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nInsira o terceiro numero: ");
            int num_3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nInsira o quarto numero: ");
            int num_4 = int.Parse(Console.ReadLine());

            int diferenca = num_1 * num_2 - num_3 * num_4;
            Console.WriteLine("\r\nDiferenca = {0}",diferenca);
            
            
            
            
            /* ------ 4º Exercício ------ */
            

        }
    }
}