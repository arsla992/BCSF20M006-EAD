using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class DOM
    {
        private List<IElement> elements = new List<IElement>();

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
