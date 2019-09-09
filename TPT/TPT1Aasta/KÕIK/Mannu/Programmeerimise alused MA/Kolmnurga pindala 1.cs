using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kolmnurga alus: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kolmnurga kõrgus: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double pindala = (a * h) / 2;
            Console.WriteLine("Kolmnurga pindala on " + pindala + " ühikut.");
            Console.ReadLine();
        }
    }
}
