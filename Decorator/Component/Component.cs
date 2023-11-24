using DecoratorDesignPattren;
using System;



public class BasicComponent : IComponent
{
    public void Draw()
    {
        Console.WriteLine("Drawing basic component");
    }
}

public abstract class Decorator : IComponent
{
    protected IComponent component;

    public Decorator(IComponent component)
    {
        this.component = component;
    }

    public virtual void Draw()
    {
        component.Draw();
    }
}

public class BorderDecorator : Decorator
{
    public BorderDecorator(IComponent component) : base(component) { }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Adding border");
    }
}

public class ScrollbarDecorator : Decorator
{
    public ScrollbarDecorator(IComponent component) : base(component) { }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Adding scrollbar");
    }
}

public class Driver
{
    public static void Main(string[] args)
    {
        IComponent basicComponent = new BasicComponent();

        IComponent componentWithBorder = new BorderDecorator(basicComponent);
        componentWithBorder.Draw();

        IComponent componentWithScrollbar = new ScrollbarDecorator(basicComponent);
        componentWithScrollbar.Draw();

        IComponent componentWithBorderAndScrollbar = new ScrollbarDecorator(new BorderDecorator(basicComponent));
        componentWithBorderAndScrollbar.Draw();
    }
}
