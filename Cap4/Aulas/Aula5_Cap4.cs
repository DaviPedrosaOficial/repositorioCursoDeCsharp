/* ------ Modificador de parâmetros (params) ------ */

namespace CursoDeCsharp{

    class Aula5_Cap4{

        static void _Aula5_Cap4(string [] arg){

            /* ------ O que é o modificador de parametro? ------
            
             Modificador de parametro é um prefixo que podemos utilizar em nossas funções para otimizar nosso código fontes,
            estruturas e funções. Com ele podemos demonstrar que uma função por exemplo, receberá "n" parametros, sem termos
            que instanciar o método.
            
            Então pense no seguinte caso:
            
            Imagine que temos de fazer uma calculadora, onde essa pode receber vários parâmetros. Se fossemos fazer a mesma de 
            maneira manual, seria extremamente desgastante, e muito provavelmente não conseguiriamos alcançar todas as necessidades
            da mesma.
            
            Isso ocorreria devido a necessidade em um código desenvolvido apenas com construtores e métodos, de ser feita todas as
            possíveis entradas. Então voltando a pensar em uma calculadora, mesmo que a mesma so fizesse somas, teriamos de 
            desenvolver métodos para cada possibilidade, por exemplo:
            
            public static int Soma (n1, n2) {
                return n1 + n2;
                }
            
            public static int Soma (n1, n2, n3) {
                return n1 + n2 + n3;
                }
            
            E assim por diante...
            
            Mas claramente essa maneira de executar tal classe seria extremamente ineficaz, alem de trabalhoso, então uma maneira
            de otimizarmos tal código seria fazer da seguinte maneira:
            
            public static int soma (int[] numeros){
                int soma = 0;
                for (int i = 0; i < numeros.Length; i++){
                    soma += numeros[i];
                }
                return soma;
            }
            
            O código acima rodaria normalmente, mas ainda sim teriamos de instanciar nosso vetor aoi chamarmos o mesmo em nossa main,
            da seguinte forma:                                                                                                     */
            
            int soma1 = Calculadora2.Soma (new int[] {1, 2, 3});
            Console.WriteLine(soma1);

            /* Porém, é possível fazer a mesma chamada, mas sem termos de executar tal instanciação do vetor, e para isso utilizaremos
            o prefixo params (veja a execução na classe Calculadora2) 
            
            Veja abaixo como ficaria a execução da chamada usando o prefixo params:                                                 */

            int soma2 = Calculadora2.Soma1 (1,2,3,4,5,6);
            Console.WriteLine(soma2);

            /* Como foi dito, não ouve a necessidade de utilizarmos a instanciação para que o nosso código utilizasse nosso vetor */
            

            
        }
    }
}