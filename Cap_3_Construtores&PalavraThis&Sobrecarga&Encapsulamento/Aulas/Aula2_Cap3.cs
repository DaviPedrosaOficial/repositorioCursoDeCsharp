/* ------ Sobrecarga ------ */

using System;
using System.Threading.Channels;

namespace CursoDeCsharp
{
    class Aula2_Cap3
    {
          static void _Aula2_Cap3(string[] arg)
          {
         /* ------ O que é sobrecarga? ------

            Sobrecarga é um recurso que uma classe possui, que lhe permite oferecer mais de uma operação utilizando o mesmo
           nome, porém, utilizando diferentes parâmetros.

            Esse recurso é muito utilizado, na orientação à objetos, principalmente na implementação de construtores, já que
           dependendo da situação e da classe, pode ser que uma hora, seja necessário uma instanciação de uma maneira, e em
           outrora, seja mais otimista instanciar de outra forma.

            Pense por exemplo em um estoque, que é formado por uma lista de objetos da classe Produto.
            Em determinado momento, podemos instanciar um produto para inserir no estoque com todas os seus atributos, como
           por exemplo, .Nome , .Preco, .Quantidade ... Porém, imagine que um produto está para chegar ao estabelecimento,
           mas o funcionário já esta fazendo a adição do mesmo ao estoque, devido a solicitação de seus superiores.
            Tendo isso em mente, podemos notar que a quantidade não poderá ser inserida, uma vez que o produto não chegou,
           o que deixaria assim, o programa defícitario, já que sem as sobrecargas, o funcionário não conseguiria instanciar
           o produto.

            Vale dizer que, o exemplo acima é somente hipotético, já que, o funcionário, poderia inserir quantidade como "0"
           que o programa rodaria. Mas para que possamos notar o conceito, é importante que tenhamos um exemplo, mesmo que
           hipotético!

            Bônus: Além de construtores customizados, é possível também, criar o construtor padrão, para que possamos criar
           objetos do meio tradicional. Vamos vê-lo na classe criada.                                                  */


           /* Para a demonstração foi criada a classe Produto2, e criaremos 3 objetos diferentes para demonstrar diferentes
           sobrecargas. */

           
           
           /* Instanciando no modo padrão */
           Produto2 pera = new Produto2();
           
           /* Instanciando com todos os atributos */
           Produto2 abacaxi = new Produto2("Abacaxi",3.90,10);
           
           /* Instanciando com apenas nome e preço */
           Produto2 uva = new Produto2("Uva",2.90);
           
           /* Como esperado, após criarmos, as sobrecargas em nossa classe, todas as instanciações que lá foram delcaradas
            estão funcionando, e permitindo que instanciemos nosso objeto da maneira que acharmos melhor.
            
            Para vermos a diferença do resultado de cada uma, vamos chamar nossa função ToString, para printá-los em nossos
            terminais.  */

           Console.WriteLine(pera);
           Console.WriteLine();

           Console.WriteLine(abacaxi);
           Console.WriteLine();

           Console.WriteLine(uva);
           
          }
    }
}

