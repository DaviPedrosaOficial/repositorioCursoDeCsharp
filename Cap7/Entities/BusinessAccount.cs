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
    }
}