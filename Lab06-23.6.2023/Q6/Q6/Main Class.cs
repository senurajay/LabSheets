using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Main_Class
    {
        public void mymethod(int x)
        {
            int[] array1 = new int[x];

            for(int i = 0; i < array1.Length;i=i+2)
            {
                Console.WriteLine($"Enter element for array position {i}");
                array1[i] = int.Parse(Console.ReadLine());

                if (i + 1 < x)
                {
                    array1[i + 1] = 0;

                }
               
             }
            for(int j = 0; j < array1.Length; j++)
            {
                Console.Write($"{array1[j]},");
            }
        }
    }
}
