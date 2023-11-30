
using CommandDesignPattern;



public class TransationManagement
{
    public static void Main(string[] args)
    {
        // Creating a bank account and commands
        BankAccount account = new BankAccount();
        ICommand depositCommand = new DepositCommand(account, 1000);
        ICommand withdrawCommand = new WithdrawCommand(account, 500);

        // Creating a transaction manager and adding commands
        TransactionManager transactionManager = new TransactionManager();
        transactionManager.AddTransaction(depositCommand);
        transactionManager.AddTransaction(withdrawCommand);

        // Executing transactions
        transactionManager.ExecuteTransactions();
    }
}
