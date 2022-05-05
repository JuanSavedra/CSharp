namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            Exception();
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
    }
}