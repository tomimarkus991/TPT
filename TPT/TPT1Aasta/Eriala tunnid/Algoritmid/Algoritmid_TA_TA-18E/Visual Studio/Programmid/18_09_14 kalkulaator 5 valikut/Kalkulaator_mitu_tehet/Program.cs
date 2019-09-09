using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator_mitu_tehet
{
    class Program
    {
        static void Main(string[] args)
        {
            Alg_01();
            Console.Write("\nVajuta suvaline klahv\n\n");
            Console.ReadKey();
        }

        static void Alg_01()
        {
            int arv1, arv2, arv3, arv4, arv5, tulemus;

            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta kolmas arv --> ");
            arv3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta neljas arv --> ");
            arv4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta viies arv --> ");
            arv5 = Convert.ToInt32(Console.ReadLine());

            tulemus = arv1 + arv2 + arv3 + arv4 + arv5;

            Console.Write("Nende arvude summa on {0}\n", tulemus);

            Console.Write("{0} + {1} + {2} + {3} + {4} = {5}\n", arv1, arv2, arv3, arv4, arv5, tulemus);

            Console.Write("Nende arvude vahe on {0}\n", arv1 - arv2 - arv3 - arv4 - arv5);

            Console.Write("Nende arvude korrutis on {0}\n", arv1 * arv2 * arv3 * arv4 * arv5);

            Console.Write("Nende arvude jagatis on {0}\n", arv1 / arv2 / arv3 / arv4 / arv5);

            Console.Write("Nende arvude jagatise jaak on {0}\n", arv1 % arv2 % arv3 % arv4 % arv5);
        }
    }
}
