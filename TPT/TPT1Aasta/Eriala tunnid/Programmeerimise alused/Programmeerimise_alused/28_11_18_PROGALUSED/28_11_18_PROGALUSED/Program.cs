using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_11_18_PROGALUSED
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Random rnd = new Random();
            List<int> list = new List<int> ();
            rnd.Next(0,10);
            while (a < rnd.Next(0, 10))
            {
                a++;
                list.Add(rnd.Next(0, 10));
            }

            Console.Write(list.Count);
            Console.ReadKey();
        }
    }
}
