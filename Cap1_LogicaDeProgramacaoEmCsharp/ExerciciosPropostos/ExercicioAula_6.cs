/* ------ Exercício de fixação ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioAula_6
    {
        static void Ex_Aula6(string[] arg)
        {
            /* Entrada */
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\r\nQuantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("\r\nEntre com o preco de um produto: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("\r\nEntre seu ultimo nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string sobrenome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2]);
            
            /* Saída */
            Console.WriteLine("\r\nNome : {0}\r\nQuartos em casa: {1}\r\nPreço do produto: {2:F2}\r\nSobrenome: {3}\r\nIdade: {4}\r\nAltura: {5:F2}",nome,quartos,preco,sobrenome,idade,altura);
        }
    }
}