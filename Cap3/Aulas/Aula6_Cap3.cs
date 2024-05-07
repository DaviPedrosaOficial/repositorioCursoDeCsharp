/* ------ Properties (Propriedades) ------ */

using CursoDeCsharp.Cap3.Classes;

namespace CursoDeCsharp.Cap3.Aulas
{
    class Aula6_Cap3
    {
        static void _Aula6_Cap3(string[] arg)
        {
            /* ------ O que são properties (propriedades) ------
             
             As propriedades são funcionalidades que auxiliam na implementação de métodos a nossas classe. Tornando-as mais 
            simples, econômico e otimizado para o nosso código, uma vez que as mesmas tornam desnecessário a implementação 
            manual das funções get & set.
            
             Para criarmos uma propriedade, devemos fazer uma chamada parecida com a de um construtor mas para nossos 
            atributos, e ao fazermos o mesmo, poderemos chamar os métodos get & set para eles, sem precisarmos 
            desenvolver 2 funções a mão para nosso projeto. (Veja a execução na classe Lapis)
            
             Além disso, a utilização das propriedades fará com que, a chamada de nossos métodos se tornem muito mais 
            simples, como veremos a seguir:                                                                            */

            Lapis lapis = new Lapis("Laranja", "Cis");

            /* Agora, utilizando as propiedades, note como fica mais simples a chamada das funções get & set em nossa
             main */
            
            /* ------ Função set ------ */
            lapis.Cor = "Azul";
            lapis.marca = "Faber-Castell";

            /* ------ Função get ------ */
            Console.WriteLine(lapis.Cor);
            Console.WriteLine(lapis.marca);
        }
    }
}

