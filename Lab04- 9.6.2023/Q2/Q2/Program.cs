using System;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            float radius = float.Parse(Console.ReadLine());

            FindValues objfindValues = new FindValues();
            objfindValues.findArea(radius);
            objfindValues.findCircumference(radius);

            Console.WriteLine($"Area of the circle = {objfindValues.area}");
            Console.WriteLine($"Circumference of the circle = {objfindValues.circum}");
            Console.ReadLine();
        }
    }
}
