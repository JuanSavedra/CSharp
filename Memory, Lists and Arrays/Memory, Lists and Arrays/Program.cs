using System.Globalization;

namespace MemoryListsArrays {
    class Program {
        static void Main(string[] args) {
            //Structs();
            Vectors();
        }

        static void Structs() {
            /* 
            É um recurso de C# para que daods de tipo valor (structs) possam
            receber o valor null
            Uso comum:
            - Campos de banco de dados que podem valer nulo (data de nascimento,
            algum valor numérico, etc)
            - Dados e parâmetros opcionais
            */

            /* 
            double x = null; Variáveis double não podem ter seu valor anulado 
            Nullable<double> x = null;
            //Ou
            double? x = null; //O '?' significa opcional
            */

            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault()); //Valor ou Default (0). Saída: 0
            Console.WriteLine(y.GetValueOrDefault()); //Valor ou Default (0). Saída: 10.0
            Console.WriteLine(x.HasValue); //Contém valor ou não. Saída: False   
            Console.WriteLine(y.HasValue); //Contém valor ou não. Saída: True

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X == Null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y == Null");
            }

            //Operador de coalescência nula
            double a = x ?? 5.0; //O valor do A será igual ao de X, porém se ele for nulo, o valor de A será 5.0
            double b = y ?? 5.0; //O valor do B será igual ao de Y, porém se ele for nulo, o valor de B será 5.0
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Vectors() {
            /* Vetores 
            Vetor é o nome dado a um array unidimensional 
            */

            //Problem1();
            Problem2();

            void Problem1() {
                /* Problema 1
                Fazer um programa para ler um número inteiro N e a altura de N pessoas.
                Armazena as N alturas em um vetor. Em seguida, mostrar a altura média
                dessas pessoas
                */

                Console.WriteLine("Diga a quantidade de pessoas: ");
                int persons = int.Parse(Console.ReadLine());
                double[] heights = new double[persons];

                for (int i = 0; i < persons; i++) {
                    Console.Write($"Diga a altura da pessoa {i + 1}: ");
                    heights[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double sum = 0.0;
                for (int i = 0; i < persons; i++) {
                    sum += heights[i];
                }

                double average = sum / persons;
                Console.WriteLine($"Altura média: {average.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            void Problem2() {
                /* Problema 2
                Fazer um programa para ler um número inteiro N e os dados (nome e preço)
                de N produtos. Armazene os N produtos em um vetor. Em seguida, mostrar o
                preço médio dos produtos
                */

                Console.WriteLine("Diga a quantidade de produtos: ");
                int products = int.Parse(Console.ReadLine());
                string[] productsName = new string[products];
                double[] productsPrices = new double[products];

                for (int i = 0; i < products; i++) {
                    Console.Write($"Diga o nome do produto {i + 1}: ");
                    productsName[i] = Console.ReadLine();
                    Console.Write($"Diga o preço do produto {i + 1}: ");
                    productsPrices[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                }

                double sum = 0.0;
                for (int i = 0; i < products; i++) {
                    sum += productsPrices[i];
                }

                double average = sum / products;
                Console.WriteLine($"Preço médio: {average.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}