using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            
            Console.WriteLine("Enter a word:");
            string word=Console.ReadLine().ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            total=word.Count(x=>vowels.Contains(x));


            Console.WriteLine($"Number of vowel={total}");
            Console.ReadLine();
        }
    }
}
