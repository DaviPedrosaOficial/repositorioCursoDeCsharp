/* ------ Sintaxe alternativa (Switch Case) ------ */

namespace CursoDeCsharp{

    class Aula2_Cap5{

        static void _Aula2_Cap5(string [] arg){

            /* ------ O que é a sintaxe alternativa (switch case) ------

            O switch case é uma estrutura opcional a vários if-else encadeados, quando a condição para determiná-los
            envolve o teste de valor de uma variável. Ou seja, a depender do valor da mesma, teremos diferentes opções
            para o prosseguimento de nosso código.

            Para ficar mais didático, vamos mostrar como o mesmo funciona na prática, mas para isso vamos demonstrar
            primeiro como seria um código sem a utilização do mesmo, para que depois possamos implementá-lo:      */


            Console.Write("Insira a seguir, qual dia estamos na semana, utilizando 1 para segunda, 2 para terça, ...\r\nInsira o número correspondente:");
            int diaDaSemana = int.Parse(Console.ReadLine());

            if (diaDaSemana == 1){
                Console.WriteLine("\r\nHoje é segunda!");
            }
            else if (diaDaSemana == 2){
                Console.WriteLine("\r\nHoje é terca!");
            }
            else if (diaDaSemana == 3){
                Console.WriteLine("\r\nHoje é quarta!");
            }
            else if (diaDaSemana == 4){
                Console.WriteLine("\r\nHoje é quinta!");
            }
            else if (diaDaSemana == 5){
                Console.WriteLine("\r\nHoje é sexta!");
            }
            else if (diaDaSemana == 6){
                Console.WriteLine("\r\nHoje é sabado!");
            }
            else if (diaDaSemana == 7){
                Console.WriteLine("\r\nHoje é domingo!");
            }
            else{
                Console.WriteLine("\r\nDia inválido!");
            }

            /* Agora que vimos como ficaria o programa utilizando as estruturas if & else, vamos reproduzi-lo utilizando o
            switch case:                                                                                                 */

            Console.Write("Insira a seguir, qual dia estamos na semana, utilizando 1 para segunda, 2 para terça, ...\r\nInsira o número correspondente:");
            int switchDiaDaSemana = int.Parse(Console.ReadLine());

            switch (switchDiaDaSemana) {
                /* No switch case, utilizamos as condições a frente do prefixo case, correspondendo ao parâmetro que dese-
                jamos para aquela condição, ou seja, de acordo com aquele caso (case), teremos a seguinte procedência.
                Veja como fica abaixo:                                                                                  */
                case 1 :
                    Console.WriteLine("\r\nHoje é segunda!");
                    break;
                case 2 :
                    Console.WriteLine("\r\nHoje é terca!");
                    break;
                case 3 :
                    Console.WriteLine("\r\nHoje é quarta!");
                    break;
                case 4 :
                    Console.WriteLine("\r\nHoje é quinta!");
                    break;
                case 5 :
                    Console.WriteLine("\r\nHoje é sexta!");
                    break;
                case 6 :
                    Console.WriteLine("\r\nHoje é sabado!");
                    break;
                case 7 :
                    Console.WriteLine("\r\nHoje é domingo!");
                    break;
                /* Note que não foi necessário escrever o if & else para cada uma das condicionais, sendo assim mais simples de
                desenvolver as mesmas. Porém, temos de lembrar que sempre ao final da case, devemos colocar o "break;", assim
                como em loops while, para que não haja erro em nosso código.

                Além disso, para o else em expecífico, utilizamos o caso "default", para que o compilador entenda como else!
                Veja a seguir:                                                                                               */
                default:
                    Console.WriteLine("\r\nDia inválido!");
                    break;
            }
        }
    }
}