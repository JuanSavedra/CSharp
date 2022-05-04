using InheritanceAndPolymorphism.Entities;

namespace InheritanceAndPolymorphism {
    class Program {
        static void Main(string[] args) {
            //Inheritance();
            //UpcastingDowncasting()
            Overlap();
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
    }
}