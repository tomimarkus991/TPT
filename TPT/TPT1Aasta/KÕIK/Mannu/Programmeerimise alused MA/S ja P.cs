using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta kujund, mida arvutada soovid: " );
            string K = Convert.ToString(Console.ReadLine());
            if (K == "kolmnurk")
            {
                kolmnurgaS();
                kolmnurgaP();
            }
            else if (K == "ristkülik")
            {
                ristkülikuS();
                ristkülikuP();
            }
            else if (K == "ring")
            {
                ringiSP();
            }
            else
            {
                Console.WriteLine("Sellist kujundit pole.");
            }

            Console.ReadLine();
        }

        static void kolmnurgaS()
        {
            Console.WriteLine("Sisesta kolmnurga alus: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kolmnurga kõrgus: ");
            double H = Convert.ToDouble(Console.ReadLine());

            double pindala = (A * H) / 2;
            Console.WriteLine("Kolmnurga pindala on " + pindala + " ühikut.");
        }
        static void kolmnurgaP()
        {
            Console.WriteLine("Sisesta kolmnurga I külg: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kolmnurga II külg: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta kolmnurga IIi külg: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double ümbermõõt = a + b + c;
            Console.WriteLine("Kolmnurga ümbermõõt on " + ümbermõõt + " ühikut.");
        }
        static void ristkülikuS()
        {
            Console.WriteLine("Sisesta ristküliku pikem külg: ");
            double ak = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta ristküliku lühem külg: ");
            double bk = Convert.ToDouble(Console.ReadLine());

            double pindala = ak * bk;
            Console.WriteLine("Ristküliku pindala on " + pindala + " ühikut.");
        }
        static void ristkülikuP()
        {
            Console.WriteLine("Sisesta ristküliku pikem külg: ");
            double akk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta ristküliku lühem külg: ");
            double bkk = Convert.ToDouble(Console.ReadLine());

            double ümbermõõt = 2 * (akk * bkk);
            Console.WriteLine("Ristküliku pindala on " + ümbermõõt + " ühikut.");
        }
        static void ringiSP()
        {
            Console.WriteLine("Sisesta ringi raadius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double pindala = 3.14 * (r * r);
            Console.WriteLine("Ringi pindala on " + pindala + " ühikut.");
            double ümbermõõt = 2 * 3.14 * r;
            Console.WriteLine("Ringi ümbermõõt on " + ümbermõõt + " ühikut.");
        }
    }
}
