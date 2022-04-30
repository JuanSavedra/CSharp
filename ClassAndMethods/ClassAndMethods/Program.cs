using System;
using System.Globalization;

namespace ClassAndMethods {
    class Program {
        static void Main(string[] args) {
            Problem();
        }

        static void Problem() {
            /* Resolvendo um problema sem orientação a objetos 
            Fazer um programa para ler as medidas dos lados de dois triângulos
            X e Y (suponha medidas válidas). Em seguida mostrar o valor das
            Áreas dos dois triângulos e dizer qual dos dois triângulos possui 
            a maior área.
            A fórmula para calcular a área de um triângulo a partir das medidas 
            de seus lados a, b e c é a seguinte (fórmula de Heron):

            area = raiz de p(p - a)(p - b)(p - c) onde p = (a + b + c) / 2
            */

            double triangleXA = 0, triangleXB = 0, triangleXC = 0;
            double triangleYA = 0, triangleYB = 0, triangleYC = 0;
            double pX, pY;
            double areaX, areaY;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            triangleXA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleXB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleXC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            triangleYA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleYB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            triangleYC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pX = (triangleXA + triangleXB + triangleXC) / 2.0;
            pY = (triangleYA + triangleYB + triangleYC) / 2.0;

            areaX = Math.Sqrt(pX * (pX - triangleXA) * (pX - triangleXB) * (pX - triangleXC));
            areaY = Math.Sqrt(pY * (pY - triangleYA) * (pY - triangleYB) * (pY - triangleYC));

            Console.WriteLine($"Área de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X.");
            }
            else if (areaY > areaX) {
                Console.WriteLine("Maior área: Y.");
            }
            else {
                Console.WriteLine("Áreas iguais.");
            }
        }
    }
}