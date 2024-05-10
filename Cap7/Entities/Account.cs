/* Classe criada para exemplificar o conceito de Herança (Aula1) */

namespace CursoDeCsharp.Cap7.Entities
{
    class Account
    {
        public int Number { get; protected set; } /* A chamada protected, permitirá que somente a superclasse e suas subclasses
        fazer alterações naqueles tópicos que desejamos. Isso é importante, principalmente nesse nosso exemplo, pois, imagine que
        fossemos utilizar o private.
         Com o mesmo, se na subclasses BusinessAccount desejassemos fazer uma alteração em nosso Balance por exemplo, não seria
        permitido, o mesmo ocorreria para outras classes quaisquer que não fossem do mesma familia.
         Mas o desejado, em nosso caso, seria classes e subclasses da mesma familia pudessem fazer tais operações e outras classes
        que não fossem da mesma familia não pudessem.
         Então, para essa função, utilizamos o protected, que tem como característica, possibilitar exatamente o que descrevemos a-
        cima. */
        public string Holder { get; protected set; }
        public double Balance { get;  protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }
    }
}