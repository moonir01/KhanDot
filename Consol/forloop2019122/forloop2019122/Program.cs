using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop2019122
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This is Mr. Khan");
            Console.WriteLine((int)products.Lemon);
            foreach (String item in Enum.GetNames(typeof(products)))
                Console.WriteLine(item);
            //নিচের লাইনটি ইফ এলস্ চেকের মাধ্যমে
            Console.WriteLine(" Below the line for if else check ");
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                    Console.WriteLine("7 is Found");

            }

            Console.ReadLine();
        }
        enum products
        {
            Apple,
            Orange,
            Multa,
            Onion,
            Lemon,
            Crusifurious,
            Green_Chilly,
            Qukamber,
            Ginger,


        }
    }
}
