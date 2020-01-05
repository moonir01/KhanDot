using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cons_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi This is Reverse String Project");
            Console.WriteLine("What is your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("In What city were your born?");
            string city = Console.ReadLine();
            // ReverseString1();
            Console.Write("Results: ");

            string reversedFirstName= ReverseString(firstName);
            string reversLastName=ReverseString(lastName);
            string reverseCity= ReverseString(city);
            //////ReverseString মেথডের জন্য নিচের লাইনটি ব্যাবহার করা হয় ।
            ////Console.Write(string.Format("{0} {1} {2}",
            ////    reversedFirstName,
            ////    reversLastName,
            ////    reverseCity));
            DisplayResult(reversedFirstName, reversLastName, reverseCity);
            Console.ReadLine();
        }


        //public static void ReverseString1()
        //{
        //    string message = "Hello World";
        //    char[] messageArray = message.ToCharArray();
        //    Array.Reverse(messageArray);
        //    foreach (char item in messageArray)
        //    {
        //        Console.Write(item);////WriteLine লিখলে একটি ক্যারেক্টার এর পর এন্টার পরে নিচের লাইনে চলে যায় তাই Write ব্যাবহার করা হয়েছে,
        //    }

        //}


/*
 //// মেথডে Value পাস করা হয়েছে String Message এর মাধ্যামে
 */

        public static string ReverseString(string message)
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }
        private static void DisplayResult(
            string reversedFirstName,
            string reversLastName,
            string reverseCity)
        {
            Console.Write(string.Format("{0} {1} {2}",
             reversedFirstName,
             reversLastName,
             reverseCity));
        }
    }
}
