using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Subaru:Car
    {
        protected string Model { get; set; }
        protected private string Brand { get; set; }
        public Subaru(int hp, string model, string color, string brand):base(hp, color)
        {
            this.Brand = brand;
            this.Model = model;  
        }
        public sealed override void Repair()
        {
            Console.WriteLine("Your Subaru {0} was repaired", Model);
        }
        public override void ShowDetails()
        {
            Console.WriteLine("Brand: {0} | Model: {1} | HP: {2} | Color: {3}", Brand, Model, HP, Color);
        }
    }
}
