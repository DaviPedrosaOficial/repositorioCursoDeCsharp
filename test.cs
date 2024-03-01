using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
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

