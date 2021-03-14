using System;
using System.Collections.Generic;
using System.Text;
using ProjectResolvidoUdemy.Entities.Enums;

namespace ProjectResolvidoUdemy.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Departament Departament { get; set; }

        public Worker(string name, WorkLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public Worker()
        {
        }

        public void AddContract(HourContract contract)
        {

            Contracts.Add(contract);

        }

        public void RemoteContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.DateContract.Year == year && contract.DateContract.Month == month)
                {

                    sum += contract.totalValue();

                }
            }
            return sum;
        }

    }
}
