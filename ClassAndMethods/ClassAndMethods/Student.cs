using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassAndMethods {
    class Student {
        public string name;
        public double pointsNeeded;
        public double noteA, noteB, noteC, average;

        public double Average() {
            average = noteA + noteB + noteC;
            return average; 
        }

        public void Aproved() {
            if (average > 60.00) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                PointsNeeded();
            }
        }
        
        void PointsNeeded() {
            pointsNeeded = 60.00 - average;
            Console.WriteLine(
                $"Faltaram " +
                $"{pointsNeeded.ToString("F2", CultureInfo.InvariantCulture)} " +
                $"pontos."
            );
        }
    }
}
