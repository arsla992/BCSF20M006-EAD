using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class HTMLElement : IElement
    {
        public string Tag { get; }

        public HTMLElement(string tag)
        {
            Tag = tag;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitHTMLElement(this);
        }
    }
}
