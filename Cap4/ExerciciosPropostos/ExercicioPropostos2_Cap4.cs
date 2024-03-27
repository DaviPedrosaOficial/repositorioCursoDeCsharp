/* ------ Exercícios Propostos 2 Cap 4 ------ */

namespace CursoDeCsharp{

    class ExercicioPropostos2_Cap4{

        static void Ex_Propostos2_Cap4(string [] arg){

            /* Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários.
            Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. 
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma mensagem e abor-
            tar a operação. Ao final, mostrar a listagem atualizada dos funcionários.
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente.
            Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.                 */

            List<Funcionario3> BancoDeFuncionarios = new List<Funcionario3>();

            Console.WriteLine("Bem vindo ao controle de funcionarios da empresa Birulinha!");

            while(true){
                Console.WriteLine();
                Console.WriteLine("Insira 1 para adicionar funcionarios ao sistema");
                Console.WriteLine("Insira 2 para aumentar o salario de um funcionario do sistema");
                Console.WriteLine("Insira 3 para visualizar a lista de funcionarios no sistema");
                Console.WriteLine("Insira 4 para encerrar o programa");
                Console.Write("Insira o numero correspondente a operacao que voce deseja efetuar: ");
                int controlador = int.Parse(Console.ReadLine());

                if (controlador < 1 && controlador > 4){
                    Console.WriteLine();
                    Console.WriteLine("Valor inserido invalido, tente novamente");
                }
                else if (controlador == 1){
                    int qtdFunc;
                    
                    while(true){
                        Console.WriteLine();
                        Console.Write("Insira a quantidade de funcionarios que voce deseja adicionar: ");
                        qtdFunc = int.Parse(Console.ReadLine());

                        if(qtdFunc < 1 && qtdFunc % 2 != 0){
                            Console.WriteLine("Valor inserido invalido, tente novamente");
                        }
                        else{
                            break;
                        }
                    }

                    for (int i = 0; i < qtdFunc; i++){
                        while(true){
                            Console.Write("Insira a seguir o id {0}º do funcionario: ", i + 1);
                            int testaId = int.Parse(Console.ReadLine());
                            
                            if (BancoDeFuncionarios.Find(x => x.Id == testaId)){
                                Console.WriteLine("O Id escolhido ja existe, tente novamente");
                            }
                        }
                    }
                }

            }
        }
    }
}