/* ------ Classes e métodos selados ------- */

namespace CursoDeCsharp.Cap7.Aulas
{
    public class Aula4_Cap7
    {
        public void _Aula4_Cap7(string [] arg)
        {
            /* Como vimos nas aulas anteriores, podemos herdar classes e seus métodos, visando facilitar e sim-
            plificar nossos códigos. Onde utilizamos elementos como "base", no qual nos permite reutilizar pro-
            priedades de uma Superclasse ao criarmos Subclasses.
            
             Por mais que esse recurso de reutilização de métodos e atributos de classes, seja de extremo auxílio,
            quando vamos a sua aplicação real, o mesmo pode não ser tão seguro.
             Isso se deve ao fato de que, ao utilizarmos diversas vezes a herança, podemos nos perder quanto as
            funcionalidades e motivos pelos quais os métodos foram criados, chegando a um ponto que podemos estar
            utilizando essa função de reuso apenas como facilitador na hora de desenvolvermos o código.
            
             Uma maneira de evitarmos tais problemas é selando nossas classes e/ou métodos da mesma. E normalmente
            o processo ocorre da seguinte maneira: Criamos uma Superclasse para termos como base no nosso projeto,
            em seguida criamos Subclasses abaixo da mesma, ou seja, Subclasses que herdam a mesma Superclasse, e ao
            desenvolvermos as Subclasses selamos as mesma, para que Subclasses dessas Subclasses não sejam feitas,
            e o mesmo para seus métodos.
            
             Outro ponto importante que devemos salientar ao tratarmos de herança, é o fato de que classes podem
            ser ao mesmo tempo Superclasse e Subclasse. Onde as mesmas, serão Subclasse deu uma classe acima de sua
            hierarquia, e Superclasse de outra(s) abaixo da mesma.
            
             Então para que possamos ver o selamento em execução, vamos fazer alterações na classe SavingsAccount,
            e criaremos a classe SavingsAccountPlus e tentaremos fazer a utilização da classe SavingsAccount, na qual
            a selamos. Confira as anotações nas mesmas para prosseguir no conteúdo.
            
             E por fim, iremos criar uma Subclasse da classe BusinessAccount que não foi selada como classe, e tenta-
            remos reutilizar um método que foi selado, e ver o que acontece. Confira as anotações nas mesmas para visua-
            lizar o final do conteúdo.*/
        }
    }
}