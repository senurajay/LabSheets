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
            Console.WriteLine("Enter a number:");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number:");
            int num2=int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum = {num1 +num2}");
            Console.ReadLine();
        }
    }
}
