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
            int nr1;
            int nr2;

            Console.Write("Kirjuta üks arv: ");
            nr1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kirjuta teine arv: ");
            nr2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kui jagada " + nr1 + " ja " + nr2 + " omavahel, siis on vastuseks " + nr1 / nr2 + ".");
            Console.ReadKey();

        }
    }
}
