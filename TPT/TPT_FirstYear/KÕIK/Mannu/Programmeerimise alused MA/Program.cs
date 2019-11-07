using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolmnurga pindala
            Console.Write("Sisesta kolmnurga alus: ");
            double kolmnurkA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisesta kolmnurga kõrgus: ");
            double kolmnurkH = Convert.ToDouble(Console.ReadLine());


            //Kolmnurga ümbermõõt
            Console.Write("Sisesta kolmnurga I külg: ");
            double kolmnurkI = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisesta kolmnurga II külg: ");
            double kolmnurkII = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sisesta kolmnurga III külg: ");
            double kolmnurkIII = Convert.ToDouble(Console.ReadLine());

            KolmnurkÜ (kolmnurkA, kolmnurkH, kolmnurkI, kolmnurkII, kolmnurkIII);


        }
        void KolmnurkÜ(double kolmnurkA, double kolmnurkH, double kolmnurkI, double kolmnurkII, double kolmnurkIII)
        {

            double Ü = kolmnurkA *kolmnurkH;
        }
    }
}
