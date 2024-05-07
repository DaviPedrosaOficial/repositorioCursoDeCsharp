/* ------ Entendendo o conceito de orientação a objeto ------ */

using System;
using CursoDeCsharp.Cap2.Classes;

namespace CursoDeCsharp.Cap2.Aulas
{
    class Aula2
    {
        static void _Aula2(string[] arg)
        {
            /* Para que possamos compreender melhor o conceito de orientação a objetos, vamos refletir sobre o exercício
             feito na ultima aula, no qual tivemos de criar um programa para calcular as dimensões de dois triangulos.*/
            
            /* A primeira observação que podemos fazer sobre o último exercício é que o triangulo representa uma entidade
             na qual possui atributos, so caso do exercício 'a', 'b' e 'c'.
              Essa mesma entidade, poderia ser uma classe Cliente, por exemplo, onde os atributos seriam, seu nome, email,
              telefone ...  */
            
            /* Porém, tivemos que fazer 3 variáveis distintas para cada triangulo que desenvolvemos, sendo de certa forma
             desgastante e contraprodutivo. Imaginem se fossem 100 triangulos, ao invés de 2. Quanto tempo não duraria para
             fazer a criação desse código, e mais, o quão extenso e desnecessário seria o processo.  */
            
            /* ------ Classes ------ */
            /* É um tipo estruturado que pode conter membros, sendo esses:
             - Atributos: (dados / campos) (no caso do triangulo seriam as medidas dos lados 'a', 'b' e 'c')
             - Métodos: (funções / operações)                             */
            
            /* A classe pode prover muitos outros recursos, tais como:
             - Construtores
             - Sobrecarga
             - Encapsulamento
             - Herança
             - Polimorfismo                                               */
            
            /* Exemplos (de possíveis classes):
             - Entidades: Produto, Cliente, Triangulo
             - Serviços: ProdutoService, ClienteService, EmailService, StorageService
             - Controladores: ProdutoController, ClienteController
             - Utilitários: Calculadora, Compactador
             - Outros: (views, repositórios, gerenciadores, etc) */
            
            /* Agora, que entendemos o conceito por trás das classes, vamos começar a utilizá-las, começando pela classe
             triangulo.
             Então para prosseguir nos estudos, basta mudar para o arquivo Triangulo.cs para acompanhar o desenvolvimento 
             da classe!*/
            
            /* Refazendo o exemplo a partir da utilização da orientação à objetos:      */
            
            Console.WriteLine("Bem vindo ao comparador de triangulos!");
            Console.WriteLine("Nesse programa, calcularemos a area de dois triangulos baseados nas medidas de cada lado");
            Console.WriteLine("que serao fornecidas por voces!");
   
            /* Declarando as variáveis */
            Triangulo x, y;
 
            /* Instânciando as variáveis */
            x = new Triangulo();
            y = new Triangulo();
            
            /* 1º Triangulo */
            Console.WriteLine("\r\n------ 1º Triangulo ------");
            Console.Write("Entao, para que possamos prosseguir, insira a seguir a medida do lado 'a' do 1º triangulo:  ");
            /* Para acessarmos atríbutos de nossos objetos basta colocar o nome do objeto, seguido do ponto "." e o nome
             do atríbuto, como na execução abaixo: */
            x.A = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a medida do lado 'b' do 1º triangulo: ");
            x.B = double.Parse(Console.ReadLine());
            
            Console.Write("Agora, insira a medida do lado 'c' do 1º triangulo: ");
            x.C = double.Parse(Console.ReadLine());
            
            /* 2º Triangulo */
            Console.Write("\r\n------ 2º Triangulo ------");
            Console.Write("Agora, insira a medida do lado 'a' do 2º triangulo: ");
            y.A = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a medida do lado 'b' do 2º triangulo: ");
            y.B = double.Parse(Console.ReadLine());

            Console.Write("E por ultimo, insira a medida do lado 'c' do 2º triangulo: ");
            y.C = double.Parse(Console.ReadLine());
            
            /* Processamento */
            double p1 = (x.A + x.B + x.C) / 2;
            double p2 = (y.A + y.B + y.C) / 2;

            double area1 = Math.Sqrt(p1 * (p1 - x.A) * (p1 - x.B) * (p1 - x.C));
            double area2 = Math.Sqrt(p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C));
            
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