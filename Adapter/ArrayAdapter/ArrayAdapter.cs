using System;

// ArrayAdapter is using the List
public class ArrayAdapter<T>
{
    private readonly List<T> data;

    public ArrayAdapter(List<T> data)
    {
        this.data = data;
    }

    public void DisplayItems()
    {
        // Display each item in the console
        foreach (var item in data)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

class Driver
{
    static void Main()
    {
        List<string> Fruits = new List<string> { "Apple", "Banana", "Grapes" };

        ArrayAdapter<string> arrayAdapter = new ArrayAdapter<string>(Fruits);

        arrayAdapter.DisplayItems();
    }
}
