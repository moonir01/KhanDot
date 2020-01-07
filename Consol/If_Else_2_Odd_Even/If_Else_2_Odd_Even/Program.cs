using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_2_Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Number 1");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A % 2 == 0)
                Console.WriteLine("This Number is Even");
            else
            {
                Console.WriteLine("This Number is ODD");
            }
            Console.ReadLine();
        }
    }
}
