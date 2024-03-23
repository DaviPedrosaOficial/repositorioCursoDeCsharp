namespace CursoDeCsharp
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto(int numero, string nome, string email)
        {
            Numero = numero;
            Nome = nome;
            Email = email;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            /* Hub de teste */

            Quarto[] pensao = new Quarto[10];
            /* Criando vetor para armazenar os 10 quartos da pensão */

            Console.Write("Insira a seguir a quantidade de quartos que serão alugados: ");
            int qtdAluguel = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdAluguel; i++)
            {
                Console.Write("Insira a seguir o nome do estudante: ");
                string nome = Console.ReadLine();
                Console.Write("Agora, insira o e-mail do estudante: ");
                string email = Console.ReadLine();
                Console.Write("E por fim, insira o número do quarto que deseja alugar: ");
                int numero = int.Parse(Console.ReadLine());

                pensao[numero - 1] = new Quarto(numero, nome, email);
            }

            Console.WriteLine("\r\n---------- Relatório de aluguéis ----------");

            for (int i = 0; i < 9; i++)
            {
                if (pensao[i] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------");
                    Console.WriteLine("QUARTO Nº: {0}", i + 1);
                    Console.WriteLine("NOME DO ESTUDANTE: {0}", pensao[i].Nome);
                    Console.WriteLine("E-MAIL DO ESTUDANTE: {0}", pensao[i].Email);
                    Console.WriteLine("---------------------------------------------------------------------------");
                }
                else
                {
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