using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPattern
{
    public class TextElement : IElement
    {
        public string Text { get; }

        public TextElement(string text)
        {
            Text = text;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTextElement(this);
        }
    }
}
