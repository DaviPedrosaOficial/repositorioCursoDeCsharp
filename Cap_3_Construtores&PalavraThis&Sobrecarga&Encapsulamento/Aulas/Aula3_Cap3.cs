/* Sintaxe alternativa para iniciar valores de objetos */

namespace CursoDeCsharp
{
    class Aula3_Cap3
    {
        
           /* Além das sobrecargas, existe outra maneira de instanciarmos um objeto, já inserindo valores aos seus
            atributos. E para isso utilizamos apenas uma sintaxe diferente.
            
             Para isso, devemos nos atentar ao seguinte:
             A classe não pode conter um construtor customizado, ou se ela conter, é necessário inserir também um
            construtor padrão, para que seja permitido utilizar tal sintaxe. 
           
             Isso se deve o fato de que tal sintaxe, ser uma alternativa padrão do sistema, sendo assim, caso seja inserido
            um construtor customizado, o compilador entenderá que apenas aqueles contrutores inseridos em nossa classe
            serão utilizado.
            
             Agora vamos a sintaxe:
            
             Para que a mesma funcione poderemos chamá-la de duas maneiras:
            
            Com parênteses
            1ª -> Produto p = new Produto () {
                   Nome = "Tv" ,
                   Preco = 950.00 ,
                   Quantidade = 10 ; 
                 }
                 
            Sem Parênteses
            2ª -> Produto p = new Produto {
                   Nome = "Tv" ,
                   Preco = 950.00 ,
                   Quantidade = 10 ;
                }
                                                                                                                     */
        
    }
}

