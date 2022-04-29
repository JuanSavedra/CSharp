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