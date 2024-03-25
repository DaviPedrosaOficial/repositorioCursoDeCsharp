/* ------ Modificadores de parâmetros ref e out ------ */

namespace CursoDeCsharp{

    class Aula6_Cap4{

        static void _Aula6_Cap4(string []  arg){

            /* Para que servem os modificadores de parâmetros ref e out?
            
            Vamos começar a responder essa pergunta pelo modificador ref. 
            
            Imagine que temos de desenvolver um código robusto no qual nossa Main precisará de uma calculadora
            para resolver uma série de funções. 
            
            Porém, nossos métodos serão resolvidos na classe calculadora, onde nosso estagiário fez a seguinte
            função:
            
            public class Calculadora{

                public static void Triplica (int x){
                    x = x * 3
                }

            }
            
            Da forma na qual a classe foi descrita acima teremos um problema em sua execução, onde como vimos no
            decorrer do curso, que se trata do escopo e funcionamento de mémoria.
            
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
            Calculadora2.Triplica(ref x);
            Console.WriteLine(x);
            /* Algo que devemos levar em conta, é que deveremos inserir também o prefixo em nossa Main, assim como inse-
            rido acima em nosso código.                                                                              */




        }
    }
}