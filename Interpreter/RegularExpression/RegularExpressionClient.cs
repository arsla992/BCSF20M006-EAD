using InterpreterDesignPattern;

public class RegularExpressionClient
{
    public static void Main(string[] args)
    {
        // Creating regular expressions
        IExpression expression1 = new RegularExpression("^[A-Za-z]+$");
        IExpression expression2 = new RegularExpression("^[0-9]+$");

        // Creating a composite expression using AND
        IExpression compositeExpression = new AndExpression(expression1, expression2);

        // Testing the expressions
        Console.WriteLine("Is 'Hello123' a valid expression? " + compositeExpression.Interpret("Hello123"));
        Console.WriteLine("Is '123' a valid expression? " + compositeExpression.Interpret("123"));
        Console.WriteLine("Is 'Hello' a valid expression? " + compositeExpression.Interpret("Hello"));
    }
}
