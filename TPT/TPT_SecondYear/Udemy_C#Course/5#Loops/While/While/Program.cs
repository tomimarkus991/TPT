using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = string.Empty;
                while (enteredText.Equals(""))
                {
                    Console.WriteLine("Press enter to count people");
                    enteredText = Console.ReadLine();                   
                    counter++;
                Console.WriteLine("Current people count is {0}", counter);
                }   
            Console.ReadKey();
        }
    }
}
