using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q6
    {
       /* internal class Program
        {
            private static void Main(string[] args)
            {
                SavingsAccount account = new SavingsAccount();
                account.CalculateInterest();
            }
        }
       */
        class Account
        {
            public virtual void CalculateInterest()
            {
                Console.WriteLine("Account class calculate");
            }
        }
        class SavingsAccount : Account
        {
            public override sealed void CalculateInterest()
            {
                Console.WriteLine("savings account class ");
            }
        }
    }
}
