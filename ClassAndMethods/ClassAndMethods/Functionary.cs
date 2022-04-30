using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassAndMethods {
    class Functionary {
        public string name;
        public double grossSalary;
        public double tax;

        public double LiquidSalary() {
            if (grossSalary - tax > 1200.00) {
                return grossSalary - tax;
            }
            else {
                return grossSalary = 1200.00;
            }
        }

        public void SalaryIncrease(double percentage) {
            double resultPercentage = (percentage / 100) * grossSalary;
            grossSalary += resultPercentage;
        }

        public override string ToString() {
            return $"{name}, R${LiquidSalary().ToString("F2", CultureInfo.InvariantCulture)}"; 
        }
    }
}
