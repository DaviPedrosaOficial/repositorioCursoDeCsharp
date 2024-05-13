/* Classe criada para exemplificar o conceito de Herança (Aula1) */

namespace CursoDeCsharp.Cap7.Entities
{
    /* O sinal de ':' demonstra que a classe BusinessAccount herdará a classe Account, ou seja, o sinal que demonstra
    herança é o ':' ! */
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance) /* Reaproveitando contrutor da classe Account */
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                LoanLimit -= amount;
                Balance += amount;
            }
        }

        /* (Aula 3 - Sobreposição) Para chamarmos a sobreposição utilizamos o prefíxo override, e assim dentro dos parênteses des-
        crevemos como queremos que nosso método seja executado nos objetos da Subclasse.
         Para realizamos o override podemos utilizar duas nomenclaturas, onde poderemos utilizar a palavra "base", que como já vimos
        ao utilizarmos a herança, reutiliza métodos, atributos de Superclasses. Ou fazermos de forma manual, como a descrita abaixo.
         O método da classe SavingsAccount, utilizará o base!
         Cheque-o para melhor compreensão.                                                                                        */
        public override void Withdraw(double amount)
        {
            Balance -= amount + 1.0;
        }
    }
}