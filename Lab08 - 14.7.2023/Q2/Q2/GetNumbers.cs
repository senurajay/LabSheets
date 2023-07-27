using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class GetNumbers
    {
        public int num1;
        public int num2;

        public void Cal()
        {
            Console.WriteLine("Enter two numbers:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());




        }
    }
       
}
