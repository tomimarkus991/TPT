using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 10;
            grades[1] = 1;
            grades[2] = 2;
            grades[3] = 3;
            grades[4] = 4;
            Console.WriteLine("Grade at index 0: {0}", grades[0]);

            string input = Console.ReadLine();
            // vasak poolne võtab parempoolse jõu ehk muutub samaks, mis parempoolne
            //grades[0] = int.Parse(input);

            bool success = int.TryParse(input, out grades[0]);
            if (success)
            {
                Console.WriteLine("Grade at index 0: {0}", input);
            }
            else
            {
                Console.WriteLine("Enter only numbers please!");
            }            

            int[] gradesOfMathStudentsA = { 5, 4, 5, 3, 6 };

            int[] gradesOfMathStudentsB = new int[] { 2, 4, 5, 4, 6, 6, 7 };

            Console.WriteLine("How many students got a grade: {0}", gradesOfMathStudentsA.Length);
            Console.WriteLine("How many students got a grade: {0}", gradesOfMathStudentsB.Length);
            Console.ReadKey();
        }
    }
}
