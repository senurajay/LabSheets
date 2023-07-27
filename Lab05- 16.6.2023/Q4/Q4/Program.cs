using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassFile objsayHello = new ClassFile();
            objsayHello.sayHello();
            /*The methods cannot be accessed as it declared as a private method .  when priate acess specifiers are used the variables anf methods declared under them can only be access within the declared class only. As a result, here the method "sayHello()" declared inside the class "ClassFile" cannot be access by "Progeam.cs".*/
        }
    }
}
