/* ------ Object e ToString ------ */

using System;

namespace CursoDeCsharp
{
    class Aula5
    {
        static void _Aula5(string[] arg)
        {
            /* Para começar essa aula, é necessário saber um conceito básico que ao decorrer do curso, apenderemos mais
             sobre o mesmo (capítulo de herança). 
             
             Então vamos ao conceito:
             
             - Todas as classes em C#, são na verdade subclasses da classe Object.
             
             Onde a classe Object, possui por padrão, os seguintes métodos:
             
             - GetType (retorna o tipo do objeto)
             - Equals (compara se o objeto é igual a outro)
             - GetHashCode (retorna um código hash do objeto) 
             - ToString (converte o objeto para String)
             
             Nessa aula, aprenderemos o seu método ToString!
             Mas para que serve o mesmo?
             
             O método ToString, nos auxiliará na descrição de um objeto. Isso, porque ao criarmos tal método em um objeto, 
             ao chamarmos o nome do objeto em nossa classe Main (sem necessidade de chamar com a nomenclatura de função,
             apenas o nome do objeto, já será compreendido pelo compilador de que desejamos chamar a função ToString),
             o mesmo retornará o que foi predefinido em nossa classe, dentro da função ToString.
             
             Entendemos que pode parecer abstrato, então vamos demonstrar na prática, utilizando a classe Carro para nos
             auxiliar: 
             
             */
        }
    }
}