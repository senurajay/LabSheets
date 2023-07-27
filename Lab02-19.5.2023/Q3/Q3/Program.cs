using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            float radius=float.Parse(Console.ReadLine());

            Console.WriteLine($"Area of the circle = {(radius * radius * Math.PI)}\nCircumference of the circle = {(2 * Math.PI * radius)}");
            Console.ReadLine();
        }
    }
}
