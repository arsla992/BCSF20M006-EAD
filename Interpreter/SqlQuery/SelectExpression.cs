using InterpreterDesignPattern;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public class SelectExpression : ISqlExpression
    {
        private readonly ISqlExpression tableExpression;

        public SelectExpression(ISqlExpression tableExpression)
        {
            this.tableExpression = tableExpression;
        }

        public void Interpret(SqlCommand command)
        {
            // Assume the interpretation involves interacting with a database
            Console.WriteLine("Executing SELECT query:");
            tableExpression.Interpret(command);
            // Additional SELECT query logic would be here
        }
    }
}
