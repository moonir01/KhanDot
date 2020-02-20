using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleClassgetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Bangla Brand";
            myCar.Model="New Hero";
            myCar.Year = 1991;
            myCar.Color = "Gray";

            Console.WriteLine("{0}{1}{2}{3}", myCar.Model, myCar.Model, myCar.Year, myCar.Color);
            Console.ReadLine();
       

                
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

    }


}
