/* ------ Inferência de tipos (palavra var) ------ */

namespace CursoDeCsharp.Cap5.Aulas
{

    class Aula1_Cap5{

        static void _Aula1_Cap5(string [] arg){

            /* ------ O que são as inferências de tipos? ------

            Inferência de tipo é uma maneira de formularmos um código, onde ao invés de declararmos o tipo
            de suas variáveis, colocamos a palavra "var". Onde essa, é uma espécie de tipo no qual se adequa
            ao que a mesma terá como conteúdo.
            
            Ou seja, ao utilizarmos a palavra var para criar uma variável, a mesma passará a ter tipos distin-
            tos a depender do conteúdo que será inserido nela, como exemplo, se for inserido um texto a nova
            variável passará a ser de tipo string, se for um inteiro, a variável passará a ser de tipo int...
            
            Por mais incrivel e prático que pareça ser a utilização das inferências, o seu uso não é recomendado,
            já que o mesmo torna o desenvolvimento de códigos mais desleixados, o que pode vir a trazer falhas no
            mesmo. Para demonstrar isso, vamos dar um exemplo:
            
            Imagine que no seu código será necessário a entrada de um valor que representará o peso de um paciente,
            e ao desenvolvermos o código, utilizamos a inferência para a variável peso. Agora, imagine que o nosso
            cliente, ao invés de inserir o peso em números, decidiu colocá-lo em extenso, o que foi permitido, já
            que nossa variável peso está utilizando a inferência como tipo.
            
            Ao decorrer de nosso programa será necessário fazer um calculo utilizando a variável peso, para saber se
            a situação do paciente está, boa, ruim, preocupante... Porém, como nosso cliente entrou com seu peso em
            extenso, ao passar pelo calculo, nosso código apresentará erro e assim interrompendo o processo.
            
            Então é importante utilizarmos os tipos corretos, tanto para auxiliar na própria compreensão de nosso có-
            digo, quanto para evitarmos que ocorram problemas no mesmo devido a propriedade mutativa das inferências.
            
            Antes de encerrarmos, vamos ver como elas funcionam na prática:                                       */

            /* Variável 'x' utilizando a inferência e se tornando de tipo string */
            var x = "Olá mundo!";
            /* Variável 'y' utilizando a inferência e se tornando de tipo int */
            var y = 10;
            /* Variável 'z' utilizando a inferência e se tornando de tipo double */
            var z = 22.00;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
        }
    }
}