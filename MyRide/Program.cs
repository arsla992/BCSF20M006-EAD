using System;
using DriverDetails;
using RideDetails;
using SuperAdmin;
using LocationDetails;


namespace Assignment
{
    public class MyRide
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; // for changing the color of Console text
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\t\t WELCOME TO MYRIDE");
            Console.WriteLine("-------------------------------------------------");
            string selection;
            Admin admin = new Admin();
            do
            {
                Console.WriteLine("1. Book a Ride");
                Console.WriteLine("2. Enter as Driver");
                Console.WriteLine("3. Enter as Admin");
                Console.WriteLine("4. Exit");
                Console.Write("Press 1 to 4 to select an option: ");
                selection = Console.ReadLine();
                if (selection == "1")
                {
                    Ride ride = new Ride();
                    string choice;
                    ride.assignPassenger();
                    ride.getLocations();
                    string type;
                    do
                    {
                        Console.Write("\nEnter Ride Type (car, bike, rikshaw): ");
                        type = Console.ReadLine();
                    } while (type != "car" && type != "rikshaw" && type != "bike");
                    if (ride.assignDriver(type, admin))
                    {
                        Console.WriteLine("-------------THANK YOU-------------");
                        Console.WriteLine("Price for this ride is: " + ride.calculatePrice());
                        Console.Write("Enter ‘Y’ if you want to Book the ride, enter ‘N’ if you want to cancel operation: ");
                        choice = Console.ReadLine();
                        if (choice == "Y" || choice =="y")
                        {
                            Console.WriteLine("Happy Travel....!");
                            ride.RideDriver.DriverRating = Convert.ToInt32(ride.RidePassenger.giveRating());
                        }
                        else if(choice != "N" && choice != "n")
                        {
                            Console.WriteLine("You entered incorrect choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No driver exists for this ride");
                    }
                }
                else if (selection == "2")
                {
                    Console.Write("Enter ID: ");
                    string ID;
                    do
                    {
                        ID = Console.ReadLine();
                    } while (ID == "");
                    
                    Console.Write("Enter Name: ");
                    string name;
                    do
                    {
                        name = Console.ReadLine();
                    } while (name == "");

                    List<Driver> drivers = admin.AllDrivers;
                    Driver driver = new Driver();
                    bool flag = false;
                    foreach (Driver d in drivers)
                    {
                        if (d.DriverID == Convert.ToInt32(ID) && d.DriverName == name)
                        {
                            flag = true;
                            driver = d;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("Hello " + name + "!");
                        Console.Write("\nEnter your current Location (e.g. 5,9): ");
                        string loc;
                        do
                        {
                            loc = Console.ReadLine();
                        } while (loc == "");

                        string[] locPoints = loc.Split(',');
                        Location location = new Location
                        {
                            LocationLongitude = float.Parse(locPoints[0]),
                            LocationLatitude = float.Parse(locPoints[1])
                        };
                        driver.MycurrLocation = location;
                        do
                        {
                            Console.WriteLine("1. Change Availability");
                            Console.WriteLine("2. Change Location");
                            Console.WriteLine("3. Exit as Driver");
                            string userChoice;
                            do
                            {
                                Console.Write("Enter your choice: ");
                                userChoice = Console.ReadLine();
                            } while (!(userChoice == "1" || userChoice == "2" || userChoice == "3"));
                            
                            if (userChoice == "1")
                            {
                                driver.updateAvailability();
                            }
                            else if (userChoice == "2")
                            {
                                driver.updateLocation();
                            }
                            else if (userChoice == "3")
                            {
                                break;
                            }
                        } while (true);
                    }
                    else
                    {
                        Console.WriteLine("No Driver is registeretd against this ID and Name");
                    }
                }
                else if (selection == "3")
                {
                    string userChoice;
                    do
                    {
                        Console.WriteLine("1. Add Driver");
                        Console.WriteLine("2. Remove Driver");
                        Console.WriteLine("3. Update Driver");
                        Console.WriteLine("4. Search Driver");
                        Console.WriteLine("5. Exit as Admin");
                        Console.Write("Enter your choice: ");
                        userChoice = Console.ReadLine();
                        if (userChoice == "1")
                        {
                            admin.addDriver();
                        }
                        else if (userChoice == "2")
                        {
                            admin.removeDriver();
                        }
                        else if (userChoice == "3")
                        {
                            admin.updateDriver();
                        }
                        else if (userChoice == "4")
                        {
                            admin.searchDriver();
                        }
                        else if (userChoice == "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You entered incorrect option");
                        }
                    } while (true);
                }
                else if (selection == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kindly enter correct choice");
                }
            } while (true);
        }
    }
}