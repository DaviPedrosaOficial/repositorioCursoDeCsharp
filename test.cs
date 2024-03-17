using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Animal animal = new Animal("Elefante", 30, "Blue");

            /* Utilizando o método get, a partir de nossa auto-properties */
            animal.Especie = "Leao";
    
            /* Se tentassemos fazer "animal.Idade = 10;" não seria possível, já que seu método set foi privado em nossa
             classe */
            
            animal.Nome = "Rubros";
            
            /* Utilizando os métodos set de nossa classe */
            Console.WriteLine("ESPECIE: {0}",animal.Especie);
            Console.WriteLine("IDADE: {0}",animal.Idade);
            Console.WriteLine("NOME: {0}",animal.Nome);
        }
    }
}


