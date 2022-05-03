using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations.Entities.Enums {
    enum OrderStatus : int /* Falando que o enum vai ser do tipo int */ {
        pendingPayment, //Se não é definido, inicia-se no 0
        processing,
        shipped,
        delivered
    }
}
