using System;

namespace CursoDeCsharp.Cap2.Classes
{
    public class Triangulo
    {
        /* Atributos da classe (lembrado que nomes de atributos, começam com letra maiúscula)*/
        public double A;
        public double B;
        public double C;
        
        /* Método para encontrarmos a área do triangulo */
        public double Area() /* Nesse caso em expecífico, não teremos de colocar entradas dentro do parêntes, já que todas as
                            condicionais que precisamos, já se encontram dentro da própria classe!) */
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); /* Como o método é uma função double, o mesmo requer um retorno
                                                                em double */
        }
    }
}