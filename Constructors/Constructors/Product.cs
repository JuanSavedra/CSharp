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

        public Product() { } //Construtor padrão

        public Product(string name, double price) { //Sobrecarga
            this.name = name;
            this.price = price;
            this.quantity = 0; //Linha desnecessária, pois o padrão já é zero
        }

        public Product(string name, double price, int quantity) { //Faz os valores não serem mais nulos
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString() {
            return $"Nome: {name}, Preço: {price}, Quantidade em estoque: {quantity}";
        }
    }
}
