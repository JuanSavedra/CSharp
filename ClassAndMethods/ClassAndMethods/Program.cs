using System;
using System.Globalization;

namespace ClassAndMethods {
    class Program {
        static void Main(string[] args) {
            //ProblemNoOO();
            //ProblemWithOO(); // OO = Orientação a Objetos
            //Exercise1();
            Exercise2();
        }

        static void ProblemNoOO() {
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

        static void ProblemWithOO() {
            Triangle x, y;
            double areaX, areaY, p;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (x.A + x.B + x.C) / 2.0;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (y.A + y.B + y.C) / 2.0;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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

        static void Exercise1() {
            /* 
            Fazer um programa para ler os dados de duas pessoas, depois mostrar
            o nome da pessoa mais velha
            */

            Person personX, personY;
            personX = new Person();
            personY = new Person();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            personX.name = Console.ReadLine();
            Console.Write("Idade: ");
            personX.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            personY.name = Console.ReadLine();
            Console.Write("Idade: ");
            personY.age = int.Parse(Console.ReadLine());

            if (personX.age > personY.age) {
                Console.WriteLine($"Pessoa mais velha: {personX.name}");
            }
            else if (personY.age > personX.age) {
                Console.WriteLine($"Pessoa mais velha: {personY.name}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: Nenhuma");
            }
        }

        static void Exercise2() {
            /* 
            Fazer um programa para ler o nome e salário de dois funcionários.
            Depois, mostrar o salário médio dos funcionários.
            */

            double averageSalary; 
            Employee employeeX, employeeY;
            employeeX = new Employee();
            employeeY = new Employee(); 

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            employeeX.name = Console.ReadLine();
            Console.Write("Salário: ");
            employeeX.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            employeeY.name = Console.ReadLine();
            Console.Write("Salário: ");
            employeeY.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            averageSalary = (employeeX.salary + employeeY.salary) / 2;
            Console.WriteLine($"Salário médio: {averageSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}