﻿using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Retangulo x = new Retangulo();

            Console.WriteLine("Bem vindo ao calculador de retangulos!");
            Console.Write("Insira a seguir a altura de seu retangulo: ");
            x.Altura = double.Parse(Console.ReadLine());
            Console.Write("Agora, insira a seguir a largura do mesmo: ");
            x.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("\r\nEntão vamos ao resultado!");
            Console.WriteLine(x);
        }
    }
}


