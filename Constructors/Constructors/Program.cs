using System;
using System.Globalization;

namespace Constructors {
    class Program {
        static void Main(string[] args) {
            //Constructors();
            //Overload();
            //AlternativeSyntax();
            //This();
            Encapsulation();
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

            Product product = new Product {
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
    }
}