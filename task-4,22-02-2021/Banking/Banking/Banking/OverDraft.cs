using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class OverDraft : Account
    {
        public OverDraft(string name, string id, int balance) : base(name, id, balance)
        {
            Console.WriteLine("Overdraft Account created.");
        }

        new public void Withdraw(int amount)
        {
            Console.WriteLine("Withdraw Amount :"+amount);
            if (amount > balance)
            {   
                balance -= amount;
                int due = -1 * balance;

                if (due < 50000)
                {
                    Console.WriteLine("Due Amount:" + due);
                }
                else
                { Console.WriteLine("Due Amount limit 50000 Tk"); }

            }
            else
            {
                balance -= amount;
                Console.WriteLine("Account Balance :" + balance);
            }
        }
    }
}
