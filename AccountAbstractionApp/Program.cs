using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountAbstractionApp.Model;

namespace AccountAbstractionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SavingsAccount s1 = new SavingsAccount("Sid", 101, 2500);
                CurrentAccount c1 = new CurrentAccount("Tom", 450, 5000);

                s1.deposit(400);
                Console.WriteLine("New balance for " + s1.SAHolderName + " is " + s1.SAHolderBalance);

                c1.deposit(1200);
                Console.WriteLine("\nNew balance for " + c1.CAHolderName + " is " + c1.CAHolderBalance);

                s1.withdraw(1000);
                Console.WriteLine("\nNew balance after withdrawal for " + s1.SAHolderName + " is " + s1.SAHolderBalance);

                c1.withdraw(3000);
                Console.WriteLine("\nNew balance after withdrawal for " + c1.CAHolderName + " is " + c1.CAHolderBalance);

                Console.WriteLine("\nTotal HeadCount for Saving Account Holders: " + SavingsAccount._headCountSA);
                Console.WriteLine("\nTotal HeadCount for Current Account Holders: " + CurrentAccount._headCountCA);

                Console.WriteLine("\nSavings Account Holder Details: ");
                Console.WriteLine(s1.ToString());

                Console.WriteLine("\nCurrent Account Holder Details: ");
                Console.WriteLine(c1.ToString());

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
