/* ------ Operadores aritméticos + Bônus (criando mais de uma variável em uma mesma linha, e resolução de Bahskara ------ */

using System;

namespace CursoDeCsharp
{
    class Aula_4
    {
        static void _4Aula(string[] arg)
        {
            /* Operadores existentes:
             - '+' = Adição;
             - '-' = Subtração;
             - '*' = Multiplicação;
             - '/' = Divisão;
             - '%' = Mod (Resto da divisão); */
            
            /* Os operadores (* , / , %) tem precedência maior que (+ , -), ou seja, assim como na matemática
             tais operadores serão executados antes do que a adição e a subtração. 
             Exemplo: 3 + 4 * 2 = 11
             Se você desejar que 3 + 4 seja executado primeiro, é necessário colocá-los entre parênteses, como 
             no exemplo a seguir: 
             (3 + 4) * 2 = 14  */

            int num = 3 + 4 * 2;
            Console.WriteLine("Demontração do calculo: 3 + 4 * 2");
            Console.WriteLine(num);

            int num2 = (3 + 4) * 2;
            Console.WriteLine("\r\nDemonstração do calculo: (3 + 4) * 2");
            Console.WriteLine(num2);

            /* O que é o Mod:
             Ao fazermos uma divisão, sempre teremos a casa do resto, mesmo que esse tenha sido 0, e é o mesmo
             que será contabilizado como Mod (%).
             Para ficar mais facíl demontraremos um exemplo a seguir:
             Imagine que temos uma variável que armazenara nosso Mod, e seu nome será resto, e nela armazenaremos
             o resto da divisão de 5 por 2, ou seja 5/2.

             resto = 5 % 2;

             O console fará a seguinte operação:
                     (Divisor) 5 | 2 (Dividendo)
            (Resto da divisão) 1   2 (Quociente)

            Como solicitamos o Mod, ao invés do programa armazenar o resultado da divisão, o mesmo fará a divisão
            até o ponto em que seja necessário adicionar dizimas a operação, ou a operação se encerre com resto 0;
            Em ambos o caso, o programa armazenara na variável o resto da divisão, mesmo esse sendo 0;

            No caso do exemplo acima, a variável resto, receberia como resultado 1, uma vez que o mesmo é o resto
            da divisão solicitada.  */

            int mod = 5 % 2;
            Console.WriteLine("\r\nDemontração mod: 5 % 2");
            Console.WriteLine(mod);
            
            /* Outro ponto importante de se salientar, se trata da divisão númerica.
            Isso se deve ao fato do compilador da linguagem C#, precisar do casting para demontrar o resultado em
            double.
            Ou seja, se criarmos uma variável inteira para receber o resto de uma divisão que terá dizimas, como
            esperado teremos um resultado inteiro, ou seja, sem as casas decimais.
            
            Porém, se colocarmos um double ou float, a depender da maneira em que o inserirmos, continuaremos 
            recebendo um valor inteiro.
            
            Exemplo: double div = 10 / 3;
                     O resultado dessa operação será 3, isso se deve a maneira como os números foram inseridos.
                     Como o valor 10 e o 3 foram inseridos sem casas decimais, o compilador entenderá que ambos
                     são inteiros, e assim retornará o valor 3;
            
            Para que possamos receber o valor correto existem duas maneiras.
            - A primeira é utilizar o Casting, ficando da seguinte maneira:
            double div = (double) 10 / 3;
            O que nos retornará o resultado, 3,333...
            
            - A segunda é apresentar no mínimo um número com decimais, fazendo assim com que o compilador entenda
            que você deseja um resultado em double:
            double div = 10.0 / 3;
            ou 
            double div = 10 / 3.0;
            ou 
            double div = 10.0 / 3.0;
            O que também nos levará ao resultado 3,333...
            */

            float div = 10 / 3;
            Console.WriteLine("\r\nDemontrando que a divisão em float: 10 / 3, resultará no resultado 3 ");
            Console.WriteLine(div);

            float div2 = (float)10 / 3;
            Console.WriteLine("\r\nDemontrando que conseguimos o resultado fracionado utilizando \r\no Casting (float) 10 / 3, ou 10f / 3");
            Console.WriteLine(div2);
            
            float div3 = 10.0f / 3;
            Console.WriteLine("\r\nDemontrando que conseguimos o resultado fracionado utilizando 10.0 / 3");
            Console.WriteLine(div3);
            
            /* ------ Bônus ------ */
            /* É possível criarmos mais de uma variável do mesmo tipo em apenas uma linha de comando.
             Para isso, utilizamos a virgula para separar cada uma delas, veja no exemplo abaixo: 
             double a = 2.0 , b = 4.0 , c = 3.0; */
            
            /* Resolvendo a formula de bahskara com dicas */
            double a = 1.0, b = -3.0, c = -4.0;
            
            /* Criando a variavel para delta */
            double delta = Math.Pow(b, 2) - 4.0 * a * c;
            /* Comando Math.pow (utilizado para fazer exponenciação), tem como primeiro parâmetro o número que
             será exponenciado, e o segundo por quanto o mesmo será.*/
            
            /* Resolvendo x1 */
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            /* Comando Math.sqrt (utilizado para fazer a raiz quadrada de seu parâmetro). */
            /* Importante salientar que devemos prestar atenção na ordem de precedência, como foi feito acima,
             onde foi utilizado parênteses para deixar o código correto. */
            
            /* Resolvendo x2 */
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            
            /* Resultado da formula */
            Console.WriteLine("\r\nResultado da formula de bahskara onde a = 1 , b = -3 , c = -4");
            Console.WriteLine("Resultado de x1: {0}", x1);
            Console.WriteLine("Resultado de x2: {0}",x2);
        }
    }
}