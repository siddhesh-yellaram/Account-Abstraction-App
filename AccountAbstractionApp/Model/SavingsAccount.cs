using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAbstractionApp.Model
{
    class SavingsAccount:Account
    {
        private string _name;
        private int _accNo;
        private double _accBal;
        public static int _headCountSA = 0;
        public SavingsAccount(string name, int accNo) : this(name, accNo, 500.75)
        { }

        public SavingsAccount(string name, int accNo, double accBal)
        {
            _name = name;
            _accNo = accNo;
            _accBal = accBal;
            _headCountSA += 1;
        }

        public string SAHolderName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = "abc";
            }
        }

        public int SAHolderAccNo
        {
            get
            {
                return _accNo;
            }
            set
            {
                if (value > 100)
                    _accNo = value;
            }
        }

        public double SAHolderBalance
        {
            get
            {
                return _accBal;
            }
            set
            {
                _accBal = 1000;
            }
        }

        public void deposit(double amount)
        {
            _accBal += amount;
        }

        public override double withdraw(double amount)
        {
            double res = _accBal - amount;
            if (res < 500)
                throw new Exception("Savings Account Holder " + _name + " has Insufficient Balance!!!");
            else
            {
                return res;
            }
        }

        public override string ToString()
        {
            return "\nName: "+SAHolderName+" Acc No: "+SAHolderAccNo+" Balance: "+SAHolderBalance;
        }
    }
}
