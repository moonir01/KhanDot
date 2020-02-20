using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            string myString = "What is new Line\n this is new line";
            string myString2 = "Go to your c:\\drive";
            string myString3 = @"Go to Your d:\Drive";
            string myString4 = string.Format("{1}={0}", "First", "Second");
            string myString5 = string.Format("{0:C}", 123.45);////show Currency
            string mystring6 = string.Format("{0:N}", 10245424);//Milleion
            string mystring7 = string.Format("Percentage:{0:P}", .123);
            string myString8 = string.Format("Phone Number:{0:(###) ###-####}", 1234567890145);
            string myString9 = "That Summer We took thress across the board";
            string myString11=""
            ////myString9 = myString9.Substring(6,14);
            //// myString9 = myString9.ToUpper();
            ////myString9 = myString9.Replace(" ", "--");
            //// myString9 = myString9.Remove(6, 14);
            /*
            for (int i = 0; i < 100; i++)
            {
                myString9 += "--" + i.ToString();
            }
            */
           

            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(mystring6);
            Console.WriteLine(mystring7);
            Console.WriteLine(myString8);
            Console.WriteLine(myString9);
            
            

            Console.ReadLine();
        }
    }
}
