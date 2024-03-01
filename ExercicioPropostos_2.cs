﻿/* ------ Exercícios propostos 2 ------ */

using System;
using System.Threading.Channels;

namespace CursoDeCsharp
{
    class ExercicioPropostos_2
    {
        static void ExProp(string[] arg)
        {
            /* ------ 1º Exercício ------ */
            /* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. */

            /* Entrada */
            Console.WriteLine("------ Exercicio 1 ------");
            Console.WriteLine("Insira a seguir um numero inteiro de sua escolha, e diremos se ele e positivo ou negativo: ");
            int numPosNeg = int.Parse(Console.ReadLine());
            
            /* Processamento & saída */
            if (numPosNeg >= 0)
            {
                Console.WriteLine("O numero {0} e positivo!",numPosNeg);
            }
            else
            {
                Console.WriteLine("O numero {0} e negativo!",numPosNeg);
            }
            
            
            
            /* ------- Exercício 2 ------- */
            /* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 2 ------");
            Console.WriteLine("Insira a seguir um numero inteiro de sua escolha, e diremos se ele e par ou impar: ");
            int numParImp = int.Parse(Console.ReadLine());
            
            /* Processamento & saída */

            if (numParImp % 2 == 0)
            {
                Console.WriteLine("O numero {0} e par!", numParImp);
            }
            else
            {
                Console.WriteLine("O numero {0} e impar!",numParImp);
            }
            
            
            
            /* ------ Exercício 3 ------ */
            /* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser 
            digitados em ordem crescente ou decrescente. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 3 ------");
            Console.WriteLine("Nesse exercicio, precisaremos de 2 numeros inteiros para calcularmos se os mesmos sao");
            Console.WriteLine("multiplos de entre si. \r\nDigite a seguir o primeiro numero: ");
            int numMult1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo numero: ");
            int numMult2 = int.Parse(Console.ReadLine());

            /* Processamento & saída */
            if (numMult1 > numMult2)
            {
                if (numMult1 % numMult2 == 0)
                {
                    Console.WriteLine("\r\nO numero {0} e multiplo de {1} !",numMult1,numMult2);
                }
                else
                {
                    Console.WriteLine("\r\nO numero {0} nao e multiplo de {1} !",numMult1,numMult2);
                }
            }
            else if (numMult1 == numMult2)
            {
                Console.WriteLine("\r\nOs numeros sao iguais, e por isso nao sao multiplos!");
            }
            else
            {
                if (numMult2 % numMult1 == 0)
                {
                    Console.WriteLine("\r\nO numero {0} e multiplo de {1} !",numMult2,numMult1);
                }
                else
                {
                    Console.WriteLine("\r\nO numero {0} nao e multiplo de {1} !",numMult2,numMult1);
                }
            }
            
            
            
            /* ------ Exercício 4 ------ */
            /* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo
             pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.  */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 4 ------");
            Console.WriteLine("Nesse exercicio, faremos o calculo da duracao de um jogo, onde o mesmo devera ter a ");
            Console.WriteLine("duracao minima de uma hora e maxima de 24 horas!");
            Console.WriteLine("Entao, para que possamos prosseguir, insira a seguir a hora em que o jogo se iniciou: ");
            string[] iniJogo = Console.ReadLine().Split(':');

            int hrInicio = int.Parse(iniJogo[0]);
            int minInicio = int.Parse(iniJogo[1]);

            Console.WriteLine("Agora, insira a hora em que o mesmo se encerrou, lembrando que o mesmo nao pode ter mais\r\nque 24 horas: ");
            string[] fimJogo = Console.ReadLine().Split(':');

            int hrFinal = int.Parse(fimJogo[0]);
            int minFinal = int.Parse(fimJogo[1]);
            
            /* Processamento & saída */
            int hrsJogadas = 0;
            int minsJogados = 0;

            /* Teste para verificar se as entradas condizem com as normas de horario */
            if (hrInicio < 0 || hrInicio > 23 || hrFinal < 0 || hrFinal > 23 || minInicio < 0 || minInicio > 59 || minFinal < 0 || minFinal > 59)
            {
                Console.WriteLine("\r\nValores inseridos sao nao condizem com as normas de horario!");
            }
            
            /* Teste para verificar se o jogo durou mais de uma hora */
            else if (hrInicio < hrFinal && (hrFinal - hrInicio) == 1 && minInicio > minFinal)
            {
                Console.WriteLine("\r\nO jogo nao pode ter menos de 1 hora de duracao!");
            }
            
            /* Calculo caso o horario de inicio seja o mesmo que o final, porém com minutos do inicio do jogo sendo
             maiores que os do final*/
            else if (hrInicio == hrFinal && minInicio > minFinal)
            {
                hrsJogadas = 23;
                minsJogados = (60 - minInicio) + minFinal;
                
                /* Saída */
                Console.WriteLine("\r\nO jogo durou {0:D2}:{1:D2} hora(s)!",hrsJogadas,minsJogados);
            }
            
            /* Calculo caso o horario de inicio for menor que o final */
            else if (hrInicio < hrFinal)
            {
                /* Contabilizando o tempo do jogo */
                hrsJogadas = hrFinal - hrInicio;
                if (minInicio > minFinal)
                {
                    minsJogados = (60 - minInicio) + minFinal;
                }
                else if (minInicio == minFinal)
                {
                    minsJogados = 0;
                }
                else
                {
                    minsJogados = minFinal - minInicio;
                }
                
                /* Saída */
                Console.WriteLine("\r\nO jogo durou {0:D2}:{1:D2} hora(s)!",hrsJogadas,minsJogados);
            }
            
            /* Calculo caso o horario de inicio for maior que o horario final */
            else if (hrFinal < hrInicio)
            {
                /* Contabilizando o tempo de jogo */
                hrsJogadas = (hrInicio - 24) + hrFinal;
                if (minInicio > minFinal)
                {
                    minsJogados = (60 - minInicio) + minFinal;
                }
                else if (minInicio == minFinal)
                {
                    minsJogados = 0;
                }
                else
                {
                    minsJogados = minFinal - minInicio;
                }
                
                /* Saída */
                Console.WriteLine("\r\nO jogo durou {0:D2}:{1:D2} hora(s)!",hrsJogadas,minsJogados);
            }
            
            /* Condição caso o horario seja o mesmo */
            else if (hrInicio == hrFinal && minInicio == minFinal)
            {
                /* Saída */
                Console.WriteLine("\r\nO jogo durou 24 horas!");
            }
            
            /* Condicional para caso o jogo tenha durado mais de 24 horas */
            else
            {
                Console.WriteLine("\r\nA duracao do jogo nao pode ser maior que 24 horas!");
            }
        }
    }
}