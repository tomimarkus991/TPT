using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int arv, maksimaalne, loendur, mitu, järjekord;

                Console.Write("Sisesta arv: ");
                arv = Convert.ToInt32(Console.ReadLine());
                maksimaalne = arv;
                järjekord = 1;
                mitu = 1;
                for (loendur = 2; loendur <= 5; loendur++)
                {
                    Console.Write("Sisesta arv: ");
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
                Console.WriteLine("Maksimum = " + maksimaalne + " , korduste arv on " + mitu + "\n");
                Console.WriteLine(" Järjekord on " + järjekord + "." + "\n");
                Console.ReadKey();
            }
        }
    }
}

