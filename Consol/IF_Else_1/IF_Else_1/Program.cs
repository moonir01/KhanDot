using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Else_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Inpute Number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == num2)
                Console.WriteLine("Both Number are equal");
            else
            {
                Console.WriteLine("Both Number ar not equal \n");
            }
            Console.ReadLine();


        }
    }
}
