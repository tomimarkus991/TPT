using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "first 4", "second 6", "third 8" };
            File.WriteAllLines(@"D:\koodid\9#Polymorphism\highscores.txt", lines);

            // Method 2
            //Console.WriteLine("File name:");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Enter text for text file:");
            //string input = Console.ReadLine();
            //File.WriteAllText(@"D:\koodid\9#Polymorphism\" + fileName + ".txt", input);

            // Method 3
            using(StreamWriter file = new StreamWriter(@"D:\koodid\9#Polymorphism\highscores.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("6"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"D:\koodid\9#Polymorphism\highscores.txt", true))
            {
                file.WriteLine("Additional Line");
            }

                /*
                string text = System.IO.File.ReadAllText(@"D:\koodid\9#Polymorphism\test.txt");
                Console.WriteLine(text);

                string[] lines = System.IO.File.ReadAllLines(@"D:\koodid\9#Polymorphism\test.txt");
                foreach(string line in lines)
                {
                    Console.WriteLine("\t {0}", line);
                }
                */
                Console.ReadKey();
        }
    }
}
