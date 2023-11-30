namespace ChainOfResponsibility
{
    public class Manager : IRequestHandler
    {
        private readonly string approvalLevel;

        public Manager(string approvalLevel)
        {
            this.approvalLevel = approvalLevel;
        }

        public void HandleRequest(Request request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"{approvalLevel} approved the expense request for ${request.Amount}");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Expense request denied. No more handlers in the chain.");
            }
        }

        public IRequestHandler NextHandler { get; set; }
    }

}
