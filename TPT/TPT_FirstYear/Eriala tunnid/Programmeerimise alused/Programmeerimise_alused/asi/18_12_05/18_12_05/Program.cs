using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 4, 746 };
            int[] b = new int[] { -43, 34, 746 };
            int[] c = CompareArrays(a, b);
            Console.WriteLine(String.Join(" ", c));
            Console.ReadKey();
        }
        static int[] CompareArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    c[i] = 1;
                }

                else if (a[i] < b[i])
                {
                    c[i] = -1;
                }

                else
                {
                    c[i] = 0;
                }
            }
            return c;
        } 
    }   
}
