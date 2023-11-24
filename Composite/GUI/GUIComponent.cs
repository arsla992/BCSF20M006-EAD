using CompositeDesignPattren;
using System;
using System.Collections.Generic;


// Leaf component
public class Button : IGUIComponent
{
    public void Render()
    {
        Console.WriteLine("Render Button");
    }
}

// Composite component
public class Panel : IGUIComponent
{
    private List<IGUIComponent> components = new List<IGUIComponent>();

    public void AddComponent(IGUIComponent component)
    {
        components.Add(component);
    }

    public void Render()
    {
        Console.WriteLine("Render Panel");
        foreach (var component in components)
        {
            component.Render();
        }
    }
}

public class Driver
{
    static void Main()
    {
        // Creating leaf components
        IGUIComponent button1 = new Button();
        IGUIComponent button2 = new Button();

        // Creating composite component (Panel) and adding leaf components
        Panel panel = new Panel(); 
        panel.AddComponent(button1);
        panel.AddComponent(button2);

        // Rendering the composite component (Panel)
        panel.Render();
    }
}
