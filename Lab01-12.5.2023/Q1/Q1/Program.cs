
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
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter you batch:");
            float batch=float.Parse(Console.ReadLine());

            Console.WriteLine($"Name:{name}\nBatch:{batch}");

            Console.ReadLine();
        }
    }
}
