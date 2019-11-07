using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Challenge
{
    class Program
    {
        static string enterButton = string.Empty;
        static void Main(string[] args)
        {
            Arvutamine();
            Console.ReadKey();  
        }
        public static void Arvutamine()
        {
            double õpilasteArv = 0;
            double keskmine = 0;
            double kokku = 1;
            double sisestatudPunktid;
            Console.WriteLine("Tööde keskmise arvutamine");
            Console.WriteLine("Kirjutage -1 + enter, et arvutada keskmine");
            Console.WriteLine("");
            while (enterButton == string.Empty)
            {
                Console.WriteLine("Sisestage punktide arv palun");

                string punktideSisestamine = Console.ReadLine();                
                õpilasteArv++;
                try
                {
                    sisestatudPunktid = double.Parse(punktideSisestamine);
                    kokku += sisestatudPunktid;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ainult numbreid saab sisestada");
                    õpilasteArv--;
                }
                //catch(exception)
                
                if (punktideSisestamine.Equals("-1"))
                {
                    õpilasteArv--;
                    keskmine = kokku / õpilasteArv;
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Siin on keskmine {0}", Math.Round(keskmine,3));
                    Console.WriteLine("õpilasi on kokku {0}", õpilasteArv);
                }   
            }
        }
    }
}
