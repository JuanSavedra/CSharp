using System; //Namespace padrão do dotnet para funções padrões
using System.Globalization;

/* Namespace 
Agrupamento de classes e programas
*/

namespace Estudos { //Namespace Criado por Você (Questão de boa prática, não é algo obrigatório)
    class Estudos { //Classe
        public static void Main(string[] args) { //Membro da classe. (string[] args = entryPoint 'primeira execução' da aplicação)
            Console.WriteLine("Hello World!");
            Variables();
            DataOutput();
            Conversion();
        }

        public static void Variables() {
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

        public static void DataOutput() {

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

        public static void AssignmentOperators() {
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

        public static void Conversion() {
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
    }
}