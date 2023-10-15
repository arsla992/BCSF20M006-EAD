using System;
using System.Collections.Generic;

namespace Assignment_04
{
    public class DMAS
    {
        public static void StringSolve(string equation)
        {
            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < equation.Length; i++)
            {
                char ch = equation[i];

                if (char.IsDigit(ch) || ch == '.')
                {
                    // Read the entire number and push it onto the numbers stack
                    string numStr = ch.ToString();
                    while (i + 1 < equation.Length && (char.IsDigit(equation[i + 1]) || equation[i + 1] == '.'))
                    {
                        numStr += equation[i + 1];
                        i++;
                    }

                    if (double.TryParse(numStr, out double num))
                    {
                        numbers.Push(num);
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid number format.");
                        return;
                    }
                }
                else if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                {
                    while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(ch))
                    {
                        ApplyOperator(numbers, operators.Pop());
                    }
                    operators.Push(ch);
                }
            }

            while (operators.Count > 0)
            {
                ApplyOperator(numbers, operators.Pop());
            }

            if (numbers.Count == 1)
            {
                Console.WriteLine(numbers.Pop());
            }
            else
            {
                Console.WriteLine("Error: Equation is not correct!");
            }
        }

        static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '/':
                    return 4;
                case '*':
                    return 3;
                case '+':
                    return 2;
                case '-':
                    return 1;
                default:
                    return 0; // Default precedence for other characters
            }
        }

        static void ApplyOperator(Stack<double> numbers, char op)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("Error: Not enough operands for operator " + op);
                Environment.Exit(1);
            }

            double b = numbers.Pop();
            double a = numbers.Pop();

            switch (op)
            {
                case '+':
                    numbers.Push(a + b);
                    break;
                case '-':
                    numbers.Push(a - b);
                    break;
                case '*':
                    numbers.Push(a * b);
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Error: Division by zero!");
                        Environment.Exit(1);
                    }
                    numbers.Push(a / b);
                    break;
            }
        }

        public static void Main(string[] args)
        {
            StringSolve("2/2*5-4");
            StringSolve("2+/2*5"); // invalid Equation!
        }
    }
}
