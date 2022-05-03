using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerations.Entities.Enums;

namespace Enumerations.Entities {
    class Worker {
        public string Name { get; set; } 
        public double BaseSalary { get; set; }
        public WorkerLevel Level { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, double baseSalary, WorkerLevel level, Department department) { 
            Name = name;
            BaseSalary = baseSalary;   
            Level = level;
            Department = department;
        }

        public void AddContract(HourContract contracts) {
            Contracts.Add(contracts);
        }

        public void RemoveContract(HourContract contracts) {
            Contracts.Remove(contracts);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
