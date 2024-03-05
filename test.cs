using System;

namespace CursoDeCsharp
{
    class test
    {
        static void Main(string[] arg)
        {
            /* Hub de teste */

            Console.WriteLine("\r\n ------ Exercicio 3 ------");
            Console.WriteLine("Bem vindo a pesquisa de satisfacao do posto Verde!");
            Console.WriteLine("Insira a seguir qual o produto de sua preferencia, de acordo com os codigos abaixo:");
            Console.WriteLine("1 - Alcool; 2 - Gasolina; 3 - Diesel; 4 - Finalizar consulta");
            
            int cod = 0;
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            /* Entrada */
            Console.Write("Insira a frente seu produto: ");
            
            /* Processamento */
            while (cod != 4)
            {
                cod = int.Parse(Console.ReadLine());

                /* Condicional para valores inválidos */
                if (cod < 1 || cod > 4)
                {
                    Console.Write("\r\nValor inserido invalido.\r\nFavor inserir novamente: ");
                }
                
                /* Condicional para seleção de alcool */
                else if (cod == 1)
                {
                    Console.WriteLine("\r\nAlcool adicionado!");
                    alcool += 1;
                    Console.Write("\r\nInsira a seguir seu produto: ");
                }
                
                /* Condicional para seleção de gasolina */
                else if (cod == 2)
                {
                    Console.WriteLine("\r\nGasolina adicionada!");
                    gasolina += 1;
                    Console.Write("\r\nInsira a seguir seu produto: ");
                }
                
                /* Condicional para seleção de diesel */
                else if (cod == 3)
                {
                    Console.WriteLine("\r\nDiesel adicionado!");
                    diesel += 1;
                    Console.Write("Insira a seguir seu produto: ");
                }

                /* Condicional para encerrar o programa */
                else
                {
                    Console.WriteLine("\r\nObrigado por participar de nossa pesquisa!");
                }
            }

            Console.WriteLine("\r\nSeu resultado foi: \r\nAlcool: {0} \r\nGasolina: {1} \r\nDiesel: {2}",alcool,gasolina,diesel);
        }
    }
}


