/* ------ Membros estáticos (parte 2) ------ */

using CursoDeCsharp.Cap2.Classes;

namespace CursoDeCsharp.Cap2.Aulas
{
    class Aula7
    {
        static void _Aula7(string[] arg)
        {
            /* Nessa aula, sobre membros estáticos, entenderemos a fundo como e qual seriam as melhores maneiras de
             utilizá-los, baseado no problema que estamos tentando resolver. 
             
             Tendo em mente o exercício, resolvido na ultima aula (Aula6). Se fossemos criar uma classe (Calculadora) para
             auxíliar em sua resolução, porém, nos teriamos o seguinte problema:
             
             Como a resolução do problema não muda de um para outro objeto, ou seja, se fizessemos o objeto calculadora1
             e um objeto calculadora2, ao tentarmos resolver um problema com as mesmas entradas seu resultado seria o 
             mesmo. Sendo assim desnecessária a instanciação de tal objeto.
             
             Veja a seguir, e na classe calculadora como ficaria:                                                     */


            Calculadora calc1 = new Calculadora();
            Calculadora calc2 = new Calculadora();

            double circ1 = calc1.Circunferencia(3.0);
            double circ2 = calc2.Circunferencia(3.0);

            double vol1 = calc1.Volume(3.0);
            double vol2 = calc2.Volume(3.0);

            Console.WriteLine(circ1);/* Os resultados serão os mesmos */
            Console.WriteLine(circ2);

            Console.WriteLine();
            Console.WriteLine(vol1.ToString("F2")); /* Os resultados serão os mesmos!*/
            Console.WriteLine(vol2.ToString("F2"));
            
            
            
            /* Sendo assim, concluimos que nesse tipo de situação não é interessante trabalhar com objetos, já que ao serem
             implementados, não teremos um benefício sobre os mesmos.
             Isso ocorre, devido ao fato de tais operações que estão sendo desenvolvidas na classe são estáticas, ou seja,
             independente de qual objeto que à utilirá, seu resultado será o mesmo.
             
             Então como faríamos o mesmo?                                                                             */
            
            /* Para isso, utilizaremos os membros estáticos de uma maneira similar a função Math.Sqrt.
             Ou seja, ao chamarmos a classe, poderemos utilizar de suas funções sem termos que criar objetos da mesma.
             
             Veja a seguir (Classe CalculadoraEstatica) :*/
            
            /* Note que não tivemos de instanciar nenhum objeto para utilizarmos os métodos da classe CalculadoraEstatica */
            double circ3 = CalculadoraEstatica.Circunferencia(3.0);
            double vol3 = CalculadoraEstatica.Volume(3.0);

            Console.Write("Circunferencia de uma esfera de raio 3,0: ");
            Console.WriteLine(circ3);
            Console.Write("Volume de uma esfera de raio 3,0: ");
            Console.WriteLine(vol3.ToString("F2"));
        }
    }
}

