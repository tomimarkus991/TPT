using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Peeter Plonkvist", "Peeter", 500);
            Console.WriteLine(employee1.ToString());

            employee1.Work();
            employee1.Pause();

            Boss boss1 = new Boss("Audi", "Boss k", "Boss", 88888);
            Console.WriteLine(boss1.ToString());

            Trainee trainee1 = new Trainee(3, 8, "Suur Mees", "Suur", 40000);
            Console.WriteLine(trainee1.ToString());   

            Console.ReadKey();

        }
    }
}
