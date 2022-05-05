using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Entities.Exceptions {
    class BalanceException : ApplicationException {
        public BalanceException(string message) : base(message) { }
    }
}
