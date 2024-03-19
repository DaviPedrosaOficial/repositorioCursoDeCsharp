/* ------ Tipos referência vs tipos valor ------ */

namespace CursoDeCsharp{
    
    class Aula1_Cap4{

        static void _Aula1_Cap4(string[] arg)
        {
            /* Para começarmos essa aula vamos fazer uma declaração, "Classes são tipos referências"!
             
              Isso ocorre, pois, variáveis do tipo classe não funcionam como "caixa", ou seja, sua função principal não
             é armazenar algo em tal variável, mas sim, armazenar o ponto de referência (o caminho para encontrar) seu 
             objeto instanciado, que ai sim, terá algo parecido à caixas para armazenar seus atributos. 
             
              Para ficar mais claro, vamos dissertar sobre a afirmação acima:
             
              Quando criamos uma classe e chamamos a mesma em nossa main através de sua variável, por exemplo:
             
              Produto p1, p2;
             
              O que ocorre, é que em uma parte da sua memória, chamada "Stack" será criada apenas uma variável para armazenar
             as coordenadas de nosso objeto quando o mesmo for instanciado. Ou seja, quando executarmos o comando
             "p1 = new Produto ()", as "caixinhas" que armazenarão os nossos atributos serão criadas em outra parte de 
             nossa memória chamada "Heap", e nossa variável criada antes no stack, terá as coordenadas para que nosso 
             compilador encontre nossos atributos em Heap! Como uma espécie de ponteiro.
             
               */
        }
    }
}