using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryListsArrays {
    class Employee {
        private int _countID;

        public string name { get; set; }
        public int id { get; private set; }
        public double salary { get; private set; }

        public Employee(string name, int id, double salary) {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string Name {
            get { return name; }
            set {
                if (value != null && value.Length > 6) {
                    name = value;
                }
                else {
                    Console.WriteLine("Nome muito curto ou inexistente...");
                }
            }
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }

        public double Salary {
            get { return salary; }
            set { salary = value; } 
        }

        public void Increase(double percentage) {
            salary += (percentage / 100) * salary;
        }

        public override string ToString() {
            return $"ID: {id} | " +
                $"Nome: {name} | " +
                $"Salário: {salary}";
        }
    }
}
