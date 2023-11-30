using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. Balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. Balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
