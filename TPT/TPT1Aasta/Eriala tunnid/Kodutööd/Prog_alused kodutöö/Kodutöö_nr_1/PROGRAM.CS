using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodutöö_nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alg_05();
            Console.Write("\nVajuta suvalist klahvi\n\n");
            Console.ReadKey();
        }
        static void Alg_01()
        {
            double arv1, arv2;
            Console.WriteLine("Sisesta esimene arv");
            arv1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sisesta teine arv");
            arv2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vastus on --> " + arv1 * arv2);

        }
        static void Alg_02()
        {
            int loendur = 0, arv1, summa;

            Console.Write("Sisesta number: ");
            arv1 = int.Parse(Console.ReadLine());
            while (loendur <= 10)
            {
                summa = arv1 * loendur;

                Console.WriteLine("{0} x {1} = {2} ", arv1, loendur, summa);
                loendur++;
            }
        }

        static void Alg_03()
        {
            Double arv1, arv2, arv3;

            Console.Write("Sisesta esimene arv --> ");
            arv1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta teine arv --> ");
            arv2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sisesta kolmas arv --> ");
            arv3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Round((arv1 + arv2 + arv3) / 3, 2));
        }
        static void Alg_04()
        {
            double celsius, fahrenheit;

            // celciusest fahrenheiti
            Console.WriteLine("Sisesta temperatuur Celsiuses(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            fahrenheit = Math.Round((celsius * 9) / 5 + 32 , 2);
            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + fahrenheit);

            //  fahrenheitist celsiusesse
            Console.WriteLine("Sisesta temperatuur Fahrenheitis(°F) : ");
            fahrenheit = int.Parse(Console.ReadLine());
            celsius = Math.Round((fahrenheit - 32) * 5 / 9 , 2);
            Console.WriteLine("Temperatuur Celciuses on (°C) : " + celsius);
        }

        static void Alg_05()
        {
            int arv1, arv2, vastus;                  
            string operatsioon;

            Console.Write("Sisesta esimene number: ");
            arv1 = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Sisesta teine number: ");
            arv2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sisesta operatsioon ( x , / , +, -) ");
            operatsioon = Console.ReadLine();

            if (operatsioon == "x")
            {
                vastus = arv1 * arv2;
                Console.WriteLine(arv1 + " x " + arv2 + " = " + vastus);               
            }
            else if (operatsioon == "/")
            {
                if (arv2 == 0)
                {
                    Console.WriteLine("Nulliga ei saa jagada!");
                }
                else
                {
                    vastus = arv1 / arv2;
                    Console.WriteLine(arv1 + " / " + arv2 + " = " + vastus);
                }
                               
            }
            else if (operatsioon == "+")
            {
                vastus = arv1 + arv2;
                Console.WriteLine(arv1 + " + " + arv2 + " = " + vastus);               
            }
            else if (operatsioon == "-")
            {
                vastus = arv1 - arv2;
                Console.WriteLine(arv1 + " - " + arv2 + " = " + vastus);
            }
            else
            {
                Console.WriteLine("Vabandust nii ei saa. Palun taaskäivita programm!"); 
            }
        }
    }
}

