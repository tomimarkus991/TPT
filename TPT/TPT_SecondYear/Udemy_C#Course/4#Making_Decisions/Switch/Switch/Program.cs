using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            if (age == 15)
            {
                Console.WriteLine("Too young!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Tomi";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Tomi");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }

            Console.Read();
        }
    }
}
