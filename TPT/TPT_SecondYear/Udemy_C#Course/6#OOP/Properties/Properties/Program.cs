using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 3);
            box.DisplayInfo();
            Console.WriteLine("Front surface of the box is {0}", box.FrontSurface);
            Console.ReadKey();
        }
    }
}
