using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop_For_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 10; i++)
            {
                // Console.WriteLine(i);
                if (i == 7)
                {
                  
                    break;

                }
            }
            for (int myvalue = 0; myvalue < 500; myvalue++)
            {
                Console.WriteLine(myvalue);
            }
            Console.ReadLine();
        }

        private static void NewMethod()
        {
            Console.WriteLine("Oh Svenen Found");
        }
    }
}
