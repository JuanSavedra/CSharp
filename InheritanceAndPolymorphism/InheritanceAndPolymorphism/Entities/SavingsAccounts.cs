using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism.Entities {
    class SavingsAccounts : Account {
        public double InterestRate { get; set; }

        public SavingsAccounts() { }

        public SavingsAccounts(int number, string holder, double balance, double interestedRate) :
            base(number, holder, balance) {
            InterestRate = interestedRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }
    }
}
