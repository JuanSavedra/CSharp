using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods {
    class Rectangle {
        public double width, height;

        public double Area() {
            return width * height;
        }

        public double Perimeter() {
            return 2 * (width + height);    
        }
    }
}
