using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int arraysize=int.Parse(Console.ReadLine());

            Main_Class objclass = new Main_Class();
            objclass.mymethod(arraysize);

            Console.ReadLine();
        }
    }
}
