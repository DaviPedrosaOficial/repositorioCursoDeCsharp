/* ------ Composição ------- */
using CursoDeCsharp.Cap6.Aulas.Entities;
using CursoDeCsharp.Cap6.Aulas.Entities.Enums;

namespace CursoDeCsharp.Cap6.Aulas
{
    public class Aula2_Cap6
    {
        public void _Aula2_Cap6(string [] arg)
        {
            /* ------ O que é a composição? ------

             Composição é um tipo de associação que permite que um objeto contenha outro.

             Dependendo do caso podemos ter associações do tipo "tem-um" ou "tem-varios", a depender do caso
            em que estamos lidando.

            --- Vantagens ao se trabalhar com a composição ---

            - Organização do projeto (divisão de responsabilidades, ou seja, cada classe tem sua responsabilidade)
            - Coesão (cada objeto é responsável por apenas uma tarefa, simples e bem definida)
            - Flexibilidade (trabalhar com um projeto que cada parte tem suas obrigações torna-o muito simples e flexível)
            - Reuso (Um mesmo objeto pode ser utilizado em mais de um local, já que eles tem suas obrigações definidas e pontuadas)

             E para que possamos entender melhor o conceito faremos alguns exercícios para implementarmos na prática a composição.

             1º Exercício:

            Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar do usuário um mês e mostrar
            qual foi o salário do funcionário nesse mês. (Para o execício foram criadas as classes: Worker, dpt, HourContract
            e WorkerLevel)
            
            Agora abaixo, vamos fazer a execução do programa central (Main):                                                      */

            Console.Write("Enter the department name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept= new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("\r\nHow many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                
                Console.Write("Date (DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.Write("\r\nEnter with year and month to calculate the income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,month):F2}");

        }
    }
}