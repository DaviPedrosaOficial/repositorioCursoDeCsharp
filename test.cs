using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Console.WriteLine("Bem vindo ao calculador de esferas!");
            
            Console.Write("Insira a seguir o valor no qual voce desejaria tem como raio de sua esfera: ");
            double raio = double.Parse(Console.ReadLine());

            /* Armazenando dados de nossos membros estáticos */
            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: {0:F2}",circ);
            Console.WriteLine("Volume: {0:F2}",vol);
            Console.WriteLine("Valor de Pi: {0:F2}",Pi);
        }
        static double Pi = 3.14;

        /* Repare que como utilizaremos as funções estáticas dentro de uma classe estática, temos de colocar a nomenclatura
         static na frente da definição, para que as mesmas possam ser utilizadas em nosso programa! */
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}


