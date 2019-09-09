using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysasParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Grades();
            Happy();
            Console.ReadKey();
        }

        static void SunIsShining(int[]x)
        {           
            for (int i = 0; i < x.Length; i++)
            {
                x[i] += 2; // x[i] = x[i] + 2;
            }
        }
        static void Happy()
        {
            int[] happiness = new int[] { 1, 2, 3, 4, 5 };
            SunIsShining(happiness);
            foreach (int happy in happiness)
            {
                Console.WriteLine("{0}", happy);
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            Console.WriteLine("Number of grades {0}", size);
            return average;           
        }
        static void Grades()
        {
            int[] studentGrades = new int[] { 5, 4, 5, 3, 2, 4, 5, 2, 4, 3, 5 };
            foreach (double grade in studentGrades)
            {
                Console.WriteLine("{0}", grade);
            }
            double averageResult = GetAverage(studentGrades);
            Console.WriteLine("The average is {0}", Math.Round(averageResult, 2));
        }


    }
}
