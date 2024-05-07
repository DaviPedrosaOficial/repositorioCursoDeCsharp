/* ------ Tipos referência vs tipos valor ------ */

using CursoDeCsharp.Cap4.Classes;

namespace CursoDeCsharp.Cap4.Aulas
{
    
    class Aula1_Cap4{

        static void _Aula1_Cap4(string[] arg)
        {
            /* ---------- Tipos referência -----------
             
              Para começarmos essa aula vamos fazer uma declaração, "Classes são tipos referências"!
             
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
             
              Isso, reflete também na forma em que o compilador veria a seguinte operação, baseado no exemplo acima:
             
              p2 = p1
             
              O que ocorre quando fazemos a variável de um objeto receber outra variável objeto, é a copia do ponteiro de
             referência de p1 para p2, ou seja, nada foi criado ou instanciado, o que esta ocorrendo é que a partir do 
             comando, a variável p2, copiará e armazenará em sua variável, o ponteiro de referência (coordenadas) do 
             objeto de p1;
             
             E é por isso, que afirmamos que classes são variáveis referência!
             
             ------ Valor "null" ------
             
              Tipos referência, aceitam o valor null, o que significará para o compilador que aquela variável não esta 
             apontando para ninguem! Ou seja, não tem coordenada dentro da mesma.
             
             
             ----------- Tipos valor -----------
             
              Os "structs" são na prática as "caixas" que imaginamos para armazenamento, sendo assim, considerados os tipos
             valor. Uma vez que, os mesmos armazenam valores dentro de suas variáveis, ao invés de referências.
             
              E quem são eles?
             
              Structs são os tipos que usamos como prefixos em nosso código para definirmos variáveis, como double, int,
             string, char ...
             
              Então quando criamos variáveis de tipo valor, o que ocorre é uma alocação de um valor dentro de uma "caixa"
             (espaço de nossa memória) em "Stack" (parte da memória). Sendo assim, veja no exemplo a seguir a diferença 
             entre os tipos valores quando fazemos uma variável receber o valor de outra:
             
             double x , y;
             
             x = 20;
             
             y = x;
             
              Quando fazemos essa operação com tipos valor, o que esta de fato acontecendo é uma cópia do valor alocado na
             variável x, sendo repassada para a variável y, e não uma cópia de uma coordenada que apontará para um objeto! 
               
              Além disso, é possível criarmos nossos próprios tipos valor!
             
              Para isso, utilizamos a mesmas norma de criação de classes, mas ao invés de colocarmos o prefixo class, 
             utilizaremos o struct. (Foi criado o struct Ponto, para demonstrar)
              O struct opera da mesma maneira da classe, porém, sem alguns de seus recursos, e com o comportamento de 
             memória igual ao que foi descrito acima. Além disso, ao inicializarmos um struct em outra classe teremos de 
             chamá-lo, porém, poderemos ou não instanciá-lo!
             
             Veja a seguir sua implementação:                                                                        */

            /* Repare que não foi necessário instanciá-lo para utilizarmos o struct Ponto */
            Ponto p1;

            p1.X = 10;
            p1.Y = 20;

            Console.WriteLine("P1");
            Console.Write(p1);
            Console.WriteLine();

            /* Mas é possível também, instanciá-lo */
            Ponto p2 = new Ponto();

            Console.WriteLine("P2");
            Console.Write(p2);
            
            /* ----------- Bônus -----------
             ------ Valores padrões ------
             
              Quando alocamos (new) qualquer tipo estruturado (classe, struct, array), são atribuídos valores padrões
             aos seus elementos.
             
             Exemplo dos valores:
             - númericos => 0;
             - bool => False;
             - char => caractere código 0 (Não significa que sera 0, mas sim o caractere de código 0)
             - objeto => null;
             
              Lembrando: uma variável apenas declarada, mas não instanciada, inicia em estado "não atribuída", onde o 
             próprio compilador não permitirá que a mesma seja acessada.                                              */
        }
    }
}
