using System;
using DriverDetails;
using VehicleDetails;

namespace SuperAdmin
{
    public class Admin
    {
       public List<Driver> AllDrivers;

        public Admin()
        {
            AllDrivers = new List<Driver>();
        }
        public void addDriver()
        {
            Console.Write("Enter Name: ");
            string name;
            do
            {
                name = Console.ReadLine();
            } while (name == "");

            Console.Write("Enter Age: ");
            string age;
            do
            {
                age = Console.ReadLine();
            } while (age == "");

            Console.Write("Enter Gender: ");
            string gender;
            do
            {
                gender = Console.ReadLine();
            } while (gender == "");

            Console.Write("Enter Address: ");
            string address;
            do
            {
                address = Console.ReadLine();
            } while (address == "");

            string type;
            do
            {
                Console.Write("\nEnter Vehicle Type (car, bike, rikshaw): ");
                type = Console.ReadLine();
            } while (type != "car" && type != "rikshaw" && type != "bike");

            Console.Write("Enter Vehicle Model: ");
            string model;
            do
            {
                model = Console.ReadLine();
            } while (model == "");

            Console.Write("Enter Vehicle License Plate: ");
            string license;
            do
            {
                license = Console.ReadLine();
            } while (license == "");

            Vehicle vehicle = new Vehicle
            {
                VehicleType = type,
                VehicleModel = model,
                VehicleLicensePlate = license
            };
            //Now, admin will assign unique ID to this driver
            int id = 0;
            if (AllDrivers.Count > 0)
            {
                id = AllDrivers[AllDrivers.Count - 1].DriverID + 1;
            }
            else
            {
                id = 111;
            }

            Driver driver = new Driver
            {
                DriverID = id,
                DriverName = name,
                DriverAge = Convert.ToInt32(age),
                DriverGender = gender,
                DriverAddress = address,
                MyVehicle = vehicle
            };

            AllDrivers.Add(driver);
            Console.WriteLine("The unique id of this driver is " + id);
        }
        public void removeDriver()
        {
            Console.Write("Enter driver ID: ");
            string driverID;
            do
            {
                driverID = Console.ReadLine();
            } while (driverID == "");

            Driver driverToDel = new Driver();
            bool flag = false;
            foreach (Driver driver in AllDrivers)
            {
                if (driver.DriverID == Convert.ToInt32(driverID))
                {
                    driverToDel = driver;
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine("This driver doesn't exist");
            }
            else
            {
                AllDrivers.Remove(driverToDel);
                Console.WriteLine("The driver has been removed successfully");
            }
        }

        public void updateDriver()
        {
            Console.Write("Enter driver ID: ");
            string driverID;
            do
            {
                driverID = Console.ReadLine();
            } while (driverID == "");

            bool flag = false;
            foreach (Driver driver in AllDrivers)
            {
                if (driver.DriverID == Convert.ToInt32(driverID))
                {
                    Console.WriteLine("Driver with ID " + driver.DriverID + " exists");

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    if (name != "")
                    {
                        driver.DriverName = name;
                    }

                    Console.Write("Enter Age: ");
                    string age = Console.ReadLine();
                    if (age != "")
                        driver.DriverAge = Convert.ToInt32(age);

                    Console.Write("Enter Gender: ");
                    string gender = Console.ReadLine();
                    if (gender != "")
                        driver.DriverGender = gender;

                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();
                    if (address != "")
                        driver.DriverAddress = address;

                    Console.Write("Enter Vehicle Type: ");
                    string type = Console.ReadLine();
                    if (type != "")
                        driver.MyVehicle.VehicleType = type;

                    Console.Write("Enter Vehicle Model: ");
                    string model = Console.ReadLine();
                    if (model != "")
                        driver.MyVehicle.VehicleModel = model;

                    Console.Write("Enter Vehicle License Plate: ");
                    string license = Console.ReadLine();
                    if (license != "")
                        driver.MyVehicle.VehicleLicensePlate = license;

                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("This driver doesn't exist");
            }
            else
            {
                Console.WriteLine("The driver info has been updated");
            }
        }
        public void searchDriver()
        {
            Console.Write("Enter driver ID: ");
            string driverID = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            string age = Console.ReadLine();
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Vehicle Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Vehicle Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Vehicle License Plate: ");
            string license = Console.ReadLine();

            Console.WriteLine("{0,-15} {1,-10} {2,-10} {3, -10} {4, -10} {5, -10}", "Name", "Age", "Gender", "V.Type", "V.Model", "V.License");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach (Driver driver in AllDrivers)
            {
                bool flag = false;
                if (driverID != "")
                {
                    if (driver.DriverID == Convert.ToInt32(driverID))
                        flag = true;
                    else
                        continue;
                }
                if (name != "")
                {
                    if (driver.DriverName == name)
                        flag = true;
                    else
                        continue;
                }
                if (age != "")
                {
                    if (driver.DriverAge == Convert.ToInt32(age))
                        flag = true;
                    else
                        continue;
                }
                if (gender != "")
                {
                    if (driver.DriverGender == gender)
                        flag = true;
                    else
                        continue;
                }
                if (address != "")
                {
                    if (driver.DriverAddress == address)
                        flag = true;
                    else
                        continue;
                }
                if (type != "")
                {
                    if (driver.MyVehicle.VehicleType == type)
                        flag = true;
                    else
                        continue;
                }
                if (model != "")
                {
                    if (driver.MyVehicle.VehicleModel == model)
                        flag = true;
                    else
                        continue;
                }
                if (license != "")
                {
                    if (driver.MyVehicle.VehicleLicensePlate == license)
                        flag = true;
                    else
                        continue;
                }
                if (flag)
                {
                    Console.WriteLine("{0,-15} {1,-10} {2,-10} {3, -10} {4, -10} {5, -10}", driver.DriverName, driver.DriverAge, driver.DriverGender, driver.MyVehicle.VehicleType, driver.MyVehicle.VehicleModel, driver.MyVehicle.VehicleLicensePlate);
                }
            }
        }
    }
}
