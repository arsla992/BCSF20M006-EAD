using InterpreterDesignPattern;
using System;
using System.Data.SqlClient;
public class SqlQueryClient
{
    public static void Main(string[] args)
    {
        // Creating SQL expressions
        ISqlExpression tableExpression = new TableExpression("Employee");
        ISqlExpression selectExpression = new SelectExpression(tableExpression);

        // Creating a SQL command and interpreting the expressions
        using (SqlConnection connection = new SqlConnection("your_connection_string"))
        {
            connection.Open();

            using (SqlCommand command = connection.CreateCommand())
            {
                selectExpression.Interpret(command);
            }
        }
    }
}
