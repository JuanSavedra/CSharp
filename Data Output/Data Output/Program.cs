using System.Globalization;

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