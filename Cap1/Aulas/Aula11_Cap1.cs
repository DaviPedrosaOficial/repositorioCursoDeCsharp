/* ------ Funções (sintaxe) ------ */

using System;

namespace CursoDeCsharp
{
    class Aula11_Cap1
    {
        static void _Aula11(string[] arg)
        {
            /* O que são funções e para que elas servem?
             
             * Funções representam um processamento que tem um significado, seja esse parte de uma biblioteca, ou uma
             função feita por nos mesmos.
             
             Exemplos de funções de biblioteca:
             - Math.sqrt(double) (retorna a raiz quadrada de um valor de sua escolha)
             - Console.WriteLine(string) (printa uma informação no terminal, ou programa)
             
             Exemplo de possíveis funções que podemos desenvolver:
             - CalculoImpRenda (salárioFuncionario) (função para retornar o imposto de renda a parir do salário do funcionário)
             - CalculoSalário (horasTrabalhadas, valorHora) (função para retornar o valor que um funcionário deve receber) 
             
             * Principais vantagens de se utilizar funções:
             - Modularização (Dividir o seus programas em partes menores, o tornado mais limpo e eficiente)
             - Delegação (Permite delegar o processamento de um processo a uma parte específica do programa, o tornando mais
             simples)
             - Reaproveitamento (Nos permite reaproveitar processos, economizando tempo e linhas em nosso programa)
             
             * Dados de entrada e saída
             - As funções podem receber dados de entrada, tendo assim uma acertividade maior sobre o que a mesma deverá
             utilizar como parâmetro ou argumento para ser executada.
             - As funções podem ou não retornar uma saída, ao depender do que esperamos da mesma.
             
             * Observação: Ao trabalharmos com orientação a objetos, funções em classses recebem o nome de "Metodos". */
            
            /* ------ Demonstrando a utilização de funções -----*/

            Console.WriteLine("Insira a seguir tres numeros inteiros, para que possamos averiguar qual deles e o maior");
            Console.WriteLine("Insira o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro e ultimo numero: ");
            int n3 = int.Parse(Console.ReadLine());

            /* Ao invés de escrevermos o código abaixo, todas as vezes que formos fazer tal comparação em nosso programa,
             delegamos esse trabalho a uma função. A mesma se encontra no final do código,após o fechamento da função de 
             execução do programa, uma vez que o próprio static void _Aula11(string [] arg) é também uma função!
             
             if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("\r\nO numero {0} e o maior entre os tres escolhidos!",n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("\r\nO numero {0} e o maior entre os tres escolhidos!",n2);
            }
            else
            {
                Console.WriteLine("\r\nO numero {0} e o maior entre os tres escolhidos!",n3);
            }  */
            
            /* ------ Após criada a função basta chamarmos a mesma ------ */
            Console.WriteLine("O numero {0} e o maior entre os tres escohidos!",Maior(n1,n2,n3));

        }
        
        /* Nomenclatura para a criação de nossa função:
         
         Ao criarmos uma função devemos, por enquanto inserir static a frente (pois a mesma entrara em uma outra static),
         depois inserir o tipo que retornará nessa função (nesse nosso caso será 'int', uma vez que ela verificará somente
         numeros inteiros), depois inserimos o nome da mesma e seus argumentos ou parâmentros dentro do parênteses.
         
         Após sua criação, inserimos dentro da mesma os comandos que desejamos para a mesma, e qual sera seu retorno, se 
         desejado.
         
         Veja a seguir como fica:  */

        static int Maior(int a, int b, int c)
        {
            int maior = 0;
            if (a > b && a > b)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}

