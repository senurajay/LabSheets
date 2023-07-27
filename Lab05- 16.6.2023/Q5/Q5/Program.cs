using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int sum = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < 10; i++)
            {                
                array[i] =int.Parse(Console.ReadLine());
                sum = sum +array[i];
            }
            int max = array[0];
            int min = array[0];
            for (int j = 0; j < 10; j++)
            {
                if (array[j]> max) {
                    max = array[j];
                }
                if (array[j]< min)
                {
                    min = array[j]; 
                }
            }
            int[] arryreverse = new int[10];
            int a = 0;
            for (int l=9; l>=0; l--)
            {
                arryreverse[a] = array[l];
                a++;
            }
            Console.WriteLine($"Minimum Value:"+min);
            Console.WriteLine("Maximum Value:"+max);
            int avg = sum / 10;
            Console.WriteLine("Average:" + avg);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(arryreverse[i]);
            }

            Console.ReadLine();
        }
        
    }
}
