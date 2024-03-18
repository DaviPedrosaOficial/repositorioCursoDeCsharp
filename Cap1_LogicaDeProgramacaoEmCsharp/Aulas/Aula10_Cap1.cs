/* ------ Escopo e inicialização ------ */

using System;

namespace CursoDeCsharp
{
    class Aula10_Cap1
    {
        static void _Aula10(string[] arg)
        {
            /* ------ Escopo de uma variável ------ */
            /* O escopo de uma variável é aonde uma variável é válida, ou seja, aonde a mesma pode ser referênciada.
              Para que possamos entender melhor, temos que pensar da seguinte forma: 
              
              Ao criarmos uma variável em um código em que ainda não possui nada, apenas a formatação padrão de sua linguagem,
            como a definição de qual classe se localiliza aquele código, as linhas que definem o que será executado
            no mesmo (como nesse utilizamos o "static void Main(string [] arg)") , ...
              
              Essa categorização por si, já é um escopo, onde iremos declarar nossas variáveis, funções ...
              
              É importante termos essa compreensão, pois, ao criarmos estruturas, como as condicionais, estamos também,
            criando um novo escopo. Onde, variáveis e condições criadas nele, só existirão dentro do mesmo.
              */

            /* A variável abaixo, se encontra no escopo geral dessa classe em nosso projeto */
            int varEscopo = 0;
            int varFuncao = 0;

            if (varEscopo == 0)
            {
                /* Note que, uma variável de um escopo maior, pode ser utilizado em um escopo menor, porém, o contrário não
                 poderia acontecer.*/
                varFuncao += 20;
                /* Se tentassemos criar uma varíavel dentro do escopo desta condicional, a mesma so existiria aqui dentro,
                 sendo encerrado juntamente com a condicional. */
            }

            Console.WriteLine(varFuncao);

            
            
            /* ------ Inicialização ------ */
            /* A inicialização é o conceito de declarar um variável por completo, ao criarmos a mesma.
              Isso porque ao ser chamada em um "Console.ReadLine" por exemplo, a variável precisará ter pelo menos um
             parâmetro para ser demonstrado, e caso o mesmo não tenha sido especificado poderemos ter um problema com
             nosso código.
             
             Isso, pode vir a ocorrer por exemplo, quando criamos uma variável que poderá a vir receber algo de uma 
             condicional, mas se a mesma não se encaixar em suas condições, a variável ficará vazia, dando assim um
             erro em nosso programa, já que o mesmo não terá nada para exibir, uma vez que não foi feita a inicialização 
             correta da variável.
             
             
             Exemplo da forma correta de se iniciar variáveis:
             
             int num = 0;
             double fração = 0.0;
             bool condição = False;
             
              */

        }
    }
}