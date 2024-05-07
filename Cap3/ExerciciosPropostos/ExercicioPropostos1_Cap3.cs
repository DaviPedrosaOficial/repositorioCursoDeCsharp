/* ------ Exercícios propostos 1 ------ */

using System.Threading.Channels;
using CursoDeCsharp.Cap3.Classes;

namespace CursoDeCsharp.Cap3.ExerciciosPropostos
{
    class ExercicioPropostos1_Cap3
    {
        static void Ex_propostos1(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
            titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. 
            Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar
            no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, 
            naturalmente, zero.

            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. 
            Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo). 

            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso.
            O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. 
            Para cada saque realizado, o banco cobra uma taxa de $ 5.00. 
            Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.

            Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado
            o valor de depósito inicial. 
            Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.  */

            Banco novoCliente;
            
            Console.Write("Insira a seguir, o nome do titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Agora, insira o numero que a sua conta terá: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Sua conta tera deposito inicial? (Utilize s/n para a resposta): ");
            string consulta = Console.ReadLine().ToLower();
            double depInicial = 0;

            if (consulta == "s" || consulta == "sim")
            {
                Console.Write("Então, insira a seguir o valor do deposito inicial: ");
                depInicial = double.Parse(Console.ReadLine());
                novoCliente = new Banco(nome, num, depInicial);
            }
            else
            {
                novoCliente = new Banco(nome, num);
            }


            Console.WriteLine();
            Console.WriteLine(novoCliente);

            Console.Write("\r\nAgora insira um valor para depositar em sua conta: ");
            novoCliente.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(novoCliente);

            Console.Write("E por fim, insira um valor para ser sacado de sua conta: ");
            novoCliente.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados!");
            Console.WriteLine(novoCliente);
        }
    }
}