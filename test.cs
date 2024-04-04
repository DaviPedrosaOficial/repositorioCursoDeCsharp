using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

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


