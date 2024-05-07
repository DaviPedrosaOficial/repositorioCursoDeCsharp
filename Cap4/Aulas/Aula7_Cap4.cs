/* ------ Boxing & Unboxing ------ */

namespace CursoDeCsharp.Cap4.Aulas
{

    class Aula7_Cap4{

        /* ------ O que é boxing? ------
        
         Boxing, é o processo de conversão de um tipo valor para um tipo referência compatível, ou seja, a transformação
        de uma variável struct, para um objeto.
        
         É importante ressaltar mais uma vez o processo que ocorre quando isso acontece. Como já comentamos em nossas aulas
        de struct e classes, valores tipos são armazenados em uma parte de nossa mémoria chamada de stack, e objetos em
        heap. Então quando é feita a conversão por boxing ou como vamos ver a seguir o unboxing, é realizado o processo de
        realocação desse valores.
        
         O fato de o processo causar tal realocação, faz com que o nosso programa tenha que efetuar mais processos para ser
        executado, podendo ser mais custoso para o processamento. Por isso é importante pensarmos sobre tal realocação.
        
        ------ O que é unboxing? ------
        
         Unboxing é o processo inverso ao boxing, onde um tipo referência é convertido para um tipo valor compatível.
         
         Ou seja, no processo de unboxing, temos um objeto de um determinado tipo, seja ele string, int, double ...
         que será convertido a uma variável de tipo compatível, sendo string caso contenha texto, int para inteiros,
         ...                                                                                                            */
    }
}