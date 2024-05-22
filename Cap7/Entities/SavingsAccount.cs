namespace CursoDeCsharp.Cap7.Entities
{
    /* (Aula 4 - Sealed) Para chamarmos o selamento devemos colocar o prefíxo sealed. */
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdadeBalance()
        {
            Balance += Balance * InterestRate;
        }

        /* (Aula 4 - Sealed) Já para métodos, quando se trata de selamento, devemos nos salientar que, para que o processo possa
        ocorrer, o método tem de ser uma Sobreposição (Aula 3), para que possamos chamar o prefíxo sealed. Ou seja, so podemos se-
        lar um método se o mesmo já foi sobrescrito! */
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 1.0;
        }
    }
}