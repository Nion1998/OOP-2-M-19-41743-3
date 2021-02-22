using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class SpecialCurrent : Account
    {
        public SpecialCurrent(string name, string id, int balance)
            : base(name, id, balance)
        {
            Console.WriteLine("Special current account created.");
        }

        public void Withdraw(int amount)
        {
            Console.WriteLine("Withdraw Amount :" + amount);
            if (amount > 0 && balance >= (balance * 10) / 100)
            {
                balance -= amount;
                Console.WriteLine("{0} is Withdrawed. Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Entered amount is invalid!");
            }
        }
    }
}
