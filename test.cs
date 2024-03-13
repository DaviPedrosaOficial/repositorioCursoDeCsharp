using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            double circ3 = CalculadoraEstatica.Circunferencia(3.0);
            double vol3 = CalculadoraEstatica.Volume(3.0);

            Console.Write("Circunferencia de uma esfera de raio 3,0: ");
            Console.WriteLine(circ3);
            Console.Write("Volume de uma esfera de raio 3,0: ");
            Console.WriteLine(vol3.ToString("F2"));
        }
    }
}


