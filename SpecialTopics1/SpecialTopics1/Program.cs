namespace SpecialTopics {
    class Program {
        static void Main(string[] args) {
            //Var();
            AlternativeSyntax();
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
    }
}