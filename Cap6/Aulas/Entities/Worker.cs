/* ------ Classe feita para a resolução do exercício de composição ------ */
using CursoDeCsharp.Cap6.Aulas.Entities.Enums;
using System.Collections.Generic;

namespace CursoDeCsharp.Cap6.Aulas.Entities
{
    class Worker{

        public string Name { get; set;}
        public WorkerLevel Level { get; set;}
        public double BaseSalary { get; set;}
        /* Composição sera descrita abaixo, como uma propriedade de nossa classe */
        public Department Department { get; set;}
        /* Como um funcionário poderá ter mais de um contrato, ao invés de apenas implementarmos a composição como para o
        Department acima, deveremos executar uma lista que armazenará os nossos objetos dentro dela, veja abaixo: */
        public List<HourContract> Contracts { get; set;} = new List<HourContract>();


        public Worker()
        {

        }

        /* Como não é usual criar um objeto dando diversos elementos do tipo lista, sempre que tivermos uma propriedade
        do tipo List, não a colocaremos como contrutor, e conforme tivermos a necessidade adicionaremos os mesmos.*/
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts){
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}