/* ------ Enumerações (enum) ------ */

using CursoDeCsharp.Cap6.Aulas.Entities;
using CursoDeCsharp.Cap6.Aulas.Entities.Enums;

namespace CursoDeCsharp
{
    class Aula1_Cap6
    {
        static void _Aula1_Cap6(string [] arg)
        {
            /* ------ O que são as enumerações? ------

            Enumerações são um tipo especial que servem para especificar de forma literal um conjunto de constan-
            tes relacionadas.

            Sua palavra chave no C# é a: enum
            Sendo que enum é um tipo VALOR, como já vimos anteriormente, e não um tipo REFERÊNCIA.

            As vantagens de se usar o enum contam com:
            - Melhor sêmantica
            - Código mais legível
            - Auxiliado pelo compilador

            Para que haja uma melhor compreesão sobre a importância da enumeração, imagine o seguinte cenário:

            Quando vamos fazer um pedido, o mesmo tem o seguinte ciclo de vida:

            # ==> PENDING PAYMENT ==Billing==> PROCESSING ==Dispatch==> SHIPPED ==Deliver==> DELIVERED ==> #

            Mas a pergunta que fica é como fazemos com que esse processo ocorra em programação, e no nosso caso
            em C#?

            Para isso utilizamos o tipo enum da seguinte forma:

            Imagine que o nosso pedido é uma classe como a descrita a seguir (A classe também será feita dentro
            do diretorio Entities).

            class Order {

            public int Id { get; set; }
            public DateTime Moment { get; set; } (Instante em que o pedido ocorreu)
            public OrderStatus Status { get; set; } (Status do pedido, onde demonstrará sua condição atual)

            }

            Sendo assim, nosso OrderStatus será um tipo que iremos criar para fazer tal demonstração de seu status.
            Veja a seguir como ficará sua execução:

            enum OrderStatus : int {

            Pending Payment = 0,
            Processing = 1,
            Shipped = 2,
            Delivered = 3

            }

            Então, dessa forma, conseguimos especificar de forma formal e auxiliada pelo compilador, quais os possí-
            veis estados de um pedido.


            Agora, após a criação de nossas classes, vamos criar e instanciar nosso pedido:                      */

            Order pedidoTeste = new Order{
                Id = 1010,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(pedidoTeste);
        }
    }
}