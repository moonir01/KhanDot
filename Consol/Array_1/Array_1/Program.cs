using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is for Array");
            /*int[] number = new int[5];
            number[0] = 4;
            number[1] = 8;
            number[2] = 15;
            number[3] = 16;
            number[4] = 23;
            Console.WriteLine(number[1]);
            Console.WriteLine(number.Length);
            Console.ReadLine();
            */
         
            String[] names = new String[]
            {
                "Monir","Abir","Rahim","Kalam","Baker","Rashedul","Shakail","Sabribna"
            };

            ////for লুপের মাধ্যামে প্রিন্ট করা.
            /*
           for (int i = 0; i < names.Length; i++)
           {
               Console.WriteLine(names[i]);
           }
           Console.ReadLine();
           */
            ////foreach লুপের মাধ্যামে প্রিন্ট করা
            /*
             foreach (string nam in names)
             {
                 Console.WriteLine(nam);

             }
             Console.ReadLine();
             */
            /// Array এর মাধ্যামে টেক্সট উল্টো করে লিখা
            string khan = "Hello this is mr khan here what about your" +
                " what you need for this how  many changes";
            char[] charArray = khan.ToCharArray();
            Array.Reverse(charArray);
            foreach (char item in charArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
