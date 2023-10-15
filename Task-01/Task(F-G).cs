using System;
namespace Assignment_04
{
    public class EquationSolver
    {
        public static string SolveEquation(string equation)
        {
            if (!IsValidEquation(equation))
                return "Invalid equation";

            Stack<char> operators = new Stack<char>();
            Stack<int> operands = new Stack<int>();
            bool lastWasOperator = true; // Initialize to true to catch the first operator

            for (int i = 0; i < equation.Length; i++)
            {
                char ch = equation[i];

                if (char.IsDigit(ch))
                {
                    int num = ch - '0';
                    while (i + 1 < equation.Length && char.IsDigit(equation[i + 1]))
                    {
                        num = num * 10 + (equation[i + 1] - '0');
                        i++;
                    }
                    operands.Push(num);
                    lastWasOperator = false; // A digit was found
                }
                else if (ch == '(')
                {
                    operators.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        Evaluate(operators, operands);
                    }
                    if (operators.Count > 0 && operators.Peek() == '(')
                    {
                        operators.Pop(); // Pop the opening bracket
                    }
                    else
                    {
                        return "Invalid equation";
                    }
                }
                else if (IsOperator(ch))
                {
                    if (!lastWasOperator)
                    {
                        while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(ch))
                        {
                            Evaluate(operators, operands);
                        }
                        operators.Push(ch);
                    }
                    else
                    {
                        return "Invalid equation";
                    }
                    lastWasOperator = true; // An operator was found
                }
            }

            while (operators.Count > 0)
            {
                Evaluate(operators, operands);
            }

            if (operands.Count == 1 && !lastWasOperator)
                return operands.Pop().ToString();
            else
                return "Invalid equation";
        }
        // Checking the Equation is Valid or not
        private static bool IsValidEquation(string equation)
        {
            int balance = 0;

            for (int i = 0; i < equation.Length; i++)
            {
                char ch = equation[i];

                if (ch == '(')
                {
                    balance++;
                }
                else if (ch == ')')
                {
                    balance--;
                    if (balance < 0)
                        return false; // Check Closing Bracketa are more than Opening Brackets.
                }
            }

            return balance == 0;
        }

        private static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/';
        }
        // Operator Precendence Table.
        private static int Precedence(char op)
        {
            if (op == '-')
                return 1;
            if (op == '+')
                return 2;

            if (op == '*')
                return 3;
            if (op == '/')
                return 4;
            return 0;
        }

        private static void Evaluate(Stack<char> operators, Stack<int> operands)
        {
            if (operators.Count == 0)
            {
                return;
            }

            char op = operators.Pop();

            if (op == '-')
            {
                if (operands.Count < 2)
                {
                    // g. Handle Invalid Equation (Sanity Check)
                    operators.Clear();
                    operands.Clear();
                    operands.Push(0); // Setting the default value
                    return;
                }
                int b = operands.Pop();
                int a = operands.Pop();
                int result = a - b;
                operands.Push(result);
            }
            else
            {
                if (operands.Count < 2)
                {
                    // g.Handle Invalid Equation(Sanity Check)
                    operators.Clear();
                    operands.Clear();
                    operands.Push(0); //Set a default value
                    return;
                }
                int b = operands.Pop();
                int a = operands.Pop();
                int result = 0;

                switch (op)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        if (b != 0)
                        {
                            result = a / b;
                        }
                        else
                        {
                            // Handle division by zero gracefully
                            operators.Clear();
                            operands.Clear();
                            operands.Push(0); // You can choose to set a default value here
                            return;
                        }
                        break;
                }

                operands.Push(result);
            }
        }
        public static void Main(string[] args)
        {
            string equation1 = "(1 + 1) - 3 * (44 * 5) / 20";
            Console.WriteLine(SolveEquation(equation1)); // Output: "-31"

            string equation2 = "1 + 2 + 4 + 6 + 8";
            Console.WriteLine(SolveEquation(equation2)); // Output: "21"

            string equation3 = "(1 + 1) 3 + 4 * 5";
            Console.WriteLine(SolveEquation(equation3)); // Output: "Invalid equation"

            string equation4 = "(((1 + 1) * 3) + 4 * 5";
            Console.WriteLine(SolveEquation(equation4)); // Output: "Invalid equation"

            string equation5 = "1 + 2 + 3 - - 4";
            Console.WriteLine(SolveEquation(equation5)); // Output: "Invalid equation"

            string equation6 = "1 + 2 + 3 -";
            Console.WriteLine(SolveEquation(equation6)); // Output: "Invalid equation"

        }

    }

}