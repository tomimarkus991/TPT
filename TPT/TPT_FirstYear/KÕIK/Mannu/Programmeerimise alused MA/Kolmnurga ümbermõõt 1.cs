using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta kolmnurga I külg: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisesta kolmnurga II külg: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisesta kolmnurga III külg: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double vastus = a + b + c;

            Console.Write("Kolmnurga ümbermõõt on: " + vastus + " ühikut.");

            Console.ReadKey();
        }
    }
}
