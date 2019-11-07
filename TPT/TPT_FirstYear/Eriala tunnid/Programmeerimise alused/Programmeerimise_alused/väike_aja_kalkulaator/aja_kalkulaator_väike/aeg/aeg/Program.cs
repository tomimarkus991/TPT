using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aeg
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DateTime.Now.Hour;
            var b = DateTime.Now.Minute;

            Console.WriteLine(a);
            Console.WriteLine(b);

            var c = a + b;
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
