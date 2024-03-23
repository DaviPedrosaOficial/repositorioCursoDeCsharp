/* ------ Classe referente a aula 4, exercício 2 ------ */

namespace CursoDeCsharp{
    
    public class Produto3{

        public string Nome {get; private set;}
        public double Preco {get; private set;}

        public Produto3(){
            Preco = 0.0;
        }
        public Produto3(string nome, double preco){
            Nome = nome;
            Preco = preco;
        }

        public void SetNome(string nome){
            if (nome != null && nome.Length > 1){
                Nome = nome;
            }
        }

        public void SetPreco(double preco){
            if (preco > 0){
                Preco = preco;
            }
        }
    }
}