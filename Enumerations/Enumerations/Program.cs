using System.Globalization;
using Enumerations.Entities;
using Enumerations.Entities.Enums;

namespace Enumerations {
    class Program {
        static void Main(string[] args) {
            //Enumeration();
            //Organization();
            Exercise1();
        }

        static void Enumeration() {
            /* Enumeradores 
            É um tipo especial que serve para especificar de forma literal um conjunto
            de constantes relacionadas
            Melhor semântica, código mais legível e auxiliado pelo compilador
            */

            Order order = new Order {
                id = 1080,
                moment = DateTime.Now,
                status = OrderStatus.pendingPayment
            };

            Console.WriteLine($"Order:\n{order}");

            /* Versões para possíveis erros pela versão do compilador
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            OrderStatus os;
            Enum.TryParse("Delivered", out os);
            */

            OrderStatus os = Enum.Parse<OrderStatus>("delivered");
            string txt = OrderStatus.pendingPayment.ToString();

            Console.WriteLine($"Os: {os}");
            Console.WriteLine($"Txt: {txt}");
        }

        static void Organization() {
            /* Comentando sobre organização do projeto
            Categorias de classes: 
            Em um sistema orientado a objetos, de modo geral "tudo" é objeto
            Por questões de design tais como organização, flexibilidade, reuso, delegação, 
            etc. Há várias categorias de classes

            Views - Parte visual
            Controllers - Controladores da aplicação (meio de campo)
            Entities - Produtos, clientes, pedidos, etc
            Services - Serviços da aplicação 
            Repositories - Conexões
            */
        }

        static void Exercise1() {
            /* 
            Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois,
            solicitar do usuário um mês e mostrar qual foi o salário do funcionário nesse mês
            */

            Console.Write("Department Name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter the worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, baseSalary, level, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract); 
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("===================================");
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for " +
                $"{monthAndYear}: " +
                $"{worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}"
            );
        }
    }
}