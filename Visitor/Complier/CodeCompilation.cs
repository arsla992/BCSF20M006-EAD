using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class CodeCompilation
    {
        private List<ICodeElement> codeElements = new List<ICodeElement>();

        public void AddElement(ICodeElement element)
        {
            codeElements.Add(element);
        }

        public void Accept(ICodeVisitor visitor)
        {
            foreach (var element in codeElements)
            {
                element.Accept(visitor);
            }
        }
    }
}
