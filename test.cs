using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Console.WriteLine("Agora demonstraremos, como funciona o metodo ToString!");
            Console.WriteLine("Veja a seguir:");

            Carro corola = new Carro();

            corola.Modelo = "Corola";
            corola.Marca = "Toyota";
            corola.Ano = 2024;

            Console.WriteLine(corola);
        }
    }
}


