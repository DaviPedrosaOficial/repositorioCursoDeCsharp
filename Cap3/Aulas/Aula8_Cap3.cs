/* ------ Modificadores de acesso ------ */

namespace CursoDeCsharp.Cap3.Aulas
{
    class Aula8_Cap3
    {
        /* ------ O que são os modificadores de acesso? ------
         
         Modificadores de acesso são os prefixos de nossas classe e atributos, que ditam quem poderá ter acesso aos mesmos!
         Durante o decorrer do curso já os utilizamos diversas vezes para criarmos nossas classes, dentre eles o "public", 
         "private" e "internal"(ao deixar apenas class em sua emplementação [Ex.: class Aula8_Cap3])                  
         
         ------ Existem 6 tipos de modificadores, são eles: -------
         
         1º => "public" : 
          Permite a utilização pela própria classe, subclasses no assembly (assembly = projeto), outras classes
         no assembly, subclasses fora do assembly e classes fora do assembly
         
         2º => "protected internal" : 
          Permite a utilização pela própria classe, subclasses no assembly, outras classes no assembly e subclasses
         fora do assembly
         
         3º => "internal" ou apenas não colocar prefixo : 
          Permite a utilização pela própria classe, subclasses no assembly e outras classes no assembly
         
         4º = "protected" : 
          Permite a utilização pela própria classe, subclasses no assembly e subclasses fora do assembly
         
         5º => "private protected" : 
          Permite a utilização pela própria classe e subclasses no assembly
         
         6º => "private" : 
          Permite a utilização apenas pela própria classe
          
          ------ Quadro demonstrativo: ------- 
          
                     |  public  | protected internal | internal | protected | private protected |       private
         ---------------------------------------------------------------------------------------------------------------              
          própria    |          |                    |          |           |                   |        
                     |    x     |          x         |    x     |     x     |         x         |          x
          classe     |          |                    |          |           |                   |             
          --------------------------------------------------------------------------------------------------------------
          subclasse  |          |                    |          |           |                   |
          no         |    x     |           x        |     x    |     x     |         x         |              
          assembly   |          |                    |          |           |                   | 
          --------------------------------------------------------------------------------------------------------------
          Outras     |          |                    |          |           |                   |         
          classe no  |    x     |           x        |     x    |           |                   |           
          assembly   |          |                    |          |           |                   |           
          --------------------------------------------------------------------------------------------------------------
          subclasses |          |                    |          |           |                   |     
          fora do    |    x     |           x        |          |      x    |                   |  
          assembly   |          |                    |          |           |                   |  
          --------------------------------------------------------------------------------------------------------------
          classses   |          |                    |          |           |                   |              
          fora do    |    x     |                    |          |           |                   |  
          assembly   |          |                    |          |           |                   |                       
          --------------------------------------------------------------------------------------------------------------
          
          
          */
    }
}

