using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int arraysize = int.Parse(Console.ReadLine());

            int[] array1 = new int[arraysize];
            int[] array2 = new int[arraysize];
            int Ssum1 = 0;
            int Ssum2 = 0;
            int[] Vsum = new int[arraysize];
            int[] Vproduct = new int[arraysize];
            int Sproduct = 0;

            for (int i = 0; i < arraysize; i++)
            {
                Console.Write($"Enter the element for array 01 position {i}: ");
                array1[i] = int.Parse(Console.ReadLine());

                Ssum1 = Ssum1 + array1[i];
            }
            for (int j = 0; j < arraysize; j++)
            {
                Console.Write($"Enter the element for array 02 position {j}: ");
                array2[j] = int.Parse(Console.ReadLine());

                Ssum2 = Ssum2 + array2[j];

            }
            Console.WriteLine("Scalar sum of array 01:" + Ssum1);
            Console.WriteLine("Scalar sum of array 02:" + Ssum2);
            Console.Write("Vector Sum:");
            for (int j = 0; j < arraysize; j++)
            {
                Vsum[j] = array1[j] + array2[j];
                Console.Write($"{Vsum[j]},");

            }
            Console.Write("\nVector Product:");
            for (int j = 0; j < arraysize; j++)
            {

                Vproduct[j] = array1[j] * array2[j];

                Sproduct = Sproduct + Vproduct[j];
                Console.Write($"{Vproduct[j]},");
            }
            Console.WriteLine("\nScalar Product:" + Sproduct);


            Console.ReadLine();


        }
    }
}