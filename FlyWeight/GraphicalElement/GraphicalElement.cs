using FlyWeight;
using System;
using System.Collections.Generic;


public class SharedColor : IGraphicalElement
{
    private ConsoleColor color;

    public SharedColor(ConsoleColor color)
    {
        this.color = color;
    }

    public void Draw(int x, int y)
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.Write("X");
        Console.ResetColor();
    }
}

// FlyweightFactory
public class GraphicalElementFactory
{
    private Dictionary<ConsoleColor, IGraphicalElement> sharedElements = new Dictionary<ConsoleColor, IGraphicalElement>();

    public IGraphicalElement GetSharedColor(ConsoleColor color)
    {
        if (!sharedElements.ContainsKey(color))
        {
            sharedElements[color] = new SharedColor(color);
        }
        return sharedElements[color];
    }
}

public class GraphicalElement
{
    public static void Main(string[] args)
    {
        // Using the flyweight pattern to manage shared graphical elements efficiently
        GraphicalElementFactory elementFactory = new GraphicalElementFactory();

        IGraphicalElement redElement = elementFactory.GetSharedColor(ConsoleColor.Red);
        IGraphicalElement blueElement = elementFactory.GetSharedColor(ConsoleColor.Blue);

        redElement.Draw(1, 1);
        blueElement.Draw(2, 2);
        redElement.Draw(3, 3);
    }
}

