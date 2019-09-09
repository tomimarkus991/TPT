using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.Write("Palun sisestage parool: ");
            string parool = Console.ReadLine();
            if (parool == "1234")
            {
                Console.WriteLine("Tere tulemast panka!");
                Console.ReadLine();
            }
            else
            { 
                Console.WriteLine("Vale parool. Proovige uuesti.");
                Console.ReadLine();
             }
                goto Start;

        }
    }
}
