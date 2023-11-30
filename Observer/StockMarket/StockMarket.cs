using ObserverDesignPattern;

public class StockMarket
{
    public static void Main(string[] args)
    {
        // Creating a stock and investors
        Stock appleStock = new Stock("AAPL", 150.0);
        Investor investor1 = new Investor("Investor 1");
        Investor investor2 = new Investor("Investor 2");

        // Attaching investors to the stock
        appleStock.Attach(investor1);
        appleStock.Attach(investor2);

        // Changing stock price - investors will be notified
        appleStock.Price = 155.0;
        appleStock.Price = 160.0;
    }
}
