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
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is a even number!");
            }
            else
            {
                Console.WriteLine($"{num1} is an odd number!");
            }
            Console.ReadLine();

        }
    }
}
