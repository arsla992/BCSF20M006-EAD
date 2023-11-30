using System;
using TemplateDesignPattren;
public class Beverage
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Making Coffee:");
        Coffee coffee = new Coffee();
        coffee.PrepareBeverage();

        Console.WriteLine("\nMaking Tea:");
        Tea tea = new Tea();
        tea.PrepareBeverage();
    }
}
