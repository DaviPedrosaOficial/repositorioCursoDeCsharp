/* ------ Criando um método para aproveitar os benefícios de reaproveitamento e delegação ------ */

using System;
using CursoDeCsharp.Cap2.Classes;

namespace CursoDeCsharp.Cap2.Aulas
{
    class Aula3
    {
        static void _Aula3(string[] arg)
        {
            /* Antes de começarmos trabalharmos na prática o conceito de reaproveitamento e delegação, vamos entender o
             qual o peso dos dois no desenvolvimento de softwares.
             
             Quando vamos desenvolver um programa, buscamos ao máximo desenvolver um código otimizado e limpo, e é por 
             e outros motivos que se torna de extrema importância trabalharmos com a orientação à objetos. Pois nela,
             encontramos um caminho, onde as classes nos auxiliam a chegarmos em tal objetivo.
             
             E o reaproveitamento e a delegação, exercem um importante papel em sua implementação, sendo:
             
             - Reaproveitamento: Ao contruirmos metodos em uma classe, estamos contribuindo para que a nossa Main, tenha 
             o mínimo de repetições possíveis. Isso, se deve ao fato de que, ao desenvolvermos tais métodos, não 
             teremos a necessidade de ficar reproduzindo uma ação manualmente para cada objeto, uma vez que em sua classe
             já estará armazenaada tal função.
             
             - Delegação: O conceito de delegação esta voltado a ideia de que, se estamos trabalhando com um objeto, como 
             por exemplo o trinagulo. Quem deve saber calcular sua área, guardar as medidas de seus lados, ... é a sua 
             própria classe! E não o código Main, tornando-o assim, mais enxuto e objetivo.
             
             Então vamos ver como ficaria a nossa Main aplicando tais métodos:    */
            
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
            
            /*------ Antigo processamento ------
            double p1 = (x.A + x.B + x.C) / 2;
            double p2 = (y.A + y.B + y.C) / 2;

            double area1 = Math.Sqrt(p1 * (p1 - x.A) * (p1 - x.B) * (p1 - x.C));
            double area2 = Math.Sqrt(p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C));  */
            
            /* ------ Novo processamento (utilizando o reaproveitamento e delegação) ------ */
            double areaX = x.Area();
            double areaY = y.Area();
            /* Note a diferença entre os códigos, isso sendo apenas dois triângulos?! */
            
            
            
            /* Saída */
            Console.WriteLine("\r\nArea do 1º triangulo: {0:F4}",areaX);
            Console.WriteLine("Area do 2º triangulo: {0:F4}",areaY);

            if (areaX == areaY)
            {
             Console.WriteLine("Os triangulos tem o mesmo tamanho!");
            }
            else if (areaX > areaY)
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
