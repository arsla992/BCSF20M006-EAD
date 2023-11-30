namespace ObserverDesignPattern
{
    class Investor : IInvestor
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"{name} received an update: {stock.Symbol} price is now {stock.Price:C}");
        }
    }
}
