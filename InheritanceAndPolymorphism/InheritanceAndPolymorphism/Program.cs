using InheritanceAndPolymorphism.Entities;
using System.Globalization;

namespace InheritanceAndPolymorphism {
    class Program {
        static void Main(string[] args) {
            //Inheritance();
            //UpcastingDowncasting()
            //Overlap();
            //SealedMethods();
            //Polymorphism();
            //Exercise1();
            //Exercise2();
            //AbstractClass();
            AbstractsMethods();
        }

        static void Inheritance() {
            /* Herança
            É um tipo de associação que permite que uma classe herde dados e comportamentos
            de outra
            */

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);
            Console.WriteLine(account);
        }

        static void UpcastingDowncasting() {
            /* Uocasting
            Casting da subclasse para superclasse
            Uso comum: Polimorfismo
            */

            /* Downcasting
            Casting da superclasse para subclasse
            As
            Is
            Uso comum: Métodos que recebem parâmetros génericos (Ex: Equals)
            */

            Account account = new Account(1001, "Alex", 0.00);
            BusinessAccount busAccount = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            //Upcasting
            Account account1 = busAccount;
            Account account2 = new BusinessAccount(1003, "Bob", 0.00, 200.00);
            Account account3 = new SavingsAccounts(1004, "Anna", 0.00, 0.01);

            //Downcasting (Operação insegura)
            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.00);

            if (account3 is BusinessAccount) {
                BusinessAccount account5 = (BusinessAccount)account3 /* account3 as BusinessAccount */;
                account5.Loan(200.00);
                Console.WriteLine("Account 3 is BusinessAccount");
            }

            if (account3 is SavingsAccounts) {
                SavingsAccounts account5 = (SavingsAccounts)account3;
                account5.UpdateBalance();
                Console.WriteLine("Account 3 is SavingsAccounts");
            }
        }

        static void Overlap() {
            /* Sobreposição 
            Palavra base:
            É possível chamar a implementação da superclasse usando a palavra base
            Exemplo - Suponha que a regra para saque para conta poupança seja realizar
            o saque normalmente da superclasse (Account), e depois descontar mais 2.0
            Deixe a função padrão com o "virtual": public virtual ...

            public override void Withdraw(double amount) {
                base.Withdraw(amount);
                Balance -= 2.0;
            }
            */

            Account account = new Account(1001, "Alex", 500.00);
            Account account2 = new SavingsAccounts(1002, "Anna", 500.00, 0.01);

            account.Withdraw(10.00);
            account2.Withdraw(10.00);

            Console.WriteLine(account);
            Console.WriteLine(account2);
        }

        static void SealedMethods() {
            /* Classes e métodos selados 
            Palavra chave - sealed 
            */

            /* Classes
            Evita que a classe seja herdada * ainda é possível extender a funcionalidade 
            de uma classe selada usando 'extension methods'*
            namespace Course {
                sealed class SavingsAccount {
                
                }   
            }
            */

            /* Métodos
            Evita que um método sobreposto possa ser sobreposto novamente * Só pode ser
            aplicado a métodos sobrepostos * 
            */
        }

        static void Polymorphism() {
            /* Polimorfismo 
            Em programação Orientada a Objetos, polimorfismo é recurso que permite que variáveis
            de um mesmo tipo mais genérico possam apontar para objetos de tipos específicos 
            diferentes, tendo assim comportamentos diferentes conforme cada tipo específico

            A associação do tipo específico com o tipo genérico é feita em tempo de execução
            O compilador não sabe para qual tipo espécífico a chamada do método Withdraw está
            sendo feita (ele só sabe que são fuas variáveis tipo Account)

            Account account = new Account(1001, "Alex", 500.00);
            Account account2 = new Account(1002, "Anna", 500.00, 0.01);
            
            account.Withdraw(10.0);
            account2.Withdraw(10.0);
            */
        }

        static void Exercise1() {
            /* 
            Uma empresa possui funcionários próprios e terceirizados. Para cada funcionário,
            deseja-se registrar nome, horas trabalhadas e valor por hora. Funcionários 
            terceirizados possuem ainda uma despesa adicional.
            O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas
            trabalhadas, sendo que os funcionário tercerizados ainda recebem um bônus 
            correspondente a 110% de sua despesa adicional.
            Faça um programa para ler os dados de N funcionários (N fornecido pelo usuário) e 
            armazená-los em uma lista. Depois de ler todos os dados, mostrar nome e pagamento
            de cada funcionário na mesma ordem em que foram digitados.
            */

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), 
                    CultureInfo.InvariantCulture
                );

                if (ch == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture
                    );

                    list.Add(new OutsourcedEmployee (
                        name, hours, valuePerHour, additionalCharge)
                    );
                } 
                else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPayments: ");
            foreach (Employee emp in list) {
                Console.WriteLine($"{emp.Name} - " +
                    $"${emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}"
                );
            }
        }

        static void Exercise2() {
            /*
            Faça um programa para ler os dados de N produtos (N fornecido pelo usuário).
            Ao final, mostrar a etiqueta de preço de cada produto na mesma ordem em que
            foram digitados.
            Todo produto possui nome e preço. Produtos importados possuem uma taxa de 
            alfândega, e produtos usados possuem data de fabricação. Estes dados 
            específicos devem ser acrescentados na etiqueta de preço. Para produtos
            importados, a taxa e alfândega deve ser acrescentada ao preço final do 
            produto.
            */


            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Product product = new Product();
            List<Product> list = new List<Product>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Product #{i + 1} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                } 
                else if (ch == 'c') {
                    list.Add(new Product(name, price));
                }
                else {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
            }

            Console.WriteLine("Price tags: ");
            foreach (Product prod in list) {
                Console.WriteLine(prod.PriceTag());
            }
        }

        static void AbstractClass() {
            /* Classes abstratas 
            São classes que não podem ser instanciadas
            É uma forma de garantir herança total: somente subclasses não abstratas podem 
            ser instanciadas, mas nunca a superclasse abstrata
            Exemplo: 
            Suponha que em um negócio relacionado a banco, apenas contas poupanças
            e contas para empresas são permitidas. Não existe conta comum.
            Para garantir que contas comuns não possam ser instanciadas, basta acrescentarmos 
            a palavra "abstract" na declaração da classe.

            namespace Course {
                abstract class Account { }
            }

            Questionamento: 
            Se a classe Account não pode ser instanciada, por que simplesmente não criar somente
            SavingsAccount e BusinessAccount?
            Resposta:
            - Reuso
            - Polimorfismo

            Classes abstratas podem ser adicionadas em listas
            */
        }

        static void AbstractsMethods() {
            /* Métodos abstratos 
            São métodos que não possuem implementação 
            Métodos precisam ser abstratos quando a classe é genérica demais para conter sua 
            implementação (Exemplo: Existe uma classe Formas que possue retângulo e círculo, 
            a classe Formas é muito genérica, pois não sabemos sua forma, então se quissesemos
            calcular a área da figura, não teria como ser pela classe Formas, pois ela é genérica,
            então adicionariamos um método abstrato em cada figura)
            Se uma classe possuir pelo menos um método abstrato, então esta classe também é
            abstrata
            */
        }
    }
}