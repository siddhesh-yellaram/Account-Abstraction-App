using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountAbstractionApp.Model
{
    abstract class Account
    {
        public abstract double withdraw(double amount);
    }
}
