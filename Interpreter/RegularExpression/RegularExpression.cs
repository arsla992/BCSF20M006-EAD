using InterpreterDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public class RegularExpression : IExpression
    {
        private readonly Regex regex;

        public RegularExpression(string pattern)
        {
            regex = new Regex(pattern);
        }

        public bool Interpret(string context)
        {
            return regex.IsMatch(context);
        }
    }
}
