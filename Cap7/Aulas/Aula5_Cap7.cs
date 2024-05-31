/* ------ Polimorfismo ------ */
using CursoDeCsharp.Cap7.Entities;

namespace CursoDeCsharp.Cap7.Aulas
{
    public class Aula5_Cap7
    {
        public void _Aula5_Cap7(string [] arg)
        {
            /* O que é polimorfismo?
            
            Polimorfismo esta relacionada a capacidade de utilizarmos classes genéricas para armazenarmos objetos de suas
            subclasses. Para ficar mais facil de entendermos, vamos buscar exemplo com os quais trabalhamos em nosso capítu-
            lo:                                                                                                          */

            Account acc1 = new BusinessAccount(001, "Marcelo", 100, 1500);
            Account acc2 = new SavingsAccount(002, "Maria", 100, 0.1);

            /* Durante nosso capítulo, utilizamos diversas vezes a instanciação acima, e podemos dizer que a mesma é uma
            excelente demonstração do polimorfismo! Podemos ver que na instanciação temos a classe Account, armazenando as
            informações de nossas subclasses SavingsAccount & BusinessAccount.
            
             O processo é de grande auxílio na otimização, organização e segurança de para nossas classes e heranças.  */

            acc1.Withdraw(30.00);
            acc2.Withdraw(30.00);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            /* Um dos motivos pelos quais a polimorfia é de extrema importância para a programação é o demonstrado acima.
            Quando observamos nossas subclasses de Account, podemos notar que ambas possuem, maneira diferentes de executar
            o método Withdraw(), e ao chamarmos o mesmo, por mais que as contas estão armazenadas em um tipo "generico"
            (Account), quando o mesmo é rodado, a operação ocorre de acordo com sua subclasse.                           */
        }
    }
}