/* Classe criada para auxiliar a aula 4 */

namespace CursoDeCsharp.Cap7.Entities
{
    /* Como podemos ver, utilizamos a classe BusinessAccount, que é uma Subclasse da classe Account, e agora passou a
    ser uma Superclasse da BusinessAccountPlus, comprovando que classes podem ser ao mesmo tempo Superclasse e Subclasse. */
    class BusinessAccountPlus : BusinessAccount
    {
        public double Exemption {get; set;}

        public BusinessAccountPlus()
        {
        }

        public BusinessAccountPlus(int number, string holder, double balance, double loanLimit, double exemption)
        : base(number, holder, balance, loanLimit)
        {
            Exemption = exemption;
        }

        /*
        Abaixo esta o método Withdraw, no qual selamos em nossa classe BusinessAccount, e se você tentar tirá-lo do comentario
        poderá verificar que o mesmo não pode ser utilizado, e o próprio compilador descreverá que a operação não pode ser feita
        já que o método foi selado em sua Superclasse BusinessAccount!

        public override void Withdraw(double amount)
        {
            Balance -= amount + 1.0;
        }

        */
    }
}