/* ------ Palavra this ------ */

namespace CursoDeCsharp
{
    class Aula4_Cap3
    {
        /* ------ O que é a palavra this? ------
         
          A palavra this é uma referência ao próprio objeto, ou seja, uma maneira de identificar para o compilador que 
         o nome passado como parâmetro é um atributo daquela classe.
         
          Vale salientar que, o uso da palavra this é mais utilizado na linguagem Java, pois em C#, utilizamos uma 
         nomenclatura diferente para atributos (letra Maiúscula) e para parâmetros (letra Minúscula), fazendo com
         que o compilador já entenda quem é quem.
         
         Exemplo (demonstrando nomenclatura utilizada): 
         
         public class Produto{
         
            public string Nome;
            
            public Produto (string nome){
                Nome = nome;
            }
         
         Exemplo (demonstrando como seria se não utilizassemos a nomenclatura correta):
         
         public class Produto{
         
            public string nome;
            
            public Produto (string nome){
                this.nome = nome;
            }
            
         Outro fator que pode nos ajudar, quando tratamos da palavra this, é a utilização da mesma para reutilizar 
        partes de outros construtores. Ou seja, ao invés de termos de ficar reescrevendo todas as interações em
        em diferentes construtores, podemos utilizar a palavra this para reutilizar o código de outros contrutores
        para completar seus parâmetros.
        
         Veja a seguir a implementação:
         
         public class Produto{
         
            public string Nome;
            public double Preco;
            public int Quantidade;
            
            public Produto {
                Quantidade = 0;
            }  
            
            public Produto (string nome, double preco) : this(){
                Nome = nome;
                Preco = preco;
            }
            
            public Produto (string nome, double preco, int quantidade) : this (nome,preco){
                Quantidade = quantidade;
            }
            
         Note que, economizamos linhas de código e tempo, já que a palavra this nos permitiu utilizar as linhas de 
        outros construtores para completar o que estamos desenvolvendo.
        
        E por ultimo, a palavra this nos permite também, que passemos o próprio objeto como um argumento na chamada 
        de um metodo ou construtor.
        
        Mas para demonstrar o mesmo, esperaremos o decorrer de nosso curso, para que possamos entender melhor a sua 
        funcionalidade!                                                                                          */
        
    }
}