using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Else_Positive_Nagative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Number 1");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A <= 0)
                Console.WriteLine("This Number Nagative");
            else
            {
                Console.WriteLine("This Number is Positive");
            }
            Console.ReadLine();

        }
    }
}
