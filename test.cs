using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Lapis lapis = new Lapis("Laranja", "Cis");

            lapis.Cor = "Azul";
            lapis.marca = "Faber-Castell";

            Console.WriteLine(lapis.Cor);
            Console.WriteLine(lapis.marca);
        }
    }
}


