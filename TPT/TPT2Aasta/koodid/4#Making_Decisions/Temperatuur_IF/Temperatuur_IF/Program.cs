using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatuur_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatuur();
            Console.Read();
        }
        public static void Temperatuur()
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }

            if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }

            if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

        }
    }
}
