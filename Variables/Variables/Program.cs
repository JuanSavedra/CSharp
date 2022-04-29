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