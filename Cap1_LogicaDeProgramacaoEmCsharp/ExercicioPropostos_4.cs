/* ------ Exercícios propostos 4 ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioPropostos_4
    {
        static void Ex_Propostos4(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha,
             inclusive o X, se for o caso.  */

            /* Entrada */
            Console.WriteLine("Bem vindo ao Odd finder!");
            Console.Write("Insira a seguir um numero inteiro para que possamos demonstrar,\r\ntodos os impares ate chegar no mesmo: ");
            int numRef = int.Parse(Console.ReadLine());
            
            /* Saída */
            Console.WriteLine("\r\nNumero impares de 1 ate {0}: ",numRef);

            /* Processamento */
            for (int i = 1; i <= numRef; i++)
            {
                if (i % 2 != 0)
                {
                    /* Saída */
                    Console.WriteLine(i);
                }
            }
            
            
            
            /* ------ Exercício 2 ------ */
            /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, 
            mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para 
            fora do intervalo).                                        */

            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo ao identificador de intervalos!");
            Console.WriteLine("Insira a seguir a quantidade de numeros inteiros, na qual voce ira efetuar a verificacao");
            Console.Write("se os mesmos fazem ou nao parte do intervalo entre 10 e 20: ");
            int qtdNum = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;
            
            /* Processamento */
            for (int i = 1; i <= qtdNum; i++)
            {
                Console.Write("Insira o {0}º numero: ",i);
                int verif = int.Parse(Console.ReadLine());

                if (verif < 10 || verif > 20)
                {
                    fora += 1;
                }
                else
                {
                    dentro += 1;
                }
            }

            Console.WriteLine("\r\nBaseado nos numeros inseridos, {0} estao dentro do intervalo entre 10 e 20,\r\ne {1} estao fora do intervalo!",dentro,fora);
            
            
            
            
            /* ------ Exercício 3 ------ */
            /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.
             Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. 
             Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem
             peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.  */

            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 3 ------");
            Console.WriteLine("Bem vindo ao calculador de notas, um programa para auxiliar os professores de todo o Brasil!");
            Console.Write("Insira a seguir a quantidade de alunos que calcularemos suas medias baseado nas notas das 3 provas: ");
            int qtdAlu = int.Parse(Console.ReadLine());

            /* Processamento & saída */
            for (int i = 1; i <= qtdAlu; i++)
            {
                Console.Write("Insira a seguir a 1ª nota do {0}º aluno: ",i);
                double nota_1 = double.Parse(Console.ReadLine());

                Console.Write("Insira a seguir a 2ª nota do {0} aluno: ",i);
                double nota_2 = double.Parse(Console.ReadLine());

                Console.Write("Insira a seguir a 3ª nota do {0} aluno: ",i);
                double nota_3 = double.Parse(Console.ReadLine());

                double media = (nota_1 * 2 + nota_2 * 3 + nota_3 * 5) / 10;
                Console.Write("Media do {0}º aluno: {1:F1}",i,media);
            }
            
            
            
            
            /* ------ Exercício 4 ------ */
            /*  Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro
             pelo segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".         */

            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 4 ------");
            Console.Write("Bem vindo ao programa de divisao!\r\nInsira a seguir a quantidade de divisoes que deseja executar: ");
            int qtdDiv = int.Parse(Console.ReadLine());

            /* Processamento & saída */
            for (int i = 1; i <= qtdDiv; i++)
            {
                Console.Write("Insira a seguir o dividendo da {0}ª divisao: ",i);
                double dividendo = double.Parse(Console.ReadLine());

                Console.Write("Agora o divisor: ");
                double divisor = double.Parse(Console.ReadLine());

                if (divisor == 0)
                {
                    Console.WriteLine("Divisao impossivel!");
                }
                else
                {
                    double divisao = dividendo / divisor;
                    Console.WriteLine("A divisao entre {0} e {1} resultam em: {2:F1}",dividendo,divisor,divisao);
                }
            }
            
            
            
            
            /* ------ Exercício 5 ------ */
            /* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
             Lembrando que, por definição, fatorial de 0 é 1.  */

            /* Entrada */
            Console.WriteLine("\r\n------ Exercício 5 ------");
            Console.WriteLine("Bem vindo ao calculador de fatorial!");
            Console.Write("Insira a seguir o numero que voce deseja encontrar seu fatorial: ");
            int fatCliente = int.Parse(Console.ReadLine());
            int fatoracao = 1;

            /* Processamento & saída */
            for (int i = 1; i <= fatCliente; i++)
            {
                fatoracao *= i;
            }
            Console.WriteLine("O fatorial de {0} é {1} !",fatCliente,fatoracao);
            
            
            
            
            /* ------ Exercício 6 ------ */
            /* Ler um número inteiro N e calcular todos os seus divisores. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 6 ------");
            Console.WriteLine("Bem vindo ao descobridor de divisores!");
            Console.WriteLine("Neste programa, descobriremos os divisores de um numero passado por voces!");
            Console.Write("Insira a seguir o numero que voce deseja que encontremos seus divisores: ");
            int numDiv = int.Parse(Console.ReadLine());

            Console.Write("Os divisores de {0} são: ",numDiv);
            for (int i = 1; i <= numDiv; i++)
            {
                if (numDiv % i == 0)
                {
                    Console.Write(" {0} ",i);
                }
            }
            
            
            
            
            /* ------ Exercício 7 ------ */
            /* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
             começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, 
             conforme exemplo. */
            
            /* Entrada */
            Console.WriteLine("\r\n------ Exercicio 7 ------");
            Console.Write("Insira a seguir um numero inteiro positivo para que possamos transformá-lo: ");
            int numLinhas = int.Parse(Console.ReadLine());
            
            /* Processamento e saída */
            for (int i = 1; i <= numLinhas; i++)
            {
                Console.WriteLine("{0} {1} {2}",i , Math.Pow(i,2), Math.Pow(i,3));
            }
        }
    }
}