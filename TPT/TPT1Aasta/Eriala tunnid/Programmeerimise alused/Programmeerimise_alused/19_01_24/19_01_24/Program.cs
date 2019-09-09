using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[10];
            lines[0] = "First line";
            string path = @"C:\Users\opilane\Documents\text.txt";

            System.IO.File.WriteAllLines(path, lines);





           //string content = System.IO.File.ReadAllText(path);
           //Console.WriteLine(content);


            //string[] lines = System.IO.File.ReadAllLines(path);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    //Console.WriteLine(lines[i]);
            //    string line = lines[i];
            //    line.Split
            //}
            //Console.WriteLine("Kõige külmem on");
            


            Console.ReadKey();
        }
    }
}
