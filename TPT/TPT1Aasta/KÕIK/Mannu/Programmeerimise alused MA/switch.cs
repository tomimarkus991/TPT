using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int num_01 = numberGenerator.Next(1,11);
            int num02 = numberGenerator.Next(1,11);

            Console.WriteLine("What is " + num_01 + " times " + num02 + "?");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num_01 * num02)
            {
                int responeIndex = numberGenerator.Next(1,4);

                switch (responeIndex)
                {
                    case 1:
                        Console.WriteLine("Well done! Your answer is correct.");
                        break;

                    case 2:
                        Console.WriteLine("Your answer is correct.");
                        break;

                    default:
                        Console.WriteLine("Well done!");
                        break;
                }
            }
            else
            {
                int diff = Math.Abs(answer - (num_01 * num02));
                if (diff == 1) {
                    Console.WriteLine("So close!");
                } else if (diff <= 10) {
                    Console.WriteLine("You can do better that that.");
                } else {
                    Console.WriteLine("You are not even close.");
                }
            }


            Console.ReadKey();

        }
    }
}
