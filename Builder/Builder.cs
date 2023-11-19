using Builder;
using System;

public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Computer with {CPU} CPU, {RAM} RAM, and {Storage} storage.");
    }
}


// Concrete builder
class StandardComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU()
    {
        computer.CPU = "Standard CPU";
    }

    public void SetRAM()
    {
        computer.RAM = "8GB RAM";
    }

    public void SetStorage()
    {
        computer.Storage = "256GB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

// Director
class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetRAM();
        builder.SetStorage();
    }
}


// Example 2: Building a Meal


// Product
public class Meal
{
    public List<string> Items { get; } = new List<string>();

    public void Display()
    {
        Console.WriteLine("Meal contains:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}

// Concrete builder
class HealthyMealBuilder : IMealBuilder
{
    private Meal meal = new Meal();

    public void BuildMainCourse()
    {
        meal.Items.Add("Grilled Chicken Salad");
    }

    public void BuildSide()
    {
        meal.Items.Add("Steamed Vegetables");
    }

    public void BuildDrink()
    {
        meal.Items.Add("Water");
    }

    public Meal GetMeal()
    {
        return meal;
    }
}

// Director
class MealDirector
{
    public void Construct(IMealBuilder builder)
    {
        builder.BuildMainCourse();
        builder.BuildSide();
        builder.BuildDrink();
    }
}



public class Driver
{
    static void Main(string[] args)
    {
        // Client code using the Builder pattern for building a computer
        IComputerBuilder builder = new StandardComputerBuilder();
        ComputerDirector director = new ComputerDirector();

        director.Construct(builder);
        Computer computer = builder.GetComputer();

        computer.DisplayInfo();

        Console.ReadLine();

        //Example2 : Meal Driver

        // Client code using the Builder pattern for building a meal
        IMealBuilder builder2 = new HealthyMealBuilder();
        MealDirector director2 = new MealDirector();

        director.Construct(builder);
        Meal meal = builder2.GetMeal();

        meal.Display();

        Console.ReadLine();
    }
}
