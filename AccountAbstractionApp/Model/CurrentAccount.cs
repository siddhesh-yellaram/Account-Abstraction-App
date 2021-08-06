using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAbstractionApp.Model
{
    class CurrentAccount:Account
    {
        private string _name;
        private int _accNo;
        private double _accBal;
        public static int _headCountCA = 0;

        public CurrentAccount(string name, int accNo) : this(name, accNo, 1200.75)
        { }

        public CurrentAccount(string name, int accNo, double accBal)
        {
            _name = name;
            _accNo = accNo;
            _accBal = accBal;
            _headCountCA += 1;
        }

        public string CAHolderName
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

        public int CAHolderAccNo
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

        public double CAHolderBalance
        {
            get
            {
                return _accBal;
            }
            set
            {
                _accBal = 2000;
            }
        }

        public void deposit(double amount)
        {
            _accBal += amount;
        }

        public override double withdraw(double amount)
        {
            double res = _accBal - amount;
            if (res < 1500)
                throw new Exception("Current Account Holder "+_name+" has Insufficient Balance!!!");
            else
            {
                return res;
            }
        }

        public override string ToString()
        {
            return "\nName: " + CAHolderName + " Acc No: " + CAHolderAccNo + " Balance: " + CAHolderBalance;
        }
    }
}
