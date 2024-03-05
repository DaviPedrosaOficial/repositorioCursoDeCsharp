/* ------ Exercícios propostos 3 ------ */

using System;

namespace CursoDeCsharp
{
    class ExercicioPropostos_3
    {
        static void Ex_Propostos3(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida.
             Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
             Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo
             encerrado. Considere que a senha correta é o valor 2002. */
            
            
            Console.WriteLine("------ Exercicio 1 ------");
            int senha = 2002;
            
            /* Entrada */
            Console.WriteLine("Digite a seguir sua senha, para proseguir: ");
            int testeCliente = int.Parse(Console.ReadLine());
            
            /* Processamento */
            while (testeCliente != senha)
            {
                Console.WriteLine("\r\nSenha Invalida!");
                Console.WriteLine("Tente novamente para que possamos prosseguir: ");
                testeCliente = int.Parse(Console.ReadLine());
            }
            
            /* Saída */
            Console.WriteLine("Acesso Autorizado!");



            
            /* ------ Exercício 2 ------ */
            /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */


            Console.WriteLine("\r\n ------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo ao Quadrant Finder, nesse programa iremos receber as coordenadas x e y, e retornaremos");
            Console.WriteLine("qual quadrante as mesmas fazem parte! ");

            double x = 0;
            double y = 0;
            
            /* Entrada */
            Console.WriteLine("Para iniciarmos, insira o valor de x e y a seguir (na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');

            x = double.Parse(vetor[0]);
            y = double.Parse(vetor[1]);

            /* Processamento */
            while ((x > 0 && y > 0) || (x < 0 && y < 0) || (x > 0 && y < 0) || (x < 0 && y > 0))
            {
                /* Quadrante 1 (x e y positivos) */
                if (x > 0 && y > 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q1 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");
                    
                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
                
                /* Quadrante 2 (x negativo e y positivo) */
                else if (x < 0 && y > 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q2 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");
                    
                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
                
                /* Quadrante 3 (x e y negativos)*/
                else if (x < 0 && y < 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q3 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");

                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }

                /* Quadrante 4 (x positivo e y negativo) */
                else
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q4 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");

                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
            }
        }
    }
}

 