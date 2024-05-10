using CursoDeCsharp.Cap6.Aulas.ExercicioProposto.Entities;
using CursoDeCsharp.Cap6.Aulas.ExercicioProposto.Entities.Enums;

Client client= new Client();

            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            client.Name = Console.ReadLine();

            Console.Write("Email: ");
            client.Email = Console.ReadLine();

            Console.Write("Birth Date (DD/MM/YYYY): ");
            client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter order data: ");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: R$ ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                Product prod = new Product(name, price);
                OrderItem item= new OrderItem(quant,prod);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(order);