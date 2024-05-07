/* ------ Auto-properties ------ */

using CursoDeCsharp.Cap3.Classes;

namespace CursoDeCsharp.Cap3.Aulas
{
    class Aula7_Cap3
    {
        static void _Aula7_Cap3(string[] arg)
        {
            /* ------ O que são auto properties? ------
             Auto properties são uma maneira ainda mais simples de controlarmos nossos atributos que as próprias properties.
            Só que com um porém, não poderemos criar condicionais nas mesmas!
            
            As auto-properties são boas para podermos definir métodos get & set padrão e definirmos quem poderá ou não os
            atributos da classe, definindo se o método será private ou public. (Veja a execução na classe Animal)
            
            Agora, vamos ver abaixo o resultado:                                                                      */

            /* Instanciando nosso animal */
            Animal animal = new Animal("Elefante", 30, "Blue");

            /* Utilizando o método get, a partir de nossa auto-properties */
            animal.Especie = "Leao";
    
            /* Se tentassemos fazer "animal.Idade = 10;" não seria possível, já que seu método set foi privado em nossa
             classe */
            
            animal.Nome = "Rubros";
            
            /* Utilizando os métodos set de nossa classe */
            Console.WriteLine("ESPECIE: {0}",animal.Especie);
            Console.WriteLine("IDADE: {0}",animal.Idade);
            Console.WriteLine("NOME: {0}",animal.Nome);
            
            

        }
    }
}

