using InheritanceAndPolymorphism.Entities;

namespace InheritanceAndPolymorphism {
    class Program {
        static void Main(string[] args) {
            Inheritance();
        }

        static void Inheritance() {
            /* Herança
            É um tipo de associação que permite que uma classe herde dados e comportamentos
            de outra
            */

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);
            Console.WriteLine(account);
        }
    }
}