using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerations.Entities.Enums;

namespace Enumerations.Entities {
    class Order {
        public int id { get; set; }
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public override string ToString() {
            return $"ID: {id}, " +
                $"Moment: {moment} " +
                $"Status: {status}";
        }
    }
}
