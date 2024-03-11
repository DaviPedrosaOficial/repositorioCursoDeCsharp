/* ------ Exercícios propostos 2 ------ */

using System;
using System.Threading.Channels;

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

            Console.WriteLine("------ Exercicio 1 ------");
            Console.WriteLine("Bem vindo ao calculador de retangulos!");
            
            Console.Write("Insira a seguir a altura de seu retangulo: ");
            x.Altura = double.Parse(Console.ReadLine());
            
            Console.Write("Agora, insira a seguir a largura do mesmo: ");
            x.Largura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("\r\nEntão vamos ao resultado!");
            Console.WriteLine(x);
            
            
            
            /* ------ Exercício 2 ------ */
            /* Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
             Em seguida, mostrar os dados do funcionário (nome e salário líquido). 
             Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
             afetado pela porcentagem) e mostrar novamente os dados do funcionário.                                   */

            Funcionario2 funcionario = new Funcionario2();

            Console.WriteLine("------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo ao programa de aumento salarial!");
            
            Console.Write("Para prosseguirmos, insira a frente o nome do funcionario: ");
            funcionario.Nome = Console.ReadLine();
            
            Console.Write("Agora, insira seu salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            
            Console.Write("E por fim, insira o valor em impostos que o mesmo paga: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\nConfirmando os dados do funcionario (nome, salario liquido): ");
            Console.WriteLine(funcionario);

            Console.WriteLine("\r\nAgora, para que possamos dar o aumento ao funcionario,");
            Console.Write("insira a seguir a porcentagem na qual o funcionario receberá do mesmo: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("\r\nAumento concedido!");
            Console.WriteLine("Dados atualizados: {0}",funcionario);
        }
    }
}