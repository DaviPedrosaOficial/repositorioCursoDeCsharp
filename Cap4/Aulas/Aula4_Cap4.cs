/* ------ Vetores ------ */

namespace CursoDeCsharp{
   
    class Aula4_Cap4{
        
        static void _Aula4_Cap4(string [] arg){

            /* ---------- Índice: ----------
            1 - Revisão do conceito de vetores
            2 - Manipulação de vetor de elementos tipo structs
            3 - Manipulação de vetor de elementos tipo classe
            4 - Acesso aos elementos
            5 - Propriedade Length
            
            
            ------ Revisão do conceito de vetores ------
            
            O que são vetores?
            Em programação, vetor é o nome dado para a arranjos unidimensionais!
            
            Mas o que são arranjos?
            
            Arranjo é uma estrutura de dados:
            - Homogênia (ou seja, possui somente dados do mesmo tipo)
            - Ordenada (onde seus elementos são acessados através de sua posição no arranjo)
            - Alocado de uma só vez, em um bloco contíguo de mémoria (Ou seja, todos seus elementos são alocados
            juntos em um espaço de nossa mémoria).
        
            Mas quais são as vantagens e desvantagens de se trabalhar com arranjos?
            
            Vantagem: 
            - Acesso imediato aos elementos baseados em sua posição do arranjo (Ou seja, imagine um cenário onde
            temos um arranjo de 1000 elementos, para acessarmos o elemento 500, nosso código não terá de percorrer 
            todos os elementos para que seja retornada as informações que desejamos)
        
            Desvantagens:
            - Tamanho fixo (como os arranjos são alocados de uma vez só, isso significa que o mesmo tem um tamanho 
            definido a partir de sua alocação, fazendo com que, caso nos precisarmos inserir novos elementos, teremos
            de alocarmos os mesmos em outro arranjo)
            - Dificuldade para fazer inserções e deleções (imagine que temos que retirar um elemento de nosso arranjo,
            ao fazer isto, nosso arranjo passará a ter um espaço dentro dele vazio, e teremos que fazer o tratamento 
            de nossos elementos a mão para que o mesmo não fique desorganizado ou sem sentido)
            
            
            Então para que possamos frizar o que vimos acima, vamos fazer um exercício utilizando os vetores:
            
            ---- Exercício 1 ----
            Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.                   */

            /* ------ Manipulação de vetor de elementos tipo structs ------ */

            Console.Write("Insira a seguir a quantidade de pessoas que voce deseja calcular a media de altura: ");
            int nPessoas = int.Parse(Console.ReadLine());

            /* Criando um vetor (Para isso utilizamos "[]") */
            double[] altura = new double[nPessoas];
            /* Repare que foi colocado a variável nPessoas dentro do segundo [], que determina o tamanho que será o nosso
            vetor */

            /* Inserindo as alturas no vetor */
            for (int i = 0; i < nPessoas; i++){
                Console.Write("Insira a altura da {0}ª pessoa: ", i + 1);
                altura[i] = double.Parse(Console.ReadLine());
            }

            double totalAlturas = 0;

            for (int i = 0; i < nPessoas; i++){
                totalAlturas += altura[i];
            }

            double mediaAlt = totalAlturas / nPessoas;

            Console.WriteLine();
            Console.WriteLine("MEDIA DE ALTURA: {0:F2}", mediaAlt);

            /* Agora, vamos fazer outro exercício utilizando vetores, mas desta vez, utilizando as classes:
            
            ---- Exercício 2 ----
            Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos
            em um vetor. Em seguida, mostrar o preço médio dos produtos.
            
            ------ Manipulação de vetor de elementos tipo classe ------                                                 */

            Produto3 x;

            Console.Write("Insira a seguir a quantidade produtos que voce deseja inserir ao estoque: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            Produto3[] estoque = new Produto3[qtdProdutos];
            /* Foi criado acima, um vetor de elementos da classe Produto3, porém aqui estamos apenas criando a coordenada que 
            apontará para nosso vetor que ira conter nosso objetos quando instanciados.
            
             Ou seja, ao chamarmos o nosso vetor de classe, foi criado em nossa mémoria heap, um vetor, que nesse caso sera 
            do tamanho da entrada escolhida pelo usuário (qtdProdutos), onde seus elementos no momento se encontram nulos
            (null). E somente quando instanciarmos os mesmos, eles serão preenchidos com nossos objetos.                     */

            for (int i = 0; i < qtdProdutos; i++){
                Console.Write("Insira a seguir o nome do {0}º produto: ", i + 1);
                string nome = Console.ReadLine();
                Console.Write("Agora, insira o preco do {0}º produto: ", i + 1);
                double preco = double.Parse(Console.ReadLine());

                /* Veja abaixo a instanciação de nossos objetos */
                x = new Produto3 (nome,preco);
                estoque[i] = x;
                /* Então, a partir da instanciação acima, nosso vetor em heap deixa de ser nulo, e passa a receber nossos objetos */
            }

            double totalPreco = 0.0;

            for (int i = 0; i < qtdProdutos; i++){
                totalPreco += estoque[i].Preco;
            }

            double calcMedia = totalPreco / qtdProdutos;

            Console.WriteLine("\r\nMEDIA DE PRECO: R${0:F2}",calcMedia);
        }
    }
}