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
            Console.WriteLine("Enter the value in kilometers:");
            int km = int.Parse(Console.ReadLine());

            ConvertValues objconvertvalues = new ConvertValues();
            objconvertvalues.kilometerTOmeter(km);

            Console.WriteLine($"{objconvertvalues.meter} m");
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
