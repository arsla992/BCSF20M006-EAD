using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public interface ICodeVisitor
    {
        void VisitVariableDeclaration(VariableDeclaration element);
        void VisitAssignmentStatement(AssignmentStatement element);
    }
}
