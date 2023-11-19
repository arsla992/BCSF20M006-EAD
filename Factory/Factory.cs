using System;
// Factory: All Object are created and business logic at one Place
namespace FactoryDesignPattren
{
    public class Circle:IFactory
    {
        public void ComputeArea()
        {
            Console.Write("Enter the Radius of Circle: ");
            int radius=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Area Of Circle: " + 3.1416 * radius * radius);
        }

    }
    public class Rectangle:IFactory
    {
        public void ComputeArea()
        {
            Console.WriteLine("Enter the Width: ");
            int Width=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Length: ");
            int len=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Area of Rectangle: " + len * Width);
        }
    }

    // Now Combine the classes

    public class ShapeFactory
    {
        public IFactory getShape(string shape)
        {
            if(shape=="Circle")
            {
                return new Circle();
            }
            else if(shape=="Rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
    public class Driver
    {
        public static void Main(string[] args)
        {
            ShapeFactory shFac=new ShapeFactory();
            IFactory circle= shFac.getShape("Circle");
            circle.ComputeArea();

        }
    }
}