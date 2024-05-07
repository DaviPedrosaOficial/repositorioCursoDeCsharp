/* ------ Sintaxe alternativa (expressão condicional ternária) ------ */

namespace CursoDeCsharp.Cap5.Aulas
{

    class Aula3_Cap5{

        static void _Aula3_Cap5(string [] arg){

            /*----- O que são expressões condicionais ternárias? ------
            
            As expressões condicionais ternárias são outra maneira que temos de desenvolver uma estrutura condicional
            do tipo if & else, de maneira mais simples e resumida. Onde para que possamos executá-las é necessário um
            VALOR base para uma condicional.
            
            Sintaxe:  (condição) ? valor_se_verdadeiro : valor_se_falso;
            
            Para que possamos entender melhor o conceito, vamos desenvolver uma estrutura comum utilizando o if & else,
            para que depois, possamos demonstrar como a mesma ficaria ao utilizarmos as condicionais ternárias.
            Veja a seguir:                                                                                           */

            Console.Write("Insira a seguir o valor total da compra: ");
            double val = double.Parse(Console.ReadLine());

            double totalComDesconto = 0;
            
            if (val < 20){
                totalComDesconto += val - val * 0.1;
                Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalComDesconto);
            }
            else{
                totalComDesconto += val - val * 0.4;
                Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalComDesconto);
            }

            /* Como vimos acima, foi montada uma estrutura condicional para conceber descontos nas compra, baseados no
            valor total da mesma. Agora, vamos ver como a mesma condicional ficaria se utilizassemos as condicionais ter-
            nárias:                                                                                                   */
            
            Console.Write("Insira a seguir o valor total da compra: ");
            double val2 = double.Parse(Console.ReadLine());

            double totalC_Desc = (val2 < 20) ? val2 - val2 * 0.1 : val2 - val2 * 0.4;
            /* Note a quantidade linhas que economizamos ao utilizarmos dessa nova sintaxe.
            Lembrando que a sintaxe da mesma fica da seguinte maneira:
            (condição) ? valor_se_verdadeiro : valor_se_falso; */

            Console.WriteLine("\r\nVALOR TOTAL COM DESCONTO: R${0:F2}", totalC_Desc);
        }
    }
}