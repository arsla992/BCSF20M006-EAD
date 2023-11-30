using CommandDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class WithdrawCommand : ICommand
    {
        private readonly BankAccount account;
        private readonly double amount;

        public WithdrawCommand(BankAccount account, double amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Execute() => account.Withdraw(amount);

        public void Undo() => account.Deposit(amount);
    }

}
