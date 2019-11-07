using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suvakas
{
    class Program
    {
        static void Main(string[] args)
        {
            string Progresbar = "This is animated title of Console";
            var title = "";
            while (true)
            {
                for (int i = 0; i < Progresbar.Length; i++)
                {
                    title += Progresbar[i];
                    Console.Title = title;
                   // Thread.Sleep(100);
                }
                title = "";  
            }
        }
    }
}
