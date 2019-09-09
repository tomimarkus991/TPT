using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolmnurga pindala arvutamine

            Console.WriteLine("Sisesta kolmnurga kõrgus: " + Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Sisesta kolnurga alus: " + Convert.ToDouble(Console.ReadLine()));
            //Kolmnurga ümbermõõdu arvutamine
            Console.WriteLine("Sisesta kolmnurga I külg: " + Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("SIsesta kolnurga II külg: " + Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Sisesta kolmnurga III külg: " + Convert.ToDouble(Console.ReadLine()));


            Console.ReadKey();

        }
    }
}



/* 1. Kolmnurga S ja P
2. Ristküliku S ja P
3. Ringi S ja P
    Iga arvutuse jaoks tehke oma alamfunktsioon, mida kutsute välja main funktsioonis.
    Küsige kasutajalt millist kujundit soovib sisestada ja vastavalt sellele teha õiged arvutused.
    */