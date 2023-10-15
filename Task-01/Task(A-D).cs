using System;
namespace Assignment_04
{
    public class A_D
    {
        public void stringSolve(string equation)
        {


            char operat;
            string ops;

            do
            {
                Console.Write("Enter the Operator( + , - , * , / ): ");
                ops = Console.ReadLine();
            } while (!(char.TryParse(ops, out operat)));

            //a.Addition
            if (operat == '+')
            {
                if (equation.StartsWith('+') || equation.EndsWith('+'))
                {
                    Console.WriteLine("Error Equation is not Correct!");
                    return;
                }

                string[] oprahands = equation.Split('+');
                double[] op = new double[oprahands.Length];
                double result = 0;
                for (int i = 0; i < oprahands.Length; i++)
                {
                    double.TryParse(oprahands[i], out op[i]);
                    result += op[i];
                }
                Console.WriteLine(Convert.ToString(result));
            }
            //b.Subtraction
            else if (operat == '-')
            {
                if (equation.StartsWith('-') || equation.EndsWith('-'))
                {
                    Console.WriteLine("Error Equation is not Correct!");
                    return;
                }

                string[] oprahands = equation.Split('-');
                double[] op = new double[oprahands.Length];
                double result = 0;
                for (int i = 0; i < oprahands.Length; i++)
                {
                    double.TryParse(oprahands[i], out op[i]);
                    result -= op[i];
                }
                Console.WriteLine(Convert.ToString(result));
            }
            //c.Multiplication
            else if (operat == '*')
            {
                if (equation.StartsWith('*') || equation.EndsWith('*'))
                {
                    Console.WriteLine("Error Equation is not Correct!");
                    return;
                }

                string[] oprahands = equation.Split('*');
                double[] op = new double[oprahands.Length];
                double result = 0;
                for (int i = 0; i < oprahands.Length; i++)
                {
                    double.TryParse(oprahands[i], out op[i]);
                    result *= op[i];
                }
                Console.WriteLine(Convert.ToString(result));

            }
            //d. Division
            else if (operat == '/')
            {

                if (equation.StartsWith('/') || equation.EndsWith('/'))
                {
                    Console.WriteLine("Error: Equation is not Correct!");
                    return;
                }

                string[] oprahands = equation.Split('/');
                double result = 0;

                if (oprahands.Length > 0)
                {
                    if (double.TryParse(oprahands[0], out result))
                    {
                        for (int i = 1; i < oprahands.Length; i++)
                        {
                            double operand;

                            if (double.TryParse(oprahands[i], out operand))
                            {
                                if (operand != 0) // Check for division by zero
                                {
                                    result /= operand;
                                }
                                else
                                {
                                    Console.WriteLine("Error: Division by zero!");
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error: Invalid operand in the equation!");
                                return;
                            }
                        }

                        Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid first operand in the equation!");
                    }
                }
                else
                {
                    Console.WriteLine("Error: No operands in the equation!");
                }
            }


        }
        public static void Main(string[] args)
        {
            A_D a_D = new A_D();
            a_D.stringSolve("2+6");
            a_D.stringSolve("10-5");
            a_D.stringSolve("3*5");
            a_D.stringSolve("6/3");
            a_D.stringSolve("6 / 0"); // Generate Invalid Output

        }

    }
}