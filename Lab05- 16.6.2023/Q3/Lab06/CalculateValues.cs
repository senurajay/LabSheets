using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class CalculateValues
    {    
        public int Addition(int a,int b)
        {
            int c=a+b;
            return c ;
        } 
        public int Substraction(int a,int b)
        {
            int c= a - b;
            return c;
        }
        public int Multiplication(int a, int b)
        {
             int c= a * b;
            return c;
        }
        public int Division(int a,int b)
        {
             int c = a / b;
            return c;
        }
    }
}
