using System; //Namespace padrão do dotnet para funções padrões
using System.Globalization;

/* Namespace 
Agrupamento de classes e programas
*/

namespace Estudos { //Namespace Criado por Você (Questão de boa prática, não é algo obrigatório)
    class Estudos { //Classe
        static void Main(string[] args) { //Membro da classe. (string[] args = entryPoint 'primeira execução' da aplicação)
            Console.WriteLine("Hello World!");
            //Variables();
            //DataOutput();
            //Conversion();
            //ArithmeticOperators();
            //DataInput();
            //ComparativeOperators();
            //LogicalOperators();
            //ConditionalStructure();
            Functions();
        }

        static void Variables() {
            sbyte a = 100; //Tipo do C# (Tipo do dotnet 'SByte')
            short b = 100;
            int c = 100; //Variável do tipo inteiro
            long d = 100; //Variável do tipo inteiro, aceitando valores maiores que o tipo int
            byte e = 100;
            ushort f = 100;
            uint g = 100;
            ulong h = 100;
            float i = 100.5f; //Variável do tipo real, aceitando números quebrados, com ponto flutuante
            /* 
            Os valores do tipo float são instanciados de forma diferente, utilizando uma definição 'f'
            após o número 
            */
            double j = 100.5; //Variável do tipo real, aceitando valores maiores que o tipo float
            decimal k = 100; //Sistema de números decimais
            char l = 'a'; //Variável que aceita somente caracteres
            string m = "Hello World!"; //Variável que aceita mais que um caractere
            object n = "Object"; //Variável do tipo objeto que aceita qualquer definição

            //Variável do tipo booleano que só funciona com valores verdadeiros ou falsos
            /*
            Em outras linguagens, os valores booleanos não são pré-definidos, diferente da C#, então eles 
            acabam usando 0 para falso e qualquer outro número para verdadeiro
            */
            bool o = true;
            bool p = false;

            //Saídas do Console
            Console.WriteLine("sbyte: " + a);
            Console.WriteLine("short: " + b);
            Console.WriteLine("int: " + c);
            Console.WriteLine("long: " + d);
            Console.WriteLine("byte: " + e);
            Console.WriteLine("ushort: " + f);
            Console.WriteLine("uint: " + g);
            Console.WriteLine("ulong: " + h);
            Console.WriteLine("float: " + i);
            Console.WriteLine("double: " + j);
            Console.WriteLine("decimal: " + k);
            Console.WriteLine("char: " + l);
            Console.WriteLine("string: " + m);
            Console.WriteLine("object: " + n);
            Console.WriteLine("bool true: " + o);
            Console.WriteLine("bool false: " + p);

            /* Funções para valores mínimos e máximos
            int a = 0;
            int b = 0;
            a = decimal.MaxValue;
            b = byte.MinValue;
            */
        }

        static void DataOutput() {

            float pi = 3.14159265359f;
            Console.WriteLine(pi.ToString("F2")); //Passa o valor de pi para apenas dois números após o ponto (3,14)

            /* Placeholders
            Funciona como um "tampa buraco" na hora de programar, usado para quando não se sabe o valor na 
            hora
            */

            string name = "Juan";
            int myAge = 16;
            string city = "SP";
            Console.WriteLine("O {0} tem {1} anos e mora em {2}.", name, myAge, city); //"O Juan tem 16 anos e mora em SP"

            /* Interpolação
            Funciona como um placeholder porém é escrito de outra maneira
            */

            Console.WriteLine($"O {name} tem {myAge} anos e mora em {city}");

            /*
            Também pode-se utilizar dentro delas funções como a do ToString("F2") por exemplo
            */

            Console.WriteLine("O valor de pi é: {0:F2}", pi);
            Console.WriteLine($"O valor de pi é: {pi:F2}");
            Console.WriteLine($"O valor de pi é: {pi.ToString("F2", CultureInfo.InvariantCulture)}"); //Muda a vírgula pelo ponto

            /* Concatenação
            Junta diversas strings 
            */

            Console.WriteLine("O " + name + " tem " + myAge + " anos e mora em " + city + "\n");

            //Exercício
            /*
            Inicialize as seguintes variáveis:

            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = "2100.00";
            double price2 = "650.50";
            double media = "53.234567";

            Saída:

            Produtos: 
            Computador, cujo preço é R$2100,00
            Mesa de escritório, cujo preço é R$650,50

            Registro: 30 anos de idade, código 5290 e gênero: M

            Medida com oito casas decimais: 53,234567
            Arredondado (três casas decimais): 53,235
            Separador decimal invariant culture: 53,235
            */

            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.00;
            double price2 = 650.50;
            double size = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é: R${price1}");
            Console.WriteLine($"{product2}, cujo preço é: R${price2}");
            Console.WriteLine($"\nRegistro: {age} anos de idade, código: {code} e gênero: {gender} \n");
            Console.WriteLine($"Medida com oito casas decimais: {size}00");
            Console.WriteLine($"Arredondado (três casas decimais): {size.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {size.ToString("3F", CultureInfo.InvariantCulture)}");

            // O '\n' pula ou quebra linhas 
        }

        static void AssignmentOperators() {
            /* Operadores de Atribuição
            = - Igual
            += - Mais igual
            -= - Menos igual
            *= - Vezes igual
            /= - Dividido igual
            %= - Módulo igual
            */

            int a = 0;

            Console.WriteLine(a = 0); //0
            Console.WriteLine(a += 10); //10
            Console.WriteLine(a -= 2); //8
            Console.WriteLine(a *= 1); //8
            Console.WriteLine(a /= 2); //4
            Console.WriteLine(a %= 4); //0

            string abc = "ABC";
            abc += "DEF";

            Console.WriteLine(abc); //ABCDEF

            /* Incremento e Decremento
            ++ - Incremento (valor = valor + 1)
            -- - Decremento (valor = valor - 1)

            A ordem importa, ou seja, se o incremento vier antes da variável o valor só
            irá mudar na próxima verificação

            a = 0;
            Console.WriteLine(a++); //0
            Console.WriteLine(a); //1

            a = 0;
            Console.WriteLine(++a); //1
            Console.WriteLine(--a); //0
            */

            a = 0;
            Console.WriteLine(++a); //1
            Console.WriteLine(--a); //0
        }

        static void Conversion() {
            /* Casting
            O casting é uma conversão que você faz de uma variável a outra, por exemplo,
            a variável double não pode ser armazenada em uma variável float, pois os bytes
            são diferentes em cada uma, então fazemos o seguinte:
            */

            double a = 4.5;
            float b;

            b = (float)a;

            //Lembre-se de converter para a o tipo da variável que vai armazenar
        }

        static void ArithmeticOperators() {
            /* Operadores Aritméticos
            + - Adição
            - - Subtração
            * - Multiplicação
            / - Divisão
            % - Módulo (resto da divisão)
            */

            int n1 = 2 + 2; //4
            int n2 = 2 - 2; //0
            int n3 = 2 * 2; //4
            int n4 = 2 / 2; //1
            int n5 = 2 % 2; //0

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
        }

        static void DataInput() {
            /* Entrada de dados
            ReadLine() - Pega o que você digitou e passa a uma variável
            */

            Console.Write("Diga uma frase: ");
            string phrase = Console.ReadLine();
            Console.WriteLine($"Você disse: {phrase}");

            /* Split
            Separa strings por meio de uma tecla escolhida
            */

            string[] splitPhrase = phrase.Split(' '); //Tecla escolhida 'espaço'
            for (int i = 0; i < splitPhrase.Length; i++) {
                Console.WriteLine($"Palvra {i + 1}: {splitPhrase[i]}");
            }

            /* Parse 
            Converte a cadeia de caracteres equivalente a 32 bits
            */

            Console.WriteLine("Diga um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga outro número: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga um caractere: ");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(ch);

            /* Exercício 
            Fazer um programa para executar a seguinte interação com o usuário,
            lendo os valores destacados com a hashtag, e depois mostrar os 
            dados na tela

            Entrada 

            Entre com seu nome completo:
            #Alex Green
            Quantos quartos tem na sua casa?
            #3
            Entre com o preço de um produto: 
            #500.50
            Entre com seu último nome, idade e altura (mesma linha):
            #Green 21 1.73

            Saída 

            Alex Green
            3
            500.50
            Green
            21
            1.73
            */

            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double price = double.Parse(Console.ReadLine());
            price.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string answersQuestions = Console.ReadLine();
            string[] answers = answersQuestions.Split(' ');
            string lastName = answers[0];
            int age = int.Parse(answers[1]);
            double height = double.Parse(answers[2]);

            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString(CultureInfo.InvariantCulture));
        }

        static void ComparativeOperators() {
            /* Operadores Comparativos 
            > - Maior 
            < - Menor
            >= - Maior ou igual 
            <= - Menor ou igual
            == - Igual
            != - Diferente 
            */

            bool b;
            int a = 10;

            b = a > 10; //Falso
            Console.WriteLine(b);
            b = a < 10; //Falso
            Console.WriteLine(b);
            b = a >= 10; //True
            Console.WriteLine(b);
            b = a <= 10; // True
            Console.WriteLine(b);
            b = a == 10; //True
            Console.WriteLine(b);
            b = a != 10; //Falso
            Console.WriteLine(b);
        }

        static void LogicalOperators() {
            /* Operadores Lógicos
            && - E (Só retorna True quando as duas ou mais verificações passam)
            || - Ou (Só retorna True quando uma das verificações passam)
            ! - Não (Retorna o oposto)
            */

            int a = 10;
            bool b;

            b = a <= 10 && a == 10; //True
            Console.WriteLine(b);
            b = a < 10 && a == 10; //False
            Console.WriteLine(b);
            b = a < 10 && a > 10; //False
            Console.WriteLine(b);

            b = a <= 10 || a == 10; //True
            Console.WriteLine(b);
            b = a < 10 || a == 10; //True
            Console.WriteLine(b);
            b = a < 10 || a > 10; //False
            Console.WriteLine(b);

            b = true;
            b = !b; //False
            Console.WriteLine(b);
            b = !b; //True
            Console.WriteLine(b);
        }

        static void ConditionalStructure() {
            /* Estrutura condicional
            if - Se
            else - Senão
            else if - Senão se
            */

            Console.WriteLine("Digite um valor: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 0) {
                Console.WriteLine("A igual a 0.");
            }
            else if (a > 0) {
                Console.WriteLine("A maior que 0.");
            }
            else {
                Console.WriteLine("Valor negativo.");
            }

            //Verificando se é par ou ímpar

            if (a % 2 == 0) {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Ímpar!");
            }
        }

        static void Functions() {
            /* Funções 
            As funções são partes do código usadas para organizar e auxiliar em 
            tarefas, temos funções de todos os tipos de variáveis e inclusive void
            (tipo vazio). Elas podem receber parâmetros em seus parêneteses e também
            podem retornar diretamente algum valor com um 'return'
            */

            InternalFunc();
            Sum(8, 8 /* Passando os valores na declaração da função */);

            void InternalFunc() {
                Console.WriteLine("Função Interna.");
            }

            int Sum(int x, int y /* Parâmetros da função */) {
                int result = x + y;
                Console.WriteLine(result);
                return result; //Retornando o valor
            }
        }
    }
}