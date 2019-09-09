using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_09_20_ÜLDINE
{
    class Program
    {
        static void Main(string[] args)

        {
            Alg_12();
            Console.Write("\n Palun vajuta suvalist klahvi\n\n");
            Console.ReadKey();
        }




        static void Alg_01()
        {
            int arv1, arv2, tulemus;

            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());

            tulemus = arv1 + arv2;

            Console.Write("Nende arvude summa on {0}\n", tulemus);

            Console.Write("{0} + {1} = {2}\n", arv1, arv2, tulemus);

            Console.Write("Nende arvude vahe on {0}\n", arv1 - arv2);

            Console.Write("Nende arvude korrutis on {0}\n", arv1 * arv2);

            Console.Write("Nende arvude jagatis on {0}\n", arv1 / arv2);

            Console.Write("Nende arvude jagatise jaak on {0}\n", arv1 % arv2);
        }

        static void Alg_02()
        {
            int arv1, arv2;
            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            if (arv1 > arv2)
                Console.Write("\nEsimene arv on suurem\n");
            else
            {
                if (arv2 > arv1)
                    Console.Write("\nTeine arv on suurem\n");
                else
                    Console.Write("\nArvud on võrdsed\n");

            }
        }

        static void Alg_03()
        {

            {
                int arv1, arv2, arv3;
                Console.Write("Sisesta esimene arv --> ");
                arv1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sisesta teine arv --> ");
                arv2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sisesta kolmas arv --> ");
                arv3 = Convert.ToInt32(Console.ReadLine());
                if (arv1 > arv2 && arv1 > arv3)
                {
                    Console.Write("\nMax = {0}\n", arv1);
                }
                else
                {
                    if (arv2 > arv3)
                        Console.Write("\nMax = {0}\n", arv2);
                    else
                        Console.Write("\nMax = {0}\n", arv3);
                }
            }
        }

        static void Alg_03B()

        {
            int arv1, arv2, arv3, maksimaalne;

            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());
            maksimaalne = arv1;

            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            if (arv2 > maksimaalne)
                maksimaalne = arv2;

            Console.Write("Sisesta kolmas arv --> ");
            arv3 = Convert.ToInt32(Console.ReadLine());
            if (arv3 > maksimaalne)
                maksimaalne = arv3;

            Console.Write("\nMaksimaalne = {0}\n", maksimaalne);
        }

        static void Alg_04()
        {
            int arv, maksimaalne = 0, loendur;

            for (loendur = 1; loendur <= 5; loendur++) //loendur++ tähendab, et suureneb 1 võrra

            {
                Console.Write("Sisesta arv --> ");

                arv = Convert.ToInt32(Console.ReadLine());

                if (loendur == 1)
                    maksimaalne = arv;
                else
                {
                    if (arv > maksimaalne)
                        maksimaalne = arv;

                }
            }
            Console.Write("Maksimaalne = {0}\n", maksimaalne);

        }

        static void Alg_05()

        {
            int arv, maksimaalne, loendur, mitu, järjekord;

            Console.WriteLine("Sisesta arv");
            arv = Convert.ToInt32(Console.ReadLine());
            maksimaalne = arv;
            järjekord = 1;
            mitu = 1;
            for (loendur = 2; loendur <= 5; loendur++)
            {
                Console.WriteLine("Sisesta arv");
                arv = Convert.ToInt32(Console.ReadLine());
                if (arv >= maksimaalne)
                {
                    if (arv > maksimaalne)
                    {
                        järjekord = loendur;
                        mitu = 0;
                    }
                    maksimaalne = arv;
                    mitu = mitu + 1;
                }
            }
            Console.WriteLine("Maksimum = " + maksimaalne + " ,korduste arv on " + mitu + "\n");
            Console.WriteLine(" Järjekord on " + järjekord + "\n");

        }

        static void Alg_06()

        {
            float hind, summa;
            double KM;
            int mitu;
            summa = 0;
            mitu = 0;
            Console.WriteLine("Tere tulemast Tomi poodi! Maksta saab ainult 5EUR; 10EUR; 20EUR; 50EUR rahatähtetega");
            do
            {
                Console.WriteLine("Palju maksab--> ");
                hind = Convert.ToSingle(Console.ReadLine());
                summa += hind; // summa = summa + hind
                mitu++;
            }

            while (hind > 0);
            {
                mitu--; // mitu = mitu - 1
            }
            KM = summa * 1.2;
            Console.WriteLine("Ostetud " + mitu + " kaupa. Pead maksma " + summa + " EUR");
            Console.WriteLine("Summa koos käibemaksuga on: " + KM + " EUR --> käibemaks pole tähtis");

            double makstud, raha, veel;
            makstud = 0;
            veel = 0;
            while (makstud < summa)
            {
                Console.WriteLine("Veel " + (summa - makstud) + " palun!");
                raha = Convert.ToSingle(Console.ReadLine());

                if (raha == 5 || raha == 10 || raha == 20 || raha == 50)
                {
                    makstud += raha;

                }
                else
                {
                    Console.WriteLine("Vabandust! Maksta saab ainult 5EUR; 10EUR; 20EUR; 50EUR rahatähtetega");

                    return;
                }

                if (summa > makstud)
                {
                    veel = summa - makstud;
                    Console.WriteLine("Teil on " + veel + " EUR puudu");
                }
            }

            if (makstud > summa)
            {
                Console.WriteLine("Tagasi saate: " + (makstud - summa));
            }

            else
            {
                Console.WriteLine("Aitäh!");
            }
            Console.WriteLine("Käibemaksu summas: " + (KM - summa) + " EURi ei ole vaja maksta ");
        }

        static void Alg_07()
        {
            int[] arvud = new int[5];
            int max, i;
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("Sisesta arv");
                arvud[i] = Convert.ToInt32(Console.ReadLine());
            }

            max = arvud[0];

            for (i = 1; i < 4; i++)
            {
                if (arvud[i] > max)
                {
                    max = arvud[i];
                }
            }                                                                                                   //1 ja 2 ja 3, 3a, 3b, 4, 4a, 4b, 5, 6 ,7,8 on õpsil flowgoritmis failid

            Console.WriteLine("Max = " + max);

            for (i = 0; i <= 4; i++)
            {
                if (arvud[i] == max)
                {
                    Console.Write("Asukoht: " + (i + 1));
                }

            }
        }

        static void Alg_08()
        {
            Random rnd = new Random();
            int[] arvud = new int[50];
            int k;

            for (k = 0; k <= 49; k++)
            {
                arvud[k] = rnd.Next(10, 100);

            }

            Console.WriteLine("Formeeritud massiiv:");

            for (k = 0; k <= 49; k++)
            {
                Console.Write(" " + arvud[k]);
            }
            Console.WriteLine(" ");

            int i1, i2, temp;

            for (i1 = 0; i1 <= 48; i1++)
            {
                for (i2 = i1 + 1; i2 <= 49; i2++)
                {
                    if (arvud[i2] < arvud[i1])
                    {
                        temp = arvud[i1];
                        arvud[i1] = arvud[i2];
                        arvud[i2] = temp;

                    }
                }
            }
            Console.WriteLine("Järjestatud massiiv: ");
            for (k = 0; k <= 49; k++)
            {
                Console.Write(" " + arvud[k]);
            }
        }

        static void Alg_09()
        {
            Random rnd = new Random();
            int[] arvud = new int[50];

            for (int k = 0; k <= 49; k++)
            {
                arvud[k] = rnd.Next(10, 100);
            }

            Console.WriteLine(" Formeeritud massiiv:");

            for (int k = 0; k <= 49; k++)
            Console.Write(" " + arvud[k]);
            Console.WriteLine("");

            Console.WriteLine(" Mullimeetod");

            bool tunnus;
            int swapn = 0;
            do
            {
                tunnus = false;
                for (int i1 = 0; i1 <= 48; i1++)
                {
                    int i2 = i1 + 1;

                    if (arvud[i2] < arvud[i1])
                    {
                        int temp = arvud[i1];
                        arvud[i1] = arvud[i2];
                        arvud[i2] = temp;
                        tunnus = true;
                        swapn++;
                    }
                }
            }
            while (tunnus == true);
            Console.WriteLine(" Järjestatud massiiv: ");

                for (int k = 0; k <= 49; k++)            
                Console.Write(" " + arvud[k]);
                Console.WriteLine("\n\nSwap arv = {0}\n\n", swapn);

        }

        static void Alg_10()
        {
            Random rnd = new Random();
            int[] arvud = new int[50];

            for (int k = 0; k < 50; k++)
            {
                arvud[k] = rnd.Next(10, 100);
            }
            Console.WriteLine(" Formeeritud massiiv:");
            for (int k = 0; k < 50; k++)
            Console.Write(" " + arvud[k]);
            Console.WriteLine("");
            Console.WriteLine(" Shellmeetod");
            bool tunnus;

            int samm = 50;
            int swapn = 0;
            do
            {
                samm /= 2;
                do
                {
                    tunnus = false;
                    for (int i1 = 0; i1 < (50 - samm); i1++)
                    {
                        int i2 = i1 + samm;
                        if (arvud[i2] < arvud[i1])
                        {
                            int temp = arvud[i1];
                            arvud[i1] = arvud[i2];
                            arvud[i2] = temp;
                            tunnus = true;
                            swapn++;
                        }
                    }

                } while (tunnus == true);
            } while (samm > 1);
              
                Console.WriteLine(" Järjestatud massiiv: ");
                for (int k = 0; k < 50; k++)               
                Console.Write(" " + arvud[k]);               
                Console.WriteLine("\n\nSwap arv = {0}\n\n", swapn);
        }




        static void Alg_11(int suurus)
        {
            int[] arvud = new int[suurus];
            int[] arvud1 = new int[suurus];
            Random rnd = new Random();         
            for (int k = 0; k < suurus; k++)
            {
                arvud[k] = arvud1[k] = rnd.Next(10, 100);
            }
            Console.WriteLine(" Formeeritud massiiv:");
            for (int k = 0; k < suurus; k++)
            Console.Write(" " + arvud[k]);
            Console.WriteLine("");           
            Console.WriteLine(" Shellmeetod");

            bool tunnus;
            int samm = suurus;
            int swapn = 0;
            do
            {
                samm = samm / 2;
                do
                {
                    tunnus = false;
                    for (int i1 = 0; i1 < (suurus - samm); i1++)
                    {
                        int i2 = i1 + samm;
                        if (arvud[i2] < arvud[i1])
                        {
                            int temp = arvud[i1];
                            arvud[i1] = arvud[i2];
                            arvud[i2] = temp;
                            tunnus = true;
                            swapn++;
                        }
                    }

                } while (tunnus == true);
            } while (samm > 1);

            Console.WriteLine(" Järjestatud massiiv: ");
            for (int k = 0; k < suurus; k++)
                Console.Write(" " + arvud[k]);
            Console.WriteLine("\n\nSwap arv = {0}\n\n", swapn);

            Console.WriteLine(" Mullimeetod");
            for (int k = 0; k < suurus; k++)
            {
                arvud[k] = arvud1[k];
            }
            swapn = 0;
            do
            {
                tunnus = false;
                for (int i1 = 0; i1 < (suurus - samm); i1++)
                {
                    int i2 = i1 + samm;

                    if (arvud[i2] < arvud[i1])
                    {
                        int temp = arvud[i1];
                        arvud[i1] = arvud[i2];
                        arvud[i2] = temp;
                        tunnus = true;
                        swapn++;
                    }
                }
            }
            while (tunnus == true);
            Console.WriteLine(" Järjestatud massiiv: ");
            for (int k = 0; k < suurus; k++)
            Console.Write(" " + arvud[k]);
            Console.WriteLine("\n\nSwap arv = {0}\n\n", swapn);
        }

        static void Alg_12()        //kodutöö nr 2
        {                  
                Random rnd = new Random();           
                int[] arvud = new int[41];
                int k, summa, mink, kmin, maxk, kmax;

                summa = 0;
                kmin = 0;       //kmin on asukoht ja mink on arv
                kmax = 0;       //kmax on asukoht ja maxk on arv

                for (k = 0; k <= 40; k++)
                {
                    arvud[k] = rnd.Next(41) - 20;
                    Console.Write(" " + arvud[k]);
                }

                mink = arvud[0];
                maxk = arvud[0];
                for (k = 0; k <= 40; k++)
                {
                    if (mink > arvud[k])
                    {
                        mink = arvud[k];
                        kmin = k;
                    }

                     if (maxk < arvud[k])
                     {
                         maxk = arvud[k];
                         kmax = k;
                     }
                }

                Console.WriteLine("" + "\n");
                Console.WriteLine(" Minimaalse arvu koht jadas on " + kmin + " ja see arv on " + mink + "\n");
                Console.WriteLine(" Maksimaalse arvu koht jadas on " + kmax + " ja see arv on " + maxk + "\n");

                if (kmin > kmax)
                {
                    k = kmin;
                    kmin = kmax;
                    kmax = k;
                }

                for (k = kmin + 1; k <= kmax - 1; k++)
                {                   
                    summa += arvud[k];
                }
                Console.WriteLine(" Indeksite " + kmin + " ja " + kmax + " vaheliste arvude summa on " + summa + "\n");
            
        }

        static void Alg_13(int suurus)
        {
            Random rnd = new Random();
            int[] arvud = new int[suurus];
            int k, summa, mink, kmin, maxk, kmax;

            summa = 0;
            kmin = 0;       //kmin on asukoht ja mink on arv
            kmax = 0;       //kmax on asukoht ja maxk on arv

            for (k = 0; k <= 40; k++)
            {
                arvud[k] = rnd.Next(suurus) - 20;
                Console.Write(" " + arvud[k]);
            }

            mink = arvud[0];
            maxk = arvud[0];
            for (k = 0; k <= 40; k++)
            {
                if (mink > arvud[k])
                {
                    mink = arvud[k];
                    kmin = k;
                }

                if (maxk < arvud[k])
                {
                    maxk = arvud[k];
                    kmax = k;
                }
            }

            Console.WriteLine("" + "\n");
            Console.WriteLine(" Minimaalse arvu koht jadas on " + kmin + " ja see arv on " + mink + "\n");
            Console.WriteLine(" Maksimaalse arvu koht jadas on " + kmax + " ja see arv on " + maxk + "\n");

            if (kmin > kmax)
            {
                k = kmin;
                kmin = kmax;
                kmax = k;
            }

            for (k = kmin + 1; k <= kmax - 1; k++)
            {
                summa += arvud[k];
            }
            Console.WriteLine(" Indeksite " + kmin + " ja " + kmax + " vaheliste arvude summa on " + summa + "\n");
        }
    }
}


    

    

