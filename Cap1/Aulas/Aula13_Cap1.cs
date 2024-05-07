/* ------ Estrutura repetitiva para (for) ------ */

using System;

namespace CursoDeCsharp.Cap1.Aulas
{
    class Aula13_Cap1
    {
        static void _Aula13(string[] arg)
        {
            /* O que é a estrutura for?
             
             A estrutura repetitiva for é uma estrutura em loop utilizada pra simplificar o nosso código, onde a mesma tem o 
             funcionamento parecido com o loop while, porém, sua utilização se torna propícia quando temos uma quantidade 
             conhecida de vezes na qual faremos o loop.
             
             Para sintetizarmos o que foi dito acima, vamos entender um conceito do loop while e do loop for:
             
             -O loop while, é utilizado para situações nas quais não sabemos ao certo quantas vezes precisaremos fazer 
             um processo, ou seja, aquele processo ocorrerá até que o mesmo seja encerrado.
             
             -O loop for, também utiliza de um loop, mas devido a sua estrutura, o mesmo é mais utilizado para ocasiões
             nas quais, já sabemos quantas vezes teremos de fazer o loop ocorrer.
             
             Veja a seguir sua nomenclatura:
             
             for (início ; condição ; encremento){
                    comando 1
                    comando 2
                }
                
            Nota-se que o loop for conta com 3 fatores em sua construção, são eles:
            - início: Uma condição que só será executada no primeiro loop, e na qual traçará um parâmetro (como veremos
            no exercício abaixo).
            - condição: A condição para que aquele loop ocorra, ou seja, se a condição for verdadeira, o loop prosseguirá
            e caso seja falsa, sairemos do mesmo.
            - encremento: Como o nome diz, será um encremento para nosso fator "início", o que nos permitirá em algum momento
            sair do loop for.
            
            Agora vamos vê-lo na prática:   
            Imagine que precisamos de um programa que leia uma quantidade de números escolhidas pelo nosso cliente, e que
            logo após demonstre a soma destes números para ele. 
            Vamos utilizar o loop for para criá-lo!             */

            Console.WriteLine("Bem vindo a somador de inteiros!");
            Console.Write("Insira a seguir a quantidade de numeros que voce deseja inserir: ");
            int nums = int.Parse(Console.ReadLine());
            /* Repare que estamos solicitando quantos números serão adicionados, ou seja, temos uma noção prévia de quantas
             vezes teremos de executar o loop */

            int soma = 0;
            
            /* Outro ponto importante a se notar, é o fato de normalmente, utilizarmos o parâmetro "i" como o fator "início"
             da condicional for. Além disso, devemos perceber que criamos a variável na própria estrutura do loop.*/
            for (int i = 1; i <= nums; i++)
            {
                Console.Write("Digite o #{0}: ",i);
                int x = int.Parse(Console.ReadLine());
                soma += x;
            }

            Console.WriteLine("Soma = {0}",soma);
            
            
        }
    }
}