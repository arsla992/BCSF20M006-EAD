using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class HTMLRenderer : IVisitor
    {
        public void VisitHTMLElement(HTMLElement element)
        {
            Console.WriteLine($"Render HTML for {element.Tag} element");
        }

        public void VisitTextElement(TextElement element)
        {
            Console.WriteLine($"Render text: {element.Text}");
        }
    }

}


