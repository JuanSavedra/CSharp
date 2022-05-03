﻿namespace SpecialTopics {
    class Program {
        static void Main(string[] args) {
            //Var();
            //AlternativeSyntax();
            StringFunctions();
        }

        static void Var() {
            /* Variável var
            Ela se define de acordo com o valor dela 
            */

            var a = 1; //int
            var b = 2.00; //double
            var c = "Nome"; //string

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        static void AlternativeSyntax() {
            /* Switch e Case */
            int a = 0;
            
            //Método if
            if (a == 0) {
                Console.WriteLine("0");
            } else if (a == 1) {
                Console.WriteLine("1");
            } else if (a == 2) {
                Console.WriteLine("2");
            } else {
                Console.WriteLine("Nenhum");
            }

            //Método switch e case
            switch (a) {
                case 0: 
                    Console.WriteLine("0");
                    break;
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2: 
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Nenhum");
                    break;
            }

            /* Operações ternárias */

            //Método com abertura e fechamento de chaves
            if (a > 0) {
                a++;
            } else {
                a--;
            }

            //Método com operações ternárias
            a = (a > 0) ? a++ : a--; //? = If, : = Else
        }

        static void StringFunctions() {
            /* Funções interessantes para strings 
            - Formatar: ToLower(), ToUpper(), Trim()
            - Buscar: IndexOf(), LastIndexOf()
            - Recortar: Substring(inicio), Substring(inicio, tamanho)
            - Substituir: Replace(char, char), Replace(string, string)
            - String.isNullOrEmpty(string), String.isNullOrWhiteSpace(string)
            - string.Split('')
            - Conversão para número: int x = int.Parse(string), int x = Convert.ToInt32(string)
            - Conversão de número: 
            string = x.ToString(), 
            string = x.ToString("C"), 
            string = x.ToString("C3"),
            string = x.ToString("F2")
            */
        }
    }
}