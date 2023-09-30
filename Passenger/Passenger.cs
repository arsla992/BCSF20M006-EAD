using System;

namespace PassengerDetails
{
    public class Passenger
    {
        public string PassengerName;
        public string PassengerPhoneNo;
        public string giveRating()
        {
            string rating;
            do
            {
                Console.Write("\nGive Rating (1 to 5): ");
                rating = Console.ReadLine();
            } while (rating != "1" && rating != "2" && rating != "3" && rating != "4" && rating != "5");

            return rating;
        }
    }
}
