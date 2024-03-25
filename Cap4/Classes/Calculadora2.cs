/* ------ Classe refente a aula 5 do Cap 4 ------ */

namespace CursoDeCsharp{

    public class Calculadora2{

        public static int Soma (int[] numeros){
            int soma = 0;
            for(int i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            }
            return soma;
        }

        /* A partir do momento que utilizamos o prefixo params, nosso compilador entenderá que o contexto a seguir utilizará entradas
        como seus parâmetros, permitindo com que não haja a necessidade de instanciar o vetor por exemplo. */
         public static int Soma1 (params int[] numeros){
            int soma = 0;
            for(int i = 0; i < numeros.Length; i++){
                soma += numeros[i];
            }
            return soma;
        }

        /* Demonstrando o modificador de parâmetro ref, aula 6 do Cap. 4 */
        public static void Triplica(ref int x){
            x = x * 3;
        }
    }
}