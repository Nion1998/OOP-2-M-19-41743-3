using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************");
            Account a1=new Account("Nion","1234",1000000);
            a1.ShowInfo();
            a1.Deposit(5000);
            a1.Withdraw(1000);
            a1.Transfer(300, a1);
            Console.WriteLine("******************************");
            Savings a2 = new Savings("Afrin", "2244", 5000);
            a2.ShowInfo();
            a2.Withdraw(500);
            Console.WriteLine("******************************");
            SpecialCurrent a3 = new SpecialCurrent("Mehedi", "1111", 200000);
            a2.ShowInfo();
            a3.Withdraw(19000);
            Console.WriteLine("******************************");
            Fixed a4 = new Fixed("Alo", "3333", 900000);
            a4.ShowInfo();
            a4.Withdraw(500);
            Console.WriteLine("******************************");
            OverDraft a5 = new OverDraft("Mim", "4444", 20000);
            a5.ShowInfo();
            a5.Withdraw(30000);

        }
    }
}
