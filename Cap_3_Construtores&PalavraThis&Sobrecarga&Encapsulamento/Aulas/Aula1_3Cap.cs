/* ------ Construtores ------ */

namespace CursoDeCsharp
{
    class Aula1_3Cap{
        
        static void _Aula1_3Cap(string[] arg)
        {
            /* ------ O que são contrutores? ------
             
             Construtores são operações especiais de uma classe, onde são executados logo em seu instanciamento!
             
             Ou seja, ao criar um objeto de uma classe que possui contrutores, teremos de declarar logo em sua instanciação
             o que o objeto terá para cada um dos mesmos.
             
             Pensando em um caso hipotético, se uma classe Funcionário, possuísse o um atríbuto .Nome em seu construtor,
             sempre que fossemos adicionar um novo "Funcionário" (objeto) a ela, teriamos que inserir em sua instanciação 
             o nome daquele funcionario!
             
             ------ Usos Comuns dos Construtores ------
             * Iniciar valores dos atributos de uma classe
             * Permitir ou obrigar que o objeto receba dados / depêndencias no momento de sua instanciação (injeção de
             depêndencia)                                                                                            
             
             Outro ponto interessante que temos visto, mas não chegamos a falar é que, caso os construtores customizados
             não sejam especificados, a classe disponibilizará um construtor padrão. Esse que temos utilizado até o momento
             quando vamos instanciar classes:
             Retangulo retangulo = new Retangulo();
             
             Além disso, é possível também utilizar mais de um construtor em uma classe, onde esses são chamados de 
             "sobrecarga"!
             
             Agora, vamos ver na prática como funciona:                                                               */
            
            /* Para demonstrarmos na prática foi criada a classe Moto */

            /* Entrada */
            Console.Write("Insira a seguir o modelo da moto: ");
            string modelo = Console.ReadLine();

            Console.Write("Agora, insira a marca da mesma: ");
            string marca = Console.ReadLine();

            Console.Write("E para finalizarmos insira o ano da mesma: ");
            int ano = int.Parse(Console.ReadLine());
            
            /* Repare que so criaremos instanciaremos o objeto agora, já que para fazer o mesmo necessitamos informar seus
             construtores!                                                                                            */

            Moto moto = new Moto(modelo,marca,ano);

            Console.WriteLine();
            Console.WriteLine(moto);

        }
    }
}