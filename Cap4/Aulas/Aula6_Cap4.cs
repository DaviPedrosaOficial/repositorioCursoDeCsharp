/* ------ Modificadores de parâmetros ref e out ------ */

using CursoDeCsharp.Cap4.Classes;

namespace CursoDeCsharp.Cap4.Aulas
{

    class Aula6_Cap4{

        static void _Aula6_Cap4(string []  arg){

            /* Para que servem os modificadores de parâmetros ref e out?
            
             Vamos começar a responder essa pergunta pelo modificador ref.

            ------ Modificador ref ------
            
             Imagine que temos de desenvolver um código robusto no qual nossa Main precisará de uma calculadora
            para resolver uma série de funções. 
            
             Porém, nossos métodos serão resolvidos na classe calculadora, onde nosso estagiário fez a seguinte
            função:
            
            public class Calculadora{

                public static void Triplica (int x){
                    x = x * 3
                }

            }
            
             Da forma na qual a classe foi descrita acima teremos um problema em sua execução, problema esse que vimos
            no decorrer do curso, se tratando de falha na utilização do escopo e funcionamento de mémoria.
            
             Na função desenvolvida pelo estagiário, um numero que entrasse como x em nossa classe, teria vida utíl
            até que o loop da função Triplica terminasse, e quando isso ocorresse, mesmo que o resultado tenha sido
            alcançado, como o método se encerrará, a variável em stack, também terá o mesmo destino. Com isso, o 
            resultado da função Triplica, seria o valor que foi inserido como variável x.
            
             Para que pudessemos receber o valor de forma correta, deveriamos inserir o prefixo ref antes da entrada
            da variável x, ficando da seguinte forma:
            
            public static void Triplica (ref int x){               (foi desenvolvida a função na classe Calculadora2)
                x = x * 3;
            }
            
             Dessa maneira, estamos informando que a variável de entrada é uma referencia, ou seja, ao invés da função
            utilizar, apenas seu valor para executar o procedimento em outra variável, a função passará a utilizar a
            variável como referencia. Sendo assim, tudo que for executado dentro do método utilizando a mesma, modifi-
            cará na própria variável referencia.
            
             Veja como não teriamos problemas ao executar o código com o parâmetro ref:                              */

            int x = 30;
            Calculadora2.TriplicaRef(ref x);
            Console.WriteLine(x);
            /* Algo que devemos levar em conta, é que deveremos inserir também o prefixo em nossa Main, assim como inse-
            rido acima em nosso código.
            
             Sendo assim, podemos afirmar que o modificador ref, como o próprio nome já nos lembra, auxilia na execução de
            nosso código, dando ao mesmo o conceito de refencia aos nossos código, possibilitando que variáveis sejam uti-
            lizadas como parâmetros em nosso métodos e funções.
            
            ------ Modificador out ------
            
             O modificador out, funciona de maneira parecida ao ref, porém, ao utilizarmos o mesmo, teremos uma variável de
            entrada, ou seja, uma variável que vai demonstrar o valor que iniciará o processo, e uma variável que receberá
            o valor ao final do processo. Ou seja, tera um "In" (entrada) & "Out" (saída).
            
             Além disso, na utilização do out, a variável de saída não precisa ser declarada, antes de ser passada como parâ-
            metro.

            Exemplo:  */
            int entrada = 3;
            int resultado;                                     /*(so de ser criada, a variável já seria aceita como saída)*/
            Calculadora2.TriplicaOut(entrada, out resultado);

            /* ------ Considerações finais sobre os modificadores ref & out ------
            
            Diferença entre eles:
            - A variável passada como parâmetro ref DEVE ser iniciada com algum valor
            - A variável passada como parâmetro out NÂO precisa ser iniciada, mas pode ser caso seja necessário
            
            Conclusão:
            Ambas são muito parecidas, porém, o parâmetro ref é uma maneira do compilador obrigar o usuário a iniciar a variável
            que será passada como parâmetro
            
            Bônus: Os modificadores de parâmetros ref & out são considerados "smell codes" (design ruim) e devem ser evitados. 
            Segundo o professor, os mesmos possivelmente foram inseridos devido a implementação do .NET, que utiliza além do C#,
            a linguagem C++, que esta sim utiliza bastante dos modificadores, sendo assim necessária a sua implementação no C#.  */
            




        }
    }
}