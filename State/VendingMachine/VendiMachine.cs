using StateDesignPattern;

public class VendiMachine
{
    public static void Main(string[] args)
    {
        // Creating a vending machine
        VendingMachine vendingMachine = new VendingMachine();

        // Performing actions in different states
        vendingMachine.InsertMoney(10);
        vendingMachine.SelectProduct("Chips");
        vendingMachine.DispenseProduct();

        // Changing the state
        vendingMachine.SetState(new SoldOutState());

        // Performing actions in the new state
        vendingMachine.InsertMoney(5);
        vendingMachine.SelectProduct("Soda");
        vendingMachine.DispenseProduct();
    }
}
