using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Constructors {
    class PropertiesProduct {
        private string _name;
        private double _price;
        private int _quantity; /* Não permitindo que a variável quantidade seja acessada 
                                * por programação externa (evita erros), normalmente é
                                * usado um '_' na frente das variáveis privativas */

        public PropertiesProduct(string name, double price, int quantity) {
            _name = name;
            _price = price;
            _quantity = quantity;
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

        public double Price { get { return _price; } }

        public int Quantity { get { return _quantity; } }

        public override string ToString() {
            return $"Nome: {_name}, " +
                $"Preço: {_price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantidade em estoque: {_quantity}";
        }
    }
}
