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

        public Product(string name, double price, int quantity) { //Faz os valores não serem mais nulos
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
