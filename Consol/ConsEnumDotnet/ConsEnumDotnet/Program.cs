using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEnumDotnet
{
    class Program
    {
        public static object April { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine((int)Month_name.December);
            //আউটপুট দেখাবে ১১ কারান December 11 নাম্বার লাইনে আছে

            foreach (string allmonthname in Enum.GetNames(typeof(Month_name)))
                Console.WriteLine(allmonthname); //সব মাসের নাম প্রিন্ট করার জন্য লুপ ব্যবহার করা হয়েছে
                Console.ReadLine();

        }
    }

    enum Month_name
    {
        January,
        Febuary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
