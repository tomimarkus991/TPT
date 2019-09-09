using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class XV:Subaru
    {
        public XV(int hp, string model, string color, string brand) : base(hp, color, model, brand)
        {
            this.Brand = brand;
            this.Model = model;
        }
        //public override void Repair()
        //{
        //    Console.WriteLine("Your Audi {0} was repaired", Model);
        //}
    }
}
