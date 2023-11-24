using DecoratorDesignPattren;
using System;



// ConcreteComponent - SimpleCoffee
public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

// Decorator - CoffeeDecorator
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee decoratedCoffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.decoratedCoffee = coffee;
    }

    public virtual string GetDescription()
    {
        return decoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return decoratedCoffee.GetCost();
    }
}

// ConcreteDecorator - MilkDecorator
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}

// ConcreteDecorator - SugarDecorator
public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.2;
    }
}

// ConcreteDecorator - VanillaDecorator
public class VanillaDecorator : CoffeeDecorator
{
    public VanillaDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{base.GetDescription()}, Vanilla";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.7;
    }
}


public class Coffee
{
    public static void Main(string[] args)
    {
        // Ordering a simple coffee
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"Description: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Adding milk to the coffee
        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Adding sugar to the coffee
        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");

        // Adding vanilla to the coffee
        coffee = new VanillaDecorator(coffee);
        Console.WriteLine($"Description: {coffee.GetDescription()}");
        Console.WriteLine($"Cost: ${coffee.GetCost()}");
    }
}
