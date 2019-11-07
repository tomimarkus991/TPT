using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbrid = new Random();
            Start:
            int nr1 = numbrid.Next(1,21);
            int nr2 = numbrid.Next(1,21);

            Console.WriteLine("Mis on " + nr1 + " korrutada " + nr2 + " vastuseks? ");

            int vastus = Convert.ToInt32(Console.ReadLine());
            if (vastus == nr1 * nr2)
            {
                Console.Write("Õige vastus!");
            }
            else
            {
                Console.WriteLine("Vale vastus! Proovi uuesti.");
            }
            Console.ReadKey();
            goto Start;
        }
    }
}
