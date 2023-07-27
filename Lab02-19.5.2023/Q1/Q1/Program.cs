using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            float num1=float.Parse(Console.ReadLine());
            float num2=float.Parse(Console.ReadLine());

            Console.WriteLine("Sum=" + (num1 + num2));
            Console.ReadLine();
        }
    }
}
