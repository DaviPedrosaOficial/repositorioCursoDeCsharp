/* ------ Sintaxe opcional: laço foreach ------ */

namespace CursoDeCsharp{

    class Aula8_Cap4{

        static void _Aula8_Cap4(string [] arg){

            /* ------ O que é o laço foreach? ------
            
            O laço foreach é uma sintaxe opcional e simplificada para percorrer coleções, seja essa um vetor, uma lista, ...
            
            O mesmo possuí a seguinte nomenclatura:
            
            foreach (tipo apelidoDado in nomeDaColeção){
            }
             
            Passando para o português ficaria: para cada elemento em coleção, faça{
            }
            
            Explicando a nomenclatura:
            
            - tipo: É o tipo do elemento que você utilizará, então se sua coleção é feita de strings, o tipo será string
            
            - apelidoDado: Como será necessário dizer dentro de seu lastro, é necessário dar um apelido para que possamos
            manuseá-los corretamente, e para isso utilizaremos o apelidoDado
            
            - in: Como no inglês, in significa "em", então o mesmo esta ali para demonstrar onde iremos executar o loop
            
            - nomeDaColeção: O nomeDaColeção, é o nome do conjunto que iremos executar o loop
            
            Para que possa ficar ainda mais claro, vamos ver a execução abaixo:                                          */

            string[] nomeAlunos = new string[] {"João", "Maria", "Pedro"};

            foreach (string nome in nomeAlunos){
                Console.WriteLine(nome);
            }

            /* O exemplo acima é uma simples demonstração, mas a partir da sixtaxe podemos efetuar diversas operações para
            auxiliar nossos projetos                                                                                     */
        }
    }
}