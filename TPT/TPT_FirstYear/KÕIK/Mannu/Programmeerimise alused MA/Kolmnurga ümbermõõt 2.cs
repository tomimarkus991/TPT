using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random kolmnurgaMõõtmed = new Random();

            double a = kolmnurgaMõõtmed.Next(1,19);
            double b = kolmnurgaMõõtmed.Next(3,17);
            double c = kolmnurgaMõõtmed.Next(5, 15);


            Console.WriteLine("Kolmnurga I külg on: " + Convert.ToDouble(a));
            Console.WriteLine("Kolmnurga II külg on: " + Convert.ToDouble(b));
            Console.WriteLine("Kolmnurga III külg on: " + Convert.ToDouble(c));
            Console.WriteLine("Leia kolmnurga ümbermõõt.");

            double vastus = a + b + c;
            double kasutajaVastus = Convert.ToDouble(Console.ReadLine());

            if (vastus == kasutajaVastus)
            {
                Console.Write("Oled osav arvutaja.");
            }
            else
            {
                Console.Write("Proovi uuesti!");
            }

            Console.ReadKey();
        }
    }
}
