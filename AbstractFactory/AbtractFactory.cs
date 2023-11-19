using System;

namespace AbstractFactory
{


    public class EconomicCarFactory : IAbstract
    {
        public ICar GetValue(int price)
        {
            if (price <= 2000)
            {
                return new EconomicCar1();
            }
            else if (price >= 2500)
            {
                return new EconomicCar2();
            }

            // Handle other cases, e.g., return a default car
            return null;
        }
    }

    public class LuxuryCarFactory : IAbstract
    {
        public ICar GetValue(int price)
        {
            if (price >= 5000 && price <= 7000)
            {
                return new LuxuryCar1();
            }
            else if (price > 7000)
            {
                return new LuxuryCar2();
            }

            // Handle other cases, e.g., return a default car
            return null;
        }
    }

    public class EconomicCar1 : ICar
    {
        public int getTopSpeed()
        {
            return 100;
        }
    }

    public class EconomicCar2 : ICar
    {
        public int getTopSpeed()
        {
            return 150;
        }
    }

    public class LuxuryCar2 : ICar
    {
        public int getTopSpeed()
        {
            return 300;
        }
    }

    public class LuxuryCar1 : ICar
    {
        public int getTopSpeed()
        {
            return 250;
        }
    }

    public class AbstractFactory
    {
        public IAbstract getFactory(string name)
        {
            if (name == "Economics")
            {
                return new EconomicCarFactory();
            }
            else if (name == "Luxury")
            {
                return new LuxuryCarFactory();
            }

            // Handle other cases, e.g., return a default factory
            return null;
        }
    }
    public class Driver
    {
        public static void Main(string[] args)
        {
            // Example usage of Abstract Factory
            AbstractFactory factory = new AbstractFactory();

            // Get EconomicCarFactory
            IAbstract economicFactory = factory.getFactory("Economics");
            ICar economicCar1 = economicFactory.GetValue(1800);
            ICar economicCar2 = economicFactory.GetValue(2600);

            Console.WriteLine("Economic Car 1 Top Speed: " + economicCar1.getTopSpeed()); // Output: Economic Car 1 Top Speed: 100
            Console.WriteLine("Economic Car 2 Top Speed: " + economicCar2.getTopSpeed()); // Output: Economic Car 2 Top Speed: 150

            // Get LuxuryCarFactory
            IAbstract luxuryFactory = factory.getFactory("Luxury");
            ICar luxuryCar1 = luxuryFactory.GetValue(6000);
            ICar luxuryCar2 = luxuryFactory.GetValue(8000);

            Console.WriteLine("Luxury Car 1 Top Speed: " + luxuryCar1.getTopSpeed()); // Output: Luxury Car 1 Top Speed: 250
            Console.WriteLine("Luxury Car 2 Top Speed: " + luxuryCar2.getTopSpeed());
        }
    }
}
