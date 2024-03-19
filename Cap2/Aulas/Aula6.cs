/* ------ Membros estáticos (parte 1) ------*/

namespace CursoDeCsharp
{
    class Aula6
    {
        static void _Aula6(string[] arg)
        {
            /* Durante o decorrer deste curso, vimos que classes pode possuir membros, que são atributos (dados da classe)
             e métodos (operações / funções).
             
             Porém, existem também os membros estáticos!
             Que:
             
             - Também, são chamados de membros de classe. Ou seja, atributo de classe, método de classe.
             Aqueles que não são membros estáticos, são chamados de membros de instância!
             Que são os que temos feito no decorrer desse capítulo, dentro das classes que criamos.
             
             - São membros que fazem sentido independentemente de objetos. Ou seja, não dependem de objetos para serem
             chamados. São chamados a partir do próprio nome da classe!
             
             - Aplicações comuns de tais membros:
              * Classes utilitárias (um exemplo seria o Math.Sqrt, que tem o Math como uma classe que é chamada e executa
                a o método Sqrt quando chamada)
              * Declaração de constantes
             
             - Uma classe que possui somente membros estáticos, pode ser uma classe estática também! 
             Onde essa não poderá ser instanciada.
             
             Para demonstrar melhor seu funcionamento, vamos resolver um probleminha utilizando membros estáticos:    */
            
            
            
            /* ------ Exercício (utilizando membros estáticos) ------ */
            /* Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma
             circunferência e do volume de uma esfera para um raio daquele valor. 
             Informar também o valor de PI com duas casas decimais. */

            Console.WriteLine("Bem vindo ao calculador de esferas!");
            
            Console.Write("Insira a seguir o valor no qual voce desejaria tem como raio de sua esfera: ");
            double raio = double.Parse(Console.ReadLine());

            /* Armazenando dados de nossos membros estáticos */
            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferencia: {0:F2}",circ);
            Console.WriteLine("Volume: {0:F2}",vol);
            Console.WriteLine("Valor de Pi: {0:F2}",Pi);


        }

        
        /* Membros estáticos de nossa classe */
        static double Pi = 3.14;

        /* Repare que como utilizaremos as funções estáticas dentro de uma classe estática, temos de colocar a nomenclatura
         static na frente da definição, para que as mesmas possam ser utilizadas em nosso programa! */
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}