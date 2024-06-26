﻿/* ------ Encapsulamento ------ */

using CursoDeCsharp.Cap3.Classes;

namespace CursoDeCsharp.Cap3.Aulas
{
    class Aula5_Cap3
    {
        static void _Aula5_Cap3(string[] arg)
        {
            /* ------ O que é o encapsulamento? ------
              O encapsulamento é um pilar muito importante para a orientação à objetos, pois, ele permite nos permite 
             controlar o que pode e o que não poderá ser feito com nossa classe. 
             
              Isso ocorre, de maneira que ao criarmos os atributos e métodos de nossa classe, podemos deifinir se os mesmos
             serão públicos (outras arquivos terão liberdade de fazerem o que quiserem com o mesmo) ou privado (somente a 
             classe poderá alterar os mesmos).
             
              Sendo assim, o encapsulamento tem como função esconder detalhes de implementações de um componente, expondo 
             somente operações seguras o mantendo em estado consistente. 
             
               Agora vamos ver como fica na prática, para que possamos ter uma compreensão do conceito */

            Console.WriteLine("Insira a seguir quantos hardwares voce deseja inserir no estoque: ");
            int numDeHardwares = int.Parse(Console.ReadLine());

            List<Hardware> estoqueDeHardware = new List<Hardware>();

            for (int i = 1; i <= numDeHardwares; i++)
            {
                Console.Write("Insira a seguir o tipo do {0}º hardware: ",i);
                string tipo = Console.ReadLine();

                Console.Write("Insira a seguir o modelo do mesmo: ");
                string modelo = Console.ReadLine();

                Console.Write("Insira a seguir a marca do mesmo: ");
                string marca = Console.ReadLine();

                Console.Write("Insira a seguir o preco do mesmo: ");
                double preco = double.Parse(Console.ReadLine());

                Hardware hardware = new Hardware(tipo, modelo, marca, preco);

                estoqueDeHardware.Add(hardware);

            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Deseja fazer alguma mudança em algum produto, ou demonstrar alguma informacao produto\r\nem estoque?");
                Console.WriteLine("Insira 1 para fechar o programa");
                Console.WriteLine("Insira 2 para alterar um dos atributos do produto desejado");
                Console.WriteLine("Insira 3 para demonstra a alguma informacao de um dos produtos");
                Console.WriteLine("Insira 4 para ver todos os hardwares em estoque com seus atributos");
                Console.Write("Insira a seguir o numero correspondente ao seu desejo: ");
                int controle = int.Parse(Console.ReadLine());

                if (controle < 1 || controle > 4)
                {
                    Console.WriteLine("\r\nNumero inserido invalido, tente novamente");
                }
                
                else if (controle == 1)
                {
                    break;
                }
                
                else if (controle == 2)
                {
                    Console.Write("\r\nInsira o modelo do produto que voce deseja alterar algum atributo: ");
                    string modeloHardware = Console.ReadLine();

                    foreach (var hardware in estoqueDeHardware)
                    {
                        if (hardware.GetModelo() == modeloHardware)
                        {
                            Console.WriteLine("\r\nProduto encontrado!");
                            Console.Write("Agora insira qual atributo voce deseja alterar (tipo, modelo, marca ou preco): ");
                            string atributo = Console.ReadLine().ToLower();

                            if (atributo != "tipo" && atributo != "modelo" && atributo != "marca" &&
                                atributo != "preco")
                            {
                                Console.WriteLine("\r\nAtributo inserido invalido, tente novamente");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (atributo == "tipo")
                                {
                                    Console.Write("\r\nInsira qual o novo tipo que voce deseja: ");
                                    string novoTipo = Console.ReadLine();
                                    
                                    /* Repare que para, mudarmos um atributo tivemos que chamar o método, e ao invés de
                                     inserí-lo diretamente ao atributo*/
                                    hardware.SetTipo(novoTipo);

                                    Console.WriteLine("\r\nTipo alterado!");
                                }
                                else if (atributo == "modelo")
                                {
                                    Console.Write("\r\nInsira qual o novo modelo que voce deseja: ");
                                    string novoModelo = Console.ReadLine();
                                    
                                    hardware.SetModelo(novoModelo);

                                    Console.WriteLine("\r\nModelo alterado!");
                                }
                                
                                else if (atributo == "marca")
                                {
                                    Console.Write("\r\nInsira qual o nova marca que voce deseja: ");
                                    string novoMarca = Console.ReadLine();
                                    
                                    hardware.SetMarca(novoMarca);

                                    Console.WriteLine("\r\nMarca alterado!");
                                }
                                
                                else
                                {
                                    Console.Write("\r\nInsira qual o novo preco que voce deseja: ");
                                    double novoPreco = double.Parse(Console.ReadLine());
                                    
                                    hardware.SetPreco(novoPreco);

                                    Console.WriteLine("\r\nPreco alterado!");
                                }
                            }
                        }
                    }
                    
                }
                
                else if (controle == 3)
                {
                    Console.Write("\r\nInsira o modelo do produto que voce deseja alterar algum atributo: ");
                    string modeloHardware = Console.ReadLine();

                    foreach (var hardware in estoqueDeHardware)
                    {
                        if (hardware.GetModelo() == modeloHardware)
                        {
                            Console.WriteLine("\r\nProduto encontrado!");
                            Console.Write("Agora insira qual atributo voce deseja visualizar (tipo, modelo, marca ou preco): ");
                            string atributo = Console.ReadLine().ToLower();

                            if (atributo != "tipo" && atributo != "modelo" && atributo != "marca" &&
                                atributo != "preco")
                            {
                                Console.WriteLine("\r\nAtributo inserido invalido, tente novamente");
                                Console.WriteLine();
                            }
                            else
                            {
                                if (atributo == "tipo")
                                {
                                    /* Repare que para, visualizarmos um atributo tivemos que chamar o método, que
                                     retorna o mesmo, já que não seria possível fazer o mesmo somente colocando o 
                                     objeto.Atributo */
                                    Console.WriteLine("\r\nTIPO: {0}", hardware.GetTipo());
                                }
                                else if (atributo == "modelo")
                                {
                                    Console.WriteLine("\r\nMODELO: {0}", hardware.GetModelo());
                                }
                                
                                else if (atributo == "marca")
                                {
                                    Console.WriteLine("\r\nMARCA: {0}", hardware.GetMarca());
                                }
                                
                                else
                                {
                                    Console.WriteLine("\r\nPRECO: {0:F2}", hardware.GetPreco());
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\r\n---------- Estoque de Hardwares ----------");
                    Console.WriteLine();
                    
                    foreach (var hardware in estoqueDeHardware)
                    {
                        
                        Console.WriteLine(hardware);
                    }
                }
            }
        }
    }
}