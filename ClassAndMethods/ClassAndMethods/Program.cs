using System;
using System.Globalization;

namespace ClassAndMethods {
    class Program {
        static void Main(string[] args) {
            //ProblemNoOO();
            //ProblemWithOO(); // OO = Orientação a Objetos
            //Exercise1();
            //Exercise2();
            //ProblemWithObjectsAndToString();
            //Exercise3();
            Exercise4();
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

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();
            areaY = y.Area();

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

        static void ProblemWithObjectsAndToString() {
            /* Como deve ficar a saída do exercício
            Entre os dados do produto:
            Nome: #nome
            Preço: #preço (double)
            Quantidade no estoque: quantidade (int)

            Dados do produto: #nome, R$#preço, #quantidade unidades, Total: R$#preço_total
            
            Digite o número de produtos a serem adicionados ao estoque: #quantidade

            Dados atualizados: #nome, R$#preço, #quantidade unidades, Total: R$#preço_total

            Digite o número de produtos a serem removidos do estoque: #quantidade

            Dados atualizados: #nome, R$#preço, #quantidade unidades, Total: R$#preço_total
            */

            Product product;
            product = new Product();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            product.name = Console.ReadLine();
            Console.Write("Preço: ");
            product.price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            product.quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {product /* ou product.ToString() */}");

            Console.WriteLine("\nDigite o número de produtos a serem adicionados ao estoque: ");
            product.AddProduct(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados atualizados: {product}");

            Console.WriteLine("\nDigite o número de produtos a serem removidos do estoque: ");
            product.RemoveProduct(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nDados atualizados: {product}");
        }

        static void Exercise3() {
            /*
            Faça um programa para ler os valores da largura e altura 
            de um retângulo. Em seguida, mostre na tela o valor de sua 
            área e perímetro. Usar uma classe como mostrada no projeto 
            abaixo.

            Retângulo | Largura: double, Altura: double
            Area(): double
            Perimetro(): double
            */

            Rectangle rect;
            rect = new Rectangle();

            Console.WriteLine("Diga a altura e a largura do retângulo: ");
            rect.width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rect.height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área: {rect.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro: {rect.Perimeter().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void Exercise4() {
            /* 
            Fazer um programa para ler os dados de um funcionário 
            (nome, salário bruto e imposto). Em seguida, mostrar 
            os dados do funcionário (nome e salário líquido). Em
            seguida, aumentar o salário do funcionário com base 
            em uma porcentagem dada (somente o salário bruto é 
            afetado pela porcentagem) e mostrar novamente os dados
            do funcionário. Use a classe projetada abaixo.

            Funcionário | Nome: string, SalárioBruto: double, 
            Imposto: double
            SalárioLíquido(): double 
            AumentarSalário(porcentagem: double): void 
            */

            Functionary functionary;
            functionary = new Functionary();

            Console.Write("Nome: ");
            functionary.name = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            functionary.grossSalary = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture
            );

            Console.Write("Imposto: ");
            functionary.tax = double.Parse(
                Console.ReadLine(), CultureInfo.InvariantCulture
            );

            Console.WriteLine($"\nFuncionário: {functionary}");

            Console.WriteLine(
                $"Digite a porcentagem para aumentar o salário de {functionary.name}: "
            );
            functionary.SalaryIncrease(
                double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture)
            );

            Console.WriteLine($"Dados atualizados: {functionary}");
        }
    }
}