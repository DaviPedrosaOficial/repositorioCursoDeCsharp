using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Console.Write("Insira a seguir o modelo da moto: ");
            string modelo = Console.ReadLine();

            Console.Write("Agora, insira a marca da mesma: ");
            string marca = Console.ReadLine();

            Console.Write("E para finalizarmos insira o ano da mesma: ");
            int ano = int.Parse(Console.ReadLine());
            
            /* Repare que so criaremos instanciaremos o objeto agora, já que para fazer o mesmo necessitamos informar seus
             construtores!                                                                                            */

            Moto moto = new Moto(modelo,marca,ano);

            Console.WriteLine();
            Console.WriteLine(moto);
        }
    }
}


