/* ------ Exercícios propostos 1 ------ */

using System;

namespace CursoDeCsharp.Cap1.ExerciciosPropostos
{
    class ExercicioPropostos_1_Cap1
    {
        static void Ex_Propostos1(string[] arg)
        {
            /* ------ 1º Exercício ------ */
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números
             com uma mensagem explicativa, conforme exemplos. 
             
             Exemplo:
             Entrada: 10                       Saida: Soma = 30 
                      20                                         */

            /* Entrada */
            
            Console.WriteLine(" ------ Exercicio 1 ------");
            Console.WriteLine("Insira a seguir 2 numeros de sua escolha que serão somados (somente inteiros): ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            /* Processamento */
            
            int soma = num1 + num2;
            
            /* Saída */
            
            Console.WriteLine("\r\nSoma = {0}",soma);
            
            
            
            /* ------ 2º Exercício ------ */
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste
             círculo com quatro casas decimais conforme exemplos.
             
             Fórmula da área: area = π . raio2
             Considere o valor de π = 3.14159 
             
             Exemplo:
             Entrada: 2,00                     Saída: A = 12.5664
             */

            /* Entrada  */
            
            Console.WriteLine("\r\n ------ Exercicio 2 ------");
            Console.WriteLine("Insira a seguir o valor do raio de um circulo, para que possamos calcular sua area: ");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            
            /* Processamento */
            
            double area = pi * (Math.Pow(raio, 2));
            
            /* Saída */
            
            Console.WriteLine("\r\nArea do circulo: {0:F4}",area);
            
            
            
            
            /* ------ 3º Execício ------ */
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença
             do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). */

            /* Entrada */
            
            Console.WriteLine("\r\n ------ Exercicio 3 ------");
            Console.WriteLine("Insira a seguir 4 numeros inteiros para que possamos calcular a seguinte formula (A * B - C * D) ");
            
            Console.WriteLine("Insira o primeiro numero: ");
            int num_1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\r\nInsira o segundo numero: ");
            int num_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nInsira o terceiro numero: ");
            int num_3 = int.Parse(Console.ReadLine());

            Console.WriteLine("\r\nInsira o quarto numero: ");
            int num_4 = int.Parse(Console.ReadLine());

            /* Processamento */
            
            int diferenca = num_1 * num_2 - num_3 * num_4;
            
            /* Saída */
            
            Console.WriteLine("\r\nDiferenca = {0}",diferenca);
            
            
            
            
            /* ------ 4º Exercício ------ */
            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que
             recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, 
             com duas casas decimais. */
            
            /* Entrada */

            Console.WriteLine("\r\n------ Exercicio 4 ------");
            Console.WriteLine("Insira a seguir o seu numero de identificacao de funcionario: ");
            int nFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora insira a quantidade de horas trabalhadas nesse mes: ");
            int hrs = int.Parse(Console.ReadLine());

            Console.WriteLine("E para finalizarmos, insira o valor de sua hora: ");
            double valHr = double.Parse(Console.ReadLine());
            
            /* Processamento */

            double salFunc = hrs * valHr;
            
            /* Saída */

            Console.WriteLine("\r\nNumero de Funcionario: {0}\r\nValor a receber (salario): {1:F2}",nFunc,salFunc);
            
            
            
            /* ------ Exercicio 5 ------ */
            /*  Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1,
             o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor
              a ser pago. */

            /* Entrada */
            
            Console.WriteLine("\r\n------ Exercicio 5 ------");
            Console.WriteLine("Bem vindo ao caixa automatico!");
            Console.WriteLine("Insira a seguir em ordem, o codigo do produto 1º, a quantidade que sera levada do mesmo e \r\nseu valor unitario (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            int cod = int.Parse(vetor[0]);
            int qtd = int.Parse(vetor[1]);
            double val = double.Parse(vetor[2]);

            Console.WriteLine("Agora, o mesmo para o 2º produto, codigo, quantidade e valor unitario (mesma linha): ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vetor1[0]);
            int qtd1 = int.Parse(vetor1[1]);
            double val1 = double.Parse(vetor1[2]);
            
            /* Processamento */

            double valProd1 = qtd * val;
            double valProd2 = qtd1 * val1;
            double valTotal = valProd1 + valProd2;

            /* Saída */

            Console.WriteLine(" --- Resumo da compra ---");
            Console.WriteLine("- 1º Produto\r\nCodigo: {0}\r\nQuantidade: {1}\r\nValor unit.: R$ {2:F2}",cod,qtd,val);
            Console.WriteLine("- 2º Produto\r\nCodigo: {0}\r\nQuantidade: {1}\r\nValor unit.: R$ {2:F2}",cod1,qtd1,val1);
            Console.WriteLine("\r\nTotal a pagar: R$ {0:F2}",valTotal);
            
            
            
            /* ------ Exercicio 6 ------ */
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:  
               a)	a área do triângulo retângulo que tem A por base e C por altura.  
               b)	a área do círculo de raio C. (pi = 3.14159)  
               c)	a área do trapézio que tem A e B por bases e C por altura.  
               d)	a área do quadrado que tem lado B.  
               e)	a área do retângulo que tem lados A e B.  */

            /* Entrada */
            
            Console.WriteLine("\r\n------ Exercicio 6 ------");
            Console.WriteLine("Insira a seguir tres valores flutuantes (possuem decimais) para que possamos demonstrar\r\ncomo seriam diferente formas geometricas baseadas nos mesmos!");
            Console.WriteLine("Para isso, digite os tres valores desejados a seguir (mesma linha): ");
            string[] vetorFormas = Console.ReadLine().Split(' ');
            double a = double.Parse(vetorFormas[0]);
            double b = double.Parse(vetorFormas[1]);
            double c = double.Parse(vetorFormas[2]);

            /* Processamento */
            
            double trianRet = a * c / 2;

            double areaCirc = pi * (Math.Pow(c, 2));
            
            double areaTrap = (a+b) * c / 2;

            double areaQuad = Math.Pow(b, 2);

            double areaRetan = a * b;
            
            /* Saída */

            Console.WriteLine("\r\n --- Resultados ---\r\n- Triangulo: {0:F3}\r\n- Circulo: {1:F3}\r\n- Trapezio: {2:F3}\r\n- Quadrado: {3:F3}\r\n- Retangulo: {4:F3}",trianRet,areaCirc,areaTrap,areaQuad,areaRetan);


        }
    }
}