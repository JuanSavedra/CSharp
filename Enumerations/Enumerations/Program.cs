using Enumerations.Entities;
using Enumerations.Entities.Enums;

namespace Enumerations {
    class Program {
        static void Main(string[] args) {
            //Enumeration();
            Organization();
        }

        static void Enumeration() {
            /* Enumeradores 
            É um tipo especial que serve para especificar de forma literal um conjunto
            de constantes relacionadas
            Melhor semântica, código mais legível e auxiliado pelo compilador
            */

            Order order = new Order {
                id = 1080,
                moment = DateTime.Now,
                status = OrderStatus.pendingPayment
            };

            Console.WriteLine($"Order:\n{order}");

            /* Versões para possíveis erros pela versão do compilador
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); 
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            OrderStatus os;
            Enum.TryParse("Delivered", out os);
            */

            OrderStatus os = Enum.Parse<OrderStatus>("delivered");
            string txt = OrderStatus.pendingPayment.ToString();

            Console.WriteLine($"Os: {os}");
            Console.WriteLine($"Txt: {txt}");
        }

        static void Organization() {
            /* Comentando sobre organização do projeto
            Categorias de classes: 
            Em um sistema orientado a objetos, de modo geral "tudo" é objeto
            Por questões de design tais como organização, flexibilidade, reuso, delegação, 
            etc. Há várias categorias de classes

            Views - Parte visual
            Controllers - Controladores da aplicação (meio de campo)
            Entities - Produtos, clientes, pedidos, etc
            Services - Serviços da aplicação 
            Repositories - Conexões
            */
        }
    }
}