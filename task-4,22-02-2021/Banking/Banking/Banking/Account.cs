using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        private string name;
        private string id;
        protected int balance;

        public Account() { Console.WriteLine("Account Created with default."); }

        public Account(string name, string id, int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }


        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("{0} is Deposited. Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Entered amount is invalid!");
            }
        }



        public void Withdraw(int amount)
        {
            Console.WriteLine("Withdraw Amount :" + amount);
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("{0} is Withdrawed. Your new Balance is {1}.", amount, balance);
            }
            else
            {
                Console.WriteLine("Entered amount is invalid!");
            }
        }


        public void Transfer(int amount, Account acc)
        {
            if (amount > 0 && amount <= balance)
            {


                Console.WriteLine("Transfer amount:" + amount);
                balance-=amount;
                Console.WriteLine("After Transfer Balance:" + this.balance);

            }
            else
                Console.WriteLine("Amount Exceeded");
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Name is: " +name);
            Console.WriteLine("ID is: " + id);
            Console.WriteLine("Balance is: " + balance);
        }

        

    }
}
