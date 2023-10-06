using System;
using LocationDetails;
using VehicleDetails;

namespace DriverDetails
{
    public class Driver
    {
        public string DriverName;
        public int DriverID;
        public int DriverAge;
        public string DriverGender;
        public string DriverAddress;
        public string DriverPhNo;
        public Location MycurrLocation;
        public Vehicle MyVehicle;
        public bool DriverAvailability;
        List<int> rating;


        public int DriverRating
        {
            set
            {
                rating.Add(value);
            }
        }


        public Driver()
        {
            MycurrLocation = new Location();
            MyVehicle = new Vehicle();
            rating = new List<int>();
            DriverAvailability = true;
        }
        public void updateAvailability()
        {
            Console.Write("Your Availability (true/false): ");
            string status = Console.ReadLine();
            if (status == "true")
            {
                DriverAvailability = true;
            }
            else if (status == "false")
            {
                DriverAvailability = false;
            }
            else
            {
                Console.WriteLine("You entered incorrect choice");
            }
        }
        public float getRating()
        {
            float avg;
            int sum = 0;
            for (int i = 0; i < rating.Count; i++)
            {
                sum += rating[i];
            }
            avg = sum / rating.Count;
            return avg;
        }
        public void updateLocation()
        {
            Console.Write("Enter your Current Location: ");
            string loc;
            do
            {
                loc = Console.ReadLine();
            } while (loc == "");
            string[] locValues = loc.Split(',');
            float longitude = float.Parse(locValues[0]);
            float latitude = float.Parse(locValues[1]);
            MycurrLocation = new Location
            {
                LocationLongitude = longitude,
                LocationLatitude = latitude
            };
        }
    }
}
