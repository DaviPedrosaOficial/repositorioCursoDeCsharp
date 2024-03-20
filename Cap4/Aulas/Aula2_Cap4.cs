/* Desalocação de mémoria - Garbage collector e escopo local */

namespace CursoDeCsharp
{
    class Aula2_Cap4
    {
        /* ------ O que é o garbage collector? ------
           
          Garbage collector é um processo que automatiza o gerenciamento de mémoria de um programa
        em execução. 
        
         O garbage collector monitora os objetos alocados dinamicamente pelo programa (no "heap", parte
        de nossas mémorias), desalocando aqueles que não estão mais sendo utilizados.
         
         Ou seja, ao instanciar um objeto, o mesmo contará com uma variável em "stack" (outra parte da 
        mémoria) que armazenará as coordenadas daquele objeto. 
        
         Porém, é possível que em algum momento em nosso programa esta variável em stack perca tal 
        coordenada, seja para colocar outra coordenada em sua variável, ou até mesmo para se tornar nula.
        
         Veja um exemplo de como um objeto pode ser desalocado:
        Imagine o seguinte cenário:

        Product p1 , p2;

        p1 = new Product("Calça", 250.00 , 0);
        p2 = new Product("Tenis", 450.00 , 0);

         Até então criamos 2 objetos, e os instanciamos. Mas veja a seguir:

        p1 = p2;

         Nesse momento, o que está acontecendo é exatamente o que foi citado acima. p1 tinha uma coordenada,
        de um objeto instanciado, porém o nosso programa solicitou que as coordenadas alocadas em p1 fossem 
        trocadas pela de p2. O que faz com que o objeto que antes era de p1 se encontra "perdido" em nosssa 
        mémoria.



        
         Independente do motivo, se nossa instanciação de objeto se manter em heap sem ter outra variável em 
        stack para aponta-la, o garbage collector desalocará (retirar) essa instanciação, para preservar espaço 
        em nossa mémorias.

         Ps.: O garbage collector não fará o mesmo de imediato! Demora alguns processos para que a desalocação 
        ocorra.

        ------ Desalocação por escopo ------

         O que é a desalocação por escopo?
         
         Desalocação por escopo é o processo onde variáveis são criadas dentro de um escopo, seja esse uma função,
        método, ... após o encerramento do mesmo, as variáveis que foram alocadas ali, serão imediatamente
        desalocadas.

         Ou seja, quando criamos um loop, ou chamamos um método de uma classe que contém variáveis neles, ao mesmo
        se encerrar, aqueles que estiverem dentro dos mesmo se encerrarão com eles.

         Veja o exemplo a seguir do processo:
         Imagine o seguinte cenário:

        double total;

        if (x > 10){
        double calcDesc = x - (x * 0.1);
        total += calcDesc;
        }

         Note que a variável calcDesc existe somente dentro da condicional "if". Sendo assim, o programa quando 
        chegar a condicional irá alocar a variável calcDesc em stack (mémoria) dentro do escopo do if, e assim que
        o mesmo se encerrar, a variável sera desalocada também!
         Obs.: Podemos ter escopos dentro de escopos, onde os mesmos farão o mesmo processo citado acima, assim que 
        for encerrado.

         É importante sabermos como o processo aconteça, para que não haja confusão entre garbage collector e
        desalocação por escopo!
        */
    }
}