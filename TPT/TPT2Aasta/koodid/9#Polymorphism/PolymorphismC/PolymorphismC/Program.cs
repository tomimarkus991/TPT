using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Subaru(7000, "XV", "Black", "Subaru"),
                new Audi(5000, "A4", "White", "Audi")
            };
            foreach(var car in cars)
            {
                car.Repair();
                car.ShowDetails();
            }
            Subaru xv = new Subaru(2500, "XV", "black", "Subaru");            
            xv.SetCarIDInfo(12, "Tomi");
            xv.GetCarIDInfo();
            

            //Car subaru = new Subaru(4000, "XVV", "Blue", "Subaru");
            //subaru.ShowDetails();

            //Car audi = new Audi(2000, "A6", "Purple", "Audi");
            //audi.ShowDetails();

            //Subaru sub = new Subaru(200, "kaka2", "värv", "Subaru"); // ss peab olema new (public new void ShowDetails())
            //sub.ShowDetails();

            //Car carB = (Car)sub;
            //carB.ShowDetails();

            Console.ReadKey();
        }
    }
}
