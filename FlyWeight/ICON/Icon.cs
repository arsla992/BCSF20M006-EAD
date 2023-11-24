using FlyWeight;
using System;
using System.Collections.Generic;

public class ConcreteIcon : IIcon
{
    private string name; 

    public ConcreteIcon(string name)
    {
        this.name = name;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {name} at position ({x}, {y})");
    }
}

public class IconFactory
{
    private Dictionary<string, IIcon> icons = new Dictionary<string, IIcon>();

    public IIcon GetIcon(string name)
    {
        if (!icons.ContainsKey(name))
        {
            // If the icon with the given name doesn't exist, create a new one and add it to the dictionary
            icons[name] = new ConcreteIcon(name);
        }

        return icons[name];
    }
}

public class Icon
{
    public static void Main(string[] args)
    {
        IconFactory iconFactory = new IconFactory();

        // icons with different names
        IIcon iconA = iconFactory.GetIcon("A");
        IIcon iconB = iconFactory.GetIcon("B");
        IIcon iconA2 = iconFactory.GetIcon("A");

        // Drawing icons at different positions
        iconA.Draw(10, 20);
        iconB.Draw(30, 40);
        iconA2.Draw(50, 60);

        Console.WriteLine($"iconA and iconA2 are the same instance: {ReferenceEquals(iconA, iconA2)}");
    }
}

