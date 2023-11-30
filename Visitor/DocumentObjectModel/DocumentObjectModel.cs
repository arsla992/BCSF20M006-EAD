

// Concrete Elements
using VisitorDesignPattern;

public class DocumentObjectModel
{
    public static void Main(string[] args)
    {
        // Creating a DOM and adding elements
        DOM dom = new DOM();
        dom.AddElement(new HTMLElement("div"));
        dom.AddElement(new TextElement("Hello, Visitor Pattern!"));

        // Creating a visitor (HTML renderer) and traversing the DOM
        HTMLRenderer htmlRenderer = new HTMLRenderer();
        dom.Accept(htmlRenderer);
    }
}
