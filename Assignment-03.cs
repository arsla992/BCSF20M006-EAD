using System;
namespace Assignemnt_03
{
    //Task-01
    public class Assignment_03
    {
        // Task-01 (a)
        public void Greet(string greeting = "Hello", string name = "World")
        {
            Console.Write(greeting + ", " + name + "!" + "\n");
        }
        // Task-01 (b)
        public double CalculateArea(double length = 1.0, double width = 1.0)
        {
            return (length * width);
        }
        //Task-01 (C)
        public int AddNumbers(int params1, int params2)
        {
            return params1 + params2;
        }
        public int AddNumbers(int params1, int params2, int params3 = 0)
        {
            return (params1 + params2 + params3);
        }
    }
    // Task-01 (d)
    public class Book
    {
        string title;
        string author;
        public Book(string title, string author = "Unknown")
        {
            this.title = title;
            this.author = author;
        }
        public void PrintBook()
        {
            Console.WriteLine($"title: {title}\nAuthor: {author}");
        }
    }

    //Task-02 (a)
    public class MyList<T>
    {
        private List<T> list;


        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }
        public void Display()
        {
            foreach (var Lists in list)
            {
                Console.WriteLine(Lists);
            }
        }



    }

    public class Driver
    {
        public static void Main(string[] args)
        {

            //Task-02 (b)
            void Swap<T>(ref T x, ref T y)
            {
                T temp = x;
                x = y;
                y = temp;
            }

            //Task-02 (c)
            T Sum<T>(T[] array)
            {
                if (array == null)
                {
                    throw new ArgumentNullException(nameof(array));
                }

                if (array.Length == 0)
                {
                    throw new ArgumentException("The array must have at least one element.");
                }

                // Check if T is a numeric type using TypeCode
                TypeCode typeCode = Type.GetTypeCode(typeof(T));
                if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Double && typeCode != TypeCode.Single &&
                    typeCode != TypeCode.Int64 && typeCode != TypeCode.UInt32 && typeCode != TypeCode.UInt64)
                {
                    throw new ArgumentException("Unsupported data type. Only numeric types are allowed.");
                }

                dynamic sum = array[0]; // Initialize sum with the first element

                for (int i = 1; i < array.Length; i++)
                {
                    sum += array[i];
                }

                return sum;
            }


        //Task-02 D(i)
        Dictionary<int, string> studentDatabase = new Dictionary<int, string>
            {
                { 101, "Alice" },
                { 102, "Bob" },
                { 103, "Charlie" },
                { 104, "David" }
            };

            //Task-2 D(ii)
            void SearchStudentByID()
            {
                Console.Write("Enter the student ID to search: ");
                if (int.TryParse(Console.ReadLine(), out int studentID))
                {
                    if (studentDatabase.ContainsKey(studentID))
                    {
                        string studentName = studentDatabase[studentID];
                        Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
                    }
                    else
                    {
                        Console.WriteLine("Student ID not found in the database.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid student ID.");
                }
            }

            // Task-2 D(iii)
            void ViewStudentDatabase(Dictionary<int, string> studentDb)
            {
                Console.WriteLine("Student Database:");
                foreach (var data in studentDb)
                {
                    Console.WriteLine($"Student ID: {data.Key}, Name: {data.Value}");
                }
            }

            // Task-2 D(iv)
            void UpdateStudentName()
            {
                Console.Write("Enter the student ID to update: ");
                if (int.TryParse(Console.ReadLine(), out int studentID))
                {
                    if (studentDatabase.ContainsKey(studentID))
                    {
                        Console.Write("Enter the new name: ");
                        string newName = Console.ReadLine();
                        studentDatabase[studentID] = newName;
                        Console.WriteLine($"Student ID: {studentID} updated with the new name: {newName}");
                    }
                    else
                    {
                        Console.WriteLine("Student ID not found in the database.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid student ID.");
                }
            }

            do
            {
                Assignment_03 assign = new Assignment_03();
                int choice;
                string ch;
                Console.WriteLine("1. Optional Arguments");
                Console.WriteLine("2. Generics");

                do
                {
                    Console.Write("Enter Your Choice: ");
                    ch = Console.ReadLine();

                } while (!(Int32.TryParse(ch, out choice)));
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Task-1 (a)");
                        Console.WriteLine("2. Task-1 (b)");
                        Console.WriteLine("3. Task-1 (c)");
                        Console.WriteLine("4. Task-1 (d)");
                        do
                        {
                            Console.Write("Enter Your Choice: ");
                            ch = Console.ReadLine();

                        } while (!(Int32.TryParse(ch, out choice)));
                        switch (choice)
                        {
                            case 1:
                                //Without Passing any parameter!
                                Console.WriteLine("\nGreet Without Passing the Paramters");
                                assign.Greet();
                                // with passing the paramters!
                                Console.WriteLine("\nGreet with Parameters\n");
                                Console.Write("Enter the Greeting: ");
                                string greeting = Console.ReadLine();

                                Console.Write("Enter the name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine();
                                assign.Greet(greeting, name);
                                break;
                            case 2:
                                double length, width;
                                string len, wid;
                                do
                                {
                                    Console.Write("Enter the Lenght: ");
                                    len = Console.ReadLine();
                                } while (!(double.TryParse(len, out length)));
                                do
                                {
                                    Console.Write("Enter the Width: ");
                                    wid = Console.ReadLine();
                                } while (!(double.TryParse(wid, out width)));

                                Console.WriteLine("Area= " + assign.CalculateArea(length, width));
                                break;
                            case 3:
                                // for two parameters
                                Console.WriteLine(assign.AddNumbers(3, 2));
                                // for Optional Parametrs
                                Console.WriteLine(assign.AddNumbers(1, 2, 3));
                                break;
                            case 4:
                                Book book = new Book("C++");
                                Book book1 = new Book("C++", "Ditel");
                                //Book without Author
                                Console.WriteLine("**********Book Without Author**********");
                                book.PrintBook();
                                //Book without Author
                                Console.WriteLine("**********Book With Author**********");
                                book1.PrintBook();
                                break;
                            default:
                                Console.WriteLine("Your Choice is Wrong!");
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("1. Task-02 (a)");
                        Console.WriteLine("2. Task-02 (b)");
                        Console.WriteLine("3. Task-02 (c)");
                        Console.WriteLine("4. Task-02 (d)");
                        do
                        {
                            Console.Write("Enter Your Choice: ");
                            ch = Console.ReadLine();

                        } while (!(Int32.TryParse(ch, out choice)));

                        switch(choice)
                        {
                            case 1:
                                // I am creating a int List
                                MyList<object> list = new MyList<object>();
                                //Adding elements in list
                                list.Add(1);
                                list.Add("Arslan");
                                list.Add(3.1416);
                                list.Add('A');
                                //Display list
                                Console.WriteLine("********** All List Elemets **********");
                                list.Display();
                                //Removing Element
                                list.Remove('A');
                                list.Remove("Ali");
                                //Display List
                                Console.WriteLine("********** List Elemets After Removing **********");
                                list.Display();
                                break;
                            case 2:
                                int x = 5, y = 7;

                                Console.WriteLine($"Before Swapping (int): \n" +
                                    $"x = {x} \ny = {y}");

                                Swap<int>(ref x, ref y);

                                Console.WriteLine($"After Swapping (int): \n" +
                                    $"x = {x} \ny = {y}");

                                string a = "Arslan", b = "Hafiz";

                                Console.WriteLine($"Before Swapping (string): \n" +
                                    $"x = {a} \ny = {b}");

                                Swap<string>(ref a, ref b);

                                Console.WriteLine($"After Swapping (string): \n" +
                                    $"x = {a} \ny = {b}");

                                break;  
                            case 3:

                                try
                                {
                                    int[] array = { 1, 2, 3, 4, 5, 6 };
                                    for (int i = 0; i < array.Length; i++)
                                    {
                                        Console.Write(array[i]);
                                        if (i < array.Length - 1)
                                        {
                                            Console.Write(" + ");
                                        }
                                    }

                                    Console.WriteLine("\nSum Of Array = " + Sum<int>(array));
                                    Console.WriteLine("***** Trying for String *****");
                                    string[] array1 = { "Arslan", "Ali", "Ahmad", "Bilal" };
                                    Console.WriteLine("\nSum Of Array = " + Sum<string>(array1));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Error is " + ex.Message);

                                }


                                break;
                            case 4:
                                //Task-02 D(v)
                                while (true)
                                {

                                    Console.WriteLine("Enter your choice:");
                                    Console.WriteLine("1. View the student database");
                                    Console.WriteLine("2. Search for a student by ID");
                                    Console.WriteLine("3. Update a student's name");
                                    Console.WriteLine("4. Exit the program");

                                    if (!int.TryParse(Console.ReadLine(), out choice))
                                    {
                                        Console.WriteLine("Invalid choice!");
                                        continue;
                                    }

                                    switch (choice)
                                    {
                                        case 1:
                                            ViewStudentDatabase(studentDatabase);
                                            break;

                                        case 2:
                                            SearchStudentByID();
                                            break;

                                        case 3:
                                            UpdateStudentName();
                                            break;

                                        case 4:
                                            return;

                                        default:
                                            Console.WriteLine("Invalid choice!");
                                            break;
                                    }
                                }
                                //break;
                            default:
                                Console.WriteLine("Your Choice is Wrong!");
                                break;


                        }
 
                        break;
                    default:
                        Console.WriteLine("Your Choice is Wrong!");
                        break;
                }

            } while (true);


        }

    }
}
































































