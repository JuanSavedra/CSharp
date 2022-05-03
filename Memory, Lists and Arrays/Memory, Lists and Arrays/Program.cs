using System.Globalization;
using System.Collections.Generic;

namespace MemoryListsArrays {
    class Program {
        static void Main(string[] args) {
            //Structs();
            //Vectors();
            //Exercise1();
            //ParamsModificator();
            //RefAndOutModificator();
            //OptionalSintax();
            //Lists();
            //Exercise2();
            //Matrices();
            //Exercise3();
            Exercise4();
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

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            //Laço for: 
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }

            //Laço foreach: 
            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }

        static void Lists() {
            /* Listas 
            É uma estrutura de dados, iniciando-se vazia.
            Tamanho Variável
            Fácil acesso a inserções e deleções
            Acesso sequencial aos elementos
            */

            List<string> list = new List<string>(); //Lista instanciada, vazia 
            List<string> list2 = new List<string> { "Nome1", "Nome2" }; //Lista instanciada com elementos

            list.Add("Bob"); //Adicionando um elemento a lista
            Console.WriteLine(list[0]);
            list.Add("Ana"); //Adiciona por padrão no final da lista
            Console.WriteLine(list[1]);
            list.Add("Lúcio");
            Console.WriteLine(list[2]);
            list.Add("Antônio");
            Console.WriteLine(list[3]);
            list.Insert(3, "Fred"); //Escolhe a posição do elemento e o adiciona
            Console.WriteLine(list[3]);
            Console.WriteLine(list[4]); //Antônio foi pro valor [4]
            Console.WriteLine($"List count: {list.Count}");

            string s1 = list.Find(x => x[0] == 'A' /* Expressão lambda */); /* Encontrando a primeira pessoa 
                                                                            que começa com a letra 'A' */
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A'); /* Encontrando a última pessoa que começa com 
                                                           a letra 'A'*/
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //Posição da primeira pessoa com a letra A
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //Posição da última pessoa com a letra A
            Console.WriteLine(pos2);

            //Achando pessoas com nome igual a 3 caracteres
            List<string> list3 = list.FindAll(x => x.Length == 3);
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }

            /* Também temos como função os Removes
            - Remove
            - RemoveAll
            - RemoveAt (posição incial)
            - RemoveRange(posição inicial, quantidade de remoções a partir da posição inicial)
            */
        }

        static void Exercise2() {
            /* 
            Faça um programa para ler um número inteiro N e depois os dados (id, nome e salário)
            de N funcionários. Não deve haver repetição de id
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar
            uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser
            mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por
            porcentagem dada
            */

            int quantityEmployees;
            Console.Write("Diga quantos funcionários deseja registrar: ");
            quantityEmployees = int.Parse(Console.ReadLine());

            Employee emp = new Employee("Desconhecido", 0, 0.00);
            List<Employee> listEmployees = new List<Employee>();

            for (int i = 0; i < quantityEmployees; i++) {
                Console.WriteLine("===============================");
                Console.WriteLine($"Funcionário #{i + 1}: ");
                emp.ID = i;
                Console.WriteLine($"ID: {emp.ID}");
                Console.Write($"Nome: ");
                emp.Name = Console.ReadLine();
                Console.Write($"Salário: ");
                emp.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("===============================");
                listEmployees.Add(new Employee(emp.Name, emp.ID, emp.Salary));
            }

            int searchID;
            Console.Write("Escolha o ID de um usuário para aumentar seu salário em porcentagem: ");
            searchID = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            emp = listEmployees.Find(x => x.ID == searchID);
            if (emp != null) {
                Console.Write("Diga a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.Increase(percentage);
            }
            else {
                Console.WriteLine("Esse ID não existe!");
            }

            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach (Employee obj in listEmployees) {
                Console.WriteLine(obj);
            }
        }

        static void Matrices() {
            /* 
            São arrays multidimensionais 
            */

            double[,] mat = new double[2, 3 /* 2 linhas, 3 colunas */];

            Console.WriteLine(mat.Length); //6 (2 * 3)
            Console.WriteLine(mat.Rank); //2 (Linhas)
            Console.WriteLine(mat.GetLength(0)); //2 (Posição 0 == Linhas)
            Console.WriteLine(mat.GetLength(1)); //3 (Posição 1 == Colunas)
        }

        static void Exercise3() {
            /*
            Faça um programa para ler um número inteiro N e uma matriz de ordem N
            contendo números inteiros. Em seguida, mostrar a diagonal principal e 
            a quantidade de valores negativos da matriz
            */
            Console.WriteLine("Tamanho do array: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int l = 0; l < n; l++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int c = 0; c < n; c++) {
                    mat[l, c] = int.Parse(values[c]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int l = 0; l < n; l++) {
                for (int c = 0; c < n; c++) {
                    if (mat[l, c] < 0) {
                        count++;
                        Console.WriteLine($"Número negativo: {mat[l, c]}");
                    }
                }
            }

            Console.WriteLine($"Quantidade de números negativos: {count}");
        }

        static void Exercise4() {
            /*
            Fazer um programa para ler dois números inteiros M e N, e depois ler
            uma matriz de M linhas por N colunas contendo números inteiros, podendo
            haver repetições. Em seguida, ler um número inteiro X que pertence à 
            matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima,
            à direita e abaixo de X, quando houver, conforme exemplo
            */

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Baixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}