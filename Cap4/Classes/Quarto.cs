/* ------ Classe referente ao exercício proposto 1 ------ */

namespace CursoDeCsharp{

    public class Quarto{

        public int Numero {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}

        public Quarto (int numero,string nome,string email){
            Numero = numero;
            Nome = nome;
            Email = email;
        }
    }
}