using CursoDeCsharp.Cap7.Entities;

            Account acc = new Account(001, "Gustavo", 900);
            Account acc1 = new BusinessAccount(002, "Maria", 900, 1500);
            Account acc2 = new SavingsAccount(003, "Bruna", 900, 0.01);

            /* Agora que instanciamos nossos objetos, vamos executar o método Withdraw em cada um deles, para que possamos ver a di-
            ferença do resultado em cada um deles:                                                                                */
        
            acc.Withdraw(60.0);
            acc1.Withdraw(60.0);
            acc2.Withdraw(60.0);

            Console.WriteLine($"Valor na conta de todos antes da execução do método Withdraw: R$ 900,00");
            Console.WriteLine($"Resultado do método na Superclasse Account: R${acc.Balance:F2}\r\n");
            Console.WriteLine($"Resultado do método na Subclasse BusinessAccount: R${acc1.Balance:F2}\r\n");
            Console.WriteLine($"Resultado do método na Subclasse SavingsAccount: R${acc2.Balance:F2}\r\n");