namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            //Exception();
            //TryCatch();
            Finally();
        }

        static void Exception() {
            /* Exceções
            Uma exceção é qualquer condição de erro ou comportamento inesperado por um
            programa em execução
            No .NET, uma exceção é um objeto herdado da classe System.Exception
            Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em 
            execução, até que seja capturada (tratada) ou o programa seja encerrado
            */

            /* Porque exceções? 
            O modelo de tratamento de exceções permite que erros sejam tratados de forma
            consistent ee flexível, usando boas práticas
            Vantagens: 
            - Delega a lógica do erro para a classe / método responsável por conhecer as 
            regras que podem ocasionar o erro
            - Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes
            - A exceção pode carregar dados quaisquer
            */
        }

        static void TryCatch() {
            /* Bloco try
            Contém o código que representa a execução normal do trecho de código que pode 
            acarretar em uma exceção
            */

            /* Bloco catch 
            Contém o código a ser executado caso uma exceção ocorra 
            Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)
            */

            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result); //Se for 10 / 0 dará erro
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e) {
                Console.WriteLine("Format error!" + e.Message);
            }
            catch (Exception e) { //Exception (Qualquer tipo de exceção)
                Console.WriteLine(e.ToString());
            }
        }

        static void Finally() {
            /* Bloco finally 
            É um bloco que contém código a ser executado independentemente de ter 
            ocorrido ou não uma exceção
            Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final
            do processamento

            Sintaxe
            try {
                
            } catch() {
            
            } finally {

            }
            */
        }
    }
}