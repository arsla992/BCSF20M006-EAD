using InterpreterDesignPattern;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDesignPattern
{
    public class TableExpression : ISqlExpression
    {
        private readonly string tableName;

        public TableExpression(string tableName)
        {
            this.tableName = tableName;
        }

        public void Interpret(SqlCommand command)
        {
            // Assume the interpretation involves interacting with a database
            Console.WriteLine($"Executing query for table: {tableName}");
            // Command execution logic would be here
        }
    }
}
