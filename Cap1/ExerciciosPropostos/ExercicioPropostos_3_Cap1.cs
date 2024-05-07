/* ------ Exercícios propostos 3 ------ */

using System;

namespace CursoDeCsharp.Cap1.ExerciciosPropostos
{
    class ExercicioPropostos_3_Cap1
    {
        static void Ex_Propostos3(string[] arg)
        {
            /* ------ Exercício 1 ------ */
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida.
             Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
             Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo
             encerrado. Considere que a senha correta é o valor 2002. */
            
            
            Console.WriteLine("------ Exercicio 1 ------");
            int senha = 2002;
            
            /* Entrada */
            Console.WriteLine("Digite a seguir sua senha, para proseguir: ");
            int testeCliente = int.Parse(Console.ReadLine());
            
            /* Processamento */
            while (testeCliente != senha)
            {
                Console.WriteLine("\r\nSenha Invalida!");
                Console.WriteLine("Tente novamente para que possamos prosseguir: ");
                testeCliente = int.Parse(Console.ReadLine());
            }
            
            /* Saída */
            Console.WriteLine("Acesso Autorizado!");



            
            /* ------ Exercício 2 ------ */
            /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). */


            Console.WriteLine("\r\n ------ Exercicio 2 ------");
            Console.WriteLine("Bem vindo ao Quadrant Finder, nesse programa iremos receber as coordenadas x e y, e retornaremos");
            Console.WriteLine("qual quadrante as mesmas fazem parte! ");

            double x = 0;
            double y = 0;
            
            /* Entrada */
            Console.WriteLine("Para iniciarmos, insira o valor de x e y a seguir (na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');

            x = double.Parse(vetor[0]);
            y = double.Parse(vetor[1]);

            /* Processamento */
            while ((x > 0 && y > 0) || (x < 0 && y < 0) || (x > 0 && y < 0) || (x < 0 && y > 0))
            {
                /* Quadrante 1 (x e y positivos) */
                if (x > 0 && y > 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q1 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");
                    
                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
                
                /* Quadrante 2 (x negativo e y positivo) */
                else if (x < 0 && y > 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q2 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");
                    
                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
                
                /* Quadrante 3 (x e y negativos)*/
                else if (x < 0 && y < 0)
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q3 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");

                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }

                /* Quadrante 4 (x positivo e y negativo) */
                else
                {
                    /* Saída */
                    Console.WriteLine("\r\nO vetor descrito se encontra no quadrante Q4 !");
                    /* Entrada */
                    Console.Write("Insira outro vetor para que possamos lhe dizer onde o mesmo se localiza: ");

                    vetor = Console.ReadLine().Split(' ');
                    x = double.Parse(vetor[0]);
                    y = double.Parse(vetor[1]);
                }
            }
            
            
            
            
            /* ------ Exercício 3 ------ */
            /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.
             Escreva um algoritmo para ler o tipo de combustível abastecido da seguinte forma: 
             (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel4.Fim). 
             Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código 
             (até que seja válido). O programa será encerrado quando o código informado for o número 4. 
             Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de 
             combustível, conforme o exemplo abaixo.
             
             Entrada                                         Saída
                8                                        Muito Obrigado!
                1                                           Álcool: 1
                7                                           Gasolina: 2
                2                                           Diesel: 0
                2
                4                                                                */

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

 