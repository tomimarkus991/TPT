using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutoo2_Tomi_Markus_Alber_TA18E
{
    class Program
    {
        static void Main(string[] args)
        {
            Alg_01();
            Console.Write("\n Palun vajuta suvalist klahvi\n\n");
            Console.ReadKey();
        }


        static void Alg_01()
        {
                                        // TOMI MARKUS ALBER    TA-18E
            Random rnd = new Random();
            int[] arvud = new int[6];
            int k;

            Console.WriteLine(" First and third assignment");
            for (k = 0; k < 6; k++)
            {
                arvud[k] = rnd.Next(10, 100);
                
            }
            Console.WriteLine(" Formed array:");
            for (k = 0; k < 6; k++)
            Console.Write(" " + arvud[k]);
            Console.WriteLine("");
            Console.WriteLine(" Minimum number in array is " + arvud.Min());
            Console.WriteLine(" Average value in array is " + Math.Round(arvud.Average(),2));

            Console.WriteLine(" Second assignment");

            Console.WriteLine(" What number are you looking for?");
            Console.WriteLine(" Enter a number from the array at the top");
            int b = int.Parse(Console.ReadLine());
            int otsitudArv = 0;

            for (k = 0; k < arvud.Length; k++)
            {
                if (arvud[k] == b)
                {
                    otsitudArv = k;
                }
                
            }
            Console.WriteLine(" The index of " + b + " in array is " + otsitudArv);           
            
        }
        
      
    }
}
