using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Constructors {
    class AutoPropertiesProduct {
        /* Porque o nome não vira uma auto-property? 
        Pois ele contém uma lógica em seu set, portanto
        ele não será uma auto-property */

        private string _name;

        /* Agora as propriedades se tornam públicas novamente, porém somente o valor 
        get pode ser acessado */

        public double price { get; private set; }
        public int quantity { get; private set; }

        public AutoPropertiesProduct(string name, double price, int quantity) {
            _name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1 /* 'value' = parâmetro */) {
                    _name = value;
                }
                else {
                    Console.WriteLine("Nome muito curto ou inexistente...");
                }
            }
        }

        public override string ToString() {
            return $"Nome: {_name}, " +
                $"Preço: {price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade em estoque: {quantity}";
        }

        /* Ordem sugerida para implementação: 
        Atributos privados
        Propriedades autoimplementadas
        Construtores
        Propriedades customizadas
        Outros métodos da classe
        */
    }
}
