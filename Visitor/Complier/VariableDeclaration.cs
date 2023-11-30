using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class VariableDeclaration : ICodeElement
    {
        public string Type { get; }
        public string Name { get; }

        public VariableDeclaration(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public void Accept(ICodeVisitor visitor)
        {
            visitor.VisitVariableDeclaration(this);
        }
    }
}
