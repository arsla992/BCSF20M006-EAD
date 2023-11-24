using Bridge;
using System;

// Abstraction
public abstract class Shape
{
    protected IRenderer renderer;

    public Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
}

public class RedRenderer : IRenderer
{
    public void Render()
    {
        Console.WriteLine("Rendering in Red");
    }
}

// Implementor - BlueRenderer
public class BlueRenderer : IRenderer
{
    public void Render()
    {
        Console.WriteLine("Rendering in Blue");
    }
}

// Refined Abstraction - Circle
public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.Write("Drawing Circle ");
        renderer.Render();
    }
}

// Refined Abstraction - Square
public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        Console.Write("Drawing Square ");
        renderer.Render();
    }
}

public class Renderer
{
    public static void Main(string[] args)
    {
        //independently change shape and rendering mechanism
        IRenderer redRenderer = new RedRenderer();
        IRenderer blueRenderer = new BlueRenderer();

        Shape redCircle = new Circle(redRenderer);
        redCircle.Draw();

        Shape blueSquare = new Square(blueRenderer);
        blueSquare.Draw();
    }
}
