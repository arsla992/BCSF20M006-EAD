using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TransactionManager
    {
        private readonly List<ICommand> transactions = new List<ICommand>();

        public void AddTransaction(ICommand transaction)
        {
            transactions.Add(transaction);
        }

        public void ExecuteTransactions()
        {
            foreach (var transaction in transactions)
            {
                transaction.Execute();
            }
        }
    }
}
