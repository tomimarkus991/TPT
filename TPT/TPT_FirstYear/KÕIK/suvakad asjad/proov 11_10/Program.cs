using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proov
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                int arv;
                int maksimaalne = 0;
                int loendur;
                int mitmes;
                int korda;

                Console.WriteLine("Sisesta arv");
                arv = Convert.ToInt32(Console.ReadLine());

                maksimaalne = arv;
                mitmes = 1;
                korda = arv;


                for (loendur = 2; loendur <= 5; loendur++) //loendur++ tähendab, et suureneb 1 võrra
                {
                    Console.WriteLine("Sisesta arv");
                    arv = Convert.ToInt32(Console.ReadLine());
                    {
                        if (arv >= maksimaalne)
                        {
                            maksimaalne = arv;
                            mitmes = loendur;
                            korda = arv;
                        }

                        else if (arv == korda)
                    }
                }
                Console.WriteLine("Järjekord =" + mitmes);
                Console.WriteLine("Mitu korda seda arvu kasutati? =" + korda + "korda");
                Console.WriteLine("Maksimum =" + maksimaalne);
                Console.ReadKey();

            }
        }
    }

}




