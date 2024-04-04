/* ------ Funções interessantes para string ------ */

namespace CursoDeCsharp{

    class Aula4_Cap5{

        static void _Aula4_Cap5(string [] arg){

            /* Nessa aula demonstraremos funções que podem ser utilizada por strings.
            Veja abaixo a explicação e execução de cada uma delas:                                               */

            /* Para ser mais didático ao demonstrá-las, vamos criar uma string principal, e modificaremos a mesma
            utilizando as funções.                                                                               */

            string original = "abc abCDe abcdEFG  ";

            /* Para começarmos, vamos utilizar as funções .ToLower(), que converte a string para letras minúsculas.
            Veja a seguir:                                                                                       */

            string lower = original.ToLower();

            /* Agora, vamos utilizar a função .ToUpper(), que converte a string para letras maiúsculas.
            Veja a seguir:                                                                                       */

            string upper = original.ToUpper();

            /* Em seguida, utilizaremos a função .Trim(), onde esta apaga todos os espaços em branco antes do pri-
            meiro caracter da string e também após o ultimo caracter da mesma.
            Veja a seguir:                                                                                       */

            string trim = original.Trim();

            /* Agora, utilizaremos a função IndexOf(), onde esta demonstrará o index(posição) da primeira ocorrência
            do texto que será colocado como parametro.
            Veja a seguir:                                                                                        */

            int indexOf = original.IndexOf("bc");

            /* Além do IndexOf(), existe também o LastIndexOf(), que assim como seu semelhante demonstra o index
            de um texto, porém, demonstrando a ultima ocorrência do mesmo na string.
            Veja a seguir:                                                                                        */

            int lastIndexOf = original.LastIndexOf("bc");

            /* Outra função que temos ao utilizarmos as strings é a de Substring(), onde essa nos permite criar ou-
            tra string a partir da original, utilizando apenas os elementos a partir do index que desejarmos.
            Veja a seguir:                                                                                        */

            string substring = original.Substring(4);

            /* Além de nos permitir criar outra string a partir do index, a função Substring() nos permite também
            determinar a quantidade de caracter que desejamos utilizar a partir do index passado.
            Veja a seguir:                                                                                       */

            string substring2 = original.Substring(4 , 5);

            /* Outra função interessante que temos ao utilizarmos as string é a Replace(), onde esta nos permite
            trocar todas as ocorrências de um caracter por outro.
            Veja a seguir:                                                                                      */

            string replace = original.Replace('a' , 'x');

            /* Assim como a função Substring(), a função Replace() também pode ser executada de forma mais elaborada
            e nesse caso, o replace nos permite utilizar um texto como parâmetro e trocá-lo por outro.
            Veja a seguir:                                                                                        */

            string replaceTxt = original.Replace("abc" , "xyz");

            /* Outra função de extrema importancia ao analizar entradas é a IsNullOrEmpty(), na qual nos retornará
            se a variável é nula ou esta vazia.
            Veja a seguir:                                                                                       */

            bool isNullOrEmpty = String.IsNullOrEmpty(original);

            /* Além da função acima, é possível também verificar se ao invez de somente estar vazia ou ser nula, se
            a string possui somente espaços em branco dentro dela.
            Veja a seguir:                                                                                        */

            bool isNullOrWhiteSpace = String.IsNullOrWhiteSpace(original);

            /* E para finalizarmos, vamos ver como ficaram nossas string baseadas em nossas funções.
            Veja a seguir:                                                                                        */

            Console.WriteLine("STRING ORIGINAL: -" + original + "-");
            Console.WriteLine("STRING TO_LOWER: -" + lower + "-");
            Console.WriteLine("STRING TO_UPPER: -" + upper + "-");
            Console.WriteLine("STRING TRIM: -" + trim + "-");
            Console.WriteLine("STRING INDEX_OF('bc'): " + indexOf);
            Console.WriteLine("STRING LAST_INDEX_OF('bc'): " + lastIndexOf);
            Console.WriteLine("STRING SUBSTRING(4): -" + substring + "-");
            Console.WriteLine("STRING SUBSTRING_DETERMINANDO_QTD_DE_CARACTERES_DESEJADOS(4 , 5): -" + substring2 + "-");
            Console.WriteLine("STRING REPLACE('a', 'X'): -" + replace + "-");
            Console.WriteLine("STRING REPLACE_UTILIZANDO_TXT_COMO_PARAMETRO('abc' , 'xyz'): -" + replaceTxt + "-");
            Console.WriteLine("STRING IS_NULL_OR_EMPTY: " + isNullOrEmpty);
            Console.WriteLine("STRING IS_NULL_OR_WHITE_SPACE: " + isNullOrWhiteSpace);
        }
    }
}