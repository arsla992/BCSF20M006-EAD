using System;
using System.Collections.Generic;
using VisitorDesignPattern;
public class Compiler
{
    public static void Main(string[] args)
    {
        // Creating a code compilation and adding elements
        CodeCompilation codeCompilation = new CodeCompilation();
        codeCompilation.AddElement(new VariableDeclaration("int", "x"));
        codeCompilation.AddElement(new AssignmentStatement("x", "10"));

        // Creating a visitor (code generator) and traversing the code compilation
        CodeGenerator codeGenerator = new CodeGenerator();
        codeCompilation.Accept(codeGenerator);
    }
}
