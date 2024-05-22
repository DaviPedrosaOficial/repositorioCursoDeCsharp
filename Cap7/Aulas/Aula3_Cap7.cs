/* ------ Sobreposição ou Sobrescrita ------ */

using CursoDeCsharp.Cap7.Entities;

namespace CursoDeCsharp.Cap7.Aulas
{
    public class Aula3_Cap7
    {
        public void _Aula3_Cap7(string [] arg)
        {
            /* ------ O que é Sobreposição? ------
            
            Sobreposição ou sobrescrita é uma maneira que temos de utilizarmos um método de uma Superclasse, de outra forma em
            suas Subclasses. Ou seja, fazer com que o método seja sobrescrito.
            
            Nas classes que criamos até aqui nesse capítulo foi sobreposto o método WithDraw, e aqui os executaremos para que
            possamos ver a diferença entre eles, após efetuada a sobreposição.
            
            Antes de olhar a execução dos métodos, veja a sua execução nos arquivos Account.cs, BusinessAccount.cs, SavingsAccount.cs.
            
            Agora vamos vê-los na prática:                                                                                   */

            Account acc = new Account(001, "Gustavo", 900.0);
            Account acc1 = new BusinessAccount(002, "Maria", 900.0, 1500.0);
            Account acc2 = new SavingsAccount(003, "Bruna", 900.0, 0.01);

            /* Agora que instanciamos nossos objetos, vamos executar o método Withdraw em cada um deles, para que possamos ver a di-
            ferença do resultado em cada um deles:                                                                                */
        
            acc.Withdraw(60.0);
            acc1.Withdraw(60.0);
            acc2.Withdraw(60.0);

            Console.WriteLine($"Valor na conta de todos antes da execução do método Withdraw: R$ 900,00");
            Console.WriteLine($"Resultado do método na Superclasse Account: R${acc.Balance:F2}\r\n");
            Console.WriteLine($"Resultado do método na Subclasse BusinessAccount: R${acc1.Balance:F2}\r\n");
            Console.WriteLine($"Resultado do método na Subclasse SavingsAccount: R${acc2.Balance:F2}\r\n");
        }
    }
}