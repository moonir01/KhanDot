using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace enum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)names.Abir);
            foreach (string str in Enum.GetNames(typeof(names)))
               
                Console.WriteLine(str);
            Console.ReadLine();
        }

        enum names
        {
            Abir=5,
            Monir,
            Tanzir,
            Rahim,
            Karim,
            Jabbar,
            Mostofa
        }
        
    }
}
