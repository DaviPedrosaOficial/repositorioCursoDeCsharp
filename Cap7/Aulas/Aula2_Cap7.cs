/* Upcasting e Downcasting */

using CursoDeCsharp.Cap7.Entities;

namespace CursoDeCsharp.Cap7.Aulas
{
    public class Aula2_Cap7
    {
        public void _Aula2_Cap7(string [] arg)
        {
            /* Quando trabalhamos com herança podemos nos deparar com situações nas quais precisaremos transformar objetos
            de Superclasses em objetos de Subclasses e vice-versa.

            Para isso utilizamos o Upcasting e o Downcasting!

            --- Upcasting ---
            O Upcasting é o processo, alocamos um objeto de uma Subclasse em uma variável da sua Superclasse. E esse processo
            ocorre perfeitamente, e da maneira na qual apresentaremos abaixo:                                              */

            Account acc = new Account(001, "Jose", 0.0);
            BusinessAccount bacc = new BusinessAccount(002, "Leonardo", 1350, 0.01);

            /* Agora que instanciamos nossas contas, vamos fazer o Upcasting */

            Account acc1 = bacc;

            /* Note, que não tivemos problemas ao fazermos a Account acc1, receber uma subclasse. Isso se deve a subclasse Business-
            Account ser uma Account, portanto nosso compilador aceita o processo tranquilamente.

            Além disso, podemos até mesmo instanciar uma Subclasse dentro de uma Superclasse, veja a seguir:                      */

            Account acc2 = new BusinessAccount(003, "Jorge", 15500.89, 1500);
            Account acc3 = new SavingsAccount(004, "Paula", 150.25, 0.2);

            /* --- Downcasting ---
            O Downcasting é o processo contrario, onde passamos uma Superclasse para uma Subclasse, porém, o mesmo é considerado uma
            operação insegura, uma vez que podemos ter erros ao na transição de classes. Isso se deve ao fato de que, em diferentes
            ocasiões podemos tentar passar Subclasses para outras Subclasses dando erro na execução, ou até mesmo ao tentarmos fazer
            uma Superclasse se tornar uma Subclasse, sem que o objeto que esteja na mesma seja compativel.

            Ou seja, para que o processo ocorra corretamente, é necessário que a variável da Superclasse, possua um objeto da Subclasse
            que desejamos fazer a transição instanciado dentro da mesma.
            
            Mas vamos ver as seguir como o mesmo funciona:                                                                         */

            BusinessAccount bacc2 = (BusinessAccount)acc2;
            bacc2.Loan(150.0);

            /* Repare que após aplicarmos, o Downcasting, nos passa a ser permitido utilizar até mesmo as funções de nossa Subclasse. */

            BusinessAccount bacc3 = acc2 as BusinessAccount;

            /* Note que se tentassemos criar uma variável: BusinessAccount bacc4 = (BusinessAccount)acc3 , nosso compilado aceitaria,
            porém ao executarmos o programa, o mesmo daria erro, já que dentro de acc3, existe uma subclasse de SavingsAccount, que
            por mais que seja uma subclasse de Account, não é compativel com BusinessAccount, dando assim erro.
            
            Então para que possamos executar o Downcasting, de forma segura, é necessario criar condicionais para que seja verificado
            se a transição esta apta, veja abaixo:                                                                                 */

            if (acc3 is BusinessAccount)
            {
                BusinessAccount bacc4 = acc3 as BusinessAccount;
                Console.WriteLine("Aceito acc3 como BusinessAccount!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount sacc1 = acc3 as SavingsAccount;
                Console.WriteLine("Aceito acc3 como SavingsAccount!");
            }
        }
    }
}