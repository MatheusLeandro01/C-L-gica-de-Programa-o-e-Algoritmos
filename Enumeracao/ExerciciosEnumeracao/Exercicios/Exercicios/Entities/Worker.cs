using System;
using System.Collections.Generic;
using Exercicios.Entities.Enum;
namespace Exercicios.Entities
{
    class Worker //Class with worker's information.
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //para utilizar o tipo workerlevel, eu preciso criar um enumerador.
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // COMPOSIÇÃO (Associação entre duas classes diferentes)
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //posso ter varios contratos, por isso crio uma lista. (Já está instanciada para que o valor não seja nulo. Lembrando que cada atributo possui um valor padrão.)

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) // não coloque lista no método construtor.
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);//adicionando contrato, que foi informado lá no meu Program.
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)   
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
