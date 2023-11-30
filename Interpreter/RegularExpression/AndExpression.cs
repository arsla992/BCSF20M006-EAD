using InterpreterDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public class AndExpression : IExpression
    {
        private readonly IExpression expression1;
        private readonly IExpression expression2;

        public AndExpression(IExpression expression1, IExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }

        public bool Interpret(string context)
        {
            return expression1.Interpret(context) && expression2.Interpret(context);
        }
    }
}
