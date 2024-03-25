using System;
using primeiraAula.Cap4.Classes;

namespace CursoDeCsharp
{    class test
    {        static void Main(string[] arg)
        {
            /* Hub de teste */

            string[] nomeAlunos = new string[] {"João", "Maria", "Pedro"};

            foreach (string nome in nomeAlunos){
                Console.WriteLine(nome);
            }
        }
    }
}


