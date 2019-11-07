using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            int a = 3;
            int b = 5;
            int c = 7;

            Liida(a, b);
            int lahutamiseVastus = Lahuta(b, a);
            Console.WriteLine("Lahutamise vastus on: " + lahutamiseVastus);
            Console.WriteLine("Sisesta kolmnurga I külg: ");
            Console.WriteLine("Sisesta kolmnurga I külg: ");
            Console.WriteLine("Sisesta kolmnurga I külg: ");

            double x =  Math.Pow(4, 2);
            double y = Math.Pow(16, 4);
            double z = Math.Pow(18, 3);

            Console.WriteLine(y);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        static int Lahuta(int b, int a)
        {
            int vastus = b - a;
            return vastus;
        }
        static void Liida (int arv1, int arv2)
        {
            int vastus = arv1 + arv2;
            System.Console.WriteLine("Liitmise vastus on: " + vastus);
            Console.ReadKey();
        }
    }
}

// 

