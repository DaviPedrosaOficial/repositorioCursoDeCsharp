using System;
using System.IO.Pipes;

namespace primeiraAula
{
    class Exercício_1
    {
        static void Main(string[] arg)
        {
            string curso = "ciências da computação";
            string nome = "Davi";
            int idade = 24;
            string uni = "Una";
            
            Console.WriteLine("Olá mundo, esse é o meu primeiro programa em C#!");
            Console.WriteLine("Meu nome é {0}, tenho {1} anos e no momento estou cursando em {2} pela universidade {3}!",nome,idade,curso,uni);
            Console.WriteLine("\r\nO intuito desse primeiro programa é aprender a utilizar o comando 'Console.WriteLine' e suas formatações.");
        }
    }
    
}