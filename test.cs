using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            Quarto[] pensao = new Quarto[10];
            /* Criando vetor para armazenar os 10 quartos da pensão */

            Console.Write("Insira a seguir a quantidades de quartos que serao alugados: ");
            int qtdAluguel = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAluguel; i ++){
                Console.Write("Insira a seguir o nome do {0}º estudante: ", i + 1);
                string nome = Console.ReadLine();
                Console.Write("Agora, insira o e-mail do estudante: ");
                string email = Console.ReadLine();
                Console.Write("E por fim, insira o numero do quarto que deseja alugar: ");
                int numero = int.Parse(Console.ReadLine());

                pensao[numero - 1] = new Quarto (numero,nome,email);
            }

        Console.WriteLine("\r\n---------- Relatorio de alugueis ----------");

            for (int i = 0; i < 9; i++){
                if(pensao[i] != null){
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("QUARTO Nº: {0}", i + 1);
                    Console.WriteLine("NOME DO ESTUDANTE: {0}", pensao[i].Nome);
                    Console.WriteLine("E-MAIL DO ESTUDANTE: {0}", pensao[i].Email);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("QUARTO Nº: {0}", i + 1);
                    Console.WriteLine("QUARTO VAGO!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
            }
        }
    }
}


