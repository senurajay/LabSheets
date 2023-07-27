using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetNumbers objgetnum= new GetNumbers();
            objgetnum.Cal();
            
            Summation objsummation= new Summation();
            Console.WriteLine("Sum = "+objsummation.Cal(objgetnum.num1,objgetnum.num2));

            Substraction objsubstraction= new Substraction();
            Console.WriteLine("Difference = "objsubstraction.Cal(objgetnum.num1, objgetnum.num2));

            Multiplication objmultiplication= new Multiplication();
            Console.WriteLine(objmultiplication.Cal(objgetnum.num1, objgetnum.num2));

            Division objdivision= new Division();
            Console.WriteLine(objdivision.Cal(objgetnum.num1, objgetnum.num2)); ;

            Console.ReadLine();
        }
    }
}
