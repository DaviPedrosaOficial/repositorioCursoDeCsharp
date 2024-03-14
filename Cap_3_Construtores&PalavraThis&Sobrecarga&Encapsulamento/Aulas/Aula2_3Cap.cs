/* ------ Sobrecarga ------ */

namespace CursoDeCsharp
{
    class Aula2_3Cap
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
         
         */
    }
}

