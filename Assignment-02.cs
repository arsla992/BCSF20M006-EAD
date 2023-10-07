using System;
namespace Assignment
{
    public class Assignment_02
    {
        public void Task_01()
        {
            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last Name: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

        }


        public void Task_02()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            if (sentence.Length >= 5)
            {
                string lastFiveCharacters = sentence.Substring(sentence.Length - 5);
                Console.WriteLine(lastFiveCharacters);
            }
            else
            {
                Console.WriteLine("The Sentence is too Short");
            }
        }


        public void Task_03()
        {
            double temperature;
            string city;

            // Ask the user for the current temperature and city

            string temp;

            do
            {
                Console.Write("Enter the current temperature (in degrees Celsius): ");
                temp = Console.ReadLine();

            } while (!double.TryParse(temp, out temperature));

            Console.Write("Enter the name of your city: ");
            city = Console.ReadLine();


            // Display the message using string interpolation
            Console.WriteLine($"The temperature in {city} is {temperature} degrees Celsius.");
        }


        public void Task_04()
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(",");

                }


            }
        }


        public void Task_05_a()
        {
            string[] fruits = { "Apple", "Banana", "Mango", "Orange", "Grapes" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

        }


        public void Task_05_b()
        {
            string[] colors = { "Red", "Blue", "Green", "Orange", "Pink" };
            foreach (string color in colors)
            {

                Console.Write(color + ", ");

            }
        }


        public void Task_06()
        {
            int[] scores = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                scores[i] = random.Next(10, 50);
                Console.Write(scores[i]);
                if (i < scores.Length - 1)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
            // for calculating the Sum
            int sum = 0;
            int index = 0;

            do
            {
                sum += scores[index];
                index++;
            } while (index < scores.Length);
            // To Console the sum of all the scores
            Console.WriteLine("Sum of all test scores: " + sum);
        }


        public void Task_07()
        {
            int[] values = { 15, 28, 7, 42, 10, 55, 99, 23, 50 };

            int max = int.MinValue;
            int index = 0;

            while (index < values.Length)
            {
                if (values[index] > max)
                {
                    max = values[index];
                }
                index++;
            }

            Console.WriteLine("The maximum value in the array is: " + max);
        }


        public void Task_08()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;

                left++;
                right--;
            }

            Console.Write("Reversed array: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }


        public void Task_09_a()
        {
            int x = 42;

            object boxedValue = x;

            int y = (int)boxedValue;

            Console.WriteLine("Value of 'y' after unboxing: " + y);
        }


        public void Task_09_b()
        {
            double doubleValue = 3.14159;

            object boxedValue = doubleValue;

            double unboxedValue = (double)boxedValue;

            Console.WriteLine("Value of 'unboxedValue' after unboxing: " + unboxedValue);
        }


        public void Task_10_a()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

            Console.WriteLine("Original Integer | Squared Value");

            foreach (int num in numbers)
            {

                object boxedValue = num;

                //Unbox the boxed object and store it in a new integer variable.
                int unboxedValue = (int)boxedValue;

                // Calculate the square of the unboxed integer.
                int squaredValue = unboxedValue * unboxedValue;

                //Display both the original integer and its squared value
                Console.WriteLine($"{unboxedValue,-16} | {squaredValue}");
            }
        }


        public void Task_10_b()
        {
            List<object> mixedList = new List<object>();

            // Addding the valuse of Different type
            mixedList.Add(42);                      // int
            mixedList.Add(3.14159);                 // double
            mixedList.Add('A');                     // char
            mixedList.Add("Arslan Iftikhar");       // string
            mixedList.Add(true);                    // bool

            Console.WriteLine("Elements in the List:");

            foreach (object item in mixedList)
            {
                Console.WriteLine($"Element: {item}, Type: {item.GetType()}");
            }
        }


        public void Task_11_a()
        {
            dynamic MyVariable = 42;
            // showing an integer value
            Console.WriteLine(MyVariable);
            MyVariable = "Hello, Dynamic!";
            // Showing a String
            Console.WriteLine(MyVariable);
        }


        public void Task_11_b()
        {
            dynamic myVariable2 = 42; // Assigning Integer Value
            Console.WriteLine("Type of Varible is : " + myVariable2.GetType());

            myVariable2 = 3.1416; // Assigning double Value
            Console.WriteLine("Type of Varible is : " + myVariable2.GetType());

            myVariable2 = DateTime.Now; // Assigning DateTime
            Console.WriteLine("Type of Varible is : " + myVariable2.GetType());

            myVariable2 = "Hello, I am the Arslan"; // Assigning string Value
            Console.WriteLine("Type of Varible is : " + myVariable2.GetType());
        }

    }
    public class Driver
    {
        static void Main(string[] args)
        {
            Assignment_02 Assign = new Assignment_02();

            Console.WriteLine("1. Task-01 ");
            Console.WriteLine("2. Task-02 ");
            Console.WriteLine("3. Task-03 ");
            Console.WriteLine("4. Task-04 ");
            Console.WriteLine("5. Task-05 (a) ");
            Console.WriteLine("6. Task-05 (b) ");
            Console.WriteLine("7. Task-06 ");
            Console.WriteLine("8. Task-07 ");
            Console.WriteLine("9. Task-08 ");
            Console.WriteLine("10.Task-09 (a) ");
            Console.WriteLine("11.Task-09 (b) ");
            Console.WriteLine("12.Task-10 (a) ");
            Console.WriteLine("13.Task-10 (b) ");
            Console.WriteLine("14.Task-11 (a) ");
            Console.WriteLine("15.Task-11 (b) ");
            int Choice;
            char choice;
            do
            {

                string ch;
                do
                {
                    Console.Write("Enter Your Choice: ");
                    ch = Console.ReadLine();

                } while (!Int32.TryParse(ch, out Choice));

                switch (Choice)
                {
                    case 1:
                        Assign.Task_01();
                        break;
                    case 2:
                        Assign.Task_02();
                        break;
                    case 3:
                        Assign.Task_03();
                        break;
                    case 4:
                        Assign.Task_04();
                        break;
                    case 5:
                        Assign.Task_05_a();
                        break;
                    case 6:
                        Assign.Task_05_b();
                        break;
                    case 7:
                        Assign.Task_06();
                        break;
                    case 8:
                        Assign.Task_07();
                        break;
                    case 9:
                        Assign.Task_08();
                        break;
                    case 10:
                        Assign.Task_09_a();
                        break;
                    case 11:
                        Assign.Task_09_b();

                        break;


                    case 12:
                        Assign.Task_10_a();

                        break;

                    case 13:
                        Assign.Task_10_b();

                        break;


                    case 14:
                        Assign.Task_11_a();

                        break;


                    case 15:
                        Assign.Task_11_b();
                        break;
                    default:
                        Console.WriteLine("Your Choice is not Correct!");
                        break;
                }
                Console.WriteLine();
                Console.Write("do you want to Run Again(Y/N): ");
                string choic = Console.ReadLine();
                char.TryParse(choic, out choice);



            } while (choice == 'Y' || choice == 'y');
            if(choice =='N' || choice=='n')
            {
               Console.WriteLine("Thanks for using!");
            }
            else if((choice!='N' || choice != 'n') && (choice!='Y' || choice!='n'))
            {
                Console.WriteLine("Your Choice is wrong!");
            }
        }
    }


}

