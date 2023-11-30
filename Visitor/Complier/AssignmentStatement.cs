using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class AssignmentStatement : ICodeElement
    {
        public string Variable { get; }
        public string Value { get; }

        public AssignmentStatement(string variable, string value)
        {
            Variable = variable;
            Value = value;
        }

        public void Accept(ICodeVisitor visitor)
        {
            visitor.VisitAssignmentStatement(this);
        }
    }
}
