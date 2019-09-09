using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            int nr1 = 12;
            int nr2 = 3;

            Console.WriteLine("Mis on " + nr1 + " jagada " + nr2 + " vastuseks? ");

            int vastus = Convert.ToInt32(Console.ReadLine());
            if (vastus == nr1 / nr2 ) {
                Console.Write("Õige vastus!");
            } else {
                Console.WriteLine("Vale vastus! Proovi uuesti.");
            }
            Console.ReadKey();
            goto Start;
        }
    }
}
