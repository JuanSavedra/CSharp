using System;
using System.Globalization;

namespace Constructors {
    class Program {
        static void Main(string[] args) {
            //Constructors();
            //Overload();
            //AlternativeSyntax();
            //This();
            //Encapsulation();
            //Properties();
            //AutoProperties();
            //AccessModifiers();
            Exercise1();
        }

        static void Constructors() {
            /* Construtores 
            É uma operação especial da classe, que executa no momento da instanciação do objeto
            Se um construtor customizado não for especificado, a classe disponibiliza o construtor 
            padrão (Product p = new Product())
            É possível especificar mais de um construtor na mesma classe (sobrecarga)
            */

            /* Product product = new Product("TV", 900.00, 10); //Produto instanciado com dados padrão */

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine(); //Variável do nome para ser adicionado ao construtor 
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(name, price, quantity);
        }

        static void Overload() {
            /* Sobrecarga 
            É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome,
            porém com diferentes listas de parâmetros
            */

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(name, price); //Construtor de apenas dois parâmetros

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Preço: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            product = new Product(name, price, quantity); //Construtor com os três parâmetros
        }

        static void AlternativeSyntax() {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product
            {
                name = name,
                price = price,
                quantity = quantity
            };

            Console.WriteLine(product);
        }

        static void This() {
            /* This
            Usos comuns: 
            Diferenciar atributos de variáveis locais
            Referenciar outro construtor em um construtor
            Passar o próprio objeto como argumento na chamada de um método ou construtor
            */
        }

        static void Encapsulation() {
            /* Encapsulamento 
            É um princípio que consiste em esconder detalhes de implementação de um componente,
            expondo apenas operações seguras e que o mantenha em um estado consistente
            Regra de ouro: o objeto deve sempre estar em um estado consistente, e a própria classe
            deve garantir isso
            Get e Set não é usual na plataforma C# 
            */

            PrivateProduct product = new PrivateProduct("TV");

            Console.WriteLine($"Nome do produto: {product.GetName()}");
            Console.Write("Diga o novo nome do produto: ");
            product.SetName(Console.ReadLine());
            Console.WriteLine($"Novo nome do produto: {product.GetName()}");
        }

        static void Properties() {
            /* Propriedades 
            São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e 
            não de métodos
            Uma propriedade é um membro que oferece um mecanismo felxível para ler, gravar ou calcular 
            o valor de um campo particular. As propriedades podem ser usadas como se fossem atributos 
            públicos, mas na verdade elas são métodos especiais chamados "acessores". Isso permite que 
            os dados sejam acessados facilmente e ainda ajuda a promover a segurança e a flexibilidade
            dos métodos
            */

            PropertiesProduct product = new PropertiesProduct("TV", 900.00, 10);
            Console.WriteLine($"Nome do produto: {product.Name}");
            Console.Write("Diga o novo nome do produto: ");
            product.Name = Console.ReadLine();
            Console.WriteLine($"Novo nome do produto: {product.Name}");
            Console.WriteLine($"Dados gerais do produto: {product}");
        }

        static void AutoProperties() {
            /* Propriedades autoimplementadas 
            É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares 
            para as operações get e set
            */

            AutoPropertiesProduct product = new AutoPropertiesProduct("TV", 900.00, 10);
            Console.WriteLine($"Nome do produto: {product.Name}");
            Console.Write("Diga o novo nome do produto: ");
            product.Name = Console.ReadLine();
            Console.WriteLine($"Novo nome do produto: {product.Name}");
            Console.WriteLine($"Dados gerais do produto: {product}");
        }

        static void AccessModifiers() {
            /* Modificadores de Acesso 
             * 1 - Própria classe
             * 2 - Subclasses do assembly
             * 3 - Classes do assembly
             * 4 - Subclasses fora do assembly
             * 5 - Classes fora do assembly
            public - [1][2][3][4][5]
            protected internal - [1][2][3][4]
            internal - [1][2][3]
            protected - [1][2][4]
            private protected - [1][2]
            private - [1]
            */
        }

        static void Exercise1() {
            /* 
            Em um banco, para se cadastrar uma conta bancária, é necessário informar o
            número da conta, o nome do titular da conta, e o valor do depósito inicial
            que o titular depositou ao abrir a conta. Este valor de depósito inicial,
            entretanto, é opcional, ou seja: Se o titular não tiver dinheiro a depositar
            no momento de abrir sua conta, o depósito inicial não será feito e o saldo 
            inicial da conta será, naturalmente zero.
            Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca 
            poderá ser alterado. Já o nome do titular pode.
            Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um 
            mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só 
            diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa 
            de R$5,00. Nota: A conta pode ficar com saldo negativo se o saldo não for 
            suficiente para realizar o saque e/ou pagar a taxa.
            Você deve informar um programa que realize o cadastro de uma conta, dando opção
            para que seja ou não informado o valor de depósito inicial. Em seguida, realizar 
            um depósito e depois um saque, sempre mostrando os dados da conta após cada 
            operação.
            */

            string name; 
            string response = null;
            Bank bank = new Bank("Desconhecido", 0000);

            Console.Write("Entre com o número da conta: ");
            bank.ID = int.Parse(Console.ReadLine());
            Console.Write("Diga o nome do titular da conta: ");
            bank.Name = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n)");
            response = Console.ReadLine();

            if (response == "s") {
                Console.Write("Diga o valor do depósito: ");
                bank.Deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Dados da conta: {bank}");
                Console.Write("\nEntre um valor para depósito: ");
                bank.Deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Dados da conta atualizados: {bank}");
                Console.Write("\nDiga um valor para saque (Taxa de R$5,00): ");
                bank.Withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                Console.Write($"Dados da conta atualizados: {bank}");
            }
            else if (response == "n") {
                Console.Write($"Dados da conta: {bank}");
                Console.Write("\nEntre um valor para depósito: ");
                bank.Deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Dados da conta atualizados: {bank}");
                Console.Write("\nDiga um valor para saque (Taxa de R$5,00): ");
                bank.Withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write($"Dados da conta atualizados: {bank}");
            }
            else {
                Console.WriteLine("Erro...");
                Exercise1();
            }
        }
    }
}