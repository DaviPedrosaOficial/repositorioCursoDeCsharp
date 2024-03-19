/* ------ Entrada de dados (Parte 2) ------ */

using System;

namespace CursoDeCsharp
{
    class Aula6_Cap1
    {
        static void _Aula6(string[] arg)
        {
            /* Agora iremos fazer a entrada de variáveis que tem como entrada parâmetros diferentes de 'strings'.
             Como dito na aula 5, o Console.ReadLine() lê apenas textos, e para que possamos receber, inteiros,
             doubles, chars ... utilizamos o metodo .Parse() */
            
            /* O mesmo funciona da seguinte forma, ao solicitar uma entrada para uma variável int', por exemplo,
             faremos a chamada normal colocando o tipo da variável + seu nome + recebe (=) + tipo da variável +
             Parse + Console.ReadLine() + ';' 
             Veja a seguir: */

            /* Exemplo com int */
            Console.WriteLine("Insira a seguir a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            /* Exemplo com char */
            Console.WriteLine("\r\nInsira a seguir o seu sexo (Com M ou F): ");
            char sexo = char.Parse(Console.ReadLine());
            
            /* Exemplo com double */
            Console.WriteLine("\r\nInsira o seu saldo em conta: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("\r\n---- Confirmação da conta ----");
            Console.WriteLine("Idade: {0}\r\nSexo: {1}\r\nSaldo: {2}",idade,sexo,saldo);
            
            /* Utilizando junto ao vetor */

            Console.WriteLine("\r\nInsira a seguir as seguintes informações em ordem: nome, idade, sexo, deposito\r\ninserir na mesma linha, utilizando espaço para separa-las: ");
            string[] vet = Console.ReadLine().Split(' ');

            string nome_2 = vet[0];
            int idade_2 = int.Parse(vet[1]);
            char sexo_2 = char.Parse(vet[2]);
            float deposito_2 = float.Parse(vet[3]);

            Console.WriteLine("\r\n----- Confirmando informações do deposito -----\r\nNome: {0}\r\nIdade: {1}\r\nSexo: {2}\r\nValor de deposito: {3:F2}",nome_2,idade_2,sexo_2,deposito_2);
        }
    }
}