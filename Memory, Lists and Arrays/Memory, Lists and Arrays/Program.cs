namespace MemoryListsArrays {
    class Program {
        static void Main(string[] args) {
            Structs();
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
    }
}