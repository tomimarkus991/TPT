using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static string[] test = new string[] { "Kaarel", "Mati" };
        static string[][] friends = new string[][]
            {
                new string[] {"Kaur", "Wolffe", "Venom" },
                new string[] {"Albert", "Marta", "Masha" },
                new string[] {"Sten", "Juta", "Mari"},
                test
            };
        static void Main(string[] args)
        {
            Introduction();
            Console.ReadKey();
        }

        public static void Introduction()
        {
            Console.WriteLine("{0}: {1} see on {2}, {3}, see on {4}", friends[0][0], friends[0][1], friends[1][1], friends[1][1], friends[0][1]);
            Console.WriteLine("{0}: {1} see on {2}, {3}, see on {4}", friends[1][0], friends[1][1], friends[2][1], friends[2][1], friends[1][1]);
            Console.WriteLine("{0}: {1} see on {2}, {3}, see on {4}", friends[2][0], friends[2][1], friends[0][2], friends[0][2], friends[2][1]);
        }
    }
}
