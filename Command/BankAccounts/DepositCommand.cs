using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class DepositCommand : ICommand
    {
        private readonly BankAccount account;
        private readonly double amount;

        public DepositCommand(BankAccount account, double amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Execute() => account.Deposit(amount);

        public void Undo() => account.Withdraw(amount);
    }
}
