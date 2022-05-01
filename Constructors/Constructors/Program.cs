namespace Constructors {
    class Program {
        static void Main(string[] args) {
            Constructors();
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
    }
}