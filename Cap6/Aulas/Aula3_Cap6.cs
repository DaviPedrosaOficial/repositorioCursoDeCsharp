/* ------ Aula voltada ao exercício 2 sobre composição ------ */
using CursoDeCsharp.Cap6.Aulas.Entities;

namespace CursoDeCsharp.Cap6.Aulas
{
    public class Aula3_Cap6
    {
        public void _Aula3_Cap6(string [] arg)
        {
            /* Instancie manualmente os objetos mostrados abaixo e mostre-os na tela do terminal, conforme exemplo.
            (objetos: Post & Comment, foram criadas classes para os mesmos)                                      */

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that was awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/05/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you!");

            Post p2 = new Post(
                DateTime.Parse("28/07/2023 15:35:01"),
                "Good night guys!",
                "See you tomorrow!",
                35
            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}