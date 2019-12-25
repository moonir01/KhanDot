using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This Program for test if else statment");
            //Console.WriteLine("Please Choise 1, and 2 or 3");
            //string userValue = Console.ReadLine();
            ///*মাল্টিপল কন্ডিশন চেক করার জন্য  একাদিক  If Else  লিখতে হয়*/
            ///* কন্ডিশনের মাধ্যমে চেক করে মেসেজের মধ্যে রাখা হয়েছে*/
            //string message = "";
            //if (userValue == "1")
            //     message="Your Press 1 and own a car";
            //else if (userValue == "2")
            //     message = "Your Press 2 and own Smartphone";         
            //else if (userValue == "3")
            //     message = "You Press 3 and won a BMW";
            //else
            //{
            //    message = userValue+"We Are Sorry";
            //}
            //Console.WriteLine(message);
            //Console.ReadLine();

            /*সিঙ্গাল কন্ডিশস চেক করার জন্য এটি ব্যাবহার করা হয়েছে*/

            Console.WriteLine("This Program for test if else statment");
            Console.WriteLine("Please Choise 1, and 2 or 3");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "Your Wind" : "Your are losser";
            Console.WriteLine(message);
            Console.WriteLine(".");
            Console.WriteLine("sure {0}", message);
            Console.ReadLine();

        }
    }
}
