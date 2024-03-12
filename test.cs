using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */
            Aluno aluno = new Aluno();
            
            Console.WriteLine("------ Exercicio 3 ------");
            Console.WriteLine("Bem vindo ao calculador de media!");
            
            Console.Write("Insira a seguir a nota tirada no primeiro semestre (ate 30 pontos): ");
            aluno.PrimeiroSemestre = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a nota tirada no segundo semestre (ate 35 pontos): ");
            aluno.SegundoSemestre = double.Parse(Console.ReadLine());

            Console.Write("E para finalizarmos, insira a nota tirada no terceiro semestre (ate 35 pontos): ");
            aluno.TerceiroSemestre = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(aluno);
        }
    }
}


