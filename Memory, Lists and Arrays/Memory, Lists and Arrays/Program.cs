using System.Globalization;

namespace MemoryListsArrays {
    class Program {
        static void Main(string[] args) {
            //Structs();
            //Vectors();
            //Exercise1();
            //ParamsModificator();
            //RefAndOutModificator();
            OptionalSintax();
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
            //Problem2();

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

        static void Exercise1() {
            /*
            A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 ao 9
            Faça um programa que inicie com todos os dez quartos vazios, e depois 
            leia uma quantidade N representando o número de estudantes que vão alugar 
            quartos (N pode ser de 1 ao 10). Em seguida, registre o aluguel dos N 
            estudantes. Para cada registro de aluguel, informar o nome e email do 
            estudante, bem como qual dos quartos ele escolheu (de 0 ao 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir 
            um relatório de todas ocupações do pensionato, por ordem de quarto.
            */

            Console.WriteLine("Diga a quantidade de estudantes, " +
                "temos apenas 10 quartos disponíveis: "
            );
            int students = int.Parse(Console.ReadLine());

            if (students > 10) {
                Console.WriteLine("Não temos quartos suficientes...");
                Exercise1();
            }

            double rent = 1200.00;
            int[] rooms = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] studentsName = new string[students];
            string[] studentsEmail = new string[students];

            Console.WriteLine($"Quartos disponíveis: {rooms.Length}");
            Console.WriteLine($"Aluguel: R${rent}");

            for (int i = 0; i < students; i++) {
                Console.Write("Nome do estudante: ");
                studentsName[i] = Console.ReadLine();
                Console.Write("Email do estudante: ");
                studentsEmail[i] = Console.ReadLine();
                Console.WriteLine($"Número do quarto: {rooms[i]}");
            }

            for (int i = 0; i < students; i++) {
                Console.WriteLine("=============================");
                Console.WriteLine($"Quarto: {rooms[i]}");
                Console.WriteLine($"Estudante: {studentsName[i]}");
                Console.WriteLine($"Email: {studentsEmail[i]}");
                Console.WriteLine($"Aluguel: {rent.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("=============================");
            }
        }

        static void ParamsModificator() {
            int sum1 = Calculator.Sum(new int[] { 1, 2, 3 });
            int sum2 = Calculator.Sum(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }

        static void RefAndOutModificator() {
            /* Modificador Ref e Out(Referência)
            São mals-usos, sempre evitar
            Suponha que se queira uma calculadora com uma opração para triplicar o valor
            de um número passado como parâmetro.
            Então criamos um ref de referência para uma variável como parâmetro
            */

            int a = 10; //É obrigatório que a variável seja iniciada nos casos ref
            Calculator.TripleRef(ref a); //Saída: 30
            Console.WriteLine(a);

            int triple;
            Calculator.TripleOut(a, out triple); //Não é obrigatório iniciar
            Console.WriteLine(triple); //Saída: 90
        }

        static void BoxingAndUnboxing() {
            /* Boxing 
            É um processo de conversão de um objeto tipo valor para um objeto tipo
            referência compatível
            int x = 20;
            Object obj = x;
            */

            /* Unboxing
            É um processo de conversão de um objeto tipo referência para um objeto
            tipo valor compatível
            int x = 20;
            Object obj = x;
            int y = (int)obj;
            */
        }

        static void OptionalSintax() {
            /* Foreach 
            Sintaxe opcional e simplificada para percorrer coleções
            Leitura: "para cada objeto 'obj' contido em vect, faça"
            */

            string[] vect = new string[] {"Maria", "Bob", "Alex"};

            //Laço for: 
            for (int i = 0; i < vect.Length; i++) { 
                Console.WriteLine(vect[i]);
            }

            //Laço foreach: 
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}