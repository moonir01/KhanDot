using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int x;
             int y;
             x = 7;
             y = x + 3;
             Console.Write(y);
             Console.ReadLine();
             */
            Console.WriteLine("What is Your Name ");
            Console.WriteLine("Enter Your First Name");
            String myFristName;
            myFristName = Console.ReadLine();
            String myLastName;
            Console.WriteLine("Enter Your Second Name");
            myLastName = Console.ReadLine();
            Console.WriteLine("My Full Name " + myFristName + "  " + myLastName);
            Console.ReadLine();


        }
    }
}
