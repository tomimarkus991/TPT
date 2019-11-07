using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperatuur();
            Console.Read();
        }
        public static void Temperatuur()
        {
            Console.WriteLine("Sisesta temperatuur");
            string temperature = Console.ReadLine();
            int kraad;
            int number;

            if (int.TryParse(temperature, out number))
            {
                kraad = number;
            }
            else
            {
                kraad = 0;
                Console.WriteLine("Value you entered was not a number. 0 set as temperature");
                return;
            }

            if (kraad < 15)
            {
                Console.WriteLine("Võta jakk kaasa");
            }

            else if (kraad == 20)
            {
                Console.WriteLine("20C");
            }

            else
            {
                Console.WriteLine("Väga palav on");
            }
        }
    }   
}
