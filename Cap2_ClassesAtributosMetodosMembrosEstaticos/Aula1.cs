/* ------ Resolvendo um problema sem orientação a objeto ------ */

using System;

namespace CursoDeCsharp
{
    class Aula1
    {
        static void _Aula1(string[] arg)
        {
            /* A ideia por trás desse exercício é mostrar a diferença entre desenvolvermos soluções para problemas
             a partir da orientação à objetos. Sendo assim, iremos desenvolver a solução para um problema sem a sua 
             utilização e depois, demonstraremos a diferença na prática, trabalhando o conceito! */
            
            /* Exemplo a ser desenvolvido abaixo */
            
            /* Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas válidas).
             Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos possui a maior área.
             A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
             seguinte (fórmula de Heron): 
             
             area = Raiz quadrada de -> p( p - a)( p - b)( p - c)
             
             onde p = (a + b + c) / 2                                                                           */

            Console.WriteLine("Bem vindo ao comparador de triangulos!");
            Console.WriteLine("Nesse programa, calcularemos a area de dois triangulos baseados nas medidas de cada lado");
            Console.WriteLine("que serao fornecidas por voces!");
            
            /* Entrada */
            /* 1º Triangulo */
            Console.WriteLine("\r\n------ 1º Triangulo ------");
            Console.Write("Entao, para que possamos prosseguir, insira a seguir a medida do lado 'a' do 1º triangulo:  ");
            double a_1 = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a medida do lado 'b' do 1º triangulo: ");
            double b_1 = double.Parse(Console.ReadLine());
            
            Console.Write("Agora, insira a medida do lado 'c' do 1º triangulo: ");
            double c_1 = double.Parse(Console.ReadLine());
            
            /* 2º Triangulo */
            Console.Write("\r\n------ 2º Triangulo ------");
            Console.Write("Agora, insira a medida do lado 'a' do 2º triangulo: ");
            double a_2 = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a medida do lado 'b' do 2º triangulo: ");
            double b_2 = double.Parse(Console.ReadLine());

            Console.Write("E por ultimo, insira a medida do lado 'c' do 2º triangulo: ");
            double c_2 = double.Parse(Console.ReadLine());
            
            /* Processamento */
            double p1 = (a_1 + b_1 + c_1) / 2;
            double p2 = (a_2 + b_2 + c_2) / 2;

            double area1 = Math.Sqrt(p1 * (p1 - a_1) * (p1 - b_1) * (p1 - c_1));
            double area2 = Math.Sqrt(p2 * (p2 - a_2) * (p2 - b_2) * (p2 - c_2));
            
            /* Saída */
            Console.WriteLine("\r\nArea do 1º triangulo: {0:F4}",area1);
            Console.WriteLine("Area do 2º triangulo: {0:F4}",area2);

            if (area1 == area2)
            {
                Console.WriteLine("Os triangulos tem o mesmo tamanho!");
            }
            else if (area1 > area2)
            {
                Console.WriteLine("O 1º triangulo é maior que o 2º triangulo!");
            }
            else
            {
                Console.WriteLine("O 2º triangulo é maior que o 1º triangulo!");
            }
            

        }
    }
}