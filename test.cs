using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Console.Write("Insira a seguir, o nome de quem sera o titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Agora, insira o numero que a sua conta terá: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Sua conta tera deposito inicial? (Utilize s/n para a resposta): ");
            string consulta = Console.ReadLine().ToLower();
            double depInicial = 0;

            if (consulta == "s" || consulta == "sim")
            {
                Console.Write("Então insira a seguir o valor do deposito inicial: ");
                depInicial = double.Parse(Console.ReadLine());
            }

            Banco novoCliente = new Banco(nome, num, depInicial);

            Console.WriteLine();
            Console.WriteLine(novoCliente);

            Console.Write("\r\nAgora insira um valor para depositar em sua conta: ");
            novoCliente.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(novoCliente);

            Console.WriteLine();
            Console.Write("E por fim, insira um valor para ser sacado de sua conta: ");
            novoCliente.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(novoCliente);
        }
    }
}


