/* Desaloca��o de m�moria - Garbage collector e escopo local */

namespace CursoDeCsharp
{
    class Aula2_Cap4
    {
        /* ------ O que � o garbage collector? ------
           
          Garbage collector � um processo que automatiza o gerenciamento de m�moria de um programa
        em execu��o. 
        
         O garbage collector monitora os objetos alocados dinamicamente pelo programa (no "heap", parte
        de nossas m�morias), desalocando aqueles que n�o est�o mais sendo utilizados.
         
         Ou seja, ao instanciar um objeto, o mesmo contar� com uma vari�vel em "stack" (outra parte da 
        m�moria) que armazenar� as coordenadas daquele objeto. 
        
         Por�m, � poss�vel que em algum momento em nosso programa esta vari�vel em stack perca tal 
        coordenada, seja para colocar outra coordenada em sua vari�vel, ou at� mesmo para se tornar nula.
        
         Veja um exemplo de como um objeto pode ser desalocado:
        Imagine o seguinte cen�rio:

        Product p1 , p2;

        p1 = new Product("Cal�a", 250.00 , 0);
        p2 = new Product("Tenis", 450.00 , 0);

         At� ent�o criamos 2 objetos, e os instanciamos. Mas veja a seguir:

        p1 = p2;

         Nesse momento, o que est� acontecendo � exatamente o que foi citado acima. p1 tinha uma coordenada,
        de um objeto instanciado, por�m o nosso programa solicitou que as coordenadas alocadas em p1 fossem 
        trocadas pela de p2. O que faz com que o objeto que antes era de p1 se encontra "perdido" em nosssa 
        m�moria.



        
         Independente do motivo, se nossa instancia��o de objeto se manter em heap sem ter outra vari�vel em 
        stack para aponta-la, o garbage collector desalocar� (retirar) essa instancia��o, para preservar espa�o 
        em nossa m�morias.

         Ps.: O garbage collector n�o far� o mesmo de imediato! Demora alguns processos para que a desaloca��o 
        ocorra.

        ------ Desaloca��o por escopo ------

         O que � a desaloca��o por escopo?
         
         Desaloca��o por escopo � o processo onde vari�veis s�o criadas dentro de um escopo, seja esse uma fun��o,
        m�todo, ... ap�s o encerramento do mesmo, as vari�veis que foram alocadas ali, ser�o imediatamente
        desalocadas.

         Ou seja, quando criamos um loop, ou chamamos um m�todo de uma classe que cont�m vari�veis neles, ao mesmo
        se encerrar, aqueles que estiverem dentro dos mesmo se encerrar�o com eles.

         Veja o exemplo a seguir do processo:
         Imagine o seguinte cen�rio:

        double total;

        if (x > 10){
        double calcDesc = x - (x * 0.1);
        total += calcDesc;
        }

         Note que a vari�vel calcDesc existe somente dentro da condicional "if". Sendo assim, o programa quando 
        chegar a condicional ir� alocar a vari�vel calcDesc em stack (m�moria) dentro do escopo do if, e assim que
        o mesmo se encerrar, a vari�vel sera desalocada tamb�m!
         Obs.: Podemos ter escopos dentro de escopos, onde os mesmos far�o o mesmo processo citado acima, assim que 
        for encerrado.

         � importante sabermos como o processo aconte�a, para que n�o haja confus�o entre garbage collector e
        desaloca��o por escopo!
        */
    }
}