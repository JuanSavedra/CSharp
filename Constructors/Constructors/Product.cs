using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors {
    class Product {
        public string name;
        public double price;
        public int quantity;

        public Product() {
            quantity = 0;
        } //Construtor padrão

        public Product(string name, double price) : this() /* Referenciando o construtor vazio*/ {
            this.name = name;
            this.price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price) /* Referenciando construtor de
                                                                                     * dois parâmetros*/ 
        { 
            this.quantity = quantity;
        }

        public override string ToString() {
            return $"Nome: {name}, Preço: {price}, Quantidade em estoque: {quantity}";
        }
    }
}
