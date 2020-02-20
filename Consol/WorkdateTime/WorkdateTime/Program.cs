using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkdateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myvalue = DateTime.Now;
            DateTime myBirtday = new DateTime(1991, 03, 02);
            DateTime mybirthday2 = DateTime.Parse("02/03/1991");
            Console.WriteLine(myvalue.ToString());
            Console.WriteLine(myvalue.ToShortDateString());
            Console.WriteLine(myvalue.ToShortTimeString());
            Console.WriteLine(myvalue.ToLongDateString());
            Console.WriteLine(myvalue.ToLongTimeString());
            Console.Write(myvalue.AddDays(3).ToLongDateString());
            Console.Write(myvalue.AddDays(-3).ToLongDateString());
            Console.Write(myvalue.AddHours(3).ToLongTimeString());
            Console.Write(myvalue.Month);
            Console.WriteLine("My Birthday Given Below");
            Console.WriteLine(myBirtday.ToShortDateString());
            Console.Write(mybirthday2.ToShortDateString());

            TimeSpan myAge = DateTime.Now.Subtract(myBirtday);
            Console.WriteLine("My Alive Time");
            Console.WriteLine(myAge.TotalDays);
            
            Console.ReadLine();
        }
    }
}
