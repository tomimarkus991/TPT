using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutused
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(triArea(10,10));
            Console.ReadKey();
        }
        public static int triArea(int b, int h)
        {
            int area = (b * h) / 2;
            return area;
        }
    }
}
