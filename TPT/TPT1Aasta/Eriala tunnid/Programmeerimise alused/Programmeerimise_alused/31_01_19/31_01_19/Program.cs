using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_01_19
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<string> lines = new List<string>();           
            int i = 1;
                bool finished = false;
                while (!finished)
                {
                     Console.WriteLine("Enter row number " + i++);
                    string line = Console.ReadLine();
                    if (line == "...")
                    {
                        finished = true;
                    }
                    else
                    {
                        lines.Add(line);
                    }                                          
                }            
            string path = @"C:\Users\opilane\Documents\text.txt";
            System.IO.File.WriteAllLines(path, lines);
            Console.ReadKey();
        }
    }
}
