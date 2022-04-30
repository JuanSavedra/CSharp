using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassAndMethods {
    class Product {
        public string name;
        public double price;
        public int quantity;

        public double TotalPrice() {
            return quantity * price;
        }

        public override string ToString() { //Método que permite retornar uma string do produto
            return $"{name}, " +
                $"R${price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{quantity} unidades. " +
                $"Total: {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void AddProduct(int quantity) {
            this.quantity += quantity;
        }

        public void RemoveProduct(int quantity) {
            if (quantity > this.quantity) {
                Console.WriteLine("Você tentou remover muitos produtos...");
            } 
            else {
                this.quantity -= quantity;
            }
        }
    }
}
