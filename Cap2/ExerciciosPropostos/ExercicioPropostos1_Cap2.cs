/* ------ Exercícios propostos 1 (capítulo 2) ------ */

using System;
using CursoDeCsharp.Cap2.Classes;

namespace CursoDeCsharp
{
    class ExercicioPropostos1_Cap2
    {
        static void Ex_Propostos1(string[] arg)
        {
            /* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
             (utilizando orientação à objeto) */
            /* Para a execução do exercício foi criada a classe Pessoa */

            Console.WriteLine("------ Exercicio 1 ------");
            Console.WriteLine("Nesse exercicio descobriremos quem é a pessoa mais velha, a partir dos dados inseridos.");

            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();
            
            /* Entrada */
            Console.Write("Entao para comecarmos, insira a seguir o nome da 1ª pessoa: ");
            a.Nome = Console.ReadLine();
            Console.Write("Agora, insira sua idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.Write("Agora, insira o nome da 2ª pessoa: ");
            b.Nome = Console.ReadLine();
            Console.Write("E para finalizarmos, insira sua idade: ");
            b.Idade = int.Parse(Console.ReadLine());
            
            /* Processamento */
            if (a.Idade == b.Idade)
            {
                /* Saída */
                Console.WriteLine("\r\n{0} e {1} tem a mesma idade!",a.Nome,b.Nome);
            }
            else if (a.Idade > b.Idade)
            {
                /* Saída */
                Console.WriteLine("\r\n{0} é mais velho(a) que {1}!",a.Nome,b.Nome);
            }
            else
            {
                /* Saída */
                Console.WriteLine("\r\n{0} é mais velho(a) que {1}!",b.Nome,a.Nome);
            }
            
            
            
            
            /* ------ Exercício 2 ------ */
            /* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos
             funcionários. (utilizando orientação à objeto) */

            Console.WriteLine("\r\n------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo a media salarial, o programa no qual verificaremos a media salarial entre ");
            Console.WriteLine("funcionarios de uma empresa!");

            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();
            
            /* Entrada */
            Console.Write("\r\nPara comecarmos, insira o nome do 1º funcionario: ");
            x.Nome = Console.ReadLine();
            Console.Write("Agora, insira o salario do mesmo: ");
            x.Salario = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira o nome do 2º funcionario: ");
            y.Nome = Console.ReadLine();
            Console.Write("E para finalizarmos, insira a seguir o salario do mesmo: ");
            y.Salario = double.Parse(Console.ReadLine());
            
            /* Processamento */
            double media = (x.Salario + y.Salario) / 2;
            
            /* Saída */
            Console.WriteLine("\r\nA media salarial da empresa é de R${0:F2}",media);
        }
    }
}