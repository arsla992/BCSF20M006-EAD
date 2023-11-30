using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern;

namespace VisitorDesignPattern
{
    public class CodeGenerator : ICodeVisitor
    {
        public void VisitVariableDeclaration(VariableDeclaration element)
        {
            Console.WriteLine($"Generate code for variable declaration: {element.Type} {element.Name};");
        }

        public void VisitAssignmentStatement(AssignmentStatement element)
        {
            Console.WriteLine($"Generate code for assignment: {element.Variable} = {element.Value};");
        }
    }
}
