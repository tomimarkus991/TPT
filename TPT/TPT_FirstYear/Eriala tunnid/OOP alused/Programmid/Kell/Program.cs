using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kell
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime.Now.ToLongTimeString(); Näitab minuteid, tunde ja sekundeid
            // DateTime.Now.ToLongDateString(); Näitab kuupäeva sõnades ja numbrites
            // DateTime.Now.ToLocalTime(); Näitab praegust aega, kus ma olen
            var a = DateTime.Now.ToLocalTime(); // a on Eesti
            Console.WriteLine(a + "on aeg Eestis");

            // b on Inglismaa


            Console.WriteLine(DateTime.Now.ToUniversalTime());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.ReadKey();
        }
    }
}
