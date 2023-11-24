using System;
using System.Collections.Generic;
                                            // Document Object Model
// Component interface
public abstract class DOMElement
{
    protected string tagName;
    protected List<DOMElement> children = new List<DOMElement>();

    public DOMElement(string tagName)
    {
        this.tagName = tagName;
    }

    public void AddChild(DOMElement element)
    {
        children.Add(element);
    }

    public abstract void Render();
}

// Leaf component
public class DOMLeaf : DOMElement
{
    public DOMLeaf(string tagName) : base(tagName) { }

    public override void Render()
    {
        Console.WriteLine($"Render {tagName}");
    }
}

public class DOMComposite : DOMElement
{
    public DOMComposite(string tagName) : base(tagName) { }

    public override void Render()
    {
        Console.WriteLine($"Render {tagName}");
        foreach (var child in children)
        {
            child.Render();
        }
    }
}
public class Driver
{
    public static void Main(string[] args)
    {
        // Creating leaf elements
        DOMElement paragraph1 = new DOMLeaf("p");
        DOMElement paragraph2 = new DOMLeaf("p");

        // Creating composite element (div) and adding leaf elements
        DOMElement div = new DOMComposite("div");
        div.AddChild(paragraph1);
        div.AddChild(paragraph2);

        // Rendering the composite element (div)
        div.Render();
    }
}

