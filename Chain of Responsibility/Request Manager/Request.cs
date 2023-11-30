namespace ChainOfResponsibility
{
    public class Request
    {
        public double Amount { get; }

        public Request(double amount)
        {
            Amount = amount;
        }
    }
}
