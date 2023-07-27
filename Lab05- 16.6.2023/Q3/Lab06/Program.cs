using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        int c = 0;
        static int Main(string[] args)
        {
            CalculateValues objCalculateValues=new CalculateValues();      
            
            int num1;
            int num2;
       
            Console.WriteLine("  Enter 1 for Addition \n Enter 2 for substraction\n Enter 3 for multiplication\n Enter 4 for division");
            Console.WriteLine("Enter your choice:");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter a two number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a two number:");
            num2 = int.Parse(Console.ReadLine());
            
            switch (choice)
                {
                    case 1:
                        objCalculateValues.Addition(num1, num2);
                    Console.WriteLine("Your Answer:" + c);
                    
                    break;
                    case 2:
                        objCalculateValues.Substraction(num1, num2);
                       Console.WriteLine("Your Answer"+c)
                    
                        
                    break;
                    case 3:
                        objCalculateValues.Multiplication(num1, num2);
                    
                    break;
                    case 4:
                        objCalculateValues.Division(num1, num2);
                    
                    break;
                    default:
                    Console.WriteLine("Program Ends!");
                        break;
                }

            Console.WriteLine();
            Console.ReadLine();

            
        }
    }
}
