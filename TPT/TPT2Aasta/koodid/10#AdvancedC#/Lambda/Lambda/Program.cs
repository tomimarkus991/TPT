using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public delegate int SomeMath(int a);
        public delegate bool Compare(int a, Number n);
        static void Main(string[] args)
        {
            DoSomething();
            Console.ReadKey();
        }
        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(4));

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach (int even in evenNumbers)
            {
                Console.WriteLine(even);
            }
           
            List<int> oddNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 != 0);
            });
            foreach (int unEven in oddNumbers)
            {
                Console.WriteLine(unEven);
            }

            List<int> oddNumbers2 = list.FindAll(i => i % 2 == 1);
            oddNumbers2.ForEach(i =>
            {
                Console.WriteLine("Odd number:");
                Console.WriteLine(i);
            });
            math = new SomeMath(x => x * x * x);
            Console.WriteLine(math(8));

            Compare comp = (a, number) => a == number.n;
            Console.WriteLine(comp(5, new Number { n = 5}));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Square(int a)
        {
            return a * a;
        }
        public class Number
        {
            public int n { get; set; }
        }
    }
}
