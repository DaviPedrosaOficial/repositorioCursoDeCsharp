/* ------ Metodo de saída ------ */

using System;
using System.IO.Pipes;

namespace primeiraAula
{
    class Aula_1
    {
        static void _1Aula(string[] arg)
        {
            string curso = "ciências da computação";
            string nome = "Davi";
            int idade = 24;
            string uni = "Una";
            double numero = 12.3568;
            
            /* Comando de saida em texto (WriteLine salta linha ao final da frase, Write não salta linhas). */
            Console.WriteLine("Olá mundo, esse é o meu primeiro programa em C#!");
            
            /* Utilizando {}'s para inserir variavéis dentro do texto de saída. */
            Console.WriteLine("Meu nome é {0}, tenho {1} anos e no momento estou cursando em {2} pela universidade {3}!",nome,idade,curso,uni);
            
            /* Utilizando o comando '\r\n' para saltar linhas onde desejado. */
            Console.WriteLine("\r\nO intuito desse primeiro programa é aprender a utilizar o comando 'Console.WriteLine' e suas formatações.");
            
            /* Utilizando o padrão de formatação para numeros decimais (Para isso utilizamos o comando '.ToString("F2")' ou
             alteramos no próprio PlaceHolder ( {0 : F2} ), onde o 'F' representa a quantidade de casas decimais desejadas 
             para o numero, ou seja, como nesse caso gostariamos de alocar apenas 2 casas decimais, foi-se utilizado F2. */
            Console.WriteLine("\r\nUtilizando a formatação de numeros decimais, a partir do comando .ToString -> {0} ",numero.ToString("F2"));
            
            Console.WriteLine("\r\nUtilizando a formatação de numeros decimais, a partir da formatação do PlaceHolder -> {0:F2} ",numero);
            
            
        }
    }
    
}