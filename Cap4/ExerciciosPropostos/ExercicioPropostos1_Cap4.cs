/* ------ Exercício Proposto 1 Cap 4 ------- */

namespace CursoDeCsharp{

    class ExercicioPropostos1_Cap4{

        static void Ex_Propostos1_Cap4(string [] arg){

            /* A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos 
            identificados pelos números 0 a 9.
            
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
            
            Fazer um programa que inicie com todos os dez quartos vazios, e depois leia uma quantidade N
            representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10).
            
            Em seguida, registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e
            email do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja escolhido
            um quarto vago. Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato,
            por ordem de quarto.

            Foi criada a classe Quarto para resolver o exercício!                                            */

            Quarto[] pensao = new Quarto[10];
            /* Criando vetor para armazenar os 10 quartos da pensão */

            Console.Write("Insira a seguir a quantidades de quartos que serao alugados: ");
            int qtdAluguel = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAluguel; i ++){
                Console.Write("Insira a seguir o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Agora, insira o e-mail do estudante: ");
                string email = Console.ReadLine();
                Console.Write("E por fim, insira o numero do quarto que deseja alugar: ");
                int numero = int.Parse(Console.ReadLine());

                pensao[numero + 1] = new Quarto(numero,nome,email);
            }

        Console.WriteLine("\r\n---------- Relatorio de alugueis ----------");

            for (int i = 0; i < 9; i++){
                if(pensao[i] != null){
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("QUARTO Nº: {0}", i + 1);
                    Console.WriteLine("NOME DO ESTUDANTE: {0}", pensao[i].Nome);
                    Console.WriteLine("E-MAIL DO ESTUDANTE: {0}", pensao[i].Email);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("QUARTO Nº: {0}", i + 1);
                    Console.WriteLine("QUARTO VAGO!");
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
            }
            }
        }
    }
}