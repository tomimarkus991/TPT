using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random kolmnurgaPindala = new Random();

            double a = kolmnurgaPindala.Next(1, 21);
            double h = kolmnurgaPindala.Next(1, 19);

            Console.WriteLine("Kolmnurga alus on: " + Convert.ToDouble(a));
            Console.WriteLine("Kolmnurga kõrgus on: " + Convert.ToDouble(h));
            Console.WriteLine("Leia kolnurga pindala.");

            double vastus = (a * h) / 2;
            double kasutajaVastus = Convert.ToDouble(Console.ReadLine());

            if (vastus == kasutajaVastus)
            {
                Console.Write("Tubli! Õige vastus.");
            }
            else
            {
                double vastused = kolmnurgaPindala.Next(1, 3);

                switch (vastused)
                {
                    case 1:
                        Console.WriteLine("Proovi uuesti!");
                        break;

                    case 2:
                        Console.WriteLine("Vale vastus.");
                        break;

                    default:
                        Console.WriteLine("Kas sa üldse üritad?!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
