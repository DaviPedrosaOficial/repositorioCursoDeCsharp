﻿using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

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


