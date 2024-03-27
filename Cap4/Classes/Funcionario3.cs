/* ------ Classe criada para auxiliar a aula de Exercícios Propostos 2 Cap 4 ------ */

using System.Data.Common;

namespace CursoDeCsharp{

    public class Funcionario3{

        private int _id;
        private string _nome;
        private double _salario;

        public Funcionario3(int id, string nome, double salario){
            _id = id;
            _nome = nome;
            _salario = salario;
        }

        public int Id{
            get {return _id;}
            set {if(value != null && value > 1){
                _id = value;
            }}
        }

        public string Nome{
            get {return _nome;}
            set {if(value != null && value.Length > 1){
                _nome = value;
            }}
        }

        public double Salario{
            get {return _salario;}
            set {if(value != null && value > 1){
                _salario = value;
            }}
        }

        public void AumentaSalario(double porcentagem){
            _salario += _salario * porcentagem;
        }
    }
}