using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
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


