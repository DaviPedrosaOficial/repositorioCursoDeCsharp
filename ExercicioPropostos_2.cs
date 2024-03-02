/* ------ Exercícios propostos 2 ------ */

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
            
            
            
            /* ------ Exercício 5 ------ */
            /* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
             A seguir, calcule e mostre o valor da conta a pagar. 
             
             Tabela:
             código       Especifição        Preço
               1         Cachorro quente     R$4,00
               2            X-Salada         R$4,50
               3            X-Bacon          R$5,00
               4         Torrada simples     R$2,00
               5           Refrigerante      R$2,50       */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 5 ------");
            Console.WriteLine("Insira a seguir o código do produto de sua escolha: ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora insira a quantidade do mesmo que voce deseja levar: ");
            int qtd = int.Parse(Console.ReadLine());

            double totalPagar = 0;
            
            /* Processamento & saída */
            if (cod < 1 || cod > 5)
            {
                Console.WriteLine("\r\nProduto inserido nao encontrado");
            }
            else if (cod == 1)
            {
                totalPagar = qtd * 4;
                Console.WriteLine("\r\nProduto escolhido: Cachorro quente\r\nValor uni: R$4,00\r\nQuantidade pedida: {0}\r\nValor a pagar: R${1:F2}",qtd,totalPagar);
            }
            else if (cod == 2)
            {
                totalPagar = qtd * 4.5;
                Console.WriteLine("\r\nProduto escolhido: X-Salada\r\nValor uni: R$4,50\r\nQuantidade pedida: {0}\r\nValor a pagar: R${1:F2}",qtd,totalPagar);
            }
            else if (cod == 3)
            {
                totalPagar = qtd * 5;
                Console.WriteLine("\r\nProduto escolhido: X-bacon\r\nValor uni: R$5,00\r\nQuantidade pedida: {0}\r\nValor a pagar: R${1:F2}",qtd,totalPagar);
            }
            else if (cod == 4)
            {
                totalPagar = qtd * 2;
                Console.WriteLine("\r\nProduto escolhido: Torrada simples\r\nValor uni: R$2,00\r\nQuantidade pedida: {0}\r\nValor a pagar: R${1:F2}",qtd,totalPagar);
            }
            else
            {
                totalPagar = qtd * 2.5;
                Console.WriteLine("\r\nProduto escolhido: Refrigerante\r\nValor uni: R$2,50\r\nQuantidade pedida: {0}\r\nValor a pagar: R${1:F2}",qtd,totalPagar);
            }
            
            
            
            /* ------ Exercício 6 ------ */
            /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
             seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não
             estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.  */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 6 ------");
            Console.WriteLine("Neste programas verificaremos qual intervalo entre 0 e 100, se localiza um numero de\r\nsua escolha!");
            Console.WriteLine("Entao para que possamos comeca-lo, insira a seguir um numero de sua escolha: ");
            int numCliente = int.Parse(Console.ReadLine());

            /* Processamento e saída */
            if (numCliente < 0 || numCliente > 100)
            {
                Console.WriteLine("\r\nValor fora do intervalo 0 - 100.");   
            }
            else if (numCliente >= 0 && numCliente <= 25)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 0 e 25!");
            }
            else if (numCliente > 25 && numCliente <= 50)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 25 e 50!");
            }
            else if (numCliente > 50 && numCliente <= 75)
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 50 e 75!");
            }
            else
            {
                Console.WriteLine("\r\nValor se encontra no intervalo entre 75 e 100!");
            }
            
            
            
            /* ------ Exercício 7 ------ */
            /* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um
             plano.
             A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou
             na origem (x = y = 0). 
 
             Se o ponto estiver na origem, escreva a mensagem “Origem”. 
 
             Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação. 	 */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 7 ------");
            Console.WriteLine("Nesse programa determinaremos o quadrante em que se localiza um ponto escolhido por voce!");
            Console.WriteLine("Para comecarmos, insira a seguir as cordenadas do seu ponto da seguinte forma 'x y',");
            Console.WriteLine("separadas por espaco e com 1 casa decimal:");
            string[] vetor = Console.ReadLine().Split(' ');

            double x = double.Parse(vetor[0]);
            double y = double.Parse(vetor[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("O ponto se localiza na 'Origem'!");
            }
            else if (x == 0)
            {
                Console.WriteLine("O ponto se encontra no eixo 'X', na coordenada {0:F1} em Y",y); 
            }
            else if (y == 0)
            {
                Console.WriteLine("O ponto se encontra no eixo 'Y' na coordenada {0:F1} em Y",y);
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("O ponto se localiza no quadrante 'Q1'!");
            }
            
            
            
            /* ------ Exercício 8 ------ */
            /* Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos,
             pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício
             da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 
 
             Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. 
             Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo. 
 
             Renda                                Imposto de Renda
             de 0 a 2000,00                            Isento
             de 2000,01 a 3000,00                   8% de imposto
             de 3000,01 a 4500,00                  18% de imposto
             de 4500,01 acima                      28% de imposto
 
             Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
             salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. 
             No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em 
             R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.     */

            /* Entrada */
            Console.WriteLine("------ Exercicio 8 ------");
            Console.WriteLine("Bem vindo ao calculador de imposto de renda.\r\nInsira a seguir o valor de seu salario para que possamos calcular o valor que voce devera pagar:");
            double salCliente = double.Parse(Console.ReadLine());

            double impRenda = 0;
            
            /* Processamento e saída */

            if (salCliente < 0)
            {
                Console.WriteLine("\r\nValor inserido para o salario e invalido!");
            }
            else if (salCliente > 4500)
            {
                /* Como o imposto é acima de R$4500,00, os valores de impostos ate os R$4500,00 são fixos, respectivamente
                 R$79,99 para 8% de imposto, e R$269,99 para 18% de imposto. */

                impRenda = ((salCliente - 4500) * 0.28) + 79.9992 + 269.9982;

                Console.WriteLine("\r\nSeu imposto de renda sera R${0:F2} !",impRenda);
            }
            else if (salCliente > 3000)
            {
                /* Como o imposto é acima de R$3000,00, o valor de imposto ate os R$3000,00 é fixo, sendo ele R$79,99 para
                 8% de imposto. */

                impRenda = ((salCliente - 3000) * 0.18) + 79.9992;

                Console.WriteLine("\r\nSeu imposto de renda sera R${0:F2} !",impRenda);
            }
            else if (salCliente > 2000)
            {
                /* Como o imposto so será cobrado acima de R$2000,00, deveremos retirar R$2000,00 para calcularmos o
                 imposto */
                
                impRenda = (salCliente - 2000) * 0.08;
                
                Console.WriteLine("\r\nSeu imposto de renda sera R${0:F2} !",impRenda);
            }
            else
            {
                Console.WriteLine("\r\nVoce esta isento do imposto de renda!");
            }
        }
    }
}