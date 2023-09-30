using System;
using LocationDetails;
using DriverDetails;
using PassengerDetails;
using SuperAdmin;
using VehicleDetails;

namespace RideDetails
{
    public class Ride
    {
        Location startLocation;
        Location endLocation;
        public int RidePrice { get; set; }
        Driver driver;
        Passenger passenger;
        public Location MyStartLocation
        {
            get
            {
                return startLocation;
            }
            set
            {
                startLocation = value;
            }
        }
        public Location MyEndLocation
        {
            get
            {
                return endLocation;
            }
            set
            {
                endLocation = value;
            }
        }

        public Driver RideDriver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        public Passenger RidePassenger
        {
            get
            {
                return passenger;
            }
            set
            {
                passenger = value;
            }
        }
        public Ride()
        {
            startLocation = new Location();
            endLocation = new Location();
            driver = new Driver();
        }
        public void assignPassenger()
        {
            Console.Write("Enter your Name: ");
            string name;
            do
            {
                name = Console.ReadLine();
            } while (name == "");

            Console.Write("Enter your Phone No: ");
            string phNo;
            do
            {
                phNo = Console.ReadLine();
            } while (phNo == "");

            passenger = new Passenger
            {
                PassengerName = name,
                PassengerPhoneNo = phNo
            };
        }
        public bool assignDriver(string RideType, Admin admin)
        {
            List<Driver> AvailableDrivers = new List<Driver>();
            List<Driver> drivers = admin.AllDrivers;

            foreach (Driver driver in drivers)
            {
                if (driver.DriverAvailability == true && driver.MyVehicle.VehicleType == RideType)
                {
                    AvailableDrivers.Add(driver);
                }
            }


            List<double> distances = new List<double>();
            //Following loop will find the distance of passenger with each available driver
            foreach (Driver driver in AvailableDrivers)
            {
                Location Driverloc = driver.MycurrLocation;
                double LongitudeDiff = Math.Pow(Driverloc.LocationLongitude - startLocation.LocationLongitude, 2);
                double LatitudeDiff = Math.Pow(Driverloc.LocationLatitude - startLocation.LocationLatitude, 2);
                double distance = Math.Sqrt(LongitudeDiff + LatitudeDiff);
                distances.Add(distance);
            }
            //Now, we have to find the shortest distance driver from start location
            int ShortDisIndex = 0;
            for (int i = 1; i < distances.Count; i++)
            {
                if (distances[i] < distances[ShortDisIndex])
                {
                    ShortDisIndex = i;
                }
            }
            //Now, ShortDisIndex contains the index of the driver which has shortest distance from start location
            if (AvailableDrivers.Count > 0)
            {
                driver = AvailableDrivers[ShortDisIndex];
                return true;
            }
            else
            {
                return false;
            }
        }
        public void getLocations()
        {
            //Setting Start Location
            Console.Write("Enter Start Location: ");
            string strtLoc;
            do
            {
                strtLoc = Console.ReadLine();
            } while (strtLoc == "");

            string[] StartLocPoints = strtLoc.Split(',');
            startLocation.LocationLongitude = float.Parse(StartLocPoints[0]);
            startLocation.LocationLatitude = float.Parse(StartLocPoints[1]);

            //Setting End Location
            Console.Write("Enter End Location: ");
            string endLoc;
            do
            {
                endLoc = Console.ReadLine();
            } while (endLoc == "");

            string[] EndLocPoints = endLoc.Split(',');
            endLocation.LocationLongitude = float.Parse(EndLocPoints[0]);
            endLocation.LocationLatitude = float.Parse(EndLocPoints[1]);
        }
        public int calculatePrice()
        {
            double LongitudeDiff = Math.Pow(endLocation.LocationLongitude - startLocation.LocationLongitude, 2);
            double LatitudeDiff = Math.Pow(endLocation.LocationLatitude - startLocation.LocationLatitude, 2);
            double distance = Math.Sqrt(LongitudeDiff + LatitudeDiff);
            if (driver.MyVehicle.VehicleType == "bike")
            {
                double originalPrice = ((distance * 250) / 50);
                RidePrice = Convert.ToInt32(originalPrice + (originalPrice * 0.05));
            }
            else if (driver.MyVehicle.VehicleType == "car")
            {
                double originalPrice = ((distance * 250) / 15);
                RidePrice = Convert.ToInt32(originalPrice + (originalPrice * 0.2));
                
            }
            else
            {
                double originalPrice = ((distance * 250) / 35);
                RidePrice = Convert.ToInt32(originalPrice + (originalPrice * 0.1));
            }
            
            return RidePrice;
        }
    }
}
