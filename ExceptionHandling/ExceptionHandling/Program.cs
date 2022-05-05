namespace ExceptionHandling {
    class Program {
        static void Main(string[] args) {
            //Exception();
            //TryCatch();
            //Finally();
            Exercise1();
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

        static void Exercise1() {
            /* 
            Faça um programa para ler os dados de uma reserva de hotel (número do quarto, 
            data de entrada e data de saída) e mostrar os dados da reserva, inclusive sua 
            duração em dias. Em seguida, ler novas datas de entrada e saída, atualizar a 
            reserva, e mostrar novamente a reserva com os dados atualizados. O programa 
            não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:
            Alterações de reserva só podem ocorrer para datas futura
            A data saída deve ser maior que a data de entrada
            */

            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn) {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in");
            }
            else {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null) {
                    Console.WriteLine($"Error in reservation: {error}");
                }
                else {
                    Console.WriteLine($"Reservation: {reservation}");
                }
            }
        }
    }
}