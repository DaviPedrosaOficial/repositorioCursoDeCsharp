using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

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


