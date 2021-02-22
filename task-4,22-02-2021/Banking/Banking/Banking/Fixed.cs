using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Fixed :Account
    {
       protected int year = 10;
       protected int accold = 1;
       public Fixed(string name, string id, int balance): base(name, id, balance)
        {
            Console.WriteLine("Fixed account created.");
        }
       public void Withdraw(int amount)
       {
           Console.WriteLine("Withdraw Amount :" + amount);
           if (amount > 0 && year<=accold)
           {
               balance -= amount;
               Console.WriteLine("{0} is Withdrawed. Your new Balance is {1}.", amount, balance);
           }
           else
           {
               Console.WriteLine("Maney can be withdrawn after tunure");
           }
       }

    }
}
