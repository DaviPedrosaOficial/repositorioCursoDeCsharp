﻿/* ------ Metodo de saída ------ */

using System;
using System.Globalization;

namespace CursoDeCsharp.Cap1.ExerciciosPropostos
{
    class ExercicioAula_1_Cap1
    {
        static void Ex_Aula1(string[] arg)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}.",produto1,preco1);
            Console.WriteLine("{0}, cujo preço é $ {1}.",produto2,preco2);

            Console.WriteLine("\r\nRegistro: {0} anos de idade, código {1} e gênero: {2}.",idade,codigo,genero);

            Console.WriteLine("\r\nMedida com oito casas decimais: {0:F8}",medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}",medida);
            Console.WriteLine("Separador decimal invariant culture: {0}",medida.ToString(CultureInfo.InvariantCulture));
        }
    }
}