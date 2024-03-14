using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Produto2 pera = new Produto2();
           
            /* Instanciando com todos os atributos */
            Produto2 abacaxi = new Produto2("Abacaxi",3.90,10);
           
            /* Instanciando com apenas nome e preço */
            Produto2 uva = new Produto2("Uva",2.90);
           
            /* Como esperado, após criarmos, as sobrecargas em nossa classe, todas as instanciações que lá foram delcaradas
             estão funcionando, e permitindo que instanciemos nosso objeto da maneira que acharmos melhor.

             Para vermos a diferença do resultado de cada uma, vamos chamar nossa função ToString, para printá-los em nossos
             terminais.  */

            Console.WriteLine(pera);
            Console.WriteLine();

            Console.WriteLine(abacaxi);
            Console.WriteLine();

            Console.WriteLine(uva);
        }
    }
}


