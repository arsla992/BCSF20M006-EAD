using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void VisitHTMLElement(HTMLElement element);
        void VisitTextElement(TextElement element);
    }
}
