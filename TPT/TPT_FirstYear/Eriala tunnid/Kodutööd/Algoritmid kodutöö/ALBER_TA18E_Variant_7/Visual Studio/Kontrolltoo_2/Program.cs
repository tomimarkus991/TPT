using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo_2
{
    class Program
    {
        static void Main(string[] args)
        {                                       // Variant 7 Tomi Markus Alber TA-18E
            Random rnd = new Random();
            int[] arvud = new int[36];
            int[] nullid = new int[20];

            int k, n, mitu, summa;

            mitu = 0;
            summa = 0;
            nullid[0] = 36;
            nullid[1] = 37;
            n = 0;

            for (k = 0; k <= 35; k++)           //Teeb juhuslike arvude massiivi.
            {
                arvud[k] = rnd.Next(50) - 30;
                Console.Write(" " + arvud[k]);
            }

            for (k = 0; k < 35; k++)
            {
                if(arvud[k] > -10) // leiab mitu arvu on suuremad kui -10
                {
                    mitu = mitu + 1;  
                }

                if(arvud[k] == 0) // lisab massiivi, mis leiab arvude 0 indeksid
                {
                    nullid[n] = k;
                    n = n + 1;
                }
            }
            Console.WriteLine("");

            if(nullid[0] == 36 || nullid[1] == 37)
            {
                if (nullid[0] != 36)        // tekib siis kui teist nulli ei ole
                {
                    Console.WriteLine("Teist nulli ei ole.");
                }
                else        // Tekib siis kui nulle pole üldse
                {
                    Console.WriteLine("Nulle pole piisavalt, et summat leida.");
                    Console.WriteLine("Nulle peab olema vähemalt 2 tükki.");
                }
            }
                    else
                    {
                       for (k = 0; nullid[0] <= nullid[1] ; k++)    // leiab summa kui nulle on piisavalt
                       {
                         summa = summa + arvud[k];
                       }
                         Console.WriteLine("Indeksite " + nullid[0] + " ja " + nullid[1] + " vaheliste arvude summa on " + summa + ".");
                    }
            if (mitu >= 2)      // Annab välja, kui palju -10 suuremaid arve on massiivis.
            {
                Console.WriteLine(mitu + " arvu on suuremad kui -10. ");
            }
            else
            {
                Console.WriteLine(mitu + " arv on suurem kui -10. ");
            }
                Console.ReadKey();
        }
    }
}
