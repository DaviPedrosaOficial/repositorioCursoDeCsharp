/* Classe criada para exemplificar o conceito de Herança (Aula1) */

namespace CursoDeCsharp.Cap7.Entities
{
    class Account
    {
        /* (Aula 1 - Herança) A chamada protected, permitirá que somente a superclasse e suas subclasses
        façam alterações naqueles tópicos que desejamos. Isso é importante, principalmente nesse nosso exemplo, pois, imagine que
        fossemos utilizar o private.
         
         Com o mesmo, se na subclasses BusinessAccount desejassemos fazer uma alteração em nosso Balance por exemplo, não seria
        permitido, o mesmo ocorreria para outras classes quaisquer que não fossem da mesma familia.
         
         Em nosso caso, seria interessante classes e subclasses da mesma familia pudessem fazer tais operações e outras classes
        que não fossem da mesma familia não pudessem, dando assim, mais segurança ao realizar os métodos.
         
         Então, para essa função, utilizaremos o protected, que tem como característica, possibilitar exatamente o que descrevemos a-
        cima. */
        public int Number { get; protected set; }
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

        /* (Aula 3 - Sobreposição) Ao utilizarmos o virtual em nosso método, o mesmo passa a poder ser sobrescrito.
        Ou seja, a partir de agora, podemos alterá-lo nas Subclasses da nossa classe Account.                    */
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }
    }
}