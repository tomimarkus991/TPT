using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Keelevalikuteks on: ");
            string[] keeled = new string[3];
            keeled[0] = "eesti";
            keeled[1] = "saksa";
            keeled[2] = "hispaania";

            Console.ReadKey();

            foreach(string valik in keeled)
            {
                Console.WriteLine(valik);
            }
            Start:
            Console.ReadKey();
            Console.WriteLine("Mis keelt soovite valida?");
            var vastus = Console.ReadLine();
            if (vastus == "eesti")
            {
                Console.WriteLine("Tere hommikust!");
            }
            else if (vastus == "saksa")
            {
                Console.WriteLine("Guten Morgen!");
            }
            else if (vastus == "hispaania")
            {
                Console.WriteLine("Buenos Dias!");
            }
            else 
            {
                Console.WriteLine("Sellist keelt pole valikus.");
            }
            Console.ReadKey();
            goto Start;
        }
    }
}
