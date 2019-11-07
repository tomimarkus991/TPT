using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            int num3;

            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", --num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", --num);
            Console.WriteLine("num is {0}", ++num);
            Console.WriteLine("num is {0}", --num);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", num--);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);




            Console.ReadKey();
        }
    }
}
