using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors {
    class PrivateProduct {
        private string _name;
        private double _price;
        private int _quantity; /* Não permitindo que a variável quantidade seja acessada 
                                * por programação externa (evita erros), normalmente é
                                * usado um '_' na frente das variáveis privativas */

        public PrivateProduct(string name) {
            _name = name;
        }

        public string GetName() { //Pegando o valor do nome por função, pois a variável esta definida com private
            return _name;
        }

        public void SetName(string name) { //A vantagem de funções é que podemos usar métodos nelas
            if (name != null && name.Length > 1) {
                _name = name;
            } else {
                Console.WriteLine("Nome muito curto...");
            }
        }

        /* Não permitindo que as variáveis preço e quantidade sejam modificadas */

        public double GetPrice() {
            return _price;
        }

        public int GetQuantity() {
            return _quantity;
        }

        /* Método Set() inexistente */

        public override string ToString() {
            return $"Nome: {_name}, Preço: {_price}, Quantidade em estoque: {_quantity}";
        }
    }
}
