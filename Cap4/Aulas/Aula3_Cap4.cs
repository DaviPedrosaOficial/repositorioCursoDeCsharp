/* ------ Nullable ------ */

namespace CursoDeCsharp
{
    class Aula3_Cap4
    {
        static void _Aula3_Cap4(string [] arg)
        {
            /* ------ O que � o Nullable? ------
             
             Nullable � um recurso do C#, que permite com que tipos valor (struct) recebam valores nulos (null).
            
             Foi dito anteriormente que os mesmos n�o poderiam conter valor nulo, apenas os tipos refer�ncia.
            E de certa forma, a afirma��o esta correta, j� que nativamente, os mesmos s�o incapazes de fazer o
            mesmo. 
            
             Por�m, os tipos valos conseguem receber nulos, se utilizarmos do recurso Nullable! Onde esse, nada
            mais � do que uma nova maneira de tratar tipos valor. 

             O recurso � muito comum de ser encontrado, quando vamos definir vari�veis de valor opcionais. Ou seja,
            se temos de receber um informa��o que n�o tem obriga��o de ser informada, como: data de nascimento,
            celular ... 
            
             Para que tenhamos acesso a tal recurso � necess�rio seguir os poss�veis passos:
            
            - Inserir Nullable<> ao criar a vari�vel
            - Inserir ? ap�s a defini��o de seu tipo valor (Mais otimizado, recomendado)
            
             Veja a seguir sua implementa��o:                                                                  */

            Nullable<int> cpf = null;
            int? telefoneContato = null;

            /* Tente fazer o mesmo sem utilizar o recurso, e ver�s que o mesmo n�o dara certo!
             Exemplo: int cpf = null;
                      int telefoneContato = null;                                                               */

            /* Assim como outros recursos em C#, o Nullable possui 3 m�todos padr�es que podem ser chamados se o
             recurso estiver sendo utilizado. 
              
             S�o eles:
            - GetValueOrDefault
            - HasValue
            - Value (retorna uma excess�o caso n�o tenha valor, em outras palavras interrompe o andamento do c�digo)
            
             
             ---- GetValueOrDefault ----
             Tem a mesma ideia do get de nossas classes. O mesmo olha o recurso, descrito em uma vari�vel que recebeu
            Nullable, e executa o seguinte comando: 
             Se tiver valor definido, o mesmo retornar� o mesmo, caso contr�rio ir� retornar um valor default padr�o 
            (Ex.: valor default padr�o de double seria: 0.0)                                                        
            
             Veja sua execu��o a seguir:                                                                            */
            
            double? x = null;
            double? y = 27.50;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            /* Como dito acima, o resultado dos comandos foram 0, para o x, uma vez que o mesmo era nulo, e 27,50 para y, 
            já que o mesmo possuía valor!
            
             ---- HasValue ----
              O método HasValue, é um booleano que tem como função dizer se aquela variável Nullable, possui ou não valor 
             definido. Caso a variável tenha valor, o mesmo retornará "true" e caso não tenha "false"!
             
              Veja sua execução a seguir:                                                                               */
            Console.WriteLine();
            Console.WriteLine("x possui valor? \r\nResposta: {0}",x.HasValue);
            Console.WriteLine("y possui valor? \r\nResposta: {0}",y.HasValue);

            /* Se executado, teremos x como "false" e y como "true", uma vez que x foi declarado como null(nulo) e y possuí 
            o valor 27,50! 
            
            ---- Value ----
             O método Value, retorna para a gente o valor que a variável possuí. Porém, caso a mesma não possua valor, nosso 
             programa quebrará, uma vez que o método não conseguirá prosseguir com sua execução.
             
              Veja sua execução a seguir:                                                                                  */

              Console.WriteLine();
              Console.WriteLine("VALOR DE 'y': {0}",y.Value);

              /* Não iremos executar x.Value, pois teriamos uma quebra de nosso código, mas já podemos ter uma noção de como
              funciona o metodo Value! 
              
              Porém, poderiamos criar uma estrutura para que o erro não ocorresse, utilizando o método HasValue, como veremos
              a seguir:                                                                                                    */

              Console.WriteLine();
              if (x.HasValue){
                Console.WriteLine(x.Value);
              }
              else{
                Console.WriteLine("x é nulo!");
              }
              if(y.HasValue){
                Console.WriteLine(y.Value);
              }
              else{
                Console.WriteLine("y é nulo!");
              }

              /* ---- Operador de coalecência nula ----
               O operador de coalecência nula é um operador que visa melhorar a execução de nosso código, evitando com que possiveis
              excessões ocorram, quando tentarmos fazer com que uma variável que não seja Nullable, receba um valor de uma variável
              Nullable. 
               Tal processo pode ocasionar em uma excessão, já que variáveis structs não podem receber valores nulos, então para que 
              não ocorra o mesmo, utilizamos o operador de coalecência. 
              
              O operador é representado por "??", e é utilizado da seguinte forma:                                                */

              double a = x ?? 0.0;
              
              Console.WriteLine();
              Console.WriteLine("VALOR DE 'a': {0}", a);

              /* Note que, como o x é nulo, a variável a receberá o valor 0.0 que escolhemos, podendo ser qualquer outro, como 5 por
              exemplo. */
        }
    }
}