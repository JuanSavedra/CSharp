using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Constructors {
    class Bank {
        private string _name;

        public int id { get; private set; }
        public double balance { get; private set; }

        public Bank(string name, int id) {
            _name = name;
            this.id = id;
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 2) {
                    _name = value;
                }
            }
        }

        public int ID {
            get { return id; }
            set {
                id = value;
            }
        }

        public double Deposit {
            get { return balance; }
            set {
                balance += value;
            }
        }

        public double Withdraw {
            get { return balance; }
            set {
                if (value + 5.00 > balance) {
                    string response = null;
                    Console.WriteLine("Seu saldo irá ficar negativo, deseja prosseguir? (s/n)");
                    response = Console.ReadLine();
                    if (response == "s") {
                        balance -= value;
                        balance -= 5.00;
                    }
                    else if (response == "n") {
                        Console.WriteLine("Você cancelou a transação.");
                    }
                    else {
                        Console.WriteLine("Erro...");
                    }
                }
                else {
                    balance -= value;
                    balance -= 5.00;
                }
            }
        }

        public override string ToString() {
            return $"\n" +
                $"Conta: {id}, " +
                $"Titular: {_name}, " +
                $"Saldo: {balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
